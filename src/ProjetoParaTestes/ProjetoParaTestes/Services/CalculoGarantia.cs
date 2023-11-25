using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaTestes.Services
{
    public class CalculoGarantia
    {
        public decimal CalcularMargemParte(decimal valorExposicao, decimal valorDepositado, decimal valorLimite, decimal valorMinimoParte, decimal valorMinimoContraParte)
        {
            var calculoProvisorio = valorExposicao + valorLimite;
            Console.WriteLine($"Valor provisorio: {calculoProvisorio}");
            var saldo = valorDepositado + calculoProvisorio;
            Console.WriteLine($"Valor Saldo: {saldo}");

            var calculoFinal = calculoProvisorio > 0 ? (valorDepositado != 0 ? valorDepositado : 0) : saldo;
            Console.WriteLine($"Calculo Final: {calculoFinal}");

            var chamadaMargem = calculoFinal > 0 ? 
                (Math.Abs(calculoFinal) > Math.Abs(valorMinimoContraParte) ? calculoFinal: 0) :
                (Math.Abs(calculoFinal) > Math.Abs(valorMinimoParte) ? calculoFinal : 0);

            return chamadaMargem;
        }

        public decimal CalcularMargemContraParte(decimal valorExposicao, decimal valorDepositado, decimal valorLimite, decimal valorMinimoParte, decimal valorMinimoContraParte)
        {
            var calculoProvisorio = valorExposicao + (valorLimite < 0 ? valorLimite : valorLimite *-1);
            Console.WriteLine($"Valor provisorio: {calculoProvisorio}");
            var saldo = valorDepositado + calculoProvisorio;
            Console.WriteLine($"Valor Saldo: {saldo}");

            var calculoFinal = calculoProvisorio < 0 ? (valorDepositado != 0 ? valorDepositado : 0) : saldo;
            Console.WriteLine($"Calculo Final: {calculoFinal}");
            var chamadaMargem = calculoFinal < 0 ?
                (Math.Abs(calculoFinal) > Math.Abs(valorMinimoContraParte) ? calculoFinal : 0) :
                (Math.Abs(calculoFinal) > Math.Abs(valorMinimoParte) ? calculoFinal : 0);

            return chamadaMargem;
        }
    }
}
