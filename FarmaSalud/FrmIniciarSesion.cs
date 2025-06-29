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
                string nombreUsuario = tboxUsuario.Text.Trim();   //Desde los textbox se toman los valores de User y Pass y se quitan espacios extremos con Trim
                string contraseña = tboxContraseña.Text.Trim();

                if(nombreUsuario == "" || contraseña == "")
                {
                    throw new Exception("Debe ingresar tanto el usuario como la contraseña.");
                }

                BLL.Usuario BLLUsuario = new BLL.Usuario();
                BE.Usuario BEUsuario = BLLUsuario.IniciarSesion(nombreUsuario, contraseña);

                if (BEUsuario.Rol == BE.Usuario.RolUsuario.Administrador)
                {
                    FrmAdministrador frmAdministrador = new FrmAdministrador(BEUsuario);
                    frmAdministrador.Show();
                    this.Hide();
                }
                if (BEUsuario.Rol == BE.Usuario.RolUsuario.Farmacéutico)
                {
                    FrmFarmaceutico frmFarmaceutico = new FrmFarmaceutico(BEUsuario);
                    frmFarmaceutico.Show();
                    this.Hide();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void FrmIniciarSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
            tboxUsuario.Select();
        }

        private void tboxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            DetectarEnter(e);
        }

        private void tboxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            DetectarEnter(e);
        }

        private void DetectarEnter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion.PerformClick();
            }
        }
    }
}
