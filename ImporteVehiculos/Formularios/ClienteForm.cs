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
    public partial class ClienteForm : Form
    {
        public bool evento = false;
        public int idEvento = 0;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            LlenarDtgClientes();
            resetCampos();
        }

        public void LlenarDtgClientes()
        {
            DataTable dt = new DataTable();
            cliente_dtg.DataSource = null;

            dt = P.ObtenerClientes();
            cliente_dtg.DataSource = dt;

        }

        public void resetCampos()
        {
            cancelarEditar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            cliente_txt.Text = "";
            rncCedula_txt.Text = "";
            telefono1_txt.Text = "";
            direccion_txt.Text = "";
            estadoCliente_chbox.Checked = true;
            guardarCliente_btn.Text = "Guardar";
            guardarCliente_btn.Image = Properties.Resources.disquete;
        }

        private void guardarCliente_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                RegistrarCliente();
            }
            else
            {
                ActualizarCliente();
            }
        }

        public void RegistrarCliente()
        {
            string[] valores = { cliente_txt.Text, rncCedula_txt.Text, direccion_txt.Text, telefono1_txt.Text};

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Campo Cliente y RNC/CEDULA son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Cliente = cliente_txt.Text;
                P.CedulaRNC = rncCedula_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.Estado = estadoCliente_chbox.Checked;
                P.Direccion = direccion_txt.Text;

                string respuesta = P.RegistrarCliente();
                if (respuesta == "1")
                {
                    MessageBox.Show("Cliente fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgClientes();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("CLiente ya se encuentra registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Cliente no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarCliente()
        {
            string[] valores = { cliente_txt.Text, rncCedula_txt.Text, telefono1_txt.Text, direccion_txt.Text};

            string msj = GF.ValidarCampoString(valores);
            if (msj != "OK")
            {
                MessageBox.Show("Campo Cliente y RNC/CEDULA son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Id = idEvento;
                P.Cliente = cliente_txt.Text;
                P.CedulaRNC = rncCedula_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.Estado = estadoCliente_chbox.Checked;
                P.Direccion = direccion_txt.Text;


                string respuesta = P.ActualizarCliente();
                if (respuesta == "1")
                {
                    MessageBox.Show("Cliente fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgClientes();
                }

                else
                {
                    MessageBox.Show("Cliente no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void cancelarEditar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void cliente_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelarEditar_btn.Enabled = true;
            evento = true;
            guardarCliente_btn.Text = "Actualizar";
            guardarCliente_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(cliente_dtg.CurrentRow.Cells[0].Value.ToString());
            cliente_txt.Text = cliente_dtg.CurrentRow.Cells[1].Value.ToString();
            rncCedula_txt.Text = cliente_dtg.CurrentRow.Cells[2].Value.ToString();
            direccion_txt.Text = cliente_dtg.CurrentRow.Cells[3].Value.ToString();
            telefono1_txt.Text = cliente_dtg.CurrentRow.Cells[4].Value.ToString();
            
            estadoCliente_chbox.Checked = Convert.ToBoolean(cliente_dtg.CurrentRow.Cells[5].Value);
        }
    }
}
