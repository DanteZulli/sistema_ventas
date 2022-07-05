namespace CapaPresentacion
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.imgl17x17 = new System.Windows.Forms.ImageList(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtIdproveedor = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.grpProveedores = new System.Windows.Forms.GroupBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboSectorComercial = new System.Windows.Forms.ComboBox();
            this.lblSectorComercial = new System.Windows.Forms.Label();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.tabControlCat = new System.Windows.Forms.TabControl();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblProveedores = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgl30x30 = new System.Windows.Forms.ImageList(this.components);
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.grpProveedores.SuspendLayout();
            this.tabMantenimiento.SuspendLayout();
            this.tabControlCat.SuspendLayout();
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
            this.lblCodigo.Location = new System.Drawing.Point(16, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.cboBuscar);
            this.tabListado.Controls.Add(this.dataListado);
            this.tabListado.Controls.Add(this.lblTotal);
            this.tabListado.Controls.Add(this.chkEliminar);
            this.tabListado.Controls.Add(this.btnImprimir);
            this.tabListado.Controls.Add(this.btnEliminar);
            this.tabListado.Controls.Add(this.btnBuscar);
            this.tabListado.Controls.Add(this.txtBuscar);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(722, 448);
            this.tabListado.TabIndex = 0;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // cboBuscar
            // 
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Documento",
            "Razon Social"});
            this.cboBuscar.Location = new System.Drawing.Point(18, 14);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(92, 21);
            this.cboBuscar.TabIndex = 8;
            this.cboBuscar.Text = "Razon Social";
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
            this.lblTotal.Location = new System.Drawing.Point(378, 46);
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
            this.btnImprimir.Location = new System.Drawing.Point(641, 8);
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
            this.btnEliminar.Location = new System.Drawing.Point(560, 8);
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
            this.btnBuscar.Location = new System.Drawing.Point(479, 8);
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
            this.txtBuscar.Location = new System.Drawing.Point(115, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 1;
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
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(116, 65);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(176, 20);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // txtIdproveedor
            // 
            this.txtIdproveedor.Location = new System.Drawing.Point(116, 39);
            this.txtIdproveedor.Name = "txtIdproveedor";
            this.txtIdproveedor.Size = new System.Drawing.Size(176, 20);
            this.txtIdproveedor.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 119);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(16, 68);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // grpProveedores
            // 
            this.grpProveedores.Controls.Add(this.txtUrl);
            this.grpProveedores.Controls.Add(this.lblUrl);
            this.grpProveedores.Controls.Add(this.txtEmail);
            this.grpProveedores.Controls.Add(this.lblEmail);
            this.grpProveedores.Controls.Add(this.txtTelefono);
            this.grpProveedores.Controls.Add(this.lblTelefono);
            this.grpProveedores.Controls.Add(this.txtDireccion);
            this.grpProveedores.Controls.Add(this.lblNumeroDocumento);
            this.grpProveedores.Controls.Add(this.txtNumDocumento);
            this.grpProveedores.Controls.Add(this.cboTipoDocumento);
            this.grpProveedores.Controls.Add(this.lblTipoDocumento);
            this.grpProveedores.Controls.Add(this.cboSectorComercial);
            this.grpProveedores.Controls.Add(this.btnEditar);
            this.grpProveedores.Controls.Add(this.lblSectorComercial);
            this.grpProveedores.Controls.Add(this.btnCancelar);
            this.grpProveedores.Controls.Add(this.txtRazonSocial);
            this.grpProveedores.Controls.Add(this.btnNuevo);
            this.grpProveedores.Controls.Add(this.txtIdproveedor);
            this.grpProveedores.Controls.Add(this.btnGuardar);
            this.grpProveedores.Controls.Add(this.lblDireccion);
            this.grpProveedores.Controls.Add(this.lblRazonSocial);
            this.grpProveedores.Controls.Add(this.lblCodigo);
            this.grpProveedores.Location = new System.Drawing.Point(6, 6);
            this.grpProveedores.Name = "grpProveedores";
            this.grpProveedores.Size = new System.Drawing.Size(710, 436);
            this.grpProveedores.TabIndex = 0;
            this.grpProveedores.TabStop = false;
            this.grpProveedores.Text = "Proveedores";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(116, 194);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(176, 20);
            this.txtUrl.TabIndex = 22;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(16, 197);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(23, 13);
            this.lblUrl.TabIndex = 21;
            this.lblUrl.Text = "Url:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 171);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(116, 142);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(176, 20);
            this.txtTelefono.TabIndex = 18;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(16, 145);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(116, 116);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(176, 20);
            this.txtDireccion.TabIndex = 16;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(316, 94);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(105, 13);
            this.lblNumeroDocumento.TabIndex = 15;
            this.lblNumeroDocumento.Text = "Numero Documento:";
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Location = new System.Drawing.Point(427, 91);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(175, 20);
            this.txtNumDocumento.TabIndex = 14;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Dni",
            "Pasaporte",
            "RUC",
            "No sabe no contesta"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(116, 90);
            this.cboTipoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(176, 21);
            this.cboTipoDocumento.TabIndex = 13;
            this.cboTipoDocumento.Text = "Dni";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(16, 93);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumento.TabIndex = 12;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // cboSectorComercial
            // 
            this.cboSectorComercial.FormattingEnabled = true;
            this.cboSectorComercial.Items.AddRange(new object[] {
            "Salud",
            "Alimentos",
            "Tecnologia",
            "Indumentaria",
            "Servicios",
            "Otro"});
            this.cboSectorComercial.Location = new System.Drawing.Point(426, 64);
            this.cboSectorComercial.Margin = new System.Windows.Forms.Padding(2);
            this.cboSectorComercial.Name = "cboSectorComercial";
            this.cboSectorComercial.Size = new System.Drawing.Size(176, 21);
            this.cboSectorComercial.TabIndex = 11;
            // 
            // lblSectorComercial
            // 
            this.lblSectorComercial.AutoSize = true;
            this.lblSectorComercial.Location = new System.Drawing.Point(316, 68);
            this.lblSectorComercial.Name = "lblSectorComercial";
            this.lblSectorComercial.Size = new System.Drawing.Size(90, 13);
            this.lblSectorComercial.TabIndex = 10;
            this.lblSectorComercial.Text = "Sector Comercial:";
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.grpProveedores);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(722, 448);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // tabControlCat
            // 
            this.tabControlCat.Controls.Add(this.tabListado);
            this.tabControlCat.Controls.Add(this.tabMantenimiento);
            this.tabControlCat.Location = new System.Drawing.Point(12, 100);
            this.tabControlCat.Name = "tabControlCat";
            this.tabControlCat.SelectedIndex = 0;
            this.tabControlCat.Size = new System.Drawing.Size(730, 474);
            this.tabControlCat.TabIndex = 3;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(98, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(402, 86);
            this.lblProveedores.TabIndex = 2;
            this.lblProveedores.Text = "Proveedores";
            this.lblProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frmProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControlCat);
            this.Controls.Add(this.lblProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.grpProveedores.ResumeLayout(false);
            this.grpProveedores.PerformLayout();
            this.tabMantenimiento.ResumeLayout(false);
            this.tabControlCat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtIdproveedor;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.GroupBox grpProveedores;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboSectorComercial;
        private System.Windows.Forms.Label lblSectorComercial;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.TabControl tabControlCat;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imgl17x17;
        private System.Windows.Forms.ImageList imgl30x30;
    }
}