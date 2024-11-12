using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Models;

public partial class Raza
{
    public int CodRaza { get; set; }

    public string? NombreRaza { get; set; }

    public bool? Activo { get; set; }

    [JsonIgnore]
    public virtual ICollection<Mascotas> Mascotas { get; set; } = new List<Mascotas>();
}
