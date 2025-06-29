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
    public partial class FrmFarmaceutico : Form
    {
        private BE.Usuario farmaceutico = null;
        private BLL.Farmaceutico BLLFarmaceutico = new BLL.Farmaceutico();

        public FrmFarmaceutico(BE.Usuario BEUsuario)
        {
            InitializeComponent();

            farmaceutico = BEUsuario;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¡Bienvenido/a {farmaceutico.Nombre} {farmaceutico.Apellido}!");
            tstboxBienvenida.Text = sb.ToString();
        }

        private void tsmiCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFarmaceutico_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmIniciarSesion frmIniciarSesion = new FrmIniciarSesion();

            frmIniciarSesion.Show();
        }

        private void agregarFarmacoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFarmaceuticoAgregarFarmaco frmFarmaceuticoAgregarFarmaco = new FrmFarmaceuticoAgregarFarmaco(this);
            frmFarmaceuticoAgregarFarmaco.ShowDialog();
        }
    }
}
