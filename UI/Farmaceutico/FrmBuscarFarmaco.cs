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

namespace UI
{
    public partial class FrmBuscarFarmaco : Form
    {
        private FarmacoBLL farmacoBLL;
        private Farmaco farmacoEncontrado;

        public FrmBuscarFarmaco()
        {
            InitializeComponent();
            farmacoBLL = new FarmacoBLL();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Hacer los campos de datos del fármaco de solo lectura
            txtNombreComercial.ReadOnly = true;
            txtCodigoInventario.ReadOnly = true;
            txtPrecioUnidad.ReadOnly = true;
            txtStock.ReadOnly = true;
            txtFechaVencimiento.ReadOnly = true;
            txtProveedor.ReadOnly = true;
            chkRequiereReceta.Enabled = false;

            // Ocultar inicialmente los datos del fármaco y botones de acción
            panelDatosFarmaco.Visible = false;
            panelBotones.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoBusqueda.Text.Trim();

                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("Por favor, ingrese un código de fármaco.", "Validación", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBusqueda.Focus();
                    return;
                }

                // Buscar el fármaco
                farmacoEncontrado = farmacoBLL.ObtenerFarmacoPorCodigo(codigo);

                if (farmacoEncontrado == null)
                {
                    MessageBox.Show("Fármaco no encontrado.", "Búsqueda", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                    return;
                }

                // Mostrar los datos del fármaco encontrado
                MostrarDatosFarmaco();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la búsqueda: " + ex.Message, "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosFarmaco()
        {
            txtCodigoInventario.Text = farmacoEncontrado.CodigoInventario;
            txtNombreComercial.Text = farmacoEncontrado.NombreComercial;
            txtPrecioUnidad.Text = farmacoEncontrado.PrecioUnidad.ToString("C");
            txtStock.Text = farmacoEncontrado.Stock.ToString();
            txtFechaVencimiento.Text = farmacoEncontrado.FechaVencimiento.ToString("dd/MM/yyyy");
            txtProveedor.Text = farmacoEncontrado.Proveedor?.Nombre ?? "Sin proveedor";
            chkRequiereReceta.Checked = farmacoEncontrado.RequiereReceta;

            // Mostrar paneles con los datos y botones
            panelDatosFarmaco.Visible = true;
            panelBotones.Visible = true;
        }

        private void LimpiarDatos()
        {
            txtCodigoInventario.Clear();
            txtNombreComercial.Clear();
            txtPrecioUnidad.Clear();
            txtStock.Clear();
            txtFechaVencimiento.Clear();
            txtProveedor.Clear();
            chkRequiereReceta.Checked = false;

            panelDatosFarmaco.Visible = false;
            panelBotones.Visible = false;
            farmacoEncontrado = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (farmacoEncontrado == null)
            {
                MessageBox.Show("No hay fármaco seleccionado para editar.", "Validación", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí se puede abrir un formulario de edición
            // Por ahora, mostramos un mensaje
            MessageBox.Show($"Función de editar fármaco '{farmacoEncontrado.NombreComercial}' " +
                          "será implementada en el formulario de edición.", "Información", 
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (farmacoEncontrado == null)
            {
                MessageBox.Show("No hay fármaco seleccionado para eliminar.", "Validación", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro que desea eliminar el fármaco '{farmacoEncontrado.NombreComercial}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = farmacoBLL.EliminarFarmaco(farmacoEncontrado.CodigoInventario);
                    
                    if (eliminado)
                    {
                        MessageBox.Show($"Fármaco '{farmacoEncontrado.NombreComercial}' eliminado correctamente.", 
                                      "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LimpiarDatos();
                        txtCodigoBusqueda.Clear();
                        txtCodigoBusqueda.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el fármaco.", "Error", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el fármaco: " + ex.Message, "Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Buscar el formulario del farmacéutico en las ventanas abiertas
            FormFarmaceu formFarmaceutico = null;
            
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormFarmaceu)
                {
                    formFarmaceutico = (FormFarmaceu)form;
                    break;
                }
            }
            
            // Si se encontró el formulario del farmacéutico, mostrarlo
            if (formFarmaceutico != null)
            {
                formFarmaceutico.Show();
                formFarmaceutico.WindowState = FormWindowState.Normal;
                formFarmaceutico.BringToFront();
            }
            
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoBusqueda.Clear();
            LimpiarDatos();
            txtCodigoBusqueda.Focus();
        }
    }
}
