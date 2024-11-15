﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Models;

public partial class Especies
{
    public int CodEspecie { get; set; }

    public string? NombreEspecie { get; set; }

    [JsonIgnore]
    public virtual ICollection<Mascotas> Mascotas { get; set; } = new List<Mascotas>();
}
