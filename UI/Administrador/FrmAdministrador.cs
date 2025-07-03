using BE;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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
        private BE.Usuario admin;
        private BE.Usuario usuario;
        private BLL.Administrador BLLAdmin = new BLL.Administrador();
        private StringBuilder texto = new StringBuilder();
        private StringBuilder titulo = new StringBuilder();
        private StringBuilder exito = new StringBuilder();
        private StringBuilder error = new StringBuilder();

        public FrmAdministrador(BE.Usuario BEUsuario)
        {
            InitializeComponent();

            admin = new Administrador();

            admin = BEUsuario;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¡Bienvenido/a {admin.Apellido} {admin.Nombre}!\n");
            lblBienvenida.Text = sb.ToString();

            tsmiSesion.Text = admin.NombreUsuario;
            DeshabilitarCampos();
            ResetearCamposBuscarUsuario();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = tboxBuscarNombreUsuario.Text.Trim();

                usuario = BLLAdmin.BuscarUsuario(nombreUsuario);

                tboxNombre.Text = usuario.Nombre;
                tboxApellido.Text = usuario.Apellido;
                tboxNombreUsuario.Text = usuario.NombreUsuario;
                tboxContraseña.Text = usuario.Contrasenia;
                tboxCUIL.Text = usuario.CUIL;
                tboxEmail.Text = usuario.Email;
                tboxTelefono.Text = usuario.Telefono;
                cboxRol.SelectedIndex = (int)usuario.Rol - 1;

                if (usuario is BE.Farmaceutico farmaceutico)
                    tboxMatricula.Text = farmaceutico.Matricula;

                btnEditarUsuario.Visible = true;
                btnEliminarUsuario.Visible = true;
                btnCambiarRol.Visible = true;

                DeshabilitarCampos();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            cboxRol.Enabled = false;

            btnBuscarUsuario.Visible = false;
            lblModificarUsuario.Text = "Editar usuario";
            lblModificarUsuario.Visible = true;
            btnCambiarRol.Visible = false;
            btnEditarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            btnConfirmarCambios.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                texto.Clear();
                titulo.Clear();
                exito.Clear();
                error.Clear();
                texto.Append($"¿Estás seguro que deseas editar los datos del usuario '{usuario.NombreUsuario}'?");
                titulo.Append("Confirmar edición");
                exito.Append("Usuario editado exitosamente.");
                error.Append($"Se produjo un error al editar los datos del usuario '{usuario.NombreUsuario}'.");

                usuario.Nombre = tboxNombre.Text.Trim();
                usuario.Apellido = tboxApellido.Text.Trim();
                usuario.NombreUsuario = tboxNombreUsuario.Text.Trim();
                usuario.Contrasenia = tboxContraseña.Text.Trim();
                usuario.CUIL = tboxCUIL.Text.Trim();
                usuario.Email = tboxEmail.Text.Trim();
                usuario.Telefono = tboxTelefono.Text.Trim();

                if (usuario is BE.Farmaceutico farmaceutico)
                    farmaceutico.Matricula = tboxMatricula.Text.Trim();

                DialogResult resultado = MessageBox.Show(
                    texto.ToString(),
                    titulo.ToString(),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    if (BLLAdmin.EditarUsuario(usuario))
                    {
                        MessageBox.Show(exito.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetearCamposBuscarUsuario();
                        DeshabilitarCampos();
                        lblModificarUsuario.Visible = false;
                    }
                    else
                        MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                texto.Clear();
                titulo.Clear();
                exito.Clear();
                error.Clear();
                texto.Append($"¿Estás seguro que deseas eliminar el usuario '{usuario.NombreUsuario}'?");
                titulo.Append("Confirmar eliminación");
                exito.Append("Usuario eliminado exitosamente.");
                error.Append($"Se produjo un error al eliminar el usuario '{usuario.NombreUsuario}'.");

                DialogResult resultado = MessageBox.Show(
                    texto.ToString(),
                    titulo.ToString(),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    if (BLLAdmin.EliminarUsuario(usuario))
                    {
                        MessageBox.Show(exito.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetearCamposBuscarUsuario();
                        DeshabilitarCampos();
                    }
                    else
                        MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
        }

        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            lblModificarUsuario.Text = "Cambiar rol del usuario";
            lblModificarUsuario.Visible = true;
            cboxRol.Enabled = true;
            btnCambiarRol.Visible = false;
            btnEditarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            tboxBuscarNombreUsuario.Enabled = false;
            btnBuscarUsuario.Visible = false;
            btnConfirmarRol.Visible = true;
            btnCancelar.Visible = true;
            tboxMatricula.Enabled = true;
        }

        private void btnConfirmarRol_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Farmaceutico farmaceutico = new Farmaceutico();
                bool retorno;
                texto.Clear();
                titulo.Clear();
                exito.Clear();
                error.Clear();

                texto.Append($"¿Estás seguro que deseas cambiar el rol del usuario '{usuario.NombreUsuario}'?");
                titulo.Append("Confirmar cambio de rol");
                exito.Append("Rol cambiado exitosamente.");
                error.Append($"Se produjo un error al modificar el rol del usuario '{usuario.NombreUsuario}'.");

                if (cboxRol.SelectedIndex == 1)
                {
                    farmaceutico.IdUsuario = usuario.IdUsuario;
                    farmaceutico.Matricula = tboxMatricula.Text;
                }
                else
                    usuario.Rol = (BE.Usuario.RolUsuario)cboxRol.SelectedIndex + 1;

                DialogResult resultado = MessageBox.Show(
                    texto.ToString(),
                    titulo.ToString(),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    if (cboxRol.SelectedIndex != 1)
                        retorno = BLLAdmin.CambiarRolUsuario(usuario);
                    else
                        retorno = BLLAdmin.CambiarRolUsuario(farmaceutico);

                    if (retorno)
                    {
                        MessageBox.Show(exito.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetearCamposBuscarUsuario();
                        DeshabilitarCampos();
                    }
                    else
                        MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally{ }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try{
                texto.Clear();
                titulo.Clear();
                texto.Append("¿Estás seguro que deseas cancelar los cambios?");
                titulo.Append("Confirmar cancelación");

                DialogResult resultado = MessageBox.Show(
                    texto.ToString(),
                    titulo.ToString(),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    ResetearCamposBuscarUsuario();
                    DeshabilitarCampos();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally{ }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                texto.Clear();
                titulo.Clear();
                exito.Clear();
                error.Clear();
                texto.Append($"¿Estás seguro que deseas agregar el usuario '{tboxAgregarNombreUsuario.Text}'?");
                titulo.Append("Agregar usuario");
                exito.Append("Usuario agregado exitosamente.");
                error.Append($"Se produjo un error al agregar el usuario '{tboxAgregarNombreUsuario.Text}'.");

                DialogResult resultado = MessageBox.Show(
                    texto.ToString(),
                    titulo.ToString(),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (cboxAgregarRol.Text == "Administrador")
                    usuario = new BE.Administrador();
                else if (cboxAgregarRol.Text == "Farmaceutico")
                {
                    usuario = new BE.Farmaceutico();
                    ((BE.Farmaceutico)usuario).Matricula = tboxAgregarMatricula.Text;
                }
                else if (cboxAgregarRol.Text == "Gerente")
                    usuario = new BE.Gerente();
                else if (cboxAgregarRol.Text == "Vendedor")
                    usuario = new BE.Vendedor();
                else
                    throw new Exception("Debe ingresar el rol del usuario.");

                usuario.Nombre = tboxAgregarNombre.Text;
                usuario.Apellido = tboxAgregarApellido.Text;
                usuario.NombreUsuario = tboxAgregarNombreUsuario.Text;
                usuario.Contrasenia = BLL.Seguridad.HashearContrasenia(tboxAgregarContraseña.Text);
                usuario.CUIL = tboxAgregarCUIL.Text;
                usuario.Email = tboxAgregarEmail.Text;
                usuario.Telefono = tboxAgregarTelefono.Text;

                if (resultado == DialogResult.Yes)
                {
                    if (BLLAdmin.AgregarUsuario(usuario))
                    {
                        MessageBox.Show(exito.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetearCamposAgregarUsuario();
                        tboxAgregarNombre.Select();
                    }
                    else
                        MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
        }

        private void btnVisualizarListaUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                List<BE.Usuario> listaUsuarios = new List<BE.Usuario>();

                listaUsuarios = BLLAdmin.ListarUsuarios();

                dgvUsuarios.Columns.Clear();
                dgvUsuarios.Rows.Clear();
                dgvUsuarios.Columns.Add("Id Usuario", "Id Usuario");
                dgvUsuarios.Columns.Add("Nombre", "Nombre");
                dgvUsuarios.Columns.Add("Apellido", "Apellido");
                dgvUsuarios.Columns.Add("Nombre de Usuario", "Nombre de Usuario");
                dgvUsuarios.Columns.Add("Contraseña", "Contraseña");
                dgvUsuarios.Columns.Add("CUIL", "CUIL");
                dgvUsuarios.Columns.Add("Email", "Email");
                dgvUsuarios.Columns.Add("Telefono", "Telefono");
                dgvUsuarios.Columns.Add("Rol", "Rol");
                dgvUsuarios.Columns.Add("Matrícula", "Matrícula");
                
                foreach (BE.Usuario usuario in listaUsuarios)
                {
                    if(usuario is BE.Farmaceutico farmaceutico)
                        dgvUsuarios.Rows.Add(
                            usuario.IdUsuario, 
                            usuario.Nombre, 
                            usuario.Apellido, 
                            usuario.NombreUsuario, 
                            usuario.Contrasenia, 
                            usuario.CUIL, 
                            usuario.Email, 
                            usuario.Telefono, 
                            usuario.Rol.ToString(),
                            farmaceutico.Matricula);
                    else
                        dgvUsuarios.Rows.Add(
                            usuario.IdUsuario,
                            usuario.Nombre,
                            usuario.Apellido,
                            usuario.NombreUsuario,
                            usuario.Contrasenia,
                            usuario.CUIL,
                            usuario.Email,
                            usuario.Telefono,
                            usuario.Rol.ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboxAgregarRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxAgregarRol.SelectedIndex == 1)
            {
                lblAgregarMatricula.Visible = true;
                tboxAgregarMatricula.Text = "";
                tboxAgregarMatricula.Visible = true;
            }
            else
            {
                lblAgregarMatricula.Visible = false;
                tboxAgregarMatricula.Visible = false;
            }

        }

        private void cboxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxRol.SelectedIndex == 1)
            {
                lblMatricula.Visible = true;
                tboxMatricula.Visible = true;
            }
            else
            {
                lblMatricula.Visible = false;
                tboxMatricula.Visible = false;
            }
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
            tboxMatricula.Enabled = false;
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
            tboxMatricula.Enabled= true;
        }

        private void ResetearCamposBuscarUsuario()
        {
            tboxBuscarNombreUsuario.Text = "";
            tboxNombre.Text = "";
            tboxApellido.Text = "";
            tboxNombreUsuario.Text = "";
            tboxContraseña.Text = "";
            tboxCUIL.Text = "";
            tboxEmail.Text = "";
            tboxTelefono.Text = "";
            cboxRol.SelectedIndex = 0;
            tboxMatricula.Text = "";
            lblModificarUsuario.Text = "";
            lblModificarUsuario.Visible = false;
            btnEditarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
            btnCambiarRol.Visible = false;
            btnConfirmarRol.Visible = false;
            btnConfirmarCambios.Visible = false;
            btnCancelar.Visible = false;
            tboxBuscarNombreUsuario.Enabled = true;
            btnBuscarUsuario.Visible = true;
        }

        private void ResetearCamposAgregarUsuario()
        {
            tboxAgregarNombre.Text = "";
            tboxAgregarApellido.Text = "";
            tboxAgregarNombreUsuario.Text = "";
            tboxAgregarContraseña.Text = "";
            tboxAgregarCUIL.Text = "";
            tboxAgregarEmail.Text = "";
            tboxAgregarTelefono.Text = "";
            cboxAgregarRol.SelectedIndex = 0;
            tboxMatricula.Text = "";
        }

        private void tsmiAgregarUsuario_Click(object sender, EventArgs e)
        {
            ResetearCamposAgregarUsuario();
            pnlBienvenida.Visible = false;
            pnlBuscarUsuario.Visible = false;
            pnlVisualizarListaDeUsuarios.Visible = false;
            pnlAgregarUsuario.Visible = true;
            this.Text = "Administrador - Agregar usuario";
        }

        private void tsmiBuscarUsuario_Click(object sender, EventArgs e)
        {
            ResetearCamposBuscarUsuario();
            DeshabilitarCampos();
            pnlBienvenida.Visible = false;
            pnlVisualizarListaDeUsuarios.Visible = false;
            pnlAgregarUsuario.Visible = false;
            pnlBuscarUsuario.Visible = true;
            this.Text = "Administrador - Buscar usuario";

        }

        private void tsmiVisualizarListaUsuarios_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Rows.Clear();
            pnlBienvenida.Visible = false;
            pnlBuscarUsuario.Visible = false;
            pnlAgregarUsuario.Visible = false;
            pnlVisualizarListaDeUsuarios.Visible = true;
            this.Text = "Administrador - Visualizar usuarios";
        }

        private void tboxNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarUsuario.PerformClick();
            }
        }

        private void FrmAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmIniciarSesion frmIniciarSesion = new FrmIniciarSesion();

            frmIniciarSesion.Show();
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
