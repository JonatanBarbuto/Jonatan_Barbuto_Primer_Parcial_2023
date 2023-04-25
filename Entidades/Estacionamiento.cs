using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private List<EspacioEstacionamiento> listadoEspacios;

        public Estacionamiento()
        {
            this.listadoEspacios = new List<EspacioEstacionamiento> ();
        }

        public List<EspacioEstacionamiento> ListadoEspacios
        {
            get
            {
                return this.listadoEspacios;
            }
            set
            {
                this.listadoEspacios = value;
            }
        }


        // Sobrecargas para agregar y sacar un vehiculo

        /// <summary>
        /// g.Un Estacionamiento y un Vehículo serán iguales, si el Vehículo se encuentra en el estacionamiento.
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator == (Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento is not null && vehiculo is not null)
            {
                foreach (EspacioEstacionamiento item in estacionamiento.listadoEspacios)
                {
                    if (item.VehiculoEstacionado == vehiculo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator != (Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        /// <summary>
        /// h.La sobrecargar del operador + (mas) permitirá agregar un Vehículo al Estacionamiento,
        /// siempre y cuando haya espacio disponible y el vehículo no se encuentre en él.
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            //if(estacionamiento.listadoEspacios.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            //{
            //    estacionamiento.ListadoVehiculos.Add(vehiculo);
            //    return true;
            //}
            return false;
        }
        /// <summary>
        /// i.La Sobrecarga del operador – (menos) permitirá retirar un Vehículo del  estacionamiento,
        /// si es que este se encuentra en él.
        /// Antes de remover se deberá asignar una hora de Egreso al vehículo, usar DateTime.Now.
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            
            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraSalida = DateTime.Now;
                // Aca falta codigo
            }
            return false;
        }


    }
}
