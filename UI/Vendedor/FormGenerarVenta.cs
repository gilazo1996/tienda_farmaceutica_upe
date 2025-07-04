using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace FarmaSalud
{
    public partial class FormGenerarVenta : Form
    {
        private class ProductoSeleccionado
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal => Cantidad * PrecioUnitario;
        }
        private List<ProductoSeleccionado> productosSeleccionados = new List<ProductoSeleccionado>();
        private FarmacoBLL farmacoBLL = new FarmacoBLL();
        private Farmaco productoActual;
        
        public FormGenerarVenta()
        {
            InitializeComponent();
            AgregarColumnaEliminar();
            dgvFarmacos.CellContentClick += dgvFarmacos_CellContentClick;
            txtCodigoProductoEncontrado.ReadOnly = true;
            txtCodigoProductoEncontrado.BackColor = SystemColors.Control;

            txtNombreProductoEncontrado.ReadOnly = true;
            txtNombreProductoEncontrado.BackColor = SystemColors.Control;

            txtPrecioProductoEncontrado.ReadOnly = true;
            txtPrecioProductoEncontrado.BackColor = SystemColors.Control;

            txtStock.ReadOnly = true;
            txtStock.BackColor = SystemColors.Control;
        }
        private void AgregarColumnaEliminar()
        {
            if (dgvFarmacos.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvFarmacos.Columns.Add(btnEliminar);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvFarmacos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvFarmacos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (productosSeleccionados.Count == 0)
                    return;

                var result = MessageBox.Show("¿Eliminar fármaco?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                     //Elimina de la lista interna según el índice de la fila
                    productosSeleccionados.RemoveAt(e.RowIndex);
                    ActualizarGrid();
                }
            }
        }
        private void ActualizarGrid()
        {
            dgvFarmacos.Rows.Clear();
            foreach (var p in productosSeleccionados)
            {
                dgvFarmacos.Rows.Add(p.Codigo, p.Nombre, p.Cantidad, p.PrecioUnitario, p.Subtotal);
            }
        }

        private void FormGenerarVenta_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarFarmaco_Click(object sender, EventArgs e)
        {
            

            if (productoActual == null)

            {
                MessageBox.Show("Primero busque un producto.");
                return;
            }

            int cantidad = (int)nudCantidadProductoEncontrado.Value;
            if (cantidad > productoActual.Stock)
            {
                MessageBox.Show("Stock insuficiente.");
                return;
            }

            productosSeleccionados.Add(new ProductoSeleccionado
            {
                Codigo = productoActual.CodigoInventario,
                Nombre = productoActual.NombreComercial,
                Cantidad = cantidad,
                PrecioUnitario = (decimal)productoActual.PrecioUnidad
            });

            ActualizarGrid();

             //Limpia los campos para la próxima búsqueda
            txtCodigoProductoEncontrado.Clear();
            txtNombreProductoEncontrado.Clear();
            txtPrecioProductoEncontrado.Clear();
            nudCantidadProductoEncontrado.Value = 1;
            productoActual = null;
        }

        private void btnBuscarFarmaco_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoFarmaco.Text.Trim();
            productoActual = farmacoBLL.ObtenerFarmacoPorCodigo(codigo);

            if (productoActual == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }
            txtCodigoProductoEncontrado.Text = productoActual.CodigoInventario;
            txtNombreProductoEncontrado.Text = productoActual.NombreComercial;
            txtPrecioProductoEncontrado.Text = productoActual.PrecioUnidad.ToString("C");
            nudCantidadProductoEncontrado.Maximum = productoActual.Stock;
            nudCantidadProductoEncontrado.Value = 1;
            txtStock.Text = productoActual.Stock.ToString();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (productosSeleccionados.Count == 0)
                {
                    MessageBox.Show("No hay productos en la venta.");
                    return;
                }

                int idVendedor = 1;  
                int? idCliente = null; 
                int idMetodoPago = 1;

                var productosDAL = productosSeleccionados
                    .Select(p => new DAL.ProductoSeleccionado
                    {
                        Codigo = p.Codigo,
                        Nombre = p.Nombre,
                        Cantidad = p.Cantidad,
                        PrecioUnitario = p.PrecioUnitario
                    })
                    .ToList();

                var ventaBLL = new VentaBLL();

                bool exito = ventaBLL.RegistrarVenta(idVendedor, idCliente, idMetodoPago, productosDAL);

                if (exito)
                {
                    MessageBox.Show("¡Venta registrada correctamente!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar la venta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FormGenerarVenta_Load_1(object sender, EventArgs e)
        {

        }
    }
}
