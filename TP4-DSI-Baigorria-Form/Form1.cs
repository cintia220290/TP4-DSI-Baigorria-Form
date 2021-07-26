using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_DSI_Baigorria_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Ciudadano ciudadano1 = new Ciudadano();
        Ingreso ingreso1 = new Ingreso();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ciudadano1.NombreApellido = txtNombreApellido.Text;
            ciudadano1.Email = txtEmail.Text;
            ciudadano1.Domicilio = txtDomicilio.Text;
            ciudadano1.Dni = Convert.ToInt64(txtDNI.Text);
            ciudadano1.Telefono = Convert.ToInt64(txtTelefono.Text);
            ciudadano1.ActividadRealizada = listBoxActividad.Text;
            MessageBox.Show("Los datos fueron cargados correctamente");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            ingreso1.DniValidar = Convert.ToInt64(txtDniValidar.Text);
            if (ingreso1.DniValidar== ciudadano1.Dni)
              {
                ingreso1.EstadoAutorizacion = "Autorizado";
                txtEstado.Text = ingreso1.EstadoAutorizacion;
                txtMostrarNom.Text = ciudadano1.NombreApellido;
                txtActividad.Text = ciudadano1.ActividadRealizada;
              }
            else
            {
                ingreso1.EstadoAutorizacion = " NO Autorizado";
                txtEstado.Text = ingreso1.EstadoAutorizacion;
                txtMostrarNom.Text = "";
                txtActividad.Text = "";
            }
        }
    }
}
