using System.ComponentModel.DataAnnotations;

namespace ProyectoFinanzas_DWI_.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre de usuario")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo correo electrónico es requerido")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo contraseña es requerido")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
