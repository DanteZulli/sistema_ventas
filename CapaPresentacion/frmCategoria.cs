using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Importar Capa Negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {   
        //Variabels de registro/edicion
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmCategoria()
        {
            InitializeComponent();
            //Mensaje de Ayuda
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre de la Categoría");

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
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdcategoria.Text = string.Empty;

        }

        //Método para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtIdcategoria.ReadOnly = !valor;

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
            this.dataListado.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);

        }
        //Método BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NCategoria.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            //Alineacion
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Se aclaran las cosas bue
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try{
                string rpta = "";
                //Comprueba la caja de texto
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre,"Ingrese un Nombre");
                }
                else
                {
                    if(this.IsNuevo){
                        rpta = NCategoria.Insertar(this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim());
                    }
                    else //Si no es nuevo, es editar
                    {
                        rpta = NCategoria.Editar(Convert.ToInt32(this.txtIdcategoria.Text),this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim());
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
                    this.IsEditar=false;
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
            if (!this.txtIdcategoria.Text.Equals(""))
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

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            //Al hacer doble click en un listado, sus datos se pasarán al área de mantenimiento para editarlos rapidamente
            this.txtIdcategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);

            this.tabControlCat.SelectedIndex = 1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento cell content click para la casilla eliminar
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                //El código declara una variable y junta toda la fila a eliminar ahi para que despues sea borrada
                //IMPORTANTE = Revisar mayúsculas y minúsculas. Acá tambien me confundí. NOTA: Pensar nombres para las variables que no sean solo
                //un cambio de letra a mayúscula xd
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

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
                            Rpta = NCategoria.Eliminar(Convert.ToInt32(codigo));

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); //El mensaje MÁS el final de la linea
            }
        }
    }
}
