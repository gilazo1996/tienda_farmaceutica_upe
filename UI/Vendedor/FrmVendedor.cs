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
    public partial class FrmVendedor : Form
    {
        public FrmVendedor(BE.Usuario BEVendedor)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGenerarVenta formGenerarVenta = new FormGenerarVenta();
            formGenerarVenta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIniciarSesion frmIniciarSesion = new FrmIniciarSesion();
            frmIniciarSesion.Show();
            this.Close(); 
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
