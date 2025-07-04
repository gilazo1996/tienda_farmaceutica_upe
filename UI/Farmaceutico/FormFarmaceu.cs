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
    public partial class FormFarmaceu : Form
    {
        public FormFarmaceu()
        {
            InitializeComponent();
        }

        private void buscarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarFarmaco frmBuscarFarmaco = new FrmBuscarFarmaco();
            frmBuscarFarmaco.ShowDialog();
        }
    }
}
