using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string dni;
        private bool administrador;

        public Empleado(string nombre, string apellido, string dni, bool administrador)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.administrador = administrador;
        }


    }
}
