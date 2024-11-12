using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Models;

public partial class Jornada
{
    public string NombreDia { get; set; } = null!;

    public TimeOnly HoraInicioJornada { get; set; }

    public TimeOnly HoraFinJornada { get; set; }

    [JsonIgnore]
    public virtual ICollection<Usuarios> DniProfesional { get; set; } = new List<Usuarios>();
}
