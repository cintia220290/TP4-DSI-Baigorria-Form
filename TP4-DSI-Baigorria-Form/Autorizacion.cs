using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_DSI_Baigorria_Form
{
    class Autorizacion
    {
        private Int64 cuitEmpresa;
        private Int64 dniEmpleado;
        private DateTime fechaDesde;
        private DateTime fechaHasta;

        public Int64  CuitEmpresa{ get; set; }
        public Int64 DniEmpleado { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

    }
}
