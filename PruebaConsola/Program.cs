using Entidades;

namespace PruebaConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Auto("Honda", "Civic", "irv368", DateTime.Now);
            EspacioEstacionamiento e1 = new EspacioEstacionamiento(1, EspacioEstacionamiento.ETipo.Auto, false);
            e1.VehiculoEstacionado = v1;
            EspacioEstacionamiento e2 = new EspacioEstacionamiento(2, EspacioEstacionamiento.ETipo.Auto, false);
            EspacioEstacionamiento e3 = new EspacioEstacionamiento(3, EspacioEstacionamiento.ETipo.Auto, false);
            EspacioEstacionamiento e4 = new EspacioEstacionamiento(4, EspacioEstacionamiento.ETipo.Auto, false);
            EspacioEstacionamiento e5 = new EspacioEstacionamiento(5, EspacioEstacionamiento.ETipo.Auto, false);
            Estacionamiento estacionamiento = new Estacionamiento();
            estacionamiento.ListadoEspacios.Add(e1);
            estacionamiento.ListadoEspacios.Add(e2);
            estacionamiento.ListadoEspacios.Add(e3);
            estacionamiento.ListadoEspacios.Add(e4);
            estacionamiento.ListadoEspacios.Add(e5);

            Console.WriteLine(e1.VehiculoEstacionado.MostrarDatos());
            e1.liberarEspacio(v1);
            Console.WriteLine(e1.VehiculoEstacionado.MostrarDatos());
            

            



        }
    }
}