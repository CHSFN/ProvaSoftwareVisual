using System;
using System.ComponentModel.DataAnnotations;
using webapi.Validations;

namespace webapi.Models
{
    public class Funcionario
    {
        public Funcionario () => CriadoEm = DateTime.Now;
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage ="O campo nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O campo nome é obrigatório!")]
        [StringLength(
            11,
            MinimumLength = 11,
            ErrorMessage = "O campo deve conter 11 caracteres!"
            )]
    //    [CpfEmUso()]
        public string Cpf { get; set; }

        [Range(1,999.50,ErrorMessage ="O salario não pode ser maior que R$: 1000!")]
        public double Salario { get; set; }
        [EmailAddress(ErrorMessage ="Email inválido")]
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime CriadoEm { get; set; }

        public FolhaPagamento FolhaPagamento { get; set; }
    }
}