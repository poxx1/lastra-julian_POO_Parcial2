using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastra_julian_POO_Parcial2
{
    public class Clientes : Persona
    {
        // Propiedad de solo lectura
        public readonly int ID;

        // Constructor 
        public Clientes(string nombre, string apellido, int dni, int id)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            ID = id;
        }
    }
}
