using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();

        }

        private void grpAcceso_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Crear un DataTable que reciba los datos resultantes de mi metodo login
            DataTable Datos = CapaNegocio.NTrabajador.Login(this.txtUsuario.Text,this.txtPassword.Text);
            //Evaluar la existencia del usuario
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene acceso ya que el usuario no existe", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Creo mi objeto y le asigno valores a las variables que cree
                frmPrincipal frm = new frmPrincipal();
                frm.Idtrabajador = Datos.Rows[0][0].ToString();
                frm.Apellidos = Datos.Rows[0][1].ToString();
                frm.Nombre = Datos.Rows[0][2].ToString();
                frm.Acceso = Datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();

            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar=='*')
            {
                btnInvisible.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnInvisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnVisible.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }
    }
}
