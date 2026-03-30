using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTech_Shop
{
    public partial class FrmPrincipal : Form
    {
        // Lista donde se guardan los clientes
        private List<Cliente> listaClientes = new List<Cliente>();

        // Lista donde se guardan las órdenes
        private List<Orden> listaOrdenes = new List<Orden>();
        public FrmPrincipal()
        {
            InitializeComponent();
            // Columnas de la tabla de clientes
            dgvClientes.Columns.Add("IdCliente", "ID Cliente");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Telefono", "Telefono");
            dgvClientes.Columns.Add("Correo", "Correo");
            dgvClientes.Columns.Add("Direccion", "Direccion");

            // Columnas de la tabla de órdenes
            dgvOrdenes.Columns.Add("IdOrden", "ID Orden");
            dgvOrdenes.Columns.Add("Cliente", "Cliente");
            dgvOrdenes.Columns.Add("Descripcion", "Descripcion");
            dgvOrdenes.Columns.Add("Cantidad", "Cantidad");
            dgvOrdenes.Columns.Add("Precio", "Precio");
            dgvOrdenes.Columns.Add("Total", "Total");
            dgvOrdenes.Columns.Add("Fecha", "Fecha");
            dgvOrdenes.Columns.Add("Estado", "Estado");

            // Opciones del ComboBox de estado
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("En proceso");
            cmbEstado.Items.Add("Entregada");
            cmbEstado.Items.Add("Cancelada");
            cmbEstado.SelectedIndex = 0;
        }
       
        private void lblClientes_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
        // configurar boton para guardar clientes
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (txtIdCliente.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Completa ID, Nombre y Telefono");
                return;
            }

            // Validar que el ID sea número
            if (!int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                MessageBox.Show("ID Cliente invalido");
                return;
            }

            // Crear objeto cliente
            Cliente c = new Cliente(
                idCliente,
                txtNombre.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                txtDireccion.Text
            );

            // Guardar en la lista
            listaClientes.Add(c);

            // Mostrar en la tabla
            dgvClientes.Rows.Add(
                c.IdCliente,
                c.Nombre,
                c.Telefono,
                c.Correo,
                c.Direccion
            );

            // Agregar cliente al ComboBox
            cmbCliente.Items.Add(c.Nombre);

            // Mensaje
            MessageBox.Show("Cliente agregado");

            // Limpiar campos
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            // Validar que la cantidad sea número
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Cantidad invalida");
                return;
            }

            // Validar que el precio sea número
            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Precio invalido");
                return;
            }

            // Calcular total
            double total = cantidad * precio;

            // Mostrar el resultado en el TextBox
            txtTotal.Text = total.ToString();
        }

        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (txtIdOrden.Text == "" || cmbCliente.Text == "" || txtDescripcion.Text == "" ||
                txtCantidad.Text == "" || txtPrecio.Text == "" || txtTotal.Text == "" ||
                txtFecha.Text == "" || cmbEstado.Text == "")
            {
                MessageBox.Show("Completa todos los campos de la orden");
                return;
            }

            // Validar que el ID de la orden sea número
            if (!int.TryParse(txtIdOrden.Text, out int idOrden))
            {
                MessageBox.Show("ID Orden invalido");
                return;
            }

            // Validar que la cantidad sea número
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Cantidad invalida");
                return;
            }

            // Validar que el precio sea número
            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Precio invalido");
                return;
            }

            // Validar que el total sea número
            if (!double.TryParse(txtTotal.Text, out double total))
            {
                MessageBox.Show("Total invalido");
                return;
            }

            // Crear objeto orden
            Orden o = new Orden(
                idOrden,
                cmbCliente.Text,
                txtDescripcion.Text,
                cantidad,
                precio,
                total,
                txtFecha.Text,
                cmbEstado.Text
            );

            // Guardar la orden en la lista
            listaOrdenes.Add(o);

            // Mostrar la orden en la tabla
            dgvOrdenes.Rows.Add(
                o.IdOrden,
                o.Cliente,
                o.Descripcion,
                o.Cantidad,
                o.Precio,
                o.Total,
                o.Fecha,
                o.Estado
            );

            // Mensaje de confirmación
            MessageBox.Show("Orden agregada");

            // Limpiar campos
            txtIdOrden.Clear();
            cmbCliente.Text = "";
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
            txtFecha.Clear();
            cmbEstado.SelectedIndex = 0;
        }

        private void btnLimpiarOrden_Click(object sender, EventArgs e)
        {
            txtIdOrden.Clear();
            cmbCliente.Text = "";
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
            txtFecha.Clear();
            cmbEstado.SelectedIndex = 0;
        }
    }
  }
  

