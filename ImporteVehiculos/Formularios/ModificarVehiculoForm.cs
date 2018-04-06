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
    public partial class ModificarVehiculoForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool fillCombo = false;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public ModificarVehiculoForm()
        {
            InitializeComponent();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            ActualizarVehiculo();
        }

        public void ActualizarVehiculo()
        {
            string[] valores = { propietario_cb.Text, vin_txt.Text, color_txt.Text, nota_txt.Text, ubicacion_txt.Text };
            string[] numeros = {"0.00"};
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio, Ganancia y Año solo permiten números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdVehiculo = Program.GidVehiculo;
                P.Nota = nota_txt.Text;
                P.IdPropietario = Convert.ToInt32(propietario_cb.SelectedValue);
                P.Vin = vin_txt.Text;
               
                P.Color = color_txt.Text;
                P.Ubicacion = ubicacion_txt.Text;
                P.ActoVenta = acto_venta_chbox.Checked;
                P.CedulaVendedor = cedula_chbox.Checked;
                P.MatriculaOriginal = mat_chbox.Checked;

               
                string respuesta = P.ActualizarVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Vehículo fue Modificado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Vehículo no pudo ser Modificado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ModificarVehiculoForm_Load(object sender, EventArgs e)
        {
            

            LLenarPropietarioCb();
            ObtenerDetallesVehiculo();
        }



        public void LLenarPropietarioCb()
        {
            propietario_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerPropietarios();
            propietario_cb.DataSource = dt;
            propietario_cb.DisplayMember = "PROPIETARIO";
            propietario_cb.ValueMember = "ID";
            propietario_cb.SelectedIndex = -1;


        }

        public void ObtenerDetallesVehiculo()
        {
            DataTable dt = new DataTable();

            P.Id = Program.GidVehiculo;
            dt = P.ObtenerVehiculoEspecifico();
            vin_txt.Text = dt.Rows[0]["VIN"].ToString();
            color_txt.Text = dt.Rows[0]["COLOR"].ToString();
            nota_txt.Text = dt.Rows[0]["DETALLES"].ToString();
            propietario_cb.Text = dt.Rows[0]["PROPIETARIO"].ToString();
            ubicacion_txt.Text = dt.Rows[0]["UBICACION"].ToString();
            mat_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["MATRICULA ORIGINAL"]);
            cedula_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["CEDULA VENDEDOR"]);
            acto_venta_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["ACTO VENTA"]);
            nombreV_lbl.Text = dt.Rows[0]["FABRICANTE"].ToString() + " " + dt.Rows[0]["MODELO"].ToString() + " " + dt.Rows[0]["AÑO"].ToString();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
