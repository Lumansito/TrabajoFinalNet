using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Models.Entity.Clases
{
    //Esta es la clase usuario para interactuar con el cliente (frontend)
    public class UsuarioLoginDTO
    {
        [Required(ErrorMessage = "El DNI es obligatorio")]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "El DNI debe tener 8 dígitos")]
        public int Dni { get; set; }

        // Propiedad auxiliar para enlazar como string en la vista
        [NotMapped]
        public string DniString
        {
            get => Dni.ToString();
            set
            {
                if (int.TryParse(value, out var dni))
                {
                    Dni = dni;
                }
            }
        }

        [Required(ErrorMessage = "La Contraseña es requerida")]
        public string Contraseña { get; set; }
    }
}
