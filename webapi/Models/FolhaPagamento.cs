using System;
using System.ComponentModel.DataAnnotations;
using webapi.Validations;

namespace webapi.Models
{
    public class FolhaPagamento
    {
        public int Id { get; set; }
        public int ValorHora { get; set; }
        public int QuantidadeHoras { get; set; }

        public double SalarioBruto { get; set; }

        public double ImpostoRenda { get; set; }
        public double ImpostoInss { get; set; }
        public double ImpostoFgts { get; set; }
        public double SalarioLiquido { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}