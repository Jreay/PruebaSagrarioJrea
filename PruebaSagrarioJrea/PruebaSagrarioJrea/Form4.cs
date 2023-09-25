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
    public partial class Form4 : Form
    {
        Metodos metodos = new Metodos();
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

                var resultado = metodos.guardarCliente(cliente);
                if (resultado)
                {
                    MessageBox.Show("Cliente Guardado");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Cliente No Guardado");
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
