using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmProveedor : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public frmProveedor()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtRazonSocial, "Ingrese Razon Social del proveedor");
            this.ttMensaje.SetToolTip(this.txtNumDocumento, "Ingrese Numero de documento del proveedor");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion del proveedor");
        }
        //Mensaje de confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo para limpiar controles del formulario
        private void Limpiar()
        {
            this.txtRazonSocial.Text = string.Empty;
            this.txtNumDocumento.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtUrl.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtIdproveedor.Text = string.Empty;
        }

        //Método para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtRazonSocial.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.cboSectorComercial.Enabled = valor;
            this.cboTipoDocumento.Enabled = valor;
            this.txtNumDocumento.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtUrl.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtIdproveedor.ReadOnly = !valor;

        }

        //Habilitar botones o deshabilitarlos
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //Método ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }
        //Método mostrar registros
        private void Mostrar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);

        }
        //Método BuscarRazonSocial
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazon_Social(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);

        }
        //Método Buscar num Documento
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = NProveedor.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);

        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboBuscar.Text.Equals("Razon Social"))
            {
                this.BuscarRazon_Social();
            }
            else if (cboBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Boton eliminar
            try
            {
                //Le doy la opcion de arrepentirse por si missclickeo
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea ELIMINAR los registros", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string codigo;
                    string Rpta = "";

                    //Acá se genera una CADENA ENORME que recorre todos los métodos, elementos y procedimientos almacenados para eliminar algo
                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Se consigue la llave primaria de la categoria a eliminar
                            codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NProveedor.Eliminar(Convert.ToInt32(codigo));

                            //Evaluamos si se elimino
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó correctamente el registro");
                                chkEliminar.Checked = false;


                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    //Para mostrar los cambios
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); //El mensaje MÁS el final de la linea
            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            //ChkBox para eliminar listados de una
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtRazonSocial.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                //Comprueba la caja de texto
                if (this.txtRazonSocial.Text == string.Empty || this.txtNumDocumento.Text == string.Empty || this.txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtRazonSocial, "Revise el valor");
                    errorIcono.SetError(txtNumDocumento, "Revise el valor");
                    errorIcono.SetError(txtDireccion, "Revise el valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NProveedor.Insertar(this.txtRazonSocial.Text.Trim().ToUpper(), this.cboSectorComercial.Text,cboTipoDocumento.Text,txtNumDocumento.Text,txtDireccion.Text,txtTelefono.Text,txtEmail.Text,txtUrl.Text);
                    }
                    else //Si no es nuevo, es editar
                    {
                        rpta = NProveedor.Editar(Convert.ToInt32(this.txtIdproveedor.Text), this.txtRazonSocial.Text.Trim().ToUpper(), this.cboSectorComercial.Text, cboTipoDocumento.Text, txtNumDocumento.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtUrl.Text);
                    }

                    //Analiza la respuesta, si es OK...
                    if (rpta.Equals("OK"))
                    {//Analiza a que proceso corresponde
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    //Re acomodo mis métodos
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdproveedor.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdproveedor.Text = string.Empty;
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento cell content click para la casilla eliminar
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            //Al hacer doble click en un listado, sus datos se pasarán al área de mantenimiento para editarlos rapidamente
            this.txtIdproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            this.txtRazonSocial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            this.cboSectorComercial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sector_comercial"].Value);
            this.cboTipoDocumento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value);
            this.txtNumDocumento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_documento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.txtUrl.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["url"].Value);
            this.tabControlCat.SelectedIndex = 1;
        }
    }
}
