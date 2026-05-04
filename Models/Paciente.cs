using System;
using System.Collections.Generic;

namespace Fase_1_C_.Models;

public partial class Paciente
{
    public int IdPaciente { get; set; }

    public string DuiPaciente { get; set; } = null!;

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public virtual ICollection<RegistrosTriaje> RegistrosTriajes { get; set; } = new List<RegistrosTriaje>();
}
