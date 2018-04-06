namespace ImporteVehiculos.Formularios
{
    partial class VenderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenderForm));
            this.usdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.rdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.pago_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cliente_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoPago_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha_dtp = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.restante_USD_lbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.totalUSD_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.restante_RD_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalRD_lbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.precioVentaUSD_lbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.precioVentaRd_lbl = new System.Windows.Forms.Label();
            this.nota_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.pagos_dtg = new System.Windows.Forms.DataGridView();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGOUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idtipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.vehiculos_cb = new System.Windows.Forms.ComboBox();
            this.chasis_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.precio_txt = new System.Windows.Forms.TextBox();
            this.radioBtnUSD_precio = new System.Windows.Forms.RadioButton();
            this.radioBtnRD_precio = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.costoRD_txt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.costoUSD_txt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tasa_lbl = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagos_dtg)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // usdDinero_radiobtn
            // 
            this.usdDinero_radiobtn.AutoSize = true;
            this.usdDinero_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdDinero_radiobtn.Location = new System.Drawing.Point(74, 3);
            this.usdDinero_radiobtn.Name = "usdDinero_radiobtn";
            this.usdDinero_radiobtn.Size = new System.Drawing.Size(57, 19);
            this.usdDinero_radiobtn.TabIndex = 36;
            this.usdDinero_radiobtn.Text = "USD$";
            this.usdDinero_radiobtn.UseVisualStyleBackColor = true;
            // 
            // rdDinero_radiobtn
            // 
            this.rdDinero_radiobtn.AutoSize = true;
            this.rdDinero_radiobtn.Checked = true;
            this.rdDinero_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDinero_radiobtn.Location = new System.Drawing.Point(3, 3);
            this.rdDinero_radiobtn.Name = "rdDinero_radiobtn";
            this.rdDinero_radiobtn.Size = new System.Drawing.Size(49, 19);
            this.rdDinero_radiobtn.TabIndex = 38;
            this.rdDinero_radiobtn.TabStop = true;
            this.rdDinero_radiobtn.Tag = "4";
            this.rdDinero_radiobtn.Text = "RD$";
            this.rdDinero_radiobtn.UseVisualStyleBackColor = true;
            this.rdDinero_radiobtn.CheckedChanged += new System.EventHandler(this.rdDinero_radiobtn_CheckedChanged);
            // 
            // pago_txt
            // 
            this.pago_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago_txt.Location = new System.Drawing.Point(597, 110);
            this.pago_txt.Name = "pago_txt";
            this.pago_txt.Size = new System.Drawing.Size(150, 20);
            this.pago_txt.TabIndex = 37;
            this.pago_txt.TextChanged += new System.EventHandler(this.pago_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "MONTO:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(19, 295);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 15);
            this.label.TabIndex = 34;
            this.label.Text = "CLIENTE:";
            // 
            // cliente_cb
            // 
            this.cliente_cb.DropDownHeight = 180;
            this.cliente_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cliente_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_cb.FormattingEnabled = true;
            this.cliente_cb.IntegralHeight = false;
            this.cliente_cb.Location = new System.Drawing.Point(142, 287);
            this.cliente_cb.Name = "cliente_cb";
            this.cliente_cb.Size = new System.Drawing.Size(196, 23);
            this.cliente_cb.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "FORMA PAGO: ";
            // 
            // tipoPago_cb
            // 
            this.tipoPago_cb.DropDownHeight = 180;
            this.tipoPago_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPago_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPago_cb.FormattingEnabled = true;
            this.tipoPago_cb.IntegralHeight = false;
            this.tipoPago_cb.Location = new System.Drawing.Point(633, 52);
            this.tipoPago_cb.Name = "tipoPago_cb";
            this.tipoPago_cb.Size = new System.Drawing.Size(246, 23);
            this.tipoPago_cb.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "FECHA DE VENTA:";
            // 
            // fecha_dtp
            // 
            this.fecha_dtp.CustomFormat = "dd/MM/yyyy";
            this.fecha_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_dtp.Location = new System.Drawing.Point(142, 339);
            this.fecha_dtp.Name = "fecha_dtp";
            this.fecha_dtp.Size = new System.Drawing.Size(91, 20);
            this.fecha_dtp.TabIndex = 43;
            this.fecha_dtp.ValueChanged += new System.EventHandler(this.fecha_dtp_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 48);
            this.panel3.TabIndex = 88;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(848, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 31;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(879, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 30;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(175, 24);
            this.label27.TabIndex = 28;
            this.label27.Text = "FACTURACION";
            // 
            // guardar_btn
            // 
            this.guardar_btn.FlatAppearance.BorderSize = 0;
            this.guardar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.guardar_btn.Image = global::ImporteVehiculos.Properties.Resources.vendido;
            this.guardar_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardar_btn.Location = new System.Drawing.Point(782, 3);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(123, 54);
            this.guardar_btn.TabIndex = 40;
            this.guardar_btn.Text = "Registrar Venta";
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.guardar_btn);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.restante_USD_lbl);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.totalUSD_lbl);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.restante_RD_lbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.totalRD_lbl);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.precioVentaUSD_lbl);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.precioVentaRd_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 117);
            this.panel1.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(596, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "_______________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(579, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 25);
            this.label10.TabIndex = 94;
            this.label10.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(190, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 25);
            this.label6.TabIndex = 93;
            this.label6.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label14.Location = new System.Drawing.Point(381, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 19);
            this.label14.TabIndex = 90;
            this.label14.Text = "RESTANTE($USD):";
            // 
            // restante_USD_lbl
            // 
            this.restante_USD_lbl.AutoSize = true;
            this.restante_USD_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restante_USD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.restante_USD_lbl.Location = new System.Drawing.Point(598, 89);
            this.restante_USD_lbl.Name = "restante_USD_lbl";
            this.restante_USD_lbl.Size = new System.Drawing.Size(29, 19);
            this.restante_USD_lbl.TabIndex = 91;
            this.restante_USD_lbl.Text = "pv";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label18.Location = new System.Drawing.Point(381, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 19);
            this.label18.TabIndex = 88;
            this.label18.Text = "PAGO($USD):";
            // 
            // totalUSD_lbl
            // 
            this.totalUSD_lbl.AutoSize = true;
            this.totalUSD_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUSD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.totalUSD_lbl.Location = new System.Drawing.Point(598, 44);
            this.totalUSD_lbl.Name = "totalUSD_lbl";
            this.totalUSD_lbl.Size = new System.Drawing.Size(29, 19);
            this.totalUSD_lbl.TabIndex = 89;
            this.totalUSD_lbl.Text = "pv";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(200, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "_______________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(7, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 19);
            this.label7.TabIndex = 85;
            this.label7.Text = "RESTANTE($RD):";
            // 
            // restante_RD_lbl
            // 
            this.restante_RD_lbl.AutoSize = true;
            this.restante_RD_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restante_RD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.restante_RD_lbl.Location = new System.Drawing.Point(207, 89);
            this.restante_RD_lbl.Name = "restante_RD_lbl";
            this.restante_RD_lbl.Size = new System.Drawing.Size(29, 19);
            this.restante_RD_lbl.TabIndex = 86;
            this.restante_RD_lbl.Text = "pv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 83;
            this.label5.Text = "PAGO($RD):";
            // 
            // totalRD_lbl
            // 
            this.totalRD_lbl.AutoSize = true;
            this.totalRD_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.totalRD_lbl.Location = new System.Drawing.Point(210, 44);
            this.totalRD_lbl.Name = "totalRD_lbl";
            this.totalRD_lbl.Size = new System.Drawing.Size(29, 19);
            this.totalRD_lbl.TabIndex = 84;
            this.totalRD_lbl.Text = "pv";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label16.Location = new System.Drawing.Point(7, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 19);
            this.label16.TabIndex = 79;
            this.label16.Text = "PRECIO VENTA($RD):";
            // 
            // precioVentaUSD_lbl
            // 
            this.precioVentaUSD_lbl.AutoSize = true;
            this.precioVentaUSD_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioVentaUSD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.precioVentaUSD_lbl.Location = new System.Drawing.Point(598, 14);
            this.precioVentaUSD_lbl.Name = "precioVentaUSD_lbl";
            this.precioVentaUSD_lbl.Size = new System.Drawing.Size(29, 19);
            this.precioVentaUSD_lbl.TabIndex = 82;
            this.precioVentaUSD_lbl.Text = "pv";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label15.Location = new System.Drawing.Point(381, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 19);
            this.label15.TabIndex = 80;
            this.label15.Text = "PRECIO VENTA($USD):";
            // 
            // precioVentaRd_lbl
            // 
            this.precioVentaRd_lbl.AutoSize = true;
            this.precioVentaRd_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioVentaRd_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.precioVentaRd_lbl.Location = new System.Drawing.Point(210, 14);
            this.precioVentaRd_lbl.Name = "precioVentaRd_lbl";
            this.precioVentaRd_lbl.Size = new System.Drawing.Size(29, 19);
            this.precioVentaRd_lbl.TabIndex = 81;
            this.precioVentaRd_lbl.Text = "pv";
            // 
            // nota_txt
            // 
            this.nota_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota_txt.Location = new System.Drawing.Point(535, 151);
            this.nota_txt.Multiline = true;
            this.nota_txt.Name = "nota_txt";
            this.nota_txt.Size = new System.Drawing.Size(256, 63);
            this.nota_txt.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(535, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 91;
            this.label9.Text = "NOTA PAGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 95;
            this.label3.Text = "LISTADO PAGOS";
            // 
            // agregar_btn
            // 
            this.agregar_btn.FlatAppearance.BorderSize = 0;
            this.agregar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.agregar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.agregar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_btn.Image = global::ImporteVehiculos.Properties.Resources.circulo_de_suma;
            this.agregar_btn.Location = new System.Drawing.Point(797, 170);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(58, 42);
            this.agregar_btn.TabIndex = 94;
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // pagos_dtg
            // 
            this.pagos_dtg.AllowUserToAddRows = false;
            this.pagos_dtg.AllowUserToDeleteRows = false;
            this.pagos_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.pagos_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.pagos_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagos_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoPago,
            this.PAGORD,
            this.PAGOUSD,
            this.detalles,
            this.dataGridViewDeleteButton,
            this.idtipoPago});
            this.pagos_dtg.Location = new System.Drawing.Point(535, 260);
            this.pagos_dtg.MultiSelect = false;
            this.pagos_dtg.Name = "pagos_dtg";
            this.pagos_dtg.ReadOnly = true;
            this.pagos_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pagos_dtg.Size = new System.Drawing.Size(344, 111);
            this.pagos_dtg.TabIndex = 106;
            this.pagos_dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pagos_dtg_CellClick);
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "Tipo de Pago";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.ReadOnly = true;
            this.TipoPago.Width = 88;
            // 
            // PAGORD
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.PAGORD.DefaultCellStyle = dataGridViewCellStyle1;
            this.PAGORD.HeaderText = "VALOR ($RD)";
            this.PAGORD.Name = "PAGORD";
            this.PAGORD.ReadOnly = true;
            this.PAGORD.Width = 91;
            // 
            // PAGOUSD
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.PAGOUSD.DefaultCellStyle = dataGridViewCellStyle2;
            this.PAGOUSD.HeaderText = "VALOR ($USD)";
            this.PAGOUSD.Name = "PAGOUSD";
            this.PAGOUSD.ReadOnly = true;
            this.PAGOUSD.Width = 97;
            // 
            // detalles
            // 
            this.detalles.HeaderText = "DETALLES";
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Width = 87;
            // 
            // dataGridViewDeleteButton
            // 
            this.dataGridViewDeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewDeleteButton.HeaderText = "ELIMINAR";
            this.dataGridViewDeleteButton.Name = "dataGridViewDeleteButton";
            this.dataGridViewDeleteButton.ReadOnly = true;
            this.dataGridViewDeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewDeleteButton.Width = 83;
            // 
            // idtipoPago
            // 
            this.idtipoPago.HeaderText = "idTipoPAgo";
            this.idtipoPago.Name = "idtipoPago";
            this.idtipoPago.ReadOnly = true;
            this.idtipoPago.Visible = false;
            this.idtipoPago.Width = 96;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 108;
            this.label12.Text = "VEHICULO: ";
            // 
            // vehiculos_cb
            // 
            this.vehiculos_cb.DropDownHeight = 180;
            this.vehiculos_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehiculos_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiculos_cb.FormattingEnabled = true;
            this.vehiculos_cb.IntegralHeight = false;
            this.vehiculos_cb.Location = new System.Drawing.Point(143, 66);
            this.vehiculos_cb.Name = "vehiculos_cb";
            this.vehiculos_cb.Size = new System.Drawing.Size(271, 23);
            this.vehiculos_cb.TabIndex = 107;
            this.vehiculos_cb.SelectionChangeCommitted += new System.EventHandler(this.vehiculos_cb_SelectionChangeCommitted);
            // 
            // chasis_txt
            // 
            this.chasis_txt.Enabled = false;
            this.chasis_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chasis_txt.Location = new System.Drawing.Point(143, 110);
            this.chasis_txt.Name = "chasis_txt";
            this.chasis_txt.Size = new System.Drawing.Size(271, 20);
            this.chasis_txt.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 15);
            this.label13.TabIndex = 109;
            this.label13.Text = "CHASIS:";
            // 
            // precio_txt
            // 
            this.precio_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_txt.Location = new System.Drawing.Point(142, 240);
            this.precio_txt.Name = "precio_txt";
            this.precio_txt.Size = new System.Drawing.Size(159, 20);
            this.precio_txt.TabIndex = 111;
            this.precio_txt.TextChanged += new System.EventHandler(this.precio_txt_TextChanged);
            // 
            // radioBtnUSD_precio
            // 
            this.radioBtnUSD_precio.AutoSize = true;
            this.radioBtnUSD_precio.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnUSD_precio.Location = new System.Drawing.Point(57, 3);
            this.radioBtnUSD_precio.Name = "radioBtnUSD_precio";
            this.radioBtnUSD_precio.Size = new System.Drawing.Size(57, 19);
            this.radioBtnUSD_precio.TabIndex = 113;
            this.radioBtnUSD_precio.Text = "USD$";
            this.radioBtnUSD_precio.UseVisualStyleBackColor = true;
            // 
            // radioBtnRD_precio
            // 
            this.radioBtnRD_precio.AutoSize = true;
            this.radioBtnRD_precio.Checked = true;
            this.radioBtnRD_precio.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRD_precio.Location = new System.Drawing.Point(3, 3);
            this.radioBtnRD_precio.Name = "radioBtnRD_precio";
            this.radioBtnRD_precio.Size = new System.Drawing.Size(49, 19);
            this.radioBtnRD_precio.TabIndex = 114;
            this.radioBtnRD_precio.TabStop = true;
            this.radioBtnRD_precio.Tag = "4";
            this.radioBtnRD_precio.Text = "RD$";
            this.radioBtnRD_precio.UseVisualStyleBackColor = true;
            this.radioBtnRD_precio.CheckedChanged += new System.EventHandler(this.radioBtnRD_precio_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 112;
            this.label17.Text = "PRECIO VENTA:";
            // 
            // costoRD_txt
            // 
            this.costoRD_txt.Enabled = false;
            this.costoRD_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoRD_txt.Location = new System.Drawing.Point(105, 148);
            this.costoRD_txt.Name = "costoRD_txt";
            this.costoRD_txt.Size = new System.Drawing.Size(99, 20);
            this.costoRD_txt.TabIndex = 116;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 117;
            this.label19.Text = "COSTO($RD):";
            // 
            // costoUSD_txt
            // 
            this.costoUSD_txt.Enabled = false;
            this.costoUSD_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoUSD_txt.Location = new System.Drawing.Point(316, 148);
            this.costoUSD_txt.Name = "costoUSD_txt";
            this.costoUSD_txt.Size = new System.Drawing.Size(99, 20);
            this.costoUSD_txt.TabIndex = 118;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(220, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 15);
            this.label20.TabIndex = 119;
            this.label20.Text = "COSTO($USD):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioBtnRD_precio);
            this.panel2.Controls.Add(this.radioBtnUSD_precio);
            this.panel2.Location = new System.Drawing.Point(19, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 24);
            this.panel2.TabIndex = 120;
            // 
            // tasa_lbl
            // 
            this.tasa_lbl.AutoSize = true;
            this.tasa_lbl.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasa_lbl.Location = new System.Drawing.Point(156, 202);
            this.tasa_lbl.Name = "tasa_lbl";
            this.tasa_lbl.Size = new System.Drawing.Size(83, 15);
            this.tasa_lbl.TabIndex = 39;
            this.tasa_lbl.TabStop = true;
            this.tasa_lbl.Text = "1.00 USD$ ->";
            this.tasa_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tasa_lbl_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdDinero_radiobtn);
            this.panel4.Controls.Add(this.usdDinero_radiobtn);
            this.panel4.Location = new System.Drawing.Point(535, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 24);
            this.panel4.TabIndex = 121;
            // 
            // VenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 543);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.costoUSD_txt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.costoRD_txt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.precio_txt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.chasis_txt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.vehiculos_cb);
            this.Controls.Add(this.pagos_dtg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.cliente_cb);
            this.Controls.Add(this.fecha_dtp);
            this.Controls.Add(this.nota_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoPago_cb);
            this.Controls.Add(this.tasa_lbl);
            this.Controls.Add(this.pago_txt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VenderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURACION";
            this.Load += new System.EventHandler(this.VenderForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagos_dtg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.RadioButton usdDinero_radiobtn;
        private System.Windows.Forms.RadioButton rdDinero_radiobtn;
        private System.Windows.Forms.TextBox pago_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cliente_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipoPago_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fecha_dtp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nota_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label restante_USD_lbl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label totalUSD_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label restante_RD_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalRD_lbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label precioVentaUSD_lbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label precioVentaRd_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView pagos_dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGOUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox vehiculos_cb;
        private System.Windows.Forms.TextBox chasis_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox precio_txt;
        private System.Windows.Forms.RadioButton radioBtnUSD_precio;
        private System.Windows.Forms.RadioButton radioBtnRD_precio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox costoRD_txt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox costoUSD_txt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel tasa_lbl;
        private System.Windows.Forms.Panel panel4;
    }
}