namespace CapaPresentacion
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.imgl30x30 = new System.Windows.Forms.ImageList(this.components);
            this.lblArticulo = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.grpVentas = new System.Windows.Forms.GroupBox();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtIdarticulo = new System.Windows.Forms.TextBox();
            this.dataListadoDetalle = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFecVenc = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblIGV = new System.Windows.Forms.Label();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblNumcomprobante = new System.Windows.Forms.Label();
            this.cboComprobante = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtIdcliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imgl17x17 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtIdventa = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabControlArt = new System.Windows.Forms.TabControl();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblVentas = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabMantenimiento.SuspendLayout();
            this.grpVentas.SuspendLayout();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.tabControlArt.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.ImageIndex = 0;
            this.btnBuscarArticulo.ImageList = this.imgl30x30;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(158, 19);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(45, 45);
            this.btnBuscarArticulo.TabIndex = 34;
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // imgl30x30
            // 
            this.imgl30x30.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl30x30.ImageStream")));
            this.imgl30x30.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl30x30.Images.SetKeyName(0, "android-search_icon-icons.com_50501.ico");
            this.imgl30x30.Images.SetKeyName(1, "1904666-calculate-close-delete-hide-minimize-minus-remove_122516.ico");
            this.imgl30x30.Images.SetKeyName(2, "1491254405-plusaddmoredetail_82972.ico");
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(10, 46);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(45, 13);
            this.lblArticulo.TabIndex = 32;
            this.lblArticulo.Text = "Articulo:";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(604, 70);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(40, 20);
            this.txtIGV.TabIndex = 29;
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.grpVentas);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(722, 448);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // grpVentas
            // 
            this.grpVentas.Controls.Add(this.lblTotalPagado);
            this.grpVentas.Controls.Add(this.lblDinero);
            this.grpVentas.Controls.Add(this.grpDetalles);
            this.grpVentas.Controls.Add(this.txtIGV);
            this.grpVentas.Controls.Add(this.lblIGV);
            this.grpVentas.Controls.Add(this.txtCorrelativo);
            this.grpVentas.Controls.Add(this.txtSerie);
            this.grpVentas.Controls.Add(this.lblNumcomprobante);
            this.grpVentas.Controls.Add(this.cboComprobante);
            this.grpVentas.Controls.Add(this.dtpFecha);
            this.grpVentas.Controls.Add(this.lblFecha);
            this.grpVentas.Controls.Add(this.btnBuscarCliente);
            this.grpVentas.Controls.Add(this.txtIdcliente);
            this.grpVentas.Controls.Add(this.lblCliente);
            this.grpVentas.Controls.Add(this.txtCliente);
            this.grpVentas.Controls.Add(this.lblComprobante);
            this.grpVentas.Controls.Add(this.btnCancelar);
            this.grpVentas.Controls.Add(this.btnGuardar);
            this.grpVentas.Controls.Add(this.btnNuevo);
            this.grpVentas.Controls.Add(this.txtIdventa);
            this.grpVentas.Controls.Add(this.lblCodigo);
            this.grpVentas.Location = new System.Drawing.Point(6, 6);
            this.grpVentas.Name = "grpVentas";
            this.grpVentas.Size = new System.Drawing.Size(710, 436);
            this.grpVentas.TabIndex = 0;
            this.grpVentas.TabStop = false;
            this.grpVentas.Text = "Ventas";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Location = new System.Drawing.Point(95, 409);
            this.lblTotalPagado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(22, 13);
            this.lblTotalPagado.TabIndex = 48;
            this.lblTotalPagado.Text = "0.0";
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(16, 409);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(74, 13);
            this.lblDinero.TabIndex = 47;
            this.lblDinero.Text = "Total Pagado:";
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.txtDescuento);
            this.grpDetalles.Controls.Add(this.lblDescuento);
            this.grpDetalles.Controls.Add(this.txtStockActual);
            this.grpDetalles.Controls.Add(this.txtIdarticulo);
            this.grpDetalles.Controls.Add(this.dataListadoDetalle);
            this.grpDetalles.Controls.Add(this.btnQuitar);
            this.grpDetalles.Controls.Add(this.btnAgregar);
            this.grpDetalles.Controls.Add(this.dtpVencimiento);
            this.grpDetalles.Controls.Add(this.lblFecVenc);
            this.grpDetalles.Controls.Add(this.txtPrecioCompra);
            this.grpDetalles.Controls.Add(this.lblPrecioCompra);
            this.grpDetalles.Controls.Add(this.txtPrecioVenta);
            this.grpDetalles.Controls.Add(this.lblPrecioVenta);
            this.grpDetalles.Controls.Add(this.txtCantidad);
            this.grpDetalles.Controls.Add(this.lblCantidad);
            this.grpDetalles.Controls.Add(this.btnBuscarArticulo);
            this.grpDetalles.Controls.Add(this.txtArticulo);
            this.grpDetalles.Controls.Add(this.lblArticulo);
            this.grpDetalles.Location = new System.Drawing.Point(19, 99);
            this.grpDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.grpDetalles.Size = new System.Drawing.Size(685, 296);
            this.grpDetalles.TabIndex = 30;
            this.grpDetalles.TabStop = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(529, 61);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(138, 20);
            this.txtDescuento.TabIndex = 52;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(426, 65);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 51;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(119, 73);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(84, 20);
            this.txtStockActual.TabIndex = 50;
            // 
            // txtIdarticulo
            // 
            this.txtIdarticulo.Location = new System.Drawing.Point(74, 18);
            this.txtIdarticulo.Name = "txtIdarticulo";
            this.txtIdarticulo.Size = new System.Drawing.Size(56, 20);
            this.txtIdarticulo.TabIndex = 49;
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.AllowUserToAddRows = false;
            this.dataListadoDetalle.AllowUserToDeleteRows = false;
            this.dataListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalle.Location = new System.Drawing.Point(4, 102);
            this.dataListadoDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.RowTemplate.Height = 24;
            this.dataListadoDetalle.Size = new System.Drawing.Size(628, 190);
            this.dataListadoDetalle.TabIndex = 46;
            // 
            // btnQuitar
            // 
            this.btnQuitar.ImageIndex = 1;
            this.btnQuitar.ImageList = this.imgl30x30;
            this.btnQuitar.Location = new System.Drawing.Point(636, 151);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(45, 45);
            this.btnQuitar.TabIndex = 45;
            this.btnQuitar.Text = " ";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageIndex = 2;
            this.btnAgregar.ImageList = this.imgl30x30;
            this.btnAgregar.Location = new System.Drawing.Point(636, 102);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 45);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = " ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(533, 36);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(134, 20);
            this.dtpVencimiento.TabIndex = 43;
            // 
            // lblFecVenc
            // 
            this.lblFecVenc.AutoSize = true;
            this.lblFecVenc.Location = new System.Drawing.Point(426, 39);
            this.lblFecVenc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecVenc.Name = "lblFecVenc";
            this.lblFecVenc.Size = new System.Drawing.Size(97, 13);
            this.lblFecVenc.TabIndex = 42;
            this.lblFecVenc.Text = "Fecha vencimiento";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(300, 36);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompra.TabIndex = 38;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(220, 43);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(78, 13);
            this.lblPrecioCompra.TabIndex = 37;
            this.lblPrecioCompra.Text = "Precio compra:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(300, 62);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 36;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(220, 65);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(70, 13);
            this.lblPrecioVenta.TabIndex = 35;
            this.lblPrecioVenta.Text = "Precio venta:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(73, 73);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(40, 20);
            this.txtCantidad.TabIndex = 32;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(10, 76);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 31;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(74, 43);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(79, 20);
            this.txtArticulo.TabIndex = 31;
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Location = new System.Drawing.Point(573, 72);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(25, 13);
            this.lblIGV.TabIndex = 28;
            this.lblIGV.Text = "IGV";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Location = new System.Drawing.Point(489, 69);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(78, 20);
            this.txtCorrelativo.TabIndex = 27;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(375, 69);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(108, 20);
            this.txtSerie.TabIndex = 26;
            // 
            // lblNumcomprobante
            // 
            this.lblNumcomprobante.AutoSize = true;
            this.lblNumcomprobante.Location = new System.Drawing.Point(271, 72);
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
            this.cboComprobante.Location = new System.Drawing.Point(115, 69);
            this.cboComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.cboComprobante.Name = "cboComprobante";
            this.cboComprobante.Size = new System.Drawing.Size(132, 21);
            this.cboComprobante.TabIndex = 24;
            this.cboComprobante.Text = "FACTURA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(552, 39);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(134, 20);
            this.dtpFecha.TabIndex = 23;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(474, 42);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 13);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha ingreso";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.ImageIndex = 0;
            this.btnBuscarCliente.ImageList = this.imgl30x30;
            this.btnBuscarCliente.Location = new System.Drawing.Point(409, 15);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 45);
            this.btnBuscarCliente.TabIndex = 19;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtIdcliente
            // 
            this.txtIdcliente.Location = new System.Drawing.Point(325, 15);
            this.txtIdcliente.Name = "txtIdcliente";
            this.txtIdcliente.Size = new System.Drawing.Size(56, 20);
            this.txtIdcliente.TabIndex = 18;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(271, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 17;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(325, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(79, 20);
            this.txtCliente.TabIndex = 16;
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Location = new System.Drawing.Point(20, 72);
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
            this.btnCancelar.Location = new System.Drawing.Point(629, 400);
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
            this.btnGuardar.Location = new System.Drawing.Point(548, 400);
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
            this.btnNuevo.Location = new System.Drawing.Point(467, 400);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 30);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIdventa
            // 
            this.txtIdventa.Location = new System.Drawing.Point(115, 39);
            this.txtIdventa.Name = "txtIdventa";
            this.txtIdventa.Size = new System.Drawing.Size(132, 20);
            this.txtIdventa.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tabControlArt
            // 
            this.tabControlArt.Controls.Add(this.tabListado);
            this.tabControlArt.Controls.Add(this.tabMantenimiento);
            this.tabControlArt.Location = new System.Drawing.Point(12, 100);
            this.tabControlArt.Name = "tabControlArt";
            this.tabControlArt.SelectedIndex = 0;
            this.tabControlArt.Size = new System.Drawing.Size(730, 474);
            this.tabControlArt.TabIndex = 9;
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.btnComprobante);
            this.tabListado.Controls.Add(this.lblFechaFin);
            this.tabListado.Controls.Add(this.lblFechaInicio);
            this.tabListado.Controls.Add(this.dtpFechaFin);
            this.tabListado.Controls.Add(this.dtpFechaInicio);
            this.tabListado.Controls.Add(this.dataListado);
            this.tabListado.Controls.Add(this.lblTotal);
            this.tabListado.Controls.Add(this.chkEliminar);
            this.tabListado.Controls.Add(this.btnImprimir);
            this.tabListado.Controls.Add(this.btnEliminar);
            this.tabListado.Controls.Add(this.btnBuscar);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(722, 448);
            this.tabListado.TabIndex = 0;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // btnComprobante
            // 
            this.btnComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobante.ImageIndex = 6;
            this.btnComprobante.ImageList = this.imgl17x17;
            this.btnComprobante.Location = new System.Drawing.Point(619, 11);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(97, 30);
            this.btnComprobante.TabIndex = 12;
            this.btnComprobante.Text = "&Comprobante";
            this.btnComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprobante.UseVisualStyleBackColor = true;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(143, 11);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 11;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 11);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(146, 26);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(108, 20);
            this.dtpFechaFin.TabIndex = 9;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(9, 26);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(108, 20);
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
            this.dataListado.Location = new System.Drawing.Point(9, 74);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(707, 368);
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
            this.lblTotal.Location = new System.Drawing.Point(454, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label1";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(9, 51);
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
            this.btnImprimir.Location = new System.Drawing.Point(538, 11);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.ImageIndex = 3;
            this.btnEliminar.ImageList = this.imgl17x17;
            this.btnEliminar.Location = new System.Drawing.Point(457, 11);
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
            this.btnBuscar.Location = new System.Drawing.Point(376, 11);
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
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(98, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(241, 86);
            this.lblVentas.TabIndex = 8;
            this.lblVentas.Text = "Ventas";
            this.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // frmVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControlArt);
            this.Controls.Add(this.lblVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.tabMantenimiento.ResumeLayout(false);
            this.grpVentas.ResumeLayout(false);
            this.grpVentas.PerformLayout();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.tabControlArt.ResumeLayout(false);
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.GroupBox grpVentas;
        private System.Windows.Forms.Label lblTotalPagado;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtIdarticulo;
        private System.Windows.Forms.DataGridView dataListadoDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label lblFecVenc;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblNumcomprobante;
        private System.Windows.Forms.ComboBox cboComprobante;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtIdcliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtIdventa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabControl tabControlArt;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imgl30x30;
        private System.Windows.Forms.ImageList imgl17x17;
    }
}