using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresariosBlazor.Utils;

namespace EmpresariosBlazor.Models
{
    public class MovementByProduct
    {
        [Key] public int IdMovementByProduct { get; set; }
        [Display(Name = "Fecha movimiento")] public DateTime DateMovement { get; set; }

        [Display(Name = "Saldo anterior")]
        [DisplayFormat(DataFormatString = "{0:N0} ")]
        public decimal BalanceBefore { get; set; }

        [Display(Name = "Valor retiro")]
        [DisplayFormat(DataFormatString = "{0:N0} ")]
        public decimal CashOut { get; set; }

        [Display(Name = "Saldo despues")]
        [DisplayFormat(DataFormatString = "{0:N0} ")]
        public decimal BalanceAfter { get; set; }

        [Display(Name = "Estado")] public EnumStatusMovement Status { get; set; }
        public int IdProduct { get; set; }
    }
}