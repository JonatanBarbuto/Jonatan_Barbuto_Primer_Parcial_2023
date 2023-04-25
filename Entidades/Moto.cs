using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        // Atributo static 
        private static double costoPorHora;

        /// <summary>
        /// Constructor static para setear el costo por hora
        /// </summary>
        static Moto()
        {
            Moto.costoPorHora = 100;
        }

        /// <summary>
        /// Constructor de clase
        /// </summary>
        /// <param name="marca">marca del auto</param>
        /// <param name="modelo">modelo del auto</param>
        /// <param name="patente">patente del auto</param>
        /// <param name="horaEntrada">hora de entrada del auto</param>
        public Moto(string marca, string modelo, string patente, DateTime horaEntrada)
            : base(marca, modelo, patente, horaEntrada)
        {

        }

        /// <summary>
        /// Propiedad para setear el costo de la hora
        /// </summary>
        public static double CostoPorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.costoPorHora = value;
                }
            }
        }

        /// <summary>
        /// Metodo para calcular costo de estadia
        /// </summary>
        /// <returns>El valor a pagar</returns>
        protected override double CargoDeEstadia()
        {
            return base.CargoDeEstadia() * costoPorHora;
        }

        /// <summary>
        /// Metodo para generar texto de salida
        /// </summary>
        /// <returns>Texto de salida</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Moto ***");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"El costo es {CargoDeEstadia}");

            return sb.ToString();
        }
    }
}
