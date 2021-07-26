using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_DSI_Baigorria_Form
{
    class Empresa
    {
        private string razonSocial;
        private Int64 cuit;
        private string domicilio;
        private string localidad;
        private string email;
        private Int64 telefono;
        private string actividadRealizada;

        public string RazonSocial { get; set; }
        public Int64 Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string Email { get; set; }
        public Int64 Telefono { get; set; }
        public string ActividadRealizada { get; set; }

    }
}
