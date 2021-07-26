using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_DSI_Baigorria_Form
{
    class Ingreso
    {
        private DateTime fechaIngreso;
        private DateTime hora;
        private string estadoAutorizacion;
        private Int64 dniValidar;
        private Int32 temperatura;
        private string patente;

        public DateTime FechaIngreso { get; set; }
        public DateTime Hora { get; set; }
        public string EstadoAutorizacion { get; set; }
        public Int64 DniValidar { get; set; }
        public Int32 Temperatura { get; set; }
        public string Patente { get; set; }

    }
}
