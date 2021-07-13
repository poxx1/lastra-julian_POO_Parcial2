using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastra_julian_POO_Parcial2
{
    public class Envio
    {
        public string NombreTransportista { get; set; }
        public string NombreRecepcionista { get; set; }

        public string NombreRegistrador;
        public DateTime fechaLLegada { get; set; }

        public Moviles movil { get; set; }

        public string LugarSalida { get; set; }

        public string LugarDestino { get; set; }

        public float Costo { get; set; }

        #region Metodos

        // Constructor
        public Envio(string trasportista, string recepcionista, string registrador)
        {
            NombreTransportista = trasportista;
            NombreRecepcionista = recepcionista;
            NombreRegistrador = registrador;
            fechaLLegada = CalcularLLegada();
        }

        // Calculo automatico de la fecha del envio 
        public DateTime CalcularLLegada()
        {
            var fechaActual = DateTime.Now;

            return fechaActual.AddDays(3);
        }
        #endregion
    }

}
