using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EspacioEstacionamiento
    {
        /// <summary>
        /// Enum para tipo de estacionamiento
        /// </summary>
        public enum ETipo
        {
            Auto, Moto, Camioneta, Bicicleta
        }

        // Atributos

        private int numero;
        private ETipo tipo;
        private Vehiculo vehiculoEstacionado;
        private bool ocupado;

        public EspacioEstacionamiento(int numero, ETipo tipo, bool ocupado)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.ocupado = ocupado;
        }

        public bool Ocupado
        {
            get
            {
                return this.ocupado;
            }
            set
            {
                this.ocupado = value;
            }
        }

        public Vehiculo VehiculoEstacionado
        {
            get
            {
                return this.vehiculoEstacionado;
            }

            set
            {
                this.vehiculoEstacionado = value;
            }
        }

        public void ocuparEspacio(Vehiculo vehiculo)
        {
            if(!this.Ocupado)
            {
                if(this.tipo.ToString() == vehiculo.GetType().Name)
                {
                    this.ocupado = true;
                    this.VehiculoEstacionado = vehiculo;
                }
            }
        }

        public void liberarEspacio(Vehiculo vehiculo)
        {
            this.ocupado = false;
        }

        
    }
}
