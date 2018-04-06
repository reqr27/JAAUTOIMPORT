namespace ImporteVehiculos.Formularios
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.agregarEditarUsuario_btn = new System.Windows.Forms.Button();
            this.usuarios_dtg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modificarVehiculo_chbox = new System.Windows.Forms.CheckBox();
            this.cuentasCobrar_chbox = new System.Windows.Forms.CheckBox();
            this.cuentasPagar_chbox = new System.Windows.Forms.CheckBox();
            this.reportes_chbox = new System.Windows.Forms.CheckBox();
            this.cambiarEstadosVehiculos_chbx = new System.Windows.Forms.CheckBox();
            this.crearPropietarios_chbx = new System.Windows.Forms.CheckBox();
            this.compras_chbx = new System.Windows.Forms.CheckBox();
            this.agregarGasto_chbx = new System.Windows.Forms.CheckBox();
            this.agregarPiezas_chbx = new System.Windows.Forms.CheckBox();
            this.facturacion_chbx = new System.Windows.Forms.CheckBox();
            this.importarVehiculos_chbx = new System.Windows.Forms.CheckBox();
            this.crearGastos_chbx = new System.Windows.Forms.CheckBox();
            this.crearTaller_chbx = new System.Windows.Forms.CheckBox();
            this.crearClientes_chbx = new System.Windows.Forms.CheckBox();
            this.crearPiezasRepuestos_chbx = new System.Windows.Forms.CheckBox();
            this.crearFabricantesModelos_chbx = new System.Windows.Forms.CheckBox();
            this.crearUsuario_chbx = new System.Windows.Forms.CheckBox();
            this.tasaDolar_chbx = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.estado_chbx = new System.Windows.Forms.CheckBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmarClave_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clave_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.actualizarTasaDiario_chbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_dtg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Enabled = false;
            this.cancelar_btn.FlatAppearance.BorderSize = 0;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cancelar_btn.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.cancelar_btn.Location = new System.Drawing.Point(726, 3);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(124, 76);
            this.cancelar_btn.TabIndex = 36;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // agregarEditarUsuario_btn
            // 
            this.agregarEditarUsuario_btn.FlatAppearance.BorderSize = 0;
            this.agregarEditarUsuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarEditarUsuario_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarEditarUsuario_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.agregarEditarUsuario_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.agregarEditarUsuario_btn.Location = new System.Drawing.Point(600, 3);
            this.agregarEditarUsuario_btn.Name = "agregarEditarUsuario_btn";
            this.agregarEditarUsuario_btn.Size = new System.Drawing.Size(126, 76);
            this.agregarEditarUsuario_btn.TabIndex = 33;
            this.agregarEditarUsuario_btn.Text = "Registrar";
            this.agregarEditarUsuario_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.agregarEditarUsuario_btn.UseVisualStyleBackColor = true;
            this.agregarEditarUsuario_btn.Click += new System.EventHandler(this.agregarEditarUsuario_btn_Click);
            // 
            // usuarios_dtg
            // 
            this.usuarios_dtg.AllowUserToAddRows = false;
            this.usuarios_dtg.AllowUserToDeleteRows = false;
            this.usuarios_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.usuarios_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.usuarios_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios_dtg.Location = new System.Drawing.Point(14, 327);
            this.usuarios_dtg.MultiSelect = false;
            this.usuarios_dtg.Name = "usuarios_dtg";
            this.usuarios_dtg.ReadOnly = true;
            this.usuarios_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarios_dtg.Size = new System.Drawing.Size(841, 196);
            this.usuarios_dtg.TabIndex = 32;
            this.usuarios_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarios_dtg_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.actualizarTasaDiario_chbox);
            this.panel1.Controls.Add(this.modificarVehiculo_chbox);
            this.panel1.Controls.Add(this.cuentasCobrar_chbox);
            this.panel1.Controls.Add(this.cuentasPagar_chbox);
            this.panel1.Controls.Add(this.reportes_chbox);
            this.panel1.Controls.Add(this.cambiarEstadosVehiculos_chbx);
            this.panel1.Controls.Add(this.crearPropietarios_chbx);
            this.panel1.Controls.Add(this.compras_chbx);
            this.panel1.Controls.Add(this.agregarGasto_chbx);
            this.panel1.Controls.Add(this.agregarPiezas_chbx);
            this.panel1.Controls.Add(this.facturacion_chbx);
            this.panel1.Controls.Add(this.importarVehiculos_chbx);
            this.panel1.Controls.Add(this.crearGastos_chbx);
            this.panel1.Controls.Add(this.crearTaller_chbx);
            this.panel1.Controls.Add(this.crearClientes_chbx);
            this.panel1.Controls.Add(this.crearPiezasRepuestos_chbx);
            this.panel1.Controls.Add(this.crearFabricantesModelos_chbx);
            this.panel1.Controls.Add(this.crearUsuario_chbx);
            this.panel1.Controls.Add(this.tasaDolar_chbx);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.estado_chbx);
            this.panel1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(394, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 267);
            this.panel1.TabIndex = 31;
            // 
            // modificarVehiculo_chbox
            // 
            this.modificarVehiculo_chbox.AutoSize = true;
            this.modificarVehiculo_chbox.Checked = true;
            this.modificarVehiculo_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modificarVehiculo_chbox.Location = new System.Drawing.Point(270, 146);
            this.modificarVehiculo_chbox.Name = "modificarVehiculo_chbox";
            this.modificarVehiculo_chbox.Size = new System.Drawing.Size(130, 19);
            this.modificarVehiculo_chbox.TabIndex = 24;
            this.modificarVehiculo_chbox.Text = "Modificar Vehículo";
            this.modificarVehiculo_chbox.UseVisualStyleBackColor = true;
            // 
            // cuentasCobrar_chbox
            // 
            this.cuentasCobrar_chbox.AutoSize = true;
            this.cuentasCobrar_chbox.Checked = true;
            this.cuentasCobrar_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cuentasCobrar_chbox.Location = new System.Drawing.Point(270, 122);
            this.cuentasCobrar_chbox.Name = "cuentasCobrar_chbox";
            this.cuentasCobrar_chbox.Size = new System.Drawing.Size(127, 19);
            this.cuentasCobrar_chbox.TabIndex = 22;
            this.cuentasCobrar_chbox.Text = "Cuenta por Cobrar";
            this.cuentasCobrar_chbox.UseVisualStyleBackColor = true;
            // 
            // cuentasPagar_chbox
            // 
            this.cuentasPagar_chbox.AutoSize = true;
            this.cuentasPagar_chbox.Checked = true;
            this.cuentasPagar_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cuentasPagar_chbox.Location = new System.Drawing.Point(270, 100);
            this.cuentasPagar_chbox.Name = "cuentasPagar_chbox";
            this.cuentasPagar_chbox.Size = new System.Drawing.Size(128, 19);
            this.cuentasPagar_chbox.TabIndex = 23;
            this.cuentasPagar_chbox.Text = "Cuentas por Pagar";
            this.cuentasPagar_chbox.UseVisualStyleBackColor = true;
            // 
            // reportes_chbox
            // 
            this.reportes_chbox.AutoSize = true;
            this.reportes_chbox.Checked = true;
            this.reportes_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reportes_chbox.Location = new System.Drawing.Point(270, 218);
            this.reportes_chbox.Name = "reportes_chbox";
            this.reportes_chbox.Size = new System.Drawing.Size(74, 19);
            this.reportes_chbox.TabIndex = 21;
            this.reportes_chbox.Text = "Reportes";
            this.reportes_chbox.UseVisualStyleBackColor = true;
            // 
            // cambiarEstadosVehiculos_chbx
            // 
            this.cambiarEstadosVehiculos_chbx.AutoSize = true;
            this.cambiarEstadosVehiculos_chbx.Checked = true;
            this.cambiarEstadosVehiculos_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cambiarEstadosVehiculos_chbx.Location = new System.Drawing.Point(270, 193);
            this.cambiarEstadosVehiculos_chbx.Name = "cambiarEstadosVehiculos_chbx";
            this.cambiarEstadosVehiculos_chbx.Size = new System.Drawing.Size(176, 19);
            this.cambiarEstadosVehiculos_chbx.TabIndex = 18;
            this.cambiarEstadosVehiculos_chbx.Text = "Cambiar Estados Vehículos";
            this.cambiarEstadosVehiculos_chbx.UseVisualStyleBackColor = true;
            // 
            // crearPropietarios_chbx
            // 
            this.crearPropietarios_chbx.AutoSize = true;
            this.crearPropietarios_chbx.Checked = true;
            this.crearPropietarios_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crearPropietarios_chbx.Location = new System.Drawing.Point(3, 171);
            this.crearPropietarios_chbx.Name = "crearPropietarios_chbx";
            this.crearPropietarios_chbx.Size = new System.Drawing.Size(127, 19);
            this.crearPropietarios_chbx.TabIndex = 17;
            this.crearPropietarios_chbx.Text = "Crear Propietarios";
            this.crearPropietarios_chbx.UseVisualStyleBackColor = true;
            // 
            // compras_chbx
            // 
            this.compras_chbx.AutoSize = true;
            this.compras_chbx.Checked = true;
            this.compras_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compras_chbx.Location = new System.Drawing.Point(270, 29);
            this.compras_chbx.Name = "compras_chbx";
            this.compras_chbx.Size = new System.Drawing.Size(74, 19);
            this.compras_chbx.TabIndex = 15;
            this.compras_chbx.Text = "Compras";
            this.compras_chbx.UseVisualStyleBackColor = true;
            // 
            // agregarGasto_chbx
            // 
            this.agregarGasto_chbx.AutoSize = true;
            this.agregarGasto_chbx.Checked = true;
            this.agregarGasto_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.agregarGasto_chbx.Location = new System.Drawing.Point(270, 168);
            this.agregarGasto_chbx.Name = "agregarGasto_chbx";
            this.agregarGasto_chbx.Size = new System.Drawing.Size(165, 19);
            this.agregarGasto_chbx.TabIndex = 16;
            this.agregarGasto_chbx.Text = "Agregar Gasto a Vehículo";
            this.agregarGasto_chbx.UseVisualStyleBackColor = true;
            // 
            // agregarPiezas_chbx
            // 
            this.agregarPiezas_chbx.AutoSize = true;
            this.agregarPiezas_chbx.Checked = true;
            this.agregarPiezas_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.agregarPiezas_chbx.Location = new System.Drawing.Point(4, 242);
            this.agregarPiezas_chbx.Name = "agregarPiezas_chbx";
            this.agregarPiezas_chbx.Size = new System.Drawing.Size(175, 19);
            this.agregarPiezas_chbx.TabIndex = 19;
            this.agregarPiezas_chbx.Text = "Agregar Piezas a Vehículos";
            this.agregarPiezas_chbx.UseVisualStyleBackColor = true;
            // 
            // facturacion_chbx
            // 
            this.facturacion_chbx.AutoSize = true;
            this.facturacion_chbx.Checked = true;
            this.facturacion_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.facturacion_chbx.Location = new System.Drawing.Point(270, 52);
            this.facturacion_chbx.Name = "facturacion_chbx";
            this.facturacion_chbx.Size = new System.Drawing.Size(91, 19);
            this.facturacion_chbx.TabIndex = 20;
            this.facturacion_chbx.Text = "Facturación";
            this.facturacion_chbx.UseVisualStyleBackColor = true;
            // 
            // importarVehiculos_chbx
            // 
            this.importarVehiculos_chbx.AutoSize = true;
            this.importarVehiculos_chbx.Checked = true;
            this.importarVehiculos_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.importarVehiculos_chbx.Location = new System.Drawing.Point(270, 77);
            this.importarVehiculos_chbx.Name = "importarVehiculos_chbx";
            this.importarVehiculos_chbx.Size = new System.Drawing.Size(81, 19);
            this.importarVehiculos_chbx.TabIndex = 14;
            this.importarVehiculos_chbx.Text = "Vehiculos";
            this.importarVehiculos_chbx.UseVisualStyleBackColor = true;
            // 
            // crearGastos_chbx
            // 
            this.crearGastos_chbx.AutoSize = true;
            this.crearGastos_chbx.Checked = true;
            this.crearGastos_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crearGastos_chbx.Location = new System.Drawing.Point(3, 217);
            this.crearGastos_chbx.Name = "crearGastos_chbx";
            this.crearGastos_chbx.Size = new System.Drawing.Size(157, 19);
            this.crearGastos_chbx.TabIndex = 13;
            this.crearGastos_chbx.Text = "Crear Gastos Generales";
            this.crearGastos_chbx.UseVisualStyleBackColor = true;
            // 
            // crearTaller_chbx
            // 
            this.crearTaller_chbx.AutoSize = true;
            this.crearTaller_chbx.Checked = true;
            this.crearTaller_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crearTaller_chbx.Location = new System.Drawing.Point(3, 146);
            this.crearTaller_chbx.Name = "crearTaller_chbx";
            this.crearTaller_chbx.Size = new System.Drawing.Size(175, 19);
            this.crearTaller_chbx.TabIndex = 11;
            this.crearTaller_chbx.Text = "Crear Talleres y Repuestos";
            this.crearTaller_chbx.UseVisualStyleBackColor = true;
            // 
            // crearClientes_chbx
            // 
            this.crearClientes_chbx.AutoSize = true;
            this.crearClientes_chbx.Checked = true;
            this.crearClientes_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crearClientes_chbx.Location = new System.Drawing.Point(3, 192);
            this.crearClientes_chbx.Name = "crearClientes_chbx";
            this.crearClientes_chbx.Size = new System.Drawing.Size(106, 19);
            this.crearClientes_chbx.TabIndex = 12;
            this.crearClientes_chbx.Text = "Crear Clientes";
            this.crearClientes_chbx.UseVisualStyleBackColor = true;
            // 
            // crearPiezasRepuestos_chbx
            // 
            this.crearPiezasRepuestos_chbx.AutoSize = true;
            this.crearPiezasRepuestos_chbx.Checked = true;
            this.crearPiezasRepuestos_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crearPiezasRepuestos_chbx.Location = new System.Drawing.Point(3, 124);
            this.crearPiezasRepuestos_chbx.Name = "crearPiezasRepuestos_chbx";
            this.crearPiezasRepuestos_chbx.Size = new System.Drawing.Size(158, 19);
            this.crearPiezasRepuestos_chbx.TabIndex = 10;
            this.crearPiezasRepuestos_chbx.Text = "Crear Piezas/Repuestos";
            this.crearPiezasRepuestos_chbx.UseVisualStyleBackColor = true;
            // 
            // crearFabricantesModelos_chbx
            // 
            this.crearFabricantesModelos_chbx.AutoSize = true;
            this.crearFabricantesModelos_chbx.Checked = true;
            this.crearFabricantesModelos_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crearFabricantesModelos_chbx.Location = new System.Drawing.Point(3, 100);
            this.crearFabricantesModelos_chbx.Name = "crearFabricantesModelos_chbx";
            this.crearFabricantesModelos_chbx.Size = new System.Drawing.Size(176, 19);
            this.crearFabricantesModelos_chbx.TabIndex = 9;
            this.crearFabricantesModelos_chbx.Text = "Crear Fabricantes/Modelos";
            this.crearFabricantesModelos_chbx.UseVisualStyleBackColor = true;
            // 
            // crearUsuario_chbx
            // 
            this.crearUsuario_chbx.AutoSize = true;
            this.crearUsuario_chbx.Location = new System.Drawing.Point(3, 52);
            this.crearUsuario_chbx.Name = "crearUsuario_chbx";
            this.crearUsuario_chbx.Size = new System.Drawing.Size(115, 19);
            this.crearUsuario_chbx.TabIndex = 7;
            this.crearUsuario_chbx.Text = "Agregar Usuario";
            this.crearUsuario_chbx.UseVisualStyleBackColor = true;
            // 
            // tasaDolar_chbx
            // 
            this.tasaDolar_chbx.AutoSize = true;
            this.tasaDolar_chbx.Location = new System.Drawing.Point(3, 77);
            this.tasaDolar_chbx.Name = "tasaDolar_chbx";
            this.tasaDolar_chbx.Size = new System.Drawing.Size(96, 19);
            this.tasaDolar_chbx.TabIndex = 8;
            this.tasaDolar_chbx.Text = "Tasa Cambio";
            this.tasaDolar_chbx.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Permisos del Usuario";
            // 
            // estado_chbx
            // 
            this.estado_chbx.AutoSize = true;
            this.estado_chbx.Checked = true;
            this.estado_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estado_chbx.Location = new System.Drawing.Point(3, 29);
            this.estado_chbx.Name = "estado_chbx";
            this.estado_chbx.Size = new System.Drawing.Size(112, 19);
            this.estado_chbx.TabIndex = 6;
            this.estado_chbx.Text = "Activar Usuario";
            this.estado_chbx.UseVisualStyleBackColor = true;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_txt.Location = new System.Drawing.Point(158, 64);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(186, 20);
            this.nombre_txt.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre y Apellido:";
            // 
            // confirmarClave_txt
            // 
            this.confirmarClave_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClave_txt.Location = new System.Drawing.Point(158, 247);
            this.confirmarClave_txt.Name = "confirmarClave_txt";
            this.confirmarClave_txt.PasswordChar = '*';
            this.confirmarClave_txt.Size = new System.Drawing.Size(186, 20);
            this.confirmarClave_txt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Confirmar Clave:";
            // 
            // clave_txt
            // 
            this.clave_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_txt.Location = new System.Drawing.Point(158, 189);
            this.clave_txt.Name = "clave_txt";
            this.clave_txt.PasswordChar = '*';
            this.clave_txt.Size = new System.Drawing.Size(186, 20);
            this.clave_txt.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Clave:";
            // 
            // usuario_txt
            // 
            this.usuario_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_txt.Location = new System.Drawing.Point(158, 129);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(186, 20);
            this.usuario_txt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Usuario: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.agregarEditarUsuario_btn);
            this.panel2.Controls.Add(this.cancelar_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 82);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 44);
            this.panel3.TabIndex = 47;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(804, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 33;
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
            this.button2.Location = new System.Drawing.Point(836, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "USUARIOS";
            // 
            // actualizarTasaDiario_chbox
            // 
            this.actualizarTasaDiario_chbox.AutoSize = true;
            this.actualizarTasaDiario_chbox.Checked = true;
            this.actualizarTasaDiario_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.actualizarTasaDiario_chbox.Location = new System.Drawing.Point(270, 243);
            this.actualizarTasaDiario_chbox.Name = "actualizarTasaDiario_chbox";
            this.actualizarTasaDiario_chbox.Size = new System.Drawing.Size(183, 19);
            this.actualizarTasaDiario_chbox.TabIndex = 25;
            this.actualizarTasaDiario_chbox.Text = "Actualizar Diariamente Tasa";
            this.actualizarTasaDiario_chbox.UseVisualStyleBackColor = true;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.usuarios_dtg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmarClave_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clave_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_dtg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button agregarEditarUsuario_btn;
        private System.Windows.Forms.DataGridView usuarios_dtg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox facturacion_chbx;
        private System.Windows.Forms.CheckBox agregarPiezas_chbx;
        private System.Windows.Forms.CheckBox cambiarEstadosVehiculos_chbx;
        private System.Windows.Forms.CheckBox crearPropietarios_chbx;
        private System.Windows.Forms.CheckBox agregarGasto_chbx;
        private System.Windows.Forms.CheckBox compras_chbx;
        private System.Windows.Forms.CheckBox importarVehiculos_chbx;
        private System.Windows.Forms.CheckBox crearGastos_chbx;
        private System.Windows.Forms.CheckBox crearTaller_chbx;
        private System.Windows.Forms.CheckBox crearClientes_chbx;
        private System.Windows.Forms.CheckBox crearPiezasRepuestos_chbx;
        private System.Windows.Forms.CheckBox crearFabricantesModelos_chbx;
        private System.Windows.Forms.CheckBox crearUsuario_chbx;
        private System.Windows.Forms.CheckBox tasaDolar_chbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox estado_chbx;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmarClave_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clave_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox reportes_chbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox modificarVehiculo_chbox;
        private System.Windows.Forms.CheckBox cuentasCobrar_chbox;
        private System.Windows.Forms.CheckBox cuentasPagar_chbox;
        private System.Windows.Forms.CheckBox actualizarTasaDiario_chbox;
    }
}