using System;
using System.Collections.Generic;

namespace Fase_1_C_.Models;

public partial class RegistrosTriaje
{
    public int IdRegistro { get; set; }

    public int? IdPaciente { get; set; }

    public int? IdUsuarioEnfermera { get; set; }

    public DateTime? FechaHoraIngreso { get; set; }

    public string? MotivoConsulta { get; set; }

    public string? EstadoMental { get; set; }

    public string? MecanismoLesion { get; set; }

    public string? SintomasCriticosJson { get; set; }

    public decimal? Temperatura { get; set; }

    public int? NivelDolor { get; set; }

    public int? SaturacionO2 { get; set; }

    public int? TiempoEvolucion { get; set; }

    public int? IdNivelAsignado { get; set; }

    public string? EstadoAtencion { get; set; }

    public int? IdUsuarioMedico { get; set; }

    public DateTime? FechaHoraAtencion { get; set; }

    public virtual NivelesTriaje? IdNivelAsignadoNavigation { get; set; }

    public virtual Paciente? IdPacienteNavigation { get; set; }

    public virtual Usuario? IdUsuarioEnfermeraNavigation { get; set; }

    public virtual Usuario? IdUsuarioMedicoNavigation { get; set; }
}
