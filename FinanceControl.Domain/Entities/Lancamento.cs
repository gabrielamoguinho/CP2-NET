using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Domain.Entities
{
    public class Lancamento
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        [Required]
        [RegularExpression("Receita|Despesa", ErrorMessage = "Tipo deve ser Receita ou Despesa")]
        public string Tipo { get; set; } = "Despesa";

        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
