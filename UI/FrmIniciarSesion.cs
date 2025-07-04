using FarmaSalud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace FarmaSalud
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = tboxNombreUsuario.Text.Trim();
                string contrasenia = tboxContraseña.Text.Trim();

                BLL.Usuario BLLUsuario = new BLL.Usuario();
                BE.Usuario BEUsuario = BLLUsuario.IniciarSesion(nombreUsuario, contrasenia);

                if (BEUsuario.Rol == BE.Usuario.RolUsuario.Administrador)
                {
                    FrmAdministrador frmAdministrador = new FrmAdministrador(BEUsuario);
                    frmAdministrador.Show();
                    this.Hide();
                }
                else if (BEUsuario.Rol == BE.Usuario.RolUsuario.Farmaceutico)
                {
                    FormFarmaceu frmFarmaceutico = new FormFarmaceu();
                    frmFarmaceutico.Show();
                    this.Hide();
                }
                else if(BEUsuario.Rol == BE.Usuario.RolUsuario.Gerente)
                {
                    FrmGerente frmGerente = new FrmGerente(BEUsuario);
                    frmGerente.Show();
                    this.Hide();
                }
                else if (BEUsuario.Rol == BE.Usuario.RolUsuario.Vendedor)
                {
                    FrmVendedor frmVendedor = new FrmVendedor(BEUsuario);
                    frmVendedor.Show();
                    this.Hide();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
            tboxNombreUsuario.Select();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIniciarSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
