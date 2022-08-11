using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresariosBlazor.Utils
{
    public enum EnumStatusProduct
    {
        [Display(Name = "PENDIENTE DE APROBACION")]
        PENDIENTE,
        APROBADO,
        RECHAZADO,
        FINALIZADO
    }
}