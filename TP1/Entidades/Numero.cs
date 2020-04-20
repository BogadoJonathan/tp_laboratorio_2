using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        public Numero()
        {
            this.SetNumero = "0";
        }

        public Numero(double numero)
        {
            this.SetNumero = Convert.ToString(numero);
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public string BinarioDecimal(string binario)
        {
            return "";
        }

        public string DecimalBinario(double numero)
        {
            return "";
        }

        public string DecimalBinario(string numero)
        {
            return "";
        }

        private double ValidarNumero(string strNumero)
        {
            double retorno;
            if (!(double.TryParse(strNumero, out retorno)))
                retorno = 0;
            return retorno;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
                return double.MinValue;
            else
                return n1.numero / n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
