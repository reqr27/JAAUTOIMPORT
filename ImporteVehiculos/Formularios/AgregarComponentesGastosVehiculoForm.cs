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
    public partial class AgregarComponentesGastosVehiculoForm : Form
    {
        bool ComboFill = false;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public AgregarComponentesGastosVehiculoForm()
        {
            InitializeComponent();
        }

        private void AgregarComponentesGastosVehiculoForm_Load(object sender, EventArgs e)
        {

            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            CargarVentana();
            Permisos();
        }

        public void CargarVentana()
        {
            if (Program.Gventana == "componentes")
            {
                descripcion_lbl.Text = "PIEZAS Y REPUESTOS:";
                LlenarComponenteCb();
            }
            else if (Program.Gventana == "reparacion")
            {
                descripcion_lbl.Text = "GASTOS REPARACION:";
                LlenarGastosReparacionCb();
                taller_cb.Visible = true;
                taller_lbl.Visible = true;
                agregarTaller_lnklbl.Visible = true;
                LlenarTallerCb();
            }

            else 
            {
                descripcion_lbl.Text = "OTROS GASTOS:";
                LlenarGastosAduanalesCb();
            }
        }

        public void LlenarComponenteCb()
        {
            descripcion_cb.DataSource = null;
            DataTable dt = new DataTable();
            P.IdVehiculo = Program.GidVehiculo;
            dt = P.ObtenerCompoentesVehiculoFabricanteModeloAño();
            descripcion_cb.DataSource = dt;
            descripcion_cb.DisplayMember = "COMPONENTES";
            descripcion_cb.ValueMember = "ID";
            descripcion_cb.SelectedIndex = -1;
            ComboFill = true;
        }

        public void LlenarGastosReparacionCb()
        {
            descripcion_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerGastosReparacionActivos();
            descripcion_cb.DataSource = dt;
            descripcion_cb.DisplayMember = "DESCRIPCION";
            descripcion_cb.ValueMember = "ID";
            descripcion_cb.SelectedIndex = -1;
            
        }

        public void LlenarGastosAduanalesCb()
        {
            descripcion_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerGastosAduanalesActivos();
            descripcion_cb.DataSource = dt;
            descripcion_cb.DisplayMember = "DESCRIPCION";
            descripcion_cb.ValueMember = "ID";
            descripcion_cb.SelectedIndex = -1;

        }

        public void LlenarTallerCb()
        {
            taller_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTalleresActivos();
            taller_cb.DataSource = dt;
            taller_cb.DisplayMember = "TALLER";
            taller_cb.ValueMember = "ID";
            taller_cb.SelectedIndex = -1;

        }

        public void GuardarGastosReparacion()
        {
            string[] valores = { descripcion_cb.Text};
            string[] numeros = { precio_txt.Text};
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdVehiculo = Program.GidVehiculo;
                P.Id = Convert.ToInt32(descripcion_cb.SelectedValue);
                P.IdTaller = Convert.ToInt32(taller_cb.SelectedValue);
                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                string respuesta = P.AsignarGastoReparacionVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Gasto Reparación fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Gasto Reparación ya existe para este vehículo!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    MessageBox.Show("Gasto Reparación no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void GuardarComponentes()
        {
            string[] valores = { descripcion_cb.Text };
            string[] numeros = { precio_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdVehiculo = Program.GidVehiculo;
                P.Id = Convert.ToInt32(descripcion_cb.SelectedValue);
               
                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                string respuesta = P.AsignarComponenteVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Componente fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Componente ya existe para este vehículo!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    MessageBox.Show("Componente no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void GuardarGastosAduanales()
        {
            string[] valores = { descripcion_cb.Text };
            string[] numeros = { precio_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdVehiculo = Program.GidVehiculo;
                P.Id = Convert.ToInt32(descripcion_cb.SelectedValue);

                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                string respuesta = P.AsignarGastoAduanalVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Gasto Aduanal fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Gasto Aduanal ya existe para este vehículo!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    MessageBox.Show("Gasto Aduanal no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            if(Program.Gventana == "componentes")
            {
                GuardarComponentes();
            }
            else if (Program.Gventana == "reparacion")
            {
                GuardarGastosReparacion();
            }
            else
            {
                GuardarGastosAduanales();
            }
            

        }
        public void LlenarPrecioTxt()
        {
            if (descripcion_cb.Text != "System.Data.DataRowView")
            {
                
                DataTable dt = new DataTable();
                P.Id = Convert.ToInt32(descripcion_cb.SelectedValue);
                dt = P.ObtenerPrecioCompoenteSeleccionado();
                if (rdDinero_radiobtn.Checked)
                {
                    precio_txt.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
                }
                else
                {
                    precio_txt.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
                }
            }
                
        }

        private void descripcion_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Program.Gventana == "componentes")
            {

                if (ComboFill)
                {
                    LlenarPrecioTxt();
                }
            }
        }



        private void rdDinero_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if(Program.Gventana == "componentes")
            {
                if (ComboFill)
                {
                    LlenarPrecioTxt();
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
            tasa_lbl.Text = "1.00 $USD = " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            
        }

        public void Permisos()
        {
            
            bool permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                tasa_lbl.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR TALLER");
            if (!permiso)
            {
                agregarTaller_lnklbl.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR GASTOS");
            if (!permiso)
            {
                nuevo_lnklbl.Enabled = false;
            }
        }

        private void nuevo_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComboFill = false;
            if(Program.Gventana == "componentes")
            {
                PiezasRepuestosForm form = new PiezasRepuestosForm();
                form.ShowDialog();
                
                LlenarComponenteCb();
            }
            else if(Program.Gventana == "reparacion")
            {
                GastosGeneralesForm form = new GastosGeneralesForm();
                form.ShowDialog();
                LlenarGastosReparacionCb();
                
            }
            else
            {
                GastosGeneralesForm form = new GastosGeneralesForm();
                form.ShowDialog();
                LlenarGastosAduanalesCb();
            }
        }

        private void agregarTaller_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ComboFill = false;
            TalleresForm form = new TalleresForm();
            form.ShowDialog();
            LlenarTallerCb();
        }
    }
}
