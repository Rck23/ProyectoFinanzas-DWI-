using System.ComponentModel.DataAnnotations;

namespace ProyectoFinanzas_DWI_.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo correo electrónico es requerido")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo contraseña es requerido")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Recuérdame")]
        public bool Recuerdame { get; set; }

    }
}
