using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase_1_C_.Models;

namespace Fase_1_C_
{
    public partial class VistaPacientes : Form
    {
        public VistaPacientes()
        {
            InitializeComponent();
        }

        private void VistaPacientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            using (var db = new TriajeClinicoContext())
            {
                var vistaPersonalizada = (from t1 in db.RegistrosTriajes
                                          join t2 in db.Pacientes on t1.IdPaciente equals t2.IdPaciente
                                          where t1.EstadoAtencion == "En Sala de Espera"
                                          orderby t1.IdNivelAsignado ascending, t1.FechaHoraIngreso ascending
                                          select new
                                          {
                                              Id_Registro = t1.IdRegistro,
                                              //creamos el lienzo vacio para el icono (que representa el nivel de emergencia TRIAJE)
                                              Color_Nivel = "",
                                              Nivel = t1.IdNivelAsignado,
                                              Nombres = t2.Nombres,
                                              Apellidos = t2.Apellidos,
                                              FechaIngreso = t1.FechaHoraIngreso,
                                              Motivo = t1.MotivoConsulta,
                                              EstadoMental = t1.EstadoMental,
                                              MecanismoLesion = t1.MecanismoLesion,
                                              Temperatura = t1.Temperatura,
                                              NivelDolor = t1.NivelDolor,
                                              SaturacionO2 = t1.SaturacionO2,
                                              EstadoAtencion = t1.EstadoAtencion
                                          }).ToList();

                dgvtriaje.DataSource = vistaPersonalizada;

                //Desactivamos el autoajuste visual para poder forzar la altura y anchura nosotros
                dgvtriaje.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                //Le damos a la "plantilla" de fila una altura y anchura
                dgvtriaje.RowTemplate.Height = 40;
                dgvtriaje.Columns["Color_Nivel"].Width = 150;

                //Si ya tienes datos cargados, forzamos la altura a todas las filas actuales
                foreach (DataGridViewRow row in dgvtriaje.Rows)
                {
                    row.Height = 40;
                }

            }
        }

        private void dgvtriaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvtriaje_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Validaciones normales de fila/columna y nombre de columna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvtriaje.Columns[e.ColumnIndex].Name == "Color_Nivel")
            {
                //Pintamos el fondo normal de la celda para que no se vea negra
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                //Obtenemos el nivel
                var valorCelda = dgvtriaje.Rows[e.RowIndex].Cells["Nivel"].Value;

                if (valorCelda != null)
                {
                    int nivel = Convert.ToInt32(valorCelda);

                    // VARIABLES DE DISEÑO
                    Color backColor = Color.Gray;    // Fondo del badge
                    Color textColor = Color.White;   // Color de letra
                    string textLabel = "DESCONOCIDO";

                    //ASIGNAR COLOR Y TEXTO SEGÚN NIVEL
                    switch (nivel)
                    {
                        case 1:
                            backColor = Color.Red;
                            textLabel = "RESUCITACIÓN";
                            break;
                        case 2:
                            backColor = Color.Orange;
                            textLabel = "EMERGENCIA";
                            break;
                        case 3:
                            backColor = Color.Yellow;
                            textColor = Color.Black;
                            textLabel = "URGENCIA";
                            break;
                        case 4:
                            backColor = Color.Green;
                            textLabel = "U. MENOR";
                            break;
                        case 5:
                            backColor = Color.Blue;
                            textLabel = "NO URGENTE";
                            break;
                    }

                    //Antialiasing para difuminar los bordes (para que no se vea como sierra)
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    //CALCULAR EL ÁREA DEL RECTANGULO
                    // Tomamos toda la celda y le quitamos márgenes (4px arriba/abajo, 8px lados)
                    int marginV = 4;
                    int marginH = 8;
                    Rectangle badgeArea = new Rectangle(
                        e.CellBounds.Left + marginH,
                        e.CellBounds.Top + marginV,
                        e.CellBounds.Width - (2 * marginH),
                        e.CellBounds.Height - (2 * marginV)
                    );

                    //DIBUJAR EL FONDO REDONDEADO
                    // El '10' es el radio de la curva de los bordes.
                    using (var shapePath = GetRoundedRect(badgeArea, 10))
                    {
                        using (Brush backBrush = new SolidBrush(backColor))
                        {
                            e.Graphics.FillPath(backBrush, shapePath);
                        }
                    }

                    //DIBUJAR EL TEXTO CENTRADO
                    // Creamos una fuente negrita y un formato de centrado perfecto
                    using (Font textFont = new Font("Segoe UI", 8.25F, FontStyle.Bold))
                    using (Brush textBrush = new SolidBrush(textColor))
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;     // Centrado horizontal
                        sf.LineAlignment = StringAlignment.Center;  // Centrado vertical

                        // Dibujamos el texto dentro de la misma área del badge
                        e.Graphics.DrawString(textLabel, textFont, textBrush, badgeArea, sf);
                    }
                }

                //Cancela el pintado de texto por defecto de Windows
                e.Handled = true;
            }
        }

        // --- Función Auxiliar(GDI+) ---
        // Genera el camino geométrico para un rectángulo redondeado
        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRect(RectangleF baseRect, float radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(baseRect.X, baseRect.Y, radius, radius, 180, 90);
            path.AddArc(baseRect.Right - radius, baseRect.Y, radius, radius, 270, 90);
            path.AddArc(baseRect.Right - radius, baseRect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(baseRect.X, baseRect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void dgvprueba_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
