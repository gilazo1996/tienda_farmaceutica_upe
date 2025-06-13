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
    public partial class FormVendedor : Form
    {
        public FormVendedor()
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
            formInicio login = new formInicio();
            login.Show();
            this.Close(); 
        }
    }
}
