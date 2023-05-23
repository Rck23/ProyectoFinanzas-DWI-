using Microsoft.AspNetCore.Mvc;
using ProyectoFinanzas_DWI_.validations;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinanzas_DWI_.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [PrimeraLetraMayuscula]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]

        public string Nombre { get; set; }

        public int UsuarioId { get; set; }

        public int Orden { get; set; }
    }
}
