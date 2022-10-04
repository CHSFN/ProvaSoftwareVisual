using System.ComponentModel.DataAnnotations;
using System.Linq;
using API.Models;

namespace webapi.Validations
{
    class CpfEmUso : ValidationAttribute
    {
        // public CpfEmUso(string cpf){}

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string valor =(string) value;

            DataContext _context = (DataContext) validationContext.GetService(typeof(DataContext));

            if (_context.Funcionarios.FirstOrDefault(f => f.Cpf.Equals(valor)) != null)
            {
            //Caso de erro
            return new ValidationResult("O CPF do funcionário já está em uso!");
            }
            //Caso de Sucesso
            return ValidationResult.Success;


        }
    }
}