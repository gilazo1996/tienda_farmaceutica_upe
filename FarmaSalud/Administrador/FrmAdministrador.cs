using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaSalud
{
    public partial class FrmAdministrador : Form
    {
        private BE.Usuario admin = null;
        private BLL.Administrador BLLAdmin = new BLL.Administrador();

        public FrmAdministrador(BE.Usuario BEUsuario)
        {
            InitializeComponent();

            admin = BEUsuario;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¡Bienvenido/a {admin.Apellido} {admin.Nombre}!");
            tstboxBienvenida.Text = sb.ToString();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = tboxBuscarNombreUsuario.Text.Trim();

                if(nombreUsuario == "")
                {
                    throw new Exception("Debe ingresar el nombre de usuario.");
                }

                BE.Usuario BEUsuario = BLLAdmin.BuscarUsuario(nombreUsuario);

                DeshabilitarCampos();

                tboxNombre.Text = BEUsuario.Nombre;
                tboxApellido.Text = BEUsuario.Apellido;
                tboxNombreUsuario.Text = BEUsuario.NombreUsuario;
                tboxContraseña.Text = BEUsuario.Contraseña;
                tboxCUIL.Text = BEUsuario.Cuil;
                tboxEmail.Text = BEUsuario.Email;
                tboxTelefono.Text = BEUsuario.Teléfono;
                cboxRol.Text = BEUsuario.Rol.ToString();

                btnEditarUsuario.Visible = true;
                btnEliminarUsuario.Visible = true;
                btnCambiarRol.Visible = true;
                btnLimpiarCampos.Visible = true;
                btnAgregarUsuario.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnVisualizarListaUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                List<BE.Usuario> listaUsuarios = new List<BE.Usuario>();

                listaUsuarios = BLLAdmin.ListarUsuarios();

                dgvUsuarios.Columns.Clear();
                dgvUsuarios.DataSource = listaUsuarios;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void FrmAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmIniciarSesion frmIniciarSesion = new FrmIniciarSesion();

            frmIniciarSesion.Show();
        }

        private void tsmiCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarUsuario.PerformClick();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            btnEditarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            btnLimpiarCampos.Visible = false;
            btnCambiarRol.Visible = false;
            btnAgregarUsuario.Visible = true;
        }

        private void LimpiarCampos()
        {
            tboxBuscarNombreUsuario.Text = "";
            tboxNombre.Text = "";
            tboxApellido.Text = "";
            tboxNombreUsuario.Text = "";
            tboxContraseña.Text = "";
            tboxCUIL.Text = "";
            tboxEmail.Text = "";
            tboxTelefono.Text = "";
            cboxRol.ResetText();
        }

        private void DeshabilitarCampos()
        {
            tboxNombre.Enabled = false;
            tboxApellido.Enabled = false;
            tboxNombreUsuario.Enabled = false;
            tboxContraseña.Enabled = false;
            tboxCUIL.Enabled = false;
            tboxEmail.Enabled = false;
            tboxTelefono.Enabled = false;
            cboxRol.Enabled = false;
        }

        private void HabilitarCampos()
        {
            tboxNombre.Enabled = true;
            tboxApellido.Enabled = true;
            tboxNombreUsuario.Enabled = true;
            tboxContraseña.Enabled = true;
            tboxCUIL.Enabled = true;
            tboxEmail.Enabled = true;
            tboxTelefono.Enabled = true;
            cboxRol.Enabled = true;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            cboxRol.Enabled = false;

            btnConfirmarCambios.Visible = true;
            btnCancelarCambios.Visible = true;
        }
    }
}
