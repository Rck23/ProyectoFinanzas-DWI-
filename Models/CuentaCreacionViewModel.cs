using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProyectoFinanzas_DWI_.Models
{
    public class CuentaCreacionViewModel: Cuenta
    {
        public IEnumerable<SelectListItem> TiposCuentas { get; set; }
    }
}
