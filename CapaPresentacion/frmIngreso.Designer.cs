namespace CapaPresentacion
{
    partial class frmIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.lblIngresos = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.imgl30x30 = new System.Windows.Forms.ImageList(this.components);
            this.txtIdproveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.grpIngresos = new System.Windows.Forms.GroupBox();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.txtIdarticulo = new System.Windows.Forms.TextBox();
            this.dataListadoDetalle = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFecVenc = new System.Windows.Forms.Label();
            this.dtpProduccion = new System.Windows.Forms.DateTimePicker();
            this.lblFecProd = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.lblIGV = new System.Windows.Forms.Label();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblNumcomprobante = new System.Windows.Forms.Label();
            this.cboComprobante = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imgl17x17 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtIdingreso = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.tabControlArt = new System.Windows.Forms.TabControl();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.grpIngresos.SuspendLayout();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.tabMantenimiento.SuspendLayout();
            this.tabControlArt.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(98, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(285, 86);
            this.lblIngresos.TabIndex = 6;
            this.lblIngresos.Text = "Ingresos";
            this.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.ImageIndex = 0;
            this.btnBuscarProveedor.ImageList = this.imgl30x30;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(409, 15);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(45, 45);
            this.btnBuscarProveedor.TabIndex = 19;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // imgl30x30
            // 
            this.imgl30x30.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl30x30.ImageStream")));
            this.imgl30x30.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl30x30.Images.SetKeyName(0, "android-search_icon-icons.com_50501.ico");
            this.imgl30x30.Images.SetKeyName(1, "1904666-calculate-close-delete-hide-minimize-minus-remove_122516.ico");
            this.imgl30x30.Images.SetKeyName(2, "1491254405-plusaddmoredetail_82972.ico");
            // 
            // txtIdproveedor
            // 
            this.txtIdproveedor.Location = new System.Drawing.Point(325, 15);
            this.txtIdproveedor.Name = "txtIdproveedor";
            this.txtIdproveedor.Size = new System.Drawing.Size(56, 20);
            this.txtIdproveedor.TabIndex = 18;
            this.txtIdproveedor.TextChanged += new System.EventHandler(this.txtIdproveedor_TextChanged);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(260, 41);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 17;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // grpIngresos
            // 
            this.grpIngresos.Controls.Add(this.lblTotalPagado);
            this.grpIngresos.Controls.Add(this.lblDinero);
            this.grpIngresos.Controls.Add(this.grpDetalles);
            this.grpIngresos.Controls.Add(this.txtIGV);
            this.grpIngresos.Controls.Add(this.lblIGV);
            this.grpIngresos.Controls.Add(this.txtCorrelativo);
            this.grpIngresos.Controls.Add(this.txtSerie);
            this.grpIngresos.Controls.Add(this.lblNumcomprobante);
            this.grpIngresos.Controls.Add(this.cboComprobante);
            this.grpIngresos.Controls.Add(this.dtpFecha);
            this.grpIngresos.Controls.Add(this.lblFecha);
            this.grpIngresos.Controls.Add(this.btnBuscarProveedor);
            this.grpIngresos.Controls.Add(this.txtIdproveedor);
            this.grpIngresos.Controls.Add(this.lblProveedor);
            this.grpIngresos.Controls.Add(this.txtProveedor);
            this.grpIngresos.Controls.Add(this.lblComprobante);
            this.grpIngresos.Controls.Add(this.btnCancelar);
            this.grpIngresos.Controls.Add(this.btnGuardar);
            this.grpIngresos.Controls.Add(this.btnNuevo);
            this.grpIngresos.Controls.Add(this.txtIdingreso);
            this.grpIngresos.Controls.Add(this.lblCodigo);
            this.grpIngresos.Location = new System.Drawing.Point(15, 21);
            this.grpIngresos.Name = "grpIngresos";
            this.grpIngresos.Size = new System.Drawing.Size(708, 423);
            this.grpIngresos.TabIndex = 0;
            this.grpIngresos.TabStop = false;
            this.grpIngresos.Text = "Ingresos";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Location = new System.Drawing.Point(94, 380);
            this.lblTotalPagado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(22, 13);
            this.lblTotalPagado.TabIndex = 48;
            this.lblTotalPagado.Text = "0.0";
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(16, 380);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(74, 13);
            this.lblDinero.TabIndex = 47;
            this.lblDinero.Text = "Total Pagado:";
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.txtIdarticulo);
            this.grpDetalles.Controls.Add(this.dataListadoDetalle);
            this.grpDetalles.Controls.Add(this.btnQuitar);
            this.grpDetalles.Controls.Add(this.btnAgregar);
            this.grpDetalles.Controls.Add(this.dtpVencimiento);
            this.grpDetalles.Controls.Add(this.lblFecVenc);
            this.grpDetalles.Controls.Add(this.dtpProduccion);
            this.grpDetalles.Controls.Add(this.lblFecProd);
            this.grpDetalles.Controls.Add(this.txtPrecioCompra);
            this.grpDetalles.Controls.Add(this.lblPrecioCompra);
            this.grpDetalles.Controls.Add(this.txtPrecioVenta);
            this.grpDetalles.Controls.Add(this.lblPrecioVenta);
            this.grpDetalles.Controls.Add(this.txtStock);
            this.grpDetalles.Controls.Add(this.lblStockInicial);
            this.grpDetalles.Controls.Add(this.btnBuscarArticulo);
            this.grpDetalles.Controls.Add(this.txtArticulo);
            this.grpDetalles.Controls.Add(this.lblArticulo);
            this.grpDetalles.Location = new System.Drawing.Point(5, 99);
            this.grpDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.grpDetalles.Size = new System.Drawing.Size(697, 279);
            this.grpDetalles.TabIndex = 30;
            this.grpDetalles.TabStop = false;
            // 
            // txtIdarticulo
            // 
            this.txtIdarticulo.Location = new System.Drawing.Point(73, 19);
            this.txtIdarticulo.Name = "txtIdarticulo";
            this.txtIdarticulo.Size = new System.Drawing.Size(56, 20);
            this.txtIdarticulo.TabIndex = 49;
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.AllowUserToAddRows = false;
            this.dataListadoDetalle.AllowUserToDeleteRows = false;
            this.dataListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalle.Location = new System.Drawing.Point(8, 102);
            this.dataListadoDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.RowTemplate.Height = 24;
            this.dataListadoDetalle.Size = new System.Drawing.Size(636, 171);
            this.dataListadoDetalle.TabIndex = 46;
            // 
            // btnQuitar
            // 
            this.btnQuitar.ImageIndex = 1;
            this.btnQuitar.ImageList = this.imgl30x30;
            this.btnQuitar.Location = new System.Drawing.Point(648, 151);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(45, 45);
            this.btnQuitar.TabIndex = 45;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageIndex = 2;
            this.btnAgregar.ImageList = this.imgl30x30;
            this.btnAgregar.Location = new System.Drawing.Point(648, 102);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 45);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(529, 68);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(105, 20);
            this.dtpVencimiento.TabIndex = 43;
            // 
            // lblFecVenc
            // 
            this.lblFecVenc.AutoSize = true;
            this.lblFecVenc.Location = new System.Drawing.Point(430, 71);
            this.lblFecVenc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecVenc.Name = "lblFecVenc";
            this.lblFecVenc.Size = new System.Drawing.Size(100, 13);
            this.lblFecVenc.TabIndex = 42;
            this.lblFecVenc.Text = "Fecha vencimiento:";
            // 
            // dtpProduccion
            // 
            this.dtpProduccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProduccion.Location = new System.Drawing.Point(529, 43);
            this.dtpProduccion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpProduccion.Name = "dtpProduccion";
            this.dtpProduccion.Size = new System.Drawing.Size(105, 20);
            this.dtpProduccion.TabIndex = 40;
            // 
            // lblFecProd
            // 
            this.lblFecProd.AutoSize = true;
            this.lblFecProd.Location = new System.Drawing.Point(430, 46);
            this.lblFecProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecProd.Name = "lblFecProd";
            this.lblFecProd.Size = new System.Drawing.Size(96, 13);
            this.lblFecProd.TabIndex = 39;
            this.lblFecProd.Text = "Fecha produccion:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(317, 43);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompra.TabIndex = 38;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(238, 44);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(78, 13);
            this.lblPrecioCompra.TabIndex = 37;
            this.lblPrecioCompra.Text = "Precio compra:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(317, 68);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 36;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(238, 71);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(70, 13);
            this.lblPrecioVenta.TabIndex = 35;
            this.lblPrecioVenta.Text = "Precio venta:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(73, 67);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 32;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Location = new System.Drawing.Point(6, 70);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(68, 13);
            this.lblStockInicial.TabIndex = 31;
            this.lblStockInicial.Text = "Stock Inicial:";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.ImageIndex = 0;
            this.btnBuscarArticulo.ImageList = this.imgl30x30;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(178, 19);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(45, 45);
            this.btnBuscarArticulo.TabIndex = 34;
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(73, 43);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 31;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(6, 46);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(45, 13);
            this.lblArticulo.TabIndex = 32;
            this.lblArticulo.Text = "Articulo:";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(554, 65);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(40, 20);
            this.txtIGV.TabIndex = 29;
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Location = new System.Drawing.Point(522, 67);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(28, 13);
            this.lblIGV.TabIndex = 28;
            this.lblIGV.Text = "IGV:";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Location = new System.Drawing.Point(401, 65);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(40, 20);
            this.txtCorrelativo.TabIndex = 27;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(356, 65);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(40, 20);
            this.txtSerie.TabIndex = 26;
            // 
            // lblNumcomprobante
            // 
            this.lblNumcomprobante.AutoSize = true;
            this.lblNumcomprobante.Location = new System.Drawing.Point(260, 65);
            this.lblNumcomprobante.Name = "lblNumcomprobante";
            this.lblNumcomprobante.Size = new System.Drawing.Size(98, 13);
            this.lblNumcomprobante.TabIndex = 25;
            this.lblNumcomprobante.Text = "Num Comprobante:";
            // 
            // cboComprobante
            // 
            this.cboComprobante.FormattingEnabled = true;
            this.cboComprobante.Items.AddRange(new object[] {
            "TICKET",
            "BOLETA",
            "FACTURA",
            "GUIA REMISION"});
            this.cboComprobante.Location = new System.Drawing.Point(109, 63);
            this.cboComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.cboComprobante.Name = "cboComprobante";
            this.cboComprobante.Size = new System.Drawing.Size(100, 21);
            this.cboComprobante.TabIndex = 24;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(554, 39);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(105, 20);
            this.dtpFecha.TabIndex = 23;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(473, 41);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(77, 13);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha ingreso:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(325, 39);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(79, 20);
            this.txtProveedor.TabIndex = 16;
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Location = new System.Drawing.Point(16, 65);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(73, 13);
            this.lblComprobante.TabIndex = 10;
            this.lblComprobante.Text = "Comprobante:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageIndex = 3;
            this.btnCancelar.ImageList = this.imgl17x17;
            this.btnCancelar.Location = new System.Drawing.Point(627, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.ImageIndex = 5;
            this.btnGuardar.ImageList = this.imgl17x17;
            this.btnGuardar.Location = new System.Drawing.Point(546, 387);
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
            this.btnNuevo.Location = new System.Drawing.Point(465, 387);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 30);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIdingreso
            // 
            this.txtIdingreso.Location = new System.Drawing.Point(109, 39);
            this.txtIdingreso.Name = "txtIdingreso";
            this.txtIdingreso.Size = new System.Drawing.Size(100, 20);
            this.txtIdingreso.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.grpIngresos);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(727, 448);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // tabControlArt
            // 
            this.tabControlArt.Controls.Add(this.tabListado);
            this.tabControlArt.Controls.Add(this.tabMantenimiento);
            this.tabControlArt.Location = new System.Drawing.Point(10, 101);
            this.tabControlArt.Name = "tabControlArt";
            this.tabControlArt.SelectedIndex = 0;
            this.tabControlArt.Size = new System.Drawing.Size(735, 474);
            this.tabControlArt.TabIndex = 7;
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.lblFechaFin);
            this.tabListado.Controls.Add(this.lblFechaInicio);
            this.tabListado.Controls.Add(this.dtpFechaFin);
            this.tabListado.Controls.Add(this.dtpFechaInicio);
            this.tabListado.Controls.Add(this.dataListado);
            this.tabListado.Controls.Add(this.lblTotal);
            this.tabListado.Controls.Add(this.chkAnular);
            this.tabListado.Controls.Add(this.btnImprimir);
            this.tabListado.Controls.Add(this.btnAnular);
            this.tabListado.Controls.Add(this.btnBuscar);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(727, 448);
            this.tabListado.TabIndex = 0;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(143, 16);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(72, 13);
            this.lblFechaFin.TabIndex = 11;
            this.lblFechaFin.Text = "Fecha de Fin:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(7, 16);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(146, 32);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaFin.TabIndex = 9;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(9, 32);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaInicio.TabIndex = 8;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(9, 80);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(714, 365);
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
            this.lblTotal.Location = new System.Drawing.Point(562, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label1";
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Location = new System.Drawing.Point(9, 56);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(56, 17);
            this.chkAnular.TabIndex = 5;
            this.chkAnular.Text = "Anular";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.CheckedChanged += new System.EventHandler(this.chkAnular_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.ImageIndex = 6;
            this.btnImprimir.ImageList = this.imgl17x17;
            this.btnImprimir.Location = new System.Drawing.Point(646, 11);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.ImageIndex = 3;
            this.btnAnular.ImageList = this.imgl17x17;
            this.btnAnular.Location = new System.Drawing.Point(565, 11);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 30);
            this.btnAnular.TabIndex = 3;
            this.btnAnular.Text = "&Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.ImageIndex = 0;
            this.btnBuscar.ImageList = this.imgl17x17;
            this.btnBuscar.Location = new System.Drawing.Point(484, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frmIngreso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.tabControlArt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingresos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIngreso_FormClosing);
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.grpIngresos.ResumeLayout(false);
            this.grpIngresos.PerformLayout();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.tabMantenimiento.ResumeLayout(false);
            this.tabControlArt.ResumeLayout(false);
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabControlArt;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.GroupBox grpIngresos;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtIdproveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtIdingreso;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblTotalPagado;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.DataGridView dataListadoDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label lblFecVenc;
        private System.Windows.Forms.DateTimePicker dtpProduccion;
        private System.Windows.Forms.Label lblFecProd;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblNumcomprobante;
        private System.Windows.Forms.ComboBox cboComprobante;
        private System.Windows.Forms.TextBox txtIdarticulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imgl17x17;
        private System.Windows.Forms.ImageList imgl30x30;
    }
}