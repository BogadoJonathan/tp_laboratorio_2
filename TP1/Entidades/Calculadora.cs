using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            string signo = Calculadora.ValidarOperador(operador);
            double resultado = 0;
            switch (signo)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }

        private static string ValidarOperador(string operador)
        {
            string retorno = "";
            switch (operador)
            {
                case "+":
                    retorno = operador;
                    break;
                case "-":
                    retorno = operador;
                    break;
                case "/":
                    retorno = operador;
                    break;
                case "*":
                    retorno = operador;
                    break;
                default:
                    retorno = "+";
                    break;
            }
            return retorno;
        }
    }
}
