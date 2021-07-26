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
        //Ver cambios
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Ciudadano ciudadano1 = new Ciudadano();
        Ingreso ingreso1 = new Ingreso();
        Empresa empresa1 = new Empresa();
        Autorizacion autorizacion1 = new Autorizacion();

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
            ingreso1.Temperatura= Convert.ToInt32(txtTemperatura.Text);
            ingreso1.Patente = txtPatente.Text;
            lblFechaHoy.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
            ingreso1.FechaIngreso = Convert.ToDateTime(lblFechaHoy.Text);
            ingreso1.Hora= Convert.ToDateTime(lblHora.Text);
            if (ingreso1.DniValidar== ciudadano1.Dni)
            {
                if (ingreso1.DniValidar==autorizacion1.DniEmpleado)
                {
                    if (autorizacion1.FechaDesde < ingreso1.FechaIngreso)
                    {
                        if (ingreso1.FechaIngreso < autorizacion1.FechaHasta )
                        {
                            if (ingreso1.Temperatura < 37)
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
                            MessageBox.Show("No admitido por temperatura");
                            }
                        }
                        else
                        {
                        ingreso1.EstadoAutorizacion = " NO Autorizado";
                        txtEstado.Text = ingreso1.EstadoAutorizacion;
                        txtMostrarNom.Text = "";
                        txtActividad.Text = "";
                        MessageBox.Show("No admitido por periodo");
                        }
                    }
                    else
                    {
                    ingreso1.EstadoAutorizacion = " NO Autorizado";
                    txtEstado.Text = ingreso1.EstadoAutorizacion;
                    txtMostrarNom.Text = "";
                    txtActividad.Text = "";
                    MessageBox.Show("No admitido por periodo");
                    }
                }
                else
                {
                ingreso1.EstadoAutorizacion = " NO Autorizado";
                txtEstado.Text = ingreso1.EstadoAutorizacion;
                txtMostrarNom.Text = "";
                txtActividad.Text = "";
                MessageBox.Show("No esta autorizado por la Empresa");
                }
            }
            else
            {
            ingreso1.EstadoAutorizacion = " NO Autorizado";
            txtEstado.Text = ingreso1.EstadoAutorizacion;
            txtMostrarNom.Text = "";
            txtActividad.Text = "";
            MessageBox.Show("No se encuentra registrado");
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEmpresa_Click(object sender, EventArgs e)
        {
            empresa1.RazonSocial = txtRazonSocial.Text;
            empresa1.Cuit = Convert.ToInt64(txtCuitRegEmpresa.Text);
            empresa1.Domicilio = txtDomilicioRegEmpresa.Text;
            empresa1.Email = txtEmailEmpresa.Text;
            empresa1.Localidad = txtLocalidadRegEmpresa.Text;
            empresa1.Telefono = Convert.ToInt64(txtTel.Text);
            empresa1.ActividadRealizada = listBoxActEmpresa.Text;

        }

        private void btnAutorizarIngreso_Click(object sender, EventArgs e)
        {
            autorizacion1.CuitEmpresa = Convert.ToInt64(txtCuitEmpREmpleado.Text);
            autorizacion1.DniEmpleado = Convert.ToInt64(txtDniRegistrarEmpleado.Text);
            autorizacion1.FechaDesde = dateTimeFDesde.Value.Date;
            autorizacion1.FechaHasta = dateTimeFHasta.Value.Date;
            MessageBox.Show("Los datos fueron cargados correctamente");
        }

        private void btnBajaEmpleado_Click(object sender, EventArgs e)
        {
            autorizacion1.DniEmpleado = 0;
            MessageBox.Show("Se elimino el empleado de la lista de autorizaciones");
        }
    }
}
