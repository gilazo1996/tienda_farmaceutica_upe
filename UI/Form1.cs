using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = tboxIngreseUsuario.Text;
            string password = tboxIngresePass.Text;

            // Validar credenciales (esto es un ejemplo básico)
            if (username == "admin" && password == "1234")
            {
                // Redirigir al formulario de administrador
                FormAdmin adminForm = new FormAdmin();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "vendedor" && password == "1234")
            {
                // Redirigir al formulario de vendedor
                FormVendedor vendedorForm = new FormVendedor();
                vendedorForm.Show();
                this.Hide();
            }

            else if (username == "farmaceutico" && password == "1234")
            {
                // Redirigir al formulario de vendedor
                FormFarmaceu farmaceuForm = new FormFarmaceu();
                farmaceuForm.Show();
                this.Hide();
            }

            else if (username == "gerente" && password == "1234")
            {
                // Redirigir al formulario de vendedor
                FormGerente gerenteForm = new FormGerente();
                gerenteForm.Show();
                this.Hide();
            }

            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
