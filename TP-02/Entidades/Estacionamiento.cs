using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Estacionamiento
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        

        #region "Constructores"
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public new string ToString()
        {
            return Estacionamiento.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Estacionamiento c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos ");
            sb.AppendFormat(Convert.ToString(c.vehiculos.Count));
            sb.AppendFormat(" lugares ocupados de un total de ");
            sb.AppendFormat(Convert.ToString(c.espacioDisponible));
            sb.AppendFormat(" disponibles");
            sb.AppendLine("");

            foreach (Vehiculo v in c.vehiculos)
            {
               if((v.GetType().Name == Convert.ToString(tipo)) || tipo==ETipo.Todos)
                {
                    switch (tipo)
                    {
                        case ETipo.Camioneta:
                            sb.Append(v.Mostrar());
                            break;
                        case ETipo.Moto:
                            sb.Append(v.Mostrar());
                            break;
                        case ETipo.Automovil:
                            sb.Append(v.Mostrar());
                            break;
                        default:
                            sb.Append(v.Mostrar());
                            break;
                    }
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Estacionamiento operator +(Estacionamiento c, Vehiculo p)
        {
            foreach (Vehiculo v in c.vehiculos)
            {
                if (v == p)
                    return c;
            }

            if(c.vehiculos.Count < c.espacioDisponible)
            {
                c.vehiculos.Add(p);
            }
            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Estacionamiento operator -(Estacionamiento c, Vehiculo p)
        {
            foreach (Vehiculo v in c.vehiculos)
            {
                if (v == p)
                {
                    c.vehiculos.Remove(v);
                    break;
                }
            }

            return c;
        }
        #endregion

        public enum ETipo
        {
            Moto, 
            Automovil, 
            Camioneta, 
            Todos
        }
    }
}
