using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ETipo tipo;

        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color)
            : this(marca,chasis,color,ETipo.Monovolumen)
        {
        }

        public Automovil(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color) 
        {
            this.tipo = tipo;
        }



        //public override sealed string Mostrar()
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine((string)this);
            sb.Append(string.Format("TAMAÑO : {0}", this.Tamanio));
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            sb.AppendLine("");

            return sb.ToString();
        }

        public enum ETipo 
        {
            Monovolumen,
            Sedan,
        }
    }
}
