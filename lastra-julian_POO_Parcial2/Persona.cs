using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastra_julian_POO_Parcial2
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        
        // Destructor
        ~Persona()
        {
            Nombre = "";
            Apellido = "";
            DNI = 0;
        }
    }
}
