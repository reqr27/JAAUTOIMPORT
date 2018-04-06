namespace ImporteVehiculos.Formularios
{
    partial class ClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteForm));
            this.telefono1_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rncCedula_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarEditar_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cliente_dtg = new System.Windows.Forms.DataGridView();
            this.cliente_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoCliente_chbox = new System.Windows.Forms.CheckBox();
            this.guardarCliente_btn = new System.Windows.Forms.Button();
            this.direccion_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // telefono1_txt
            // 
            this.telefono1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono1_txt.Location = new System.Drawing.Point(154, 105);
            this.telefono1_txt.Name = "telefono1_txt";
            this.telefono1_txt.Size = new System.Drawing.Size(160, 22);
            this.telefono1_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "TELEFONO 1:";
            // 
            // rncCedula_txt
            // 
            this.rncCedula_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rncCedula_txt.Location = new System.Drawing.Point(154, 39);
            this.rncCedula_txt.Name = "rncCedula_txt";
            this.rncCedula_txt.Size = new System.Drawing.Size(262, 22);
            this.rncCedula_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "RNC/CEDULA:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cancelarEditar_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(27, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 38);
            this.panel1.TabIndex = 40;
            // 
            // cancelarEditar_btn
            // 
            this.cancelarEditar_btn.Enabled = false;
            this.cancelarEditar_btn.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.cancelarEditar_btn.Location = new System.Drawing.Point(237, 3);
            this.cancelarEditar_btn.Name = "cancelarEditar_btn";
            this.cancelarEditar_btn.Size = new System.Drawing.Size(118, 28);
            this.cancelarEditar_btn.TabIndex = 1;
            this.cancelarEditar_btn.Text = "Cancelar Editar";
            this.cancelarEditar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarEditar_btn.UseVisualStyleBackColor = true;
            this.cancelarEditar_btn.Click += new System.EventHandler(this.cancelarEditar_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doble Click para Actualizar!";
            // 
            // cliente_dtg
            // 
            this.cliente_dtg.AllowUserToAddRows = false;
            this.cliente_dtg.AllowUserToDeleteRows = false;
            this.cliente_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.cliente_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cliente_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cliente_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliente_dtg.Location = new System.Drawing.Point(27, 191);
            this.cliente_dtg.MultiSelect = false;
            this.cliente_dtg.Name = "cliente_dtg";
            this.cliente_dtg.ReadOnly = true;
            this.cliente_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cliente_dtg.Size = new System.Drawing.Size(373, 215);
            this.cliente_dtg.TabIndex = 39;
            this.cliente_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cliente_dtg_CellDoubleClick);
            // 
            // cliente_txt
            // 
            this.cliente_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_txt.Location = new System.Drawing.Point(154, 8);
            this.cliente_txt.Name = "cliente_txt";
            this.cliente_txt.Size = new System.Drawing.Size(262, 22);
            this.cliente_txt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "CLIENTE:";
            // 
            // estadoCliente_chbox
            // 
            this.estadoCliente_chbox.AutoSize = true;
            this.estadoCliente_chbox.Checked = true;
            this.estadoCliente_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoCliente_chbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCliente_chbox.Location = new System.Drawing.Point(30, 156);
            this.estadoCliente_chbox.Name = "estadoCliente_chbox";
            this.estadoCliente_chbox.Size = new System.Drawing.Size(119, 29);
            this.estadoCliente_chbox.TabIndex = 36;
            this.estadoCliente_chbox.Text = "Habilitar";
            this.estadoCliente_chbox.UseVisualStyleBackColor = true;
            // 
            // guardarCliente_btn
            // 
            this.guardarCliente_btn.BackColor = System.Drawing.Color.IndianRed;
            this.guardarCliente_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarCliente_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardarCliente_btn.Location = new System.Drawing.Point(228, 139);
            this.guardarCliente_btn.Name = "guardarCliente_btn";
            this.guardarCliente_btn.Size = new System.Drawing.Size(172, 46);
            this.guardarCliente_btn.TabIndex = 4;
            this.guardarCliente_btn.Text = "GUARDAR";
            this.guardarCliente_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarCliente_btn.UseVisualStyleBackColor = false;
            this.guardarCliente_btn.Click += new System.EventHandler(this.guardarCliente_btn_Click);
            // 
            // direccion_txt
            // 
            this.direccion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_txt.Location = new System.Drawing.Point(154, 71);
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.Size = new System.Drawing.Size(262, 22);
            this.direccion_txt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "DIRECCION:";
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(432, 462);
            this.Controls.Add(this.direccion_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefono1_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rncCedula_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cliente_dtg);
            this.Controls.Add(this.cliente_txt);
            this.Controls.Add(this.guardarCliente_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estadoCliente_chbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox telefono1_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rncCedula_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarEditar_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView cliente_dtg;
        private System.Windows.Forms.TextBox cliente_txt;
        private System.Windows.Forms.Button guardarCliente_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox estadoCliente_chbox;
        private System.Windows.Forms.TextBox direccion_txt;
        private System.Windows.Forms.Label label4;
    }
}