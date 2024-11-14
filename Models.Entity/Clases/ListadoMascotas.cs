namespace Models.Entity.Clases
{
    public class ListadoMascotas
    {
        public int MascotaId { get; set; }
        public string? NombreMascota { get; set; }
        public int? Edad { get; set; }
        public string? NombreRaza { get; set; }
        public string? NombreEspecie { get; set; }
        public DateTime? FechaDefuncion { get; set; }
    }
}
