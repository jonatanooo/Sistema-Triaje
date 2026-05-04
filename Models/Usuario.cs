using System;
using System.Collections.Generic;

namespace Fase_1_C_.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string DuiUsuaio { get; set; } = null!;

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Rol { get; set; }

    public string? Username { get; set; }

    public string? PasswordHash { get; set; }

    public virtual ICollection<RegistrosTriaje> RegistrosTriajeIdUsuarioEnfermeraNavigations { get; set; } = new List<RegistrosTriaje>();

    public virtual ICollection<RegistrosTriaje> RegistrosTriajeIdUsuarioMedicoNavigations { get; set; } = new List<RegistrosTriaje>();
}
