using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Fase_1_C_.Models;

namespace Fase_1_C_
{
    public partial class Enfermera : Form
    {
        public Enfermera()
        {
            InitializeComponent();
        }



        private void Enfermera_Load(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hopeNumeric2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            // Si el texto es el placeholder, lo borramos y ponemos la letra negra
            if (txtnombre.Text == "Nombres")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtapellidos_Enter(object sender, EventArgs e)
        {
            // Si el texto es el placeholder, lo borramos y ponemos la letra negra
            if (txtapellidos.Text == "Apellidos")
            {
                txtapellidos.Text = "";
                txtapellidos.ForeColor = Color.Black;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtdui_Enter(object sender, EventArgs e)
        {
            if (txtdui.Text == "Ingrese numero de DUI")
            {
                txtdui.Text = "";
                txtdui.ForeColor = Color.Black;
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //Boton para ingresar los datos

            using (var db = new TriajeClinicoContext())
            {
                try
                {
                    //Fase 1: Paciente (Buscar si existe, si no crearlo)
                    string duiIngresado = txtdui.Text;

                    //EF busca en la tabla "Pacientes" si hay alguno con ese DUI
                    var pacienteActual = db.Pacientes.FirstOrDefault(p => p.DuiPaciente == duiIngresado);

                    //Si el pacienteActual es null, lo insertamos
                    if (pacienteActual == null)
                    {
                        pacienteActual = new Paciente
                        {
                            DuiPaciente = duiIngresado,
                            Nombres = txtnombre.Text,
                            Apellidos = txtapellidos.Text,
                            FechaNacimiento = DateOnly.FromDateTime(dateedad.Value),
                            Genero = cbgenero.Text
                        };
                        //Añade los datos anteriores
                        db.Pacientes.Add(pacienteActual);
                        db.SaveChanges();
                    }

                    //Fase 2 Sintomas Criticos Utilizando JSON
                    var sintomas = new Dictionary<string, bool>
                    {
                        {"Desmayo", rdbDesmayoSi.Checked},
                        {"HemorragiaIncontrolable", rdbHemorragiaSi.Checked},
                        {"DificultadRespiratoriaSevera", rdbDificultadadResSi.Checked},
                        {"TraumaCraneoencefalico", rdbTraumaCraneoSi.Checked},
                        {"DolorPecho", rdbDolorPechoSi.Checked}
                    };
                    //El serializer sirva para empacaar, es decir es el proceso de tomar un objeto y convertirlo en una cade de texto plana con formato JSON
                    string jsonSintomas = JsonSerializer.Serialize(sintomas);

                    //Fase 3 Guardar el registro de TRIAJE
                    var nuevoRegistro = new RegistrosTriaje
                    {
                        IdPaciente = pacienteActual.IdPaciente,
                        IdUsuarioEnfermera = 2,//Ejemplo de ID Enfermera de muestra
                        FechaHoraIngreso = DateTime.Now,

                        MotivoConsulta = cbmotivo.Text,
                        EstadoMental = cbestadomental.Text,
                        MecanismoLesion = cbmecanismo.Text,

                        //Convertir el numevolucion en enteros
                        TiempoEvolucion = Convert.ToInt32(numevolucion.ValueNumber),

                        SintomasCriticosJson = jsonSintomas,
                        EstadoAtencion = "En Sala de Espera",

                        Temperatura = Convert.ToDecimal(numtemperatura.ValueNumber),
                        NivelDolor = Convert.ToInt32(numdolor.ValueNumber),
                        SaturacionO2 = Convert.ToInt32(numoxigeno.ValueNumber),
                    };

                    //POR SISTEMA DE CASCADAS DE DESICIONES

                    //ASIGNACION NIVEL DE RESUSITACIÓN (Nivel 1)
                    if ((rdbDesmayoSi.Checked && cbestadomental.Text == "Inconsciente" ) || rdbHemorragiaSi.Checked || rdbDificultadadResSi.Checked || rdbTraumaCraneoSi.Checked || rdbDolorPechoSi.Checked || numtemperatura.ValueNumber >= 40 || numtemperatura.ValueNumber <= 35 || numdolor.ValueNumber >= 8 || numoxigeno.ValueNumber < 90 ||
                        cbmotivo.Text == "Convulsiones / Epilepsia" || cbmotivo.Text == "Intoxicación / Envenenamiento / Sobredosis" || cbestadomental.Text == "Responde solo al dolor")
                    {
                        nuevoRegistro.IdNivelAsignado = 1;          
                    }

                    //le agregamos else if ya que convierte las condiciones en opciones mutuamente exluyentes (es decir en cuanto se le asigne la primera categoria que el paciente cumpla, asignale ese nivel y salta al resto de codigo)
                    //si usaramos solo if sueltos, el programa seguiria evaluando hacia abajp, evaluando condiciones menos graves y al no cumplirlas terminaria cayendo en el else final, borrando el diagnostico critico original.

                    //ASIGNACION NIVEL DE EMERGENCIA (Nivel 2)
                    else if ((numoxigeno.ValueNumber <= 94 && numoxigeno.ValueNumber >= 90) || (numtemperatura.ValueNumber <= 39.9 && numtemperatura.ValueNumber >= 39) || (numdolor.ValueNumber <= 7 && numdolor.ValueNumber >= 5) || cbestadomental.Text == "Responde a estimulos verbales" || cbmotivo.Text == "Sospecha de derrame (ACV)" ||
                        cbmotivo.Text == "Reacción alérgica grave" || cbmotivo.Text == "Dolor en el pecho / Problemas cardíacos" || cbmotivo.Text == "Emergencia Obstétrica / Embarazo" || cbmecanismo.Text == "Quemadura" || cbmecanismo.Text == "Accidente de transito")
                    {
                        nuevoRegistro.IdNivelAsignado = 2;
                    }

                    //ASIGNACION NIVEL DE URGENCIA (Nivel 3)
                    else if ((numtemperatura.ValueNumber <=38.9 && numtemperatura.ValueNumber >=38) || (numdolor.ValueNumber <= 4 && numdolor.ValueNumber >=3) || cbmecanismo.Text == "Traumatismo / Accidente leve" || cbmecanismo.Text == "Caída desde su propia altura" || cbmecanismo.Text == "Heridas cortantes" ||
                        cbmotivo.Text== "Dolor Abdominal / Gastrointestinal" || cbmotivo.Text == "Fiebre / Infección" || cbmotivo.Text == "Problemas Respiratorios" || cbmotivo.Text == "Problemas urinarios / Renales") // no evalue el nivel de oxigeno y estado mental porque para clasificar a nivel 3 el cerebro debe estar perfectamente alerta, es decir oxigeno arriba de 95%
                    {
                        nuevoRegistro.IdNivelAsignado = 3;
                    }

                    //ASIGNACION NIVEL DE URGENCIA MENOR (Nivel 4)
                    else if ((numdolor.ValueNumber <= 2 && numdolor.ValueNumber >= 1) || (numtemperatura.ValueNumber <= 37.9 && numtemperatura.ValueNumber >= 37.5) || cbmotivo.Text == "Lesiones menores / Cortes superficiales" || cbmotivo.Text == "Problemas en la piel / Erupciones Leve " || cbmotivo.Text == "Dolor muscular / Articular crónico" || cbmotivo.Text == "Resfriado común / Tos leve")
                    {
                        nuevoRegistro.IdNivelAsignado = 4;
                    }

                    //ASIGNACION NIVEL DE NO URGENTE (Nivel 5)
                    else
                    {
                        nuevoRegistro.IdNivelAsignado = 5;
                    }

                        db.RegistrosTriajes.Add(nuevoRegistro);
                    db.SaveChanges();

                    MessageBox.Show("El paciente se ha ingresado en la clasificacion de triaje", "Exito");

                }
                catch (Exception ex)
                {
                    // Extraemos el error principal
                    string mensajeError = ex.Message;

                    // Si hay un "InnerException" (el detalle real de SQL Server), lo agregamos
                    if (ex.InnerException != null)
                    {
                        mensajeError += "\n\nDetalle de SQL Server:\n" + ex.InnerException.Message;
                    }

                    MessageBox.Show("Hubo un problema al guardar:\n\n" + mensajeError, "Error de Base de Datos");
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Login abrir = new Login();
            abrir.Show();
            this.Hide();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
