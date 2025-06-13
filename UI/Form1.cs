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
using System.Configuration;

namespace UI
{
    public partial class formInicio : Form
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        public formInicio()
        {
            InitializeComponent();
            
        }

        private void formInicio_Load(object sender, EventArgs e)
        { 
        }


        private void tboxIngreseUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxIngresePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = tboxIngreseUsuario.Text.Trim();
            string password = tboxIngresePass.Text;

            string tipoUsuario = usuarioBLL.ObtenerTipoUsuario(usuario, password);

            if (tipoUsuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipoUsuario == "vendedor@gmail.com")
            {
                FormVendedor formVendedor = new FormVendedor();
                formVendedor.Show();
                this.Hide();
            }
            else if (tipoUsuario == "gerente@gmail.com")
            {
                FormGerente formGerente = new FormGerente();
                formGerente.Show();
                this.Hide();
            }
            else if (tipoUsuario == "administrador@gmail.com")
            {
                FormAdmin formAdmin= new FormAdmin();
                formAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tipo de usuario no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
