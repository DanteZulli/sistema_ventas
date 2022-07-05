namespace CapaPresentacion
{
    partial class frmPresentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacion));
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.imgl17x17 = new System.Windows.Forms.ImageList(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdpresentacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.grpPresentaciones = new System.Windows.Forms.GroupBox();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.tabControlPres = new System.Windows.Forms.TabControl();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPresentaciones = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgl30x30 = new System.Windows.Forms.ImageList(this.components);
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.grpPresentaciones.SuspendLayout();
            this.tabMantenimiento.SuspendLayout();
            this.tabControlPres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.dataListado);
            this.tabListado.Controls.Add(this.lblTotal);
            this.tabListado.Controls.Add(this.chkEliminar);
            this.tabListado.Controls.Add(this.btnImprimir);
            this.tabListado.Controls.Add(this.btnEliminar);
            this.tabListado.Controls.Add(this.btnBuscar);
            this.tabListado.Controls.Add(this.txtBuscar);
            this.tabListado.Controls.Add(this.lblNombre);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(722, 448);
            this.tabListado.TabIndex = 0;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(6, 65);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(710, 377);
            this.dataListado.TabIndex = 7;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(557, 43);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label1";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(18, 42);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkEliminar.TabIndex = 5;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.ImageIndex = 6;
            this.btnImprimir.ImageList = this.imgl17x17;
            this.btnImprimir.Location = new System.Drawing.Point(641, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // imgl17x17
            // 
            this.imgl17x17.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl17x17.ImageStream")));
            this.imgl17x17.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl17x17.Images.SetKeyName(0, "android-search_icon-icons.com_50501.ico");
            this.imgl17x17.Images.SetKeyName(1, "1904666-calculate-close-delete-hide-minimize-minus-remove_122516.ico");
            this.imgl17x17.Images.SetKeyName(2, "1491254405-plusaddmoredetail_82972.ico");
            this.imgl17x17.Images.SetKeyName(3, "cancel_96921.ico");
            this.imgl17x17.Images.SetKeyName(4, "353430-checkbox-edit-pen-pencil_107516.ico");
            this.imgl17x17.Images.SetKeyName(5, "save_78935.ico");
            this.imgl17x17.Images.SetKeyName(6, "printer_icon_207595.ico");
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.ImageIndex = 3;
            this.btnEliminar.ImageList = this.imgl17x17;
            this.btnEliminar.Location = new System.Drawing.Point(560, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.ImageIndex = 0;
            this.btnBuscar.ImageList = this.imgl17x17;
            this.btnBuscar.Location = new System.Drawing.Point(479, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(71, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageIndex = 3;
            this.btnCancelar.ImageList = this.imgl17x17;
            this.btnCancelar.Location = new System.Drawing.Point(629, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.ImageIndex = 4;
            this.btnEditar.ImageList = this.imgl17x17;
            this.btnEditar.Location = new System.Drawing.Point(548, 400);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 30);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "E&ditar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.errorIcono.SetIconAlignment(this.btnGuardar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.ImageIndex = 5;
            this.btnGuardar.ImageList = this.imgl17x17;
            this.btnGuardar.Location = new System.Drawing.Point(467, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.ImageIndex = 2;
            this.btnNuevo.ImageList = this.imgl17x17;
            this.btnNuevo.Location = new System.Drawing.Point(386, 400);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 30);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtIdpresentacion
            // 
            this.txtIdpresentacion.Location = new System.Drawing.Point(109, 30);
            this.txtIdpresentacion.Name = "txtIdpresentacion";
            this.txtIdpresentacion.Size = new System.Drawing.Size(158, 20);
            this.txtIdpresentacion.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 82);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(421, 168);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(28, 85);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(66, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(28, 59);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Nombre:";
            // 
            // grpPresentaciones
            // 
            this.grpPresentaciones.Controls.Add(this.btnCancelar);
            this.grpPresentaciones.Controls.Add(this.btnEditar);
            this.grpPresentaciones.Controls.Add(this.btnGuardar);
            this.grpPresentaciones.Controls.Add(this.btnNuevo);
            this.grpPresentaciones.Controls.Add(this.txtNombre);
            this.grpPresentaciones.Controls.Add(this.txtIdpresentacion);
            this.grpPresentaciones.Controls.Add(this.txtDescripcion);
            this.grpPresentaciones.Controls.Add(this.lblDesc);
            this.grpPresentaciones.Controls.Add(this.lblNombre2);
            this.grpPresentaciones.Controls.Add(this.lblCodigo);
            this.grpPresentaciones.Location = new System.Drawing.Point(6, 6);
            this.grpPresentaciones.Name = "grpPresentaciones";
            this.grpPresentaciones.Size = new System.Drawing.Size(710, 436);
            this.grpPresentaciones.TabIndex = 0;
            this.grpPresentaciones.TabStop = false;
            this.grpPresentaciones.Text = "Presentaciones";
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.grpPresentaciones);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(722, 448);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // tabControlPres
            // 
            this.tabControlPres.Controls.Add(this.tabListado);
            this.tabControlPres.Controls.Add(this.tabMantenimiento);
            this.tabControlPres.Location = new System.Drawing.Point(12, 100);
            this.tabControlPres.Name = "tabControlPres";
            this.tabControlPres.SelectedIndex = 0;
            this.tabControlPres.Size = new System.Drawing.Size(730, 474);
            this.tabControlPres.TabIndex = 3;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // lblPresentaciones
            // 
            this.lblPresentaciones.AutoSize = true;
            this.lblPresentaciones.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentaciones.Location = new System.Drawing.Point(98, 0);
            this.lblPresentaciones.Name = "lblPresentaciones";
            this.lblPresentaciones.Size = new System.Drawing.Size(483, 86);
            this.lblPresentaciones.TabIndex = 2;
            this.lblPresentaciones.Text = "Presentaciones";
            this.lblPresentaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // imgl30x30
            // 
            this.imgl30x30.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl30x30.ImageStream")));
            this.imgl30x30.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl30x30.Images.SetKeyName(0, "android-search_icon-icons.com_50501.ico");
            this.imgl30x30.Images.SetKeyName(1, "1904666-calculate-close-delete-hide-minimize-minus-remove_122516.ico");
            this.imgl30x30.Images.SetKeyName(2, "1491254405-plusaddmoredetail_82972.ico");
            // 
            // frmPresentacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControlPres);
            this.Controls.Add(this.lblPresentaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.frmPresentacion_Load);
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.grpPresentaciones.ResumeLayout(false);
            this.grpPresentaciones.PerformLayout();
            this.tabMantenimiento.ResumeLayout(false);
            this.tabControlPres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdpresentacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.GroupBox grpPresentaciones;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.TabControl tabControlPres;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lblPresentaciones;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imgl30x30;
        private System.Windows.Forms.ImageList imgl17x17;
    }
}