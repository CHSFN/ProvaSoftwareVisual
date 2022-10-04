using System;
using System.ComponentModel.DataAnnotations;
using webapi.Validations;

namespace webapi.Utils
{
    public class Calcs
    {
        public int CalcularSalarioBruto(int ValorHora, int QuantidadeHoras)
        {
            return ValorHora * QuantidadeHoras;
        }
        public double CalcularImpostoRenda(double SalarioBruto)
        {
            if (SalarioBruto < 1903.99)
            {
                return 0;
            }
            else if (SalarioBruto > 1903.98 && SalarioBruto < 2826.66)
            {
                return (SalarioBruto * 0.075) - 142.80;
            }
            else if (SalarioBruto > 2826.65 && SalarioBruto < 3751.06)
            {
                return (SalarioBruto * 0.15) - 354.80;
            }
            else if (SalarioBruto > 3751.05 && SalarioBruto < 4664.69)
            {
                return (SalarioBruto * 0.225) - 636.13;
            }
            else
            {
                return (SalarioBruto * 0.275) - 869.36;
            }
        }

        public double CalcularInss(double SalarioBruto)
        {
            if (SalarioBruto < 1693.73)
            {
                return SalarioBruto * 0.08;
            }
            else if (SalarioBruto > 1693.72 && SalarioBruto < 2822.91)
            {
                return SalarioBruto * 0.09;
            }
            else if (SalarioBruto > 2822.90 && SalarioBruto < 5645.81)
            {
                return SalarioBruto * 0.11;
            }
            else
            {
                return 621.03;
            }
        }
        public double CalcularFgts(double SalarioBruto)
        {
            return SalarioBruto * 0.08;
        }
        public double CalcularSalarioLiquido(double SalarioBruto, double ImpostoRenda, double ImpostoInss, double ImpostoFgts)
        {
            return SalarioBruto - (ImpostoRenda + ImpostoInss + ImpostoFgts) ;
        }
    
    }
}