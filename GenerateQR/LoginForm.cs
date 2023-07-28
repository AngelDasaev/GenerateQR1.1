using System.Runtime.InteropServices;
using Domain;
using System.IO;


namespace Presentation
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        #region diseño de texto en txtUSUARIO
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingresa tu usuario...")
            {
                label1.Show();
                txtUsuario.Text = "";
                txtUsuario.ForeColor = System.Drawing.Color.LightBlue;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                label1.Hide();
                txtUsuario.Text = "Ingresa tu usuario...";
                txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            }
        }
        #endregion

        #region Movilidad del form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Metodos para acceder (botón y enterkey)
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Ingresa tu usuario...")
            {
                UserModel Usuario = new UserModel();
                var LoginValidado = Usuario.LoginUsuario(txtUsuario.Text); //asignacion de resultado retornado por el metodo de LoginUsuario, txtUsuario como parametro
                if (LoginValidado == true) //Verificacion de usuario (Si es que existe)
                {
                    this.Hide();
                    BienvenidaForm Bienvenida = new BienvenidaForm();
                    Bienvenida.ShowDialog();
                    MoldeoQueries menuPrincipal = new MoldeoQueries();
                    menuPrincipal.Show();
                    menuPrincipal.FormClosed += CerrarSesion;
                }
                else
                {
                    MensajeError("Usuario incorrecto. Intenta de nuevo.");
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                }
            }
            else
            {
                MensajeError("Favor de ingresar un usuario válido.");
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text != "Ingresa tu usuario...")
                {
                    UserModel Usuario = new UserModel();
                    var LoginValidado = Usuario.LoginUsuario(txtUsuario.Text);
                    if (LoginValidado == true)
                    {
                        this.Hide();
                        BienvenidaForm Bienvenida = new BienvenidaForm();
                        Bienvenida.ShowDialog();
                        MoldeoQueries menuPrincipal = new MoldeoQueries();
                        menuPrincipal.Show();
                        menuPrincipal.FormClosed += CerrarSesion;
                    }
                    else
                    {
                        MensajeError("Usuario incorrecto. Intenta de nuevo.");
                        txtUsuario.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MensajeError("Favor de ingresar un usuario válido.");
                }
            }
        }
        #endregion

        #region Metodos para cerrar sesión y acciones
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MensajeError(string msj)
        {
            lblError.Text = "    " + msj;
            lblError.Visible = true;
        }
        public void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            label1.Visible = false;
            lblError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }
        #endregion
    }
}
