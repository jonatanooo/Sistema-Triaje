using System;
using System.Collections.Generic;

namespace Fase_1_C_.Models;

public partial class NivelesTriaje
{
    public int IdNivel { get; set; }

    public string? Color { get; set; }

    public string? Descripcion { get; set; }

    public int? TiempoMaxEspera { get; set; }

    public virtual ICollection<RegistrosTriaje> RegistrosTriajes { get; set; } = new List<RegistrosTriaje>();
}
