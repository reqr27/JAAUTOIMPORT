using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImporteVehiculos.Classes;

namespace ImporteVehiculos.Formularios
{
    public partial class VenderForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        double precioVentaRD = 0;
        double precioVentaUSD = 0;
        public VenderForm()
        {
            InitializeComponent();
        }

        public void clearFields()
        {
            LLenarVehiculosCb();
            costoRD_txt.Text = "";
            chasis_txt.Text = "";
            precio_txt.Text = "";
            cliente_cb.Text = "";
            pago_txt.Text = "";
            tipoPago_cb.SelectedIndex = 0;
            nota_txt.Text = "";
            precioVentaRd_lbl.Text = "0.00";
            precioVentaUSD_lbl.Text = "0.00";
            pagos_dtg.Rows.Clear();
            restante_RD_lbl.Text = "0.00";
            restante_USD_lbl.Text = "0.00";
            totalRD_lbl.Text = "0.00";
            totalRD_lbl.Text = "0.00";
            
        }
       
        private void VenderForm_Load(object sender, EventArgs e)
        {
            FieldStatus(false);
            CalcularTotal();
            LlenarDtgClientes();
            tipoPago_cb.SelectedIndex = -1;
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text +" " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            precioVentaRd_lbl.Text = precioVentaRD.ToString("N2");
            precioVentaUSD_lbl.Text = precioVentaUSD.ToString("N2");
            LLenarVehiculosCb();
            LLenarTipoPagoCb();
            Permisos();
        }
        public void Permisos()
        {

            bool permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                tasa_lbl.Enabled = false;
            }
        }
        public void LlenarDtgClientes()
        {
            DataTable dt = new DataTable();
            dt = P.ObtenerClientesActivos();
            cliente_cb.DataSource = null;

            cliente_cb.DataSource = dt;
            cliente_cb.DisplayMember = "CLIENTE";
            cliente_cb.ValueMember = "ID";
            cliente_cb.SelectedIndex = -1;
           

        }

        public void LLenarTipoPagoCb()
        {
            tipoPago_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTiposPagos();
            tipoPago_cb.DataSource = dt;
            tipoPago_cb.DisplayMember = "TIPOPAGO";
            tipoPago_cb.ValueMember = "ID";
            tipoPago_cb.SelectedIndex = 0;


        }

        public void LLenarVehiculosCb()
        {
            vehiculos_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerVehiculosParaFacturar();
            vehiculos_cb.DataSource = dt;
            vehiculos_cb.DisplayMember = "VEHICULO";
            vehiculos_cb.ValueMember = "ID";
            vehiculos_cb.SelectedIndex = -1;


        }

        public void CambiarPago()
        {
            if (rdDinero_radiobtn.Checked)
            {
                pago_txt.Text = precioVentaRD.ToString("N2");
            }
            else
            {
                pago_txt.Text = precioVentaUSD.ToString("N2");
            }
           
        }

        private void rdDinero_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CambiarPago();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (pagos_dtg.Rows.Count > 0)
            {
                if (Convert.ToDouble(restante_RD_lbl.Text) == 0 || Convert.ToDouble(restante_USD_lbl.Text) == 0)
                {
                    VenderVehiculo();
                }
                else
                {
                    MessageBox.Show("El monto restante debe ser igual a cero", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Agregar Metodo de Pago", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
        }

        public void VenderVehiculo()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            int error = 0;
            string[] valores = {cliente_cb.Text };
            string msj = GF.ValidarCampoString(valores);
            
            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pagos_dtg.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregarse algún tipo de pago con un monto", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in pagos_dtg.Rows)
                {
                    P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                    P.Fecha = fecha_dtp.Value;
                    P.Id = Convert.ToInt32(cliente_cb.SelectedValue);
                    P.Descripcion = row.Cells[3].Value.ToString();
                    P.IdTipoPago = Convert.ToInt32(row.Cells[5].Value);
                    P.PrecioRD = Convert.ToDouble(row.Cells[1].Value); // pago rd
                    P.PrecioUSD = Convert.ToDouble(row.Cells[2].Value); // pago usd
                    P.PrecioVentaRD = precioVentaRD;
                    P.PrecioVentaUSD = precioVentaUSD;
                    
                    string respuesta = P.VenderVehiculo();
                    if (respuesta != "1")
                    {
                        error++;
                        
                    }
                }
                if(error == 0)
                {
                    
                    GenerarFactura();
                    clearFields();

                }
                else
                {
                    P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                    P.BorrarVentaYDetallePagoVehiculo();
                    MessageBox.Show("No se pudo facturar el vehículo", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void tasa_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DolaresForm form = new DolaresForm();
            form.ShowDialog();
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = "";
            tasa_lbl.Text = "1.00 $USD = " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2") + "$RD";
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            string[] valores = { tipoPago_cb.Text };
            string[] numeros = { pago_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Seleccione Tipo de Pago", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Campo Monto solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AgregarPagosDtg();
            }
        }

        public void AgregarPagosDtg()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            bool add = true;
            double cantidadAgregar;
            double precioTotal;
            if (rdDinero_radiobtn.Checked)
            {
                cantidadAgregar = Convert.ToDouble(pago_txt.Text);
                double totalAgregado = Convert.ToDouble(totalRD_lbl.Text);
                precioTotal = Convert.ToDouble(precioVentaRd_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {

                    foreach (DataGridViewRow row1 in pagos_dtg.Rows)
                    {
                        if(row1.Cells[0].Value.ToString() == tipoPago_cb.Text)
                        {
                            row1.Cells[1].Value = cantidadAgregar + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {
                        pagos_dtg.Rows.Add();

                        int row = pagos_dtg.Rows.Count;
                        pagos_dtg.Rows[row - 1].Cells[0].Value = tipoPago_cb.Text;
                        pagos_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar;
                        pagos_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                        pagos_dtg.Rows[row - 1].Cells[3].Value = nota_txt.Text;

                        pagos_dtg.Rows[row - 1].Cells[5].Value = tipoPago_cb.SelectedValue;
                    }
                   
                    CalcularTotal();
                    pago_txt.Text = "";
                    nota_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del Vehículo", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                cantidadAgregar = Convert.ToDouble(pago_txt.Text);
                double totalAgregado = Convert.ToDouble(totalUSD_lbl.Text);
                precioTotal = Convert.ToDouble(precioVentaUSD_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {
                    foreach (DataGridViewRow row1 in pagos_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPago_cb.Text)
                        {
                            row1.Cells[1].Value = (cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {

                        pagos_dtg.Rows.Add();
                        int row = pagos_dtg.Rows.Count;
                        pagos_dtg.Rows[row - 1].Cells[0].Value = tipoPago_cb.Text;
                        pagos_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"]); 
                        pagos_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar;
                        pagos_dtg.Rows[row - 1].Cells[3].Value = nota_txt.Text;

                        pagos_dtg.Rows[row - 1].Cells[5].Value = tipoPago_cb.SelectedValue;
                        
                    }
                    CalcularTotal();
                    pago_txt.Text = "";
                    nota_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del Vehículo", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CalcularTotal()
        {
            double totalRD = 0;
            double totalUSD = 0;
            if (pagos_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in pagos_dtg.Rows)
                {
                    totalRD += Convert.ToDouble(row.Cells[1].Value);
                    totalUSD += Convert.ToDouble(row.Cells[2].Value);


                }
                totalRD_lbl.Text = totalRD.ToString("N2");
                totalUSD_lbl.Text = totalUSD.ToString("N2");


                
            }
            else
            {
                totalRD_lbl.Text = "0.00";
                totalUSD_lbl.Text = "0.00";
                
            }

            restante_RD_lbl.Text = (precioVentaRD - Convert.ToDouble(totalRD_lbl.Text)).ToString("N2");
            restante_USD_lbl.Text = (precioVentaUSD - Convert.ToDouble(totalUSD_lbl.Text)).ToString("N2");
        }

        public void addDeleteButton()
        {
            //var deleteButton = new DataGridViewButtonColumn();
            //deleteButton.Name = "dataGridViewDeleteButton";
            //deleteButton.HeaderText = "ELIMINAR";
            
            ////deleteButton.UseColumnTextForButtonValue = true;
            //this.pagos_dtg.Columns.Add(deleteButton);

        }

        private void pagos_dtg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == pagos_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == pagos_dtg.Columns["dataGridViewDeleteButton"].Index)
            {
                var image = Properties.Resources.deshabilitado1; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private void pagos_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == pagos_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == pagos_dtg.Columns["dataGridViewDeleteButton"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                pagos_dtg.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

  

        private void vehiculos_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(vehiculos_cb.Text != "")
            {
                int idVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                P.Id = idVehiculo;
                DataTable dt = new DataTable();
                dt = P.ObtenerCostoChasisVehiculo();
                costoRD_txt.Text = Convert.ToDouble(dt.Rows[0]["COSTORD"]).ToString("N2");
                costoUSD_txt.Text = Convert.ToDouble(dt.Rows[0]["COSTOUSD"]).ToString("N2");
                chasis_txt.Text = dt.Rows[0]["VIN"].ToString();
            }
            else
            {
                costoRD_txt.Text = "";
                costoUSD_txt.Text = "";
                chasis_txt.Text = "";
            }
            
        }

        private void precio_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(precio_txt.Text);
               


            }
            catch
            {

                if (precio_txt.Text.Length > 1)
                {
                    precio_txt.Text = precio_txt.Text.Remove(precio_txt.Text.Length - 1);
                    precio_txt.SelectionStart = precio_txt.Text.Length;
                }
                else
                {
                    precio_txt.Text = "";
                }

            }

            if (precio_txt.Text.Length > 0)
            {
                CalcularPrecio();
                FieldStatus(true);
                if (Convert.ToDouble(restante_RD_lbl.Text) < 0 || Convert.ToDouble(restante_USD_lbl.Text) < 0)
                {
                    pagos_dtg.Rows.Clear();
                    CalcularTotal();
                    CalcularPrecio();

                }
            }
            else
            {
                FieldStatus(false);
                precioVentaRd_lbl.Text = "0.00";
                precioVentaUSD_lbl.Text = "0.00";
                pagos_dtg.Rows.Clear();
                restante_RD_lbl.Text = "0.00";
                restante_USD_lbl.Text = "0.00";
                totalRD_lbl.Text = "0.00";
                totalRD_lbl.Text = "0.00";
            }
        }

        public void CalcularPrecio()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            try
            {
                if (radioBtnRD_precio.Checked)
                {
                    precioVentaRD = Convert.ToDouble(precio_txt.Text);
                    precioVentaUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);

                }
                else if (radioBtnUSD_precio.Checked)
                {
                    precioVentaRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    precioVentaUSD = Convert.ToDouble(precio_txt.Text);


                }
                precioVentaRd_lbl.Text = precioVentaRD.ToString("N2");
                precioVentaUSD_lbl.Text = precioVentaUSD.ToString("N2");
                CalcularTotal();
            }
            catch
            {

            }
            
        }

        public void FieldStatus(bool estado)
        {
            if (estado)
            {
                tipoPago_cb.Enabled = true;
                pago_txt.Enabled = true;
                nota_txt.Enabled = true;
                agregar_btn.Enabled = true;
                rdDinero_radiobtn.Enabled = true;
                usdDinero_radiobtn.Enabled = true;
            }
            else
            {
                tipoPago_cb.Enabled = false;
                pago_txt.Enabled = false;
                nota_txt.Enabled = false;
                agregar_btn.Enabled = false;
                rdDinero_radiobtn.Enabled = false;
                usdDinero_radiobtn.Enabled = false;
            }
        }

        private void radioBtnRD_precio_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecio();
        }

        private void pago_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(pago_txt.Text);
                


            }
            catch
            {

                if (pago_txt.Text.Length > 1)
                {
                    pago_txt.Text = pago_txt.Text.Remove(pago_txt.Text.Length - 1);
                    pago_txt.SelectionStart = pago_txt.Text.Length;
                }
                else
                {
                    pago_txt.Text = "";
                }

            }
        }

        public void GenerarFactura()
        {
            int idVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
            
           
            Program.GidVehiculoRpt = idVehiculo;
            Program.Greporte = "Factura Venta Vehículo";
            ReportesForm form1 = new ReportesForm();
            form1.Show();
           
        }

        private void fecha_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (fecha_dtp.Value > DateTime.Now.Date)
            {
                fecha_dtp.Value = DateTime.Now.Date;
            }
        }
    }
}
