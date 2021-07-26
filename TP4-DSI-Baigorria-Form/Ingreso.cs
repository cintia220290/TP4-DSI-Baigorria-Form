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
        private string estadoAutorizacion;
        private Int64 dniValidar;

        public DateTime FechaIngreso { get; set; }

        public string EstadoAutorizacion { get; set; }
        public Int64 DniValidar { get; set; }
        public DateTime ImprimirFechaPres()
        {
            fechaIngreso = DateTime.Today;
            return fechaIngreso;
        }

    }
}
