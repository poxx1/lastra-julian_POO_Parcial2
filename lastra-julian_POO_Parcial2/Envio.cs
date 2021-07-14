using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastra_julian_POO_Parcial2
{
    public class Envio
    {
        // Persona que transporta el paquete
        public Transportista transportista { get; set; }

        // Persona que va a recibir el paquete
        public Clientes cliente { get; set; }

        // Persona que quiere enviar el paquete
        public Proveedor proveedor { get; set; }

        // Persona que es responsable de la carga del envio/paquete
        public Responsables responsable;

        // Movil que va a enviar el paquete
        public Moviles movil { get; set; }

        // Paquete que se va a trasnportar
        public Paquetes paquete { get; set; }
        
        public DateTime FechaLLegada { get; set; }
        public string LugarSalida { get; set; }
        public string LugarDestino { get; set; }
        public string Estado { get; set; } // Recibido, En proceso
        public float Costo { get; set; }

        #region Metodos

        // Calculo automatico de la fecha del envio 
        public DateTime CalcularLLegada()
        {
            var fechaActual = DateTime.Now;

            return fechaActual.AddDays(3);
        }
        #endregion
    }

}
