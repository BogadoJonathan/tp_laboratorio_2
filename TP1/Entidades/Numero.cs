using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Cargara valor al parametro numero
        /// </summary>
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

        /// <summary>
        /// Conviernte un numero binario a decimal
        /// </summary>
        /// <param name="binario">resultado del label</param>
        /// <returns>retorna decimal</returns>
        public string BinarioDecimal(string binario)
        {
            return Convert.ToString(Convert.ToInt32(binario, 2));
        }

        /// <summary>
        /// Conviernte un numero decimal a binario
        /// </summary>
        /// <param name="numero">resultado del label</param>
        /// <returns>retorna binario</returns>
        public string DecimalBinario(double numero)
        {
            return Convert.ToString(Convert.ToInt32(numero), 2);
        }

        /// <summary>
        /// Conviernte un numero decimal a binario
        /// </summary>
        /// <param name="numero">resultado del label</param>
        /// <returns>retorna binario</returns>
        public string DecimalBinario(string numero)
        {
            return this.DecimalBinario(Convert.ToDouble(numero)) ;
        }

        /// <summary>
        /// Valida que un numero no tenga caracteres
        /// </summary>
        /// <param name="strNumero">numero a validar</param>
        /// <returns>retorna 0 si hay caracteres, de lo contrario retorna el numero</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno;
            if (!(double.TryParse(strNumero, out retorno)))
                retorno = 0;
            return retorno;
        }

        /// <summary>
        /// Multiplica 2 numeros
        /// </summary>
        /// <param name="n1">Objeto Numero para sacar el primer valor</param>
        /// <param name="n2">Objeto Numero para sacar el segundo  valor</param>
        /// <returns>Retorna resultado de la multiplicacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Divide 2 numeros
        /// </summary>
        /// <param name="n1">Objeto Numero para sacar el primer valor</param>
        /// <param name="n2">Objeto Numero para sacar el segundo  valor</param>
        /// <returns>Retorna resultado de la division</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
                return double.MinValue;
            else
                return n1.numero / n2.numero;
        }

        /// <summary>
        /// Resta 2 numeros
        /// </summary>
        /// <param name="n1">Objeto Numero para sacar el primer valor</param>
        /// <param name="n2">Objeto Numero para sacar el segundo  valor</param>
        /// <returns>Retorna resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Suma 2 numeros
        /// </summary>
        /// <param name="n1">Objeto Numero para sacar el primer valor</param>
        /// <param name="n2">Objeto Numero para sacar el segundo  valor</param>
        /// <returns>Retorna resultado de la suma</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
