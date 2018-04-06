namespace ImporteVehiculos.Formularios
{
    partial class AgregarComponentesGastosVehiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarComponentesGastosVehiculoForm));
            this.descripcion_cb = new System.Windows.Forms.ComboBox();
            this.descripcion_lbl = new System.Windows.Forms.Label();
            this.tasa_lbl = new System.Windows.Forms.LinkLabel();
            this.usdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.rdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.precio_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taller_lbl = new System.Windows.Forms.Label();
            this.taller_cb = new System.Windows.Forms.ComboBox();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.nuevo_lnklbl = new System.Windows.Forms.LinkLabel();
            this.agregarTaller_lnklbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // descripcion_cb
            // 
            this.descripcion_cb.DropDownHeight = 180;
            this.descripcion_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descripcion_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_cb.FormattingEnabled = true;
            this.descripcion_cb.IntegralHeight = false;
            this.descripcion_cb.Location = new System.Drawing.Point(156, 26);
            this.descripcion_cb.Name = "descripcion_cb";
            this.descripcion_cb.Size = new System.Drawing.Size(301, 26);
            this.descripcion_cb.TabIndex = 5;
            this.descripcion_cb.SelectedIndexChanged += new System.EventHandler(this.descripcion_cb_SelectedIndexChanged);
            // 
            // descripcion_lbl
            // 
            this.descripcion_lbl.AutoSize = true;
            this.descripcion_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_lbl.Location = new System.Drawing.Point(8, 33);
            this.descripcion_lbl.Name = "descripcion_lbl";
            this.descripcion_lbl.Size = new System.Drawing.Size(20, 13);
            this.descripcion_lbl.TabIndex = 26;
            this.descripcion_lbl.Text = "lbl";
            // 
            // tasa_lbl
            // 
            this.tasa_lbl.AutoSize = true;
            this.tasa_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasa_lbl.Location = new System.Drawing.Point(153, 102);
            this.tasa_lbl.Name = "tasa_lbl";
            this.tasa_lbl.Size = new System.Drawing.Size(72, 13);
            this.tasa_lbl.TabIndex = 31;
            this.tasa_lbl.TabStop = true;
            this.tasa_lbl.Text = "1.00 USD$ ->";
            this.tasa_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tasa_lbl_LinkClicked);
            // 
            // usdDinero_radiobtn
            // 
            this.usdDinero_radiobtn.AutoSize = true;
            this.usdDinero_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdDinero_radiobtn.Location = new System.Drawing.Point(83, 100);
            this.usdDinero_radiobtn.Name = "usdDinero_radiobtn";
            this.usdDinero_radiobtn.Size = new System.Drawing.Size(54, 17);
            this.usdDinero_radiobtn.TabIndex = 28;
            this.usdDinero_radiobtn.Text = "USD$";
            this.usdDinero_radiobtn.UseVisualStyleBackColor = true;
            // 
            // rdDinero_radiobtn
            // 
            this.rdDinero_radiobtn.AutoSize = true;
            this.rdDinero_radiobtn.Checked = true;
            this.rdDinero_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDinero_radiobtn.Location = new System.Drawing.Point(12, 100);
            this.rdDinero_radiobtn.Name = "rdDinero_radiobtn";
            this.rdDinero_radiobtn.Size = new System.Drawing.Size(47, 17);
            this.rdDinero_radiobtn.TabIndex = 30;
            this.rdDinero_radiobtn.TabStop = true;
            this.rdDinero_radiobtn.Tag = "4";
            this.rdDinero_radiobtn.Text = "RD$";
            this.rdDinero_radiobtn.UseVisualStyleBackColor = true;
            this.rdDinero_radiobtn.CheckedChanged += new System.EventHandler(this.rdDinero_radiobtn_CheckedChanged);
            // 
            // precio_txt
            // 
            this.precio_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_txt.Location = new System.Drawing.Point(70, 126);
            this.precio_txt.Name = "precio_txt";
            this.precio_txt.Size = new System.Drawing.Size(101, 20);
            this.precio_txt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "PRECIO:";
            // 
            // taller_lbl
            // 
            this.taller_lbl.AutoSize = true;
            this.taller_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taller_lbl.Location = new System.Drawing.Point(9, 67);
            this.taller_lbl.Name = "taller_lbl";
            this.taller_lbl.Size = new System.Drawing.Size(58, 13);
            this.taller_lbl.TabIndex = 33;
            this.taller_lbl.Text = "TALLER:";
            this.taller_lbl.Visible = false;
            // 
            // taller_cb
            // 
            this.taller_cb.DropDownHeight = 180;
            this.taller_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taller_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taller_cb.FormattingEnabled = true;
            this.taller_cb.IntegralHeight = false;
            this.taller_cb.Location = new System.Drawing.Point(156, 60);
            this.taller_cb.Name = "taller_cb";
            this.taller_cb.Size = new System.Drawing.Size(301, 26);
            this.taller_cb.TabIndex = 34;
            this.taller_cb.Visible = false;
            // 
            // guardar_btn
            // 
            this.guardar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardar_btn.Location = new System.Drawing.Point(339, 102);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(118, 47);
            this.guardar_btn.TabIndex = 32;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // nuevo_lnklbl
            // 
            this.nuevo_lnklbl.AutoSize = true;
            this.nuevo_lnklbl.Location = new System.Drawing.Point(463, 33);
            this.nuevo_lnklbl.Name = "nuevo_lnklbl";
            this.nuevo_lnklbl.Size = new System.Drawing.Size(37, 13);
            this.nuevo_lnklbl.TabIndex = 35;
            this.nuevo_lnklbl.TabStop = true;
            this.nuevo_lnklbl.Text = "Añadir";
            this.nuevo_lnklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nuevo_lnklbl_LinkClicked);
            // 
            // agregarTaller_lnklbl
            // 
            this.agregarTaller_lnklbl.AutoSize = true;
            this.agregarTaller_lnklbl.Location = new System.Drawing.Point(463, 67);
            this.agregarTaller_lnklbl.Name = "agregarTaller_lnklbl";
            this.agregarTaller_lnklbl.Size = new System.Drawing.Size(37, 13);
            this.agregarTaller_lnklbl.TabIndex = 36;
            this.agregarTaller_lnklbl.TabStop = true;
            this.agregarTaller_lnklbl.Text = "Añadir";
            this.agregarTaller_lnklbl.Visible = false;
            this.agregarTaller_lnklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agregarTaller_lnklbl_LinkClicked);
            // 
            // AgregarComponentesGastosVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 158);
            this.Controls.Add(this.agregarTaller_lnklbl);
            this.Controls.Add(this.nuevo_lnklbl);
            this.Controls.Add(this.taller_cb);
            this.Controls.Add(this.taller_lbl);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.tasa_lbl);
            this.Controls.Add(this.usdDinero_radiobtn);
            this.Controls.Add(this.rdDinero_radiobtn);
            this.Controls.Add(this.precio_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descripcion_lbl);
            this.Controls.Add(this.descripcion_cb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarComponentesGastosVehiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AgregarComponentesGastosVehiculoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox descripcion_cb;
        private System.Windows.Forms.Label descripcion_lbl;
        private System.Windows.Forms.LinkLabel tasa_lbl;
        private System.Windows.Forms.RadioButton usdDinero_radiobtn;
        private System.Windows.Forms.RadioButton rdDinero_radiobtn;
        private System.Windows.Forms.TextBox precio_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Label taller_lbl;
        private System.Windows.Forms.ComboBox taller_cb;
        private System.Windows.Forms.LinkLabel nuevo_lnklbl;
        private System.Windows.Forms.LinkLabel agregarTaller_lnklbl;
    }
}