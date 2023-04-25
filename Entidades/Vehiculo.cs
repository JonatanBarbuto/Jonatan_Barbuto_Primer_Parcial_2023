using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        // Atributos de clase
        private string marca;
        private string modelo;
        private string patente;
        private DateTime horaEntrada;
        private DateTime horaSalida;


        /// <summary>
        /// Constructor de clase
        /// </summary>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="modelo">Modelo del vehiculo</param>
        /// <param name="patente">Patente del vehiculo</param>
        /// <param name="horaEntrada">Hora de entrada al estacionamiento</param>
        public Vehiculo(string marca, string modelo, string patente, DateTime horaEntrada)
        {
            this.marca = marca;
            this.modelo = modelo;
            Patente = patente;
            this.horaEntrada = horaEntrada;

        }


        

        public virtual double CostoEstacionamiento { get;}


        /// <summary>
        /// Metodo para calcular el tiempo de estacionamiento
        /// </summary>
        /// <returns>Tiempo de estadia</returns>
        protected virtual double CargoDeEstadia()
        {
            if(this.HoraSalida > this.HoraEntrada)
            {
                return (double)(this.HoraSalida.Hour - this.horaEntrada.Hour);
            }
            return 0;
        }


        




        public DateTime HoraEntrada
        {
            get 
            { 
                return this.horaEntrada;
            }
        }

        /// <summary>
        /// Propiedad con get y set de horaSalida
        /// </summary>
        public DateTime HoraSalida
        {
            get
            {
                return this.horaSalida;
            }
            
            set 
            { 
                this.horaSalida = value;
            }
        }

        /// <summary>
        /// Propiedad con get y set de patente
        /// </summary>
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        /// <summary>
        /// Metodo para validar que patente este entre 6 y 7 de largo
        /// </summary>
        /// <param name="patente">patente a validar</param>
        /// <returns></returns>
        private bool ValidarPatente(string patente)
        {
            return (patente.Length >= 6 && patente.Length <= 7);
        }

        /// <summary>
        /// Metodo para generar texto de salida
        /// </summary>
        /// <returns>Texto de salida</returns>
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*************************");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Patente: {this.patente}");
            sb.AppendLine($"Hora de Entrada: {this.horaEntrada}");
            sb.AppendLine($"Hora de Salida: {this.horaSalida}");

            return sb.ToString();
        }


        #region Sobrecarga

        /// <summary>
        /// Sobrecarga del operador == (Mediante patente)
        /// </summary>
        /// <param name="v1">Primer vehiculo a comparar</param>
        /// <param name="v2">Segundo vehiculo a comparar</param>
        /// <returns>True si ambos son iguales</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente);
        }

        /// <summary>
        /// Sobrecarga del operador != (Mediante patente)
        /// </summary>
        /// <param name="v1">Primer vehiculo a comparar</param>
        /// <param name="v2">Segundo vehiculo a comparar</param>
        /// <returns>True si son distintos</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
