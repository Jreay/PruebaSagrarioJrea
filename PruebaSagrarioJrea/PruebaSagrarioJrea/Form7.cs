using PruebaSagrarioJrea.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PruebaSagrarioJrea.Metodos;

namespace PruebaSagrarioJrea
{
    public partial class Form7 : Form
    {
        Metodos metodos = new Metodos();
        int factura = 0;
        int d = 0;
        double totalPagar = 0;
        public Form7()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtFecha.Enabled = false;
            txtSubtotal.Enabled = false;
            txtIVA.Enabled = false;
            txtTotal.Enabled = false;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var factura = metodos.consultarFactura(txtIdentificacion.Text);
            if (factura == null)
            {
                MessageBox.Show("Cliente No Encontrado");
                bloquearCampos(false);
                limpiar();
            }
            else
            {
                txtCodigo.Text = factura.codigoFactura;
                txtFecha.Text = factura.fechaEmision;
                txtNombre.Text = factura.nombres;
                txtApellido.Text = factura.apellidos;
                txtCelular.Text = factura.celular;
                txtEmail.Text = factura.email;
                txtDireccion.Text = factura.direccion;
                txtSubtotal.Text = factura.subtotal;
                txtIVA.Text = factura.iva;
                txtTotal.Text = factura.total;

                for (var i = 0; i < factura.contenido.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = factura.contenido[i].idProducto;
                    dataGridView1.Rows[i].Cells[1].Value = factura.contenido[i].nombre;
                    dataGridView1.Rows[i].Cells[2].Value = factura.contenido[i].cantidad;
                    dataGridView1.Rows[i].Cells[3].Value = factura.contenido[i].precio;
                    dataGridView1.Rows[i].Cells[4].Value = factura.contenido[i].total;
                }

                bloquearCampos(true);
            }
        }

        public void bloquearCampos(bool bloquear)
        {
            txtNombre.Enabled = bloquear;
            txtApellido.Enabled = bloquear;
            txtCelular.Enabled = bloquear;
            txtEmail.Enabled = bloquear;
            txtDireccion.Enabled = bloquear;
            txtProducto.Enabled = bloquear;
            txtCantidad.Enabled = bloquear;
            txtPrecio.Enabled = bloquear;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtCelular.Text == "" && txtEmail.Text == "" && txtDireccion.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                Guid uuid = Guid.NewGuid();
                campoFacturaCompleto campo = new();
                campo.codigoFactura = uuid.ToString();
                campo.fechaEmision = DateTime.Now.ToString();
                campo.identificacion = txtIdentificacion.Text;
                campo.nombres = txtNombre.Text;
                campo.apellidos = txtApellido.Text;
                campo.celular = txtCelular.Text;
                campo.email = txtEmail.Text;
                campo.direccion = txtDireccion.Text;
                campo.subtotal = txtSubtotal.Text;
                campo.iva = txtIVA.Text;
                campo.total = txtTotal.Text;

                List<campoFacturaContenido> listContenido = new List<campoFacturaContenido>();

                for (var i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    campoFacturaContenido contenido = new campoFacturaContenido();
                    contenido.nombre = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    contenido.cantidad = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    contenido.precio = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    contenido.total = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    listContenido.Add(contenido);
                }
                campo.contenido = listContenido;

                var resultado = metodos.actualizarFactura(campo);
                if (resultado)
                {
                    MessageBox.Show("Factura Actualizada");
                    limpiar();

                }
                else
                {
                    MessageBox.Show("Factura No Actualizada");
                }
            }
        }

        public void limpiar()
        {
            txtIdentificacion.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtIVA.Text = string.Empty;
            txtTotal.Text = string.Empty;
            dataGridView1.Rows.Clear();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal precio = Convert.ToDecimal(txtPrecio.Text, CultureInfo.InvariantCulture);
            double total = cantidad * Convert.ToDouble(precio);
            totalPagar += total;

            txtSubtotal.Text = totalPagar.ToString();
            txtIVA.Text = (Math.Round(totalPagar * 0.12, 2)).ToString();
            txtTotal.Text = (totalPagar + (totalPagar * 0.12)).ToString();
            btnUpdate.Enabled = true;

            if (txtProducto.Text != "" && txtCantidad.Text != "" && txtPrecio.Text != "")
            {
                factura++;
                int n = dataGridView1.Rows.Count;
                d = dataGridView1.Rows.Add();
                dataGridView1.Rows[d].Cells[0].Value = factura;
                dataGridView1.Rows[d].Cells[1].Value = producto;
                dataGridView1.Rows[d].Cells[2].Value = cantidad;
                dataGridView1.Rows[d].Cells[3].Value = precio;
                dataGridView1.Rows[d].Cells[4].Value = total;

                txtProducto.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
            }
        }
    }
}
