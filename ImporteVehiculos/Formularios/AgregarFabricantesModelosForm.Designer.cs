namespace ImporteVehiculos.Formularios
{
    partial class AgregarFabricantesModelosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFabricantesModelosForm));
            this.fabricante_radiobtn = new System.Windows.Forms.RadioButton();
            this.modelos_radiobtn = new System.Windows.Forms.RadioButton();
            this.codigoFabricante_txt = new System.Windows.Forms.TextBox();
            this.guardarFabricante_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.estadoFabricante_chbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fabricante_txt = new System.Windows.Forms.TextBox();
            this.modelo_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fabricante_cbox = new System.Windows.Forms.ComboBox();
            this.codigoModelo_txt = new System.Windows.Forms.TextBox();
            this.guardarModelo_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoModelo_chbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarEditar_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fabricantesModelos_dtg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantesModelos_dtg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fabricante_radiobtn
            // 
            this.fabricante_radiobtn.AutoSize = true;
            this.fabricante_radiobtn.Checked = true;
            this.fabricante_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fabricante_radiobtn.Location = new System.Drawing.Point(550, 65);
            this.fabricante_radiobtn.Name = "fabricante_radiobtn";
            this.fabricante_radiobtn.Size = new System.Drawing.Size(95, 28);
            this.fabricante_radiobtn.TabIndex = 0;
            this.fabricante_radiobtn.TabStop = true;
            this.fabricante_radiobtn.Text = "Marcas";
            this.fabricante_radiobtn.UseVisualStyleBackColor = true;
            this.fabricante_radiobtn.Visible = false;
            this.fabricante_radiobtn.CheckedChanged += new System.EventHandler(this.fabricante_radiobtn_CheckedChanged);
            // 
            // modelos_radiobtn
            // 
            this.modelos_radiobtn.AutoSize = true;
            this.modelos_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelos_radiobtn.Location = new System.Drawing.Point(662, 65);
            this.modelos_radiobtn.Name = "modelos_radiobtn";
            this.modelos_radiobtn.Size = new System.Drawing.Size(108, 28);
            this.modelos_radiobtn.TabIndex = 1;
            this.modelos_radiobtn.Text = "Modelos";
            this.modelos_radiobtn.UseVisualStyleBackColor = true;
            this.modelos_radiobtn.Visible = false;
            // 
            // codigoFabricante_txt
            // 
            this.codigoFabricante_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoFabricante_txt.Location = new System.Drawing.Point(7, 102);
            this.codigoFabricante_txt.Name = "codigoFabricante_txt";
            this.codigoFabricante_txt.Size = new System.Drawing.Size(276, 29);
            this.codigoFabricante_txt.TabIndex = 1;
            // 
            // guardarFabricante_btn
            // 
            this.guardarFabricante_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.guardarFabricante_btn.FlatAppearance.BorderSize = 0;
            this.guardarFabricante_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarFabricante_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarFabricante_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.guardarFabricante_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardarFabricante_btn.Location = new System.Drawing.Point(79, 212);
            this.guardarFabricante_btn.Name = "guardarFabricante_btn";
            this.guardarFabricante_btn.Size = new System.Drawing.Size(160, 54);
            this.guardarFabricante_btn.TabIndex = 3;
            this.guardarFabricante_btn.Text = "GUARDAR";
            this.guardarFabricante_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarFabricante_btn.UseVisualStyleBackColor = false;
            this.guardarFabricante_btn.Click += new System.EventHandler(this.guardarModelo_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "CODIGO:";
            // 
            // estadoFabricante_chbox
            // 
            this.estadoFabricante_chbox.AutoSize = true;
            this.estadoFabricante_chbox.Checked = true;
            this.estadoFabricante_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoFabricante_chbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoFabricante_chbox.ForeColor = System.Drawing.SystemColors.Control;
            this.estadoFabricante_chbox.Location = new System.Drawing.Point(7, 134);
            this.estadoFabricante_chbox.Name = "estadoFabricante_chbox";
            this.estadoFabricante_chbox.Size = new System.Drawing.Size(119, 29);
            this.estadoFabricante_chbox.TabIndex = 2;
            this.estadoFabricante_chbox.Text = "Habilitar";
            this.estadoFabricante_chbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marcas:";
            // 
            // fabricante_txt
            // 
            this.fabricante_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fabricante_txt.Location = new System.Drawing.Point(7, 34);
            this.fabricante_txt.Name = "fabricante_txt";
            this.fabricante_txt.Size = new System.Drawing.Size(276, 29);
            this.fabricante_txt.TabIndex = 0;
            // 
            // modelo_txt
            // 
            this.modelo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_txt.Location = new System.Drawing.Point(7, 91);
            this.modelo_txt.Name = "modelo_txt";
            this.modelo_txt.Size = new System.Drawing.Size(276, 29);
            this.modelo_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "MODELO:";
            // 
            // fabricante_cbox
            // 
            this.fabricante_cbox.DropDownHeight = 180;
            this.fabricante_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fabricante_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fabricante_cbox.FormattingEnabled = true;
            this.fabricante_cbox.IntegralHeight = false;
            this.fabricante_cbox.Location = new System.Drawing.Point(7, 29);
            this.fabricante_cbox.Name = "fabricante_cbox";
            this.fabricante_cbox.Size = new System.Drawing.Size(276, 32);
            this.fabricante_cbox.TabIndex = 4;
            this.fabricante_cbox.SelectedIndexChanged += new System.EventHandler(this.fabricante_cbox_SelectedIndexChanged);
            // 
            // codigoModelo_txt
            // 
            this.codigoModelo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoModelo_txt.Location = new System.Drawing.Point(7, 148);
            this.codigoModelo_txt.Name = "codigoModelo_txt";
            this.codigoModelo_txt.Size = new System.Drawing.Size(276, 29);
            this.codigoModelo_txt.TabIndex = 6;
            // 
            // guardarModelo_btn
            // 
            this.guardarModelo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.guardarModelo_btn.FlatAppearance.BorderSize = 0;
            this.guardarModelo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarModelo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarModelo_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.guardarModelo_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardarModelo_btn.Location = new System.Drawing.Point(81, 216);
            this.guardarModelo_btn.Name = "guardarModelo_btn";
            this.guardarModelo_btn.Size = new System.Drawing.Size(172, 54);
            this.guardarModelo_btn.TabIndex = 8;
            this.guardarModelo_btn.Text = "GUARDAR";
            this.guardarModelo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarModelo_btn.UseVisualStyleBackColor = false;
            this.guardarModelo_btn.Click += new System.EventHandler(this.guardarModelo_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "CODIGO:";
            // 
            // estadoModelo_chbox
            // 
            this.estadoModelo_chbox.AutoSize = true;
            this.estadoModelo_chbox.Checked = true;
            this.estadoModelo_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoModelo_chbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoModelo_chbox.ForeColor = System.Drawing.SystemColors.Control;
            this.estadoModelo_chbox.Location = new System.Drawing.Point(3, 181);
            this.estadoModelo_chbox.Name = "estadoModelo_chbox";
            this.estadoModelo_chbox.Size = new System.Drawing.Size(119, 29);
            this.estadoModelo_chbox.TabIndex = 7;
            this.estadoModelo_chbox.Text = "Habilitar";
            this.estadoModelo_chbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marcas:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cancelarEditar_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(367, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 38);
            this.panel1.TabIndex = 9;
            // 
            // cancelarEditar_btn
            // 
            this.cancelarEditar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cancelarEditar_btn.Enabled = false;
            this.cancelarEditar_btn.FlatAppearance.BorderSize = 0;
            this.cancelarEditar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarEditar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelarEditar_btn.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.cancelarEditar_btn.Location = new System.Drawing.Point(267, 3);
            this.cancelarEditar_btn.Name = "cancelarEditar_btn";
            this.cancelarEditar_btn.Size = new System.Drawing.Size(118, 28);
            this.cancelarEditar_btn.TabIndex = 1;
            this.cancelarEditar_btn.Text = "Cancelar Editar";
            this.cancelarEditar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarEditar_btn.UseVisualStyleBackColor = false;
            this.cancelarEditar_btn.Click += new System.EventHandler(this.cancelarEditar_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doble Click para Actualizar!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 319);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.tabPage1.Controls.Add(this.codigoFabricante_txt);
            this.tabPage1.Controls.Add(this.fabricante_txt);
            this.tabPage1.Controls.Add(this.guardarFabricante_btn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.estadoFabricante_chbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MARCAS";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.tabPage2.Controls.Add(this.modelo_txt);
            this.tabPage2.Controls.Add(this.fabricante_cbox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.estadoModelo_chbox);
            this.tabPage2.Controls.Add(this.codigoModelo_txt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.guardarModelo_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MODELOS";
            // 
            // fabricantesModelos_dtg
            // 
            this.fabricantesModelos_dtg.AllowUserToAddRows = false;
            this.fabricantesModelos_dtg.AllowUserToDeleteRows = false;
            this.fabricantesModelos_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.fabricantesModelos_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.fabricantesModelos_dtg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.fabricantesModelos_dtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fabricantesModelos_dtg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.fabricantesModelos_dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fabricantesModelos_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.fabricantesModelos_dtg.ColumnHeadersHeight = 30;
            this.fabricantesModelos_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fabricantesModelos_dtg.EnableHeadersVisualStyles = false;
            this.fabricantesModelos_dtg.GridColor = System.Drawing.Color.DimGray;
            this.fabricantesModelos_dtg.Location = new System.Drawing.Point(367, 99);
            this.fabricantesModelos_dtg.Name = "fabricantesModelos_dtg";
            this.fabricantesModelos_dtg.ReadOnly = true;
            this.fabricantesModelos_dtg.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.fabricantesModelos_dtg.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.fabricantesModelos_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fabricantesModelos_dtg.Size = new System.Drawing.Size(403, 275);
            this.fabricantesModelos_dtg.TabIndex = 62;
            this.fabricantesModelos_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fabricantesModelos_dtg_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 49);
            this.panel2.TabIndex = 63;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(713, 3);
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
            this.button2.Location = new System.Drawing.Point(745, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 30;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(368, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "MARCAS/MODELOS VEHICULOS";
            // 
            // AgregarFabricantesModelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(783, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fabricantesModelos_dtg);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modelos_radiobtn);
            this.Controls.Add(this.fabricante_radiobtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarFabricantesModelosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Editar Fabricantes & Modelos";
            this.Load += new System.EventHandler(this.AgregarFabricantesModelosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantesModelos_dtg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton fabricante_radiobtn;
        private System.Windows.Forms.RadioButton modelos_radiobtn;
        private System.Windows.Forms.TextBox codigoFabricante_txt;
        private System.Windows.Forms.Button guardarFabricante_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox estadoFabricante_chbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fabricante_txt;
        private System.Windows.Forms.TextBox codigoModelo_txt;
        private System.Windows.Forms.Button guardarModelo_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox estadoModelo_chbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modelo_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fabricante_cbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarEditar_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView fabricantesModelos_dtg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
    }
}