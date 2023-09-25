using PruebaSagrarioJrea.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSagrarioJrea
{
    public partial class Form5 : Form
    {
        Metodos metodos = new Metodos();

        public Form5()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var cliente = metodos.consultarCliente(txtIdentificacion.Text);
            if (cliente == null)
            {
                MessageBox.Show("Cliente No Encontrado");
                btnUpdate.Enabled = false;
                limpiar();
            }
            else
            {
                txtNombre.Text = cliente.nombres;
                txtApellido.Text = cliente.apellidos;
                txtCelular.Text = cliente.celular;
                txtEmail.Text = cliente.email;
                txtDireccion.Text = cliente.direccion;
                btnUpdate.Enabled = true;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtCelular.Text == "" && txtEmail.Text == "" && txtDireccion.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.identificacion = txtIdentificacion.Text;
                cliente.nombres = txtNombre.Text;
                cliente.apellidos = txtApellido.Text;
                cliente.celular = txtCelular.Text;
                cliente.email = txtEmail.Text;
                cliente.direccion = txtDireccion.Text;

                var resultado = metodos.actualizarCliente(cliente);
                if (resultado)
                {
                    MessageBox.Show("Cliente Actualizado");
                    limpiar();
                    btnUpdate.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Cliente No Actualizado");
                }
            }
        }

        public void limpiar()
        {
            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }
    }
}
