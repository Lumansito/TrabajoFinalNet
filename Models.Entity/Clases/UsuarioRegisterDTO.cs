using System.ComponentModel.DataAnnotations;


namespace Models.Entity.Clases
{
    public class UsuarioRegisterDTO
    {
        [Required(ErrorMessage = "El DNI es obligatorio")]
        [RegularExpression("^[0-9]{7,10}$", ErrorMessage = "El DNI debe ser un número de entre 7 y 10 dígitos")]
        public int Dni { get; set; }

        // Propiedad auxiliar para enlazar como string en la vista
        //[NotMapped]
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


        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(100, ErrorMessage = "El apellido debe tener entre 3 y 100 caracteres", MinimumLength = 3)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "Dirección de correo electrónico no válida")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(100, ErrorMessage = "La contraseña debe tener al menos 6 caracteres", MinimumLength = 6)]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "Número de teléfono no válido")]
        [StringLength(15, ErrorMessage = "El teléfono debe tener entre 7 y 15 caracteres", MinimumLength = 7)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha no válido")]
        [CustomValidation(typeof(UsuarioRegisterDTO), nameof(ValidarFechaNacimiento))]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El rol es obligatorio")]
        [StringLength(50, ErrorMessage = "El rol debe tener entre 3 y 50 caracteres", MinimumLength = 3)]
        public string Rol { get; set; }

        public bool IsAdmin { get; set; } // No requiere validación obligatoria para booleanos

        // Validación personalizada para asegurar que la fecha de nacimiento sea en el pasado
        public static ValidationResult ValidarFechaNacimiento(DateTime fechaNacimiento, ValidationContext context)
        {
            if (fechaNacimiento >= DateTime.Now)
            {
                return new ValidationResult("La fecha de nacimiento debe estar en el pasado");
            }
            return ValidationResult.Success;
        }

        // Validación personalizada para la longitud del DNI
        public static ValidationResult ValidarDni(int dni, ValidationContext context)
        {
            var dniString = dni.ToString();
            if (dniString.Length < 7 || dniString.Length > 10)
            {
                return new ValidationResult("El DNI debe tener entre 7 y 10 dígitos");
            }
            return ValidationResult.Success;
        }
    }
}
