using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaSalud.Gerente
{
    public partial class FrmGerente : Form
    {
        private BE.Usuario gerente;
        private BLL.Gerente BLLGerente = new BLL.Gerente();

        public FrmGerente(BE.Usuario BEUsuario)
        {
            InitializeComponent();

            gerente = new BE.Gerente();

            gerente = BEUsuario;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¡Bienvenido/a {gerente.Apellido} {gerente.Nombre}!\n");
            lblBienvenida.Text = sb.ToString();

            tsmiSesion.Text = gerente.NombreUsuario;
        }

        private void tsmiVisualizarVentas_Click(object sender, EventArgs e)
        {
            pnlBienvenida.Visible = false;
            pnlVisualizarSolicitudes.Visible = false;
            pnlVisualizarVentas.Visible = true;

            try
            {
                List<Factura> listaFacturas = new List<Factura>();

                listaFacturas = BLLGerente.ListarFacturas();

                cargarFacturas(listaFacturas);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarFacturas(List<Factura> listaFacturas)
        {
            StringBuilder vendedor = new StringBuilder();

            if (pnlVisualizarVentas.Visible)
            {
                dgvFacturas.Columns.Clear();
                dgvFacturas.Rows.Clear();

                dgvFacturas.Columns.Add("Id factura", "Id factura");
                dgvFacturas.Columns.Add("Número de factura", "Número de factura");
                dgvFacturas.Columns.Add("Fecha de emisión", "Fecha de emisión");
                dgvFacturas.Columns.Add("Total", "Total");
                dgvFacturas.Columns.Add("Método de pago", "Método de pago");
                dgvFacturas.Columns.Add("Vendedor", "Vendedor");
                dgvFacturas.Columns.Add("CUIL vendedor", "CUIL vendedor");

                foreach (BE.Factura factura in listaFacturas)
                {
                    vendedor.Clear();
                    vendedor.Append($"{factura.Vendedor.Nombre} {factura.Vendedor.Apellido}");
                    dgvFacturas.Rows.Add(
                        factura.IdFactura,
                        factura.NroFactura,
                        factura.FechaEmision,
                        factura.Total,
                        factura.MetodoDePago,
                        vendedor, 
                        factura.Vendedor.CUIL);
                }
            }
            else if(pnlGenerarReporte.Visible)
            {
                dgvFacturasEncontradas.Columns.Clear();
                dgvFacturasEncontradas.Rows.Clear();

                dgvFacturasEncontradas.Columns.Add("Id factura", "Id factura");
                dgvFacturasEncontradas.Columns.Add("Número de factura", "Número de factura");
                dgvFacturasEncontradas.Columns.Add("Fecha de emisión", "Fecha de emisión");
                dgvFacturasEncontradas.Columns.Add("Total", "Total");
                dgvFacturasEncontradas.Columns.Add("Método de pago", "Método de pago");
                dgvFacturasEncontradas.Columns.Add("Vendedor", "Vendedor");
                dgvFacturasEncontradas.Columns.Add("CUIL vendedor", "CUIL vendedor");

                foreach (BE.Factura factura in listaFacturas)
                {
                    vendedor.Clear();
                    vendedor.Append($"{factura.Vendedor.Nombre} {factura.Vendedor.Apellido}");
                    dgvFacturasEncontradas.Rows.Add(
                        factura.IdFactura,
                        factura.NroFactura,
                        factura.FechaEmision,
                        factura.Total,
                        factura.MetodoDePago,
                        vendedor,
                        factura.Vendedor.CUIL);
                }

                lblFacturasEncontradas.Visible = true;
                dgvFacturasEncontradas.Visible = true;
                btnGenerarReporte.Visible = true;
                btnCancelar.Visible = true;
            }
        }

        private void cargarDetallesFactura(List<DetalleFactura> listaDetalles)
        {
            dgvDetalleFactura.Columns.Clear();
            dgvDetalleFactura.Rows.Clear();

            dgvDetalleFactura.Columns.Add("Nombre fármaco", "Nombre fármaco");
            dgvDetalleFactura.Columns.Add("Código fármaco", "Código fármaco");
            dgvDetalleFactura.Columns.Add("Cantidad vendida", "Cantidad vendida");
            dgvDetalleFactura.Columns.Add("Subtotal", "Subtotal");

            foreach (BE.DetalleFactura detalle in listaDetalles)
            {
                dgvDetalleFactura.Rows.Add(
                    detalle.Farmaco.NombreComercial,
                    detalle.Farmaco.CodigoInventario,
                    detalle.Cantidad,
                    detalle.Subtotal);
            }
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvFacturas.SelectedRows.Count > 0)
                {
                    List<BE.DetalleFactura> listaDetalles = new List<BE.DetalleFactura>();
                    int idFactura = int.Parse(dgvFacturas.SelectedRows[0].Cells[0].FormattedValue.ToString());

                    listaDetalles = BLLGerente.ListarDetalleFactura(idFactura);

                    cargarDetallesFactura(listaDetalles);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmIniciarSesion frmIniciarSesion = new FrmIniciarSesion();

            frmIniciarSesion.Show();
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiVisualizarSolicitudes_Click(object sender, EventArgs e)
        {
            pnlBienvenida.Visible = false;
            pnlVisualizarVentas.Visible = false;
            pnlVisualizarSolicitudes.Visible = true;

            try
            {
                List<SolicitudVenta> listaSolicitudes = new List<SolicitudVenta>();

                listaSolicitudes = BLLGerente.ListarSolicitudes();

                cargarSolicitudes(listaSolicitudes);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvSolicitudes.SelectedRows.Count > 0)
                {
                    List<BE.DetalleSolicitudVenta> listaDetalles = new List<BE.DetalleSolicitudVenta>();
                    int idSolicitud = int.Parse(dgvSolicitudes.SelectedRows[0].Cells[0].FormattedValue.ToString());

                    if(dgvSolicitudes.SelectedRows[0].Cells[2].FormattedValue.ToString() == "Pendiente")
                    {
                        btnAceptarSolicitud.Visible = true;
                        btnRechazarSolicitud.Visible = true;
                    }
                    else
                    {
                        btnAceptarSolicitud.Visible = false;
                        btnRechazarSolicitud.Visible = false;
                    }

                        listaDetalles = BLLGerente.ListarDetalleSolicitud(idSolicitud);

                    cargarDetalleSolicitud(listaDetalles);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarSolicitudes(List<SolicitudVenta> listaSolicitudes)
        {
            StringBuilder vendedor = new StringBuilder();

            dgvSolicitudes.Columns.Clear();
            dgvSolicitudes.Rows.Clear();

            dgvSolicitudes.Columns.Add("Id solicitud", "Id solicitud");
            dgvSolicitudes.Columns.Add("Fecha de solicitud", "Fecha de solicitud");
            dgvSolicitudes.Columns.Add("Estado", "Estado");
            dgvSolicitudes.Columns.Add("Solicitante", "Solicitante");
            dgvSolicitudes.Columns.Add("CUIL solicitante", "CUIL solicitante");

            foreach (BE.SolicitudVenta solicitud in listaSolicitudes)
            {
                vendedor.Clear();
                vendedor.Append($"{solicitud.Solicitante.Nombre} {solicitud.Solicitante.Apellido}");
                dgvSolicitudes.Rows.Add(
                    solicitud.IdSolicitud,
                    solicitud.FechaSolicitud,
                    solicitud.Estado,   
                    vendedor,
                    solicitud.Solicitante.CUIL);
            }
        }

        private void cargarDetalleSolicitud(List<DetalleSolicitudVenta> listaDetalles)
        {
            dgvDetalleSolicitud.Columns.Clear();
            dgvDetalleSolicitud.Rows.Clear();

            dgvDetalleSolicitud.Columns.Add("Nombre fármaco", "Nombre fármaco");
            dgvDetalleSolicitud.Columns.Add("Código fármaco", "Código fármaco");
            dgvDetalleSolicitud.Columns.Add("Cantidad", "Cantidad");

            foreach (BE.DetalleSolicitudVenta detalle in listaDetalles)
            {
                dgvDetalleSolicitud.Rows.Add(
                    detalle.Farmaco.NombreComercial,
                    detalle.Farmaco.CodigoInventario,
                    detalle.Cantidad);
            }
        }

        private void tsmiGenerarReporte_Click(object sender, EventArgs e)
        {
            pnlBienvenida.Visible = false;
            pnlVisualizarVentas.Visible = false;
            pnlVisualizarSolicitudes.Visible = false;
            pnlGenerarReporte.Visible = true;
        }

        private void btnBuscarFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                List<BE.Factura> listaFacturas = new List<BE.Factura>();
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;

                listaFacturas = BLLGerente.BuscarFacturasPorFecha(fechaInicio, fechaFin);

                cargarFacturas(listaFacturas);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblFacturasEncontradas.Visible = false;
                dgvFacturasEncontradas.Visible = false;
                btnGenerarReporte.Visible = false;
                btnCancelar.Visible = false;
                dgvFacturasEncontradas.Columns.Clear();
                dgvFacturasEncontradas.Rows.Clear();
            }
        }
    }
}
