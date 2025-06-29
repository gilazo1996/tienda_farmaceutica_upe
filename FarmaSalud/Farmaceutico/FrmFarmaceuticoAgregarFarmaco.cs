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
    public partial class FrmFarmaceuticoAgregarFarmaco : Form
    {
        //private BE.Farmaco unFarmaco;
        private FrmFarmaceutico frmFarmaceutico;

        public FrmFarmaceuticoAgregarFarmaco(FrmFarmaceutico unFrmFarmaceutico)
        {
            InitializeComponent();
            frmFarmaceutico = unFrmFarmaceutico;
            //unFarmaco = BEFarmaco;
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            frmFarmaceutico.Show();
            this.Close();
        }

        private void FrmFarmaceuticoAgregarFarmaco_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFarmaceutico.Show();
        }
    }
}
