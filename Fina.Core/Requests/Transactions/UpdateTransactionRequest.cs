using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Transactions
{
    public class UpdateTransactionRequest:Request
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Preencha o titulo")]
        [MaxLength(80, ErrorMessage = "O titulo deve conter ate 80 caracteres")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Valor invalido")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Categoria Invalida")]
        public long CategoryId { get; set; }
        [Required(ErrorMessage = "Data invalida")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}
