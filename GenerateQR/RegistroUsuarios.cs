using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class RegistroUsuarios : Form
    {
        CDo_RegistroUsuarios objetoCDo = new CDo_RegistroUsuarios();
        public RegistroUsuarios()
        {
            InitializeComponent();
        }
        private void limpiarForm()
        {
            txtNombre.Clear();
            txtNumReloj.Clear();
            txtNumTarjeta.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtPosicion.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCDo.InsertUsuario(txtNombre.Text, txtApellido.Text, txtPosicion.Text, txtNumReloj.Text, txtNumTarjeta.Text, txtCorreo.Text);
                MessageBox.Show("Se insertó correctamente");
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden insertar los datos por: " + ex);
                limpiarForm();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumReloj.Clear();
            txtNumTarjeta.Clear();
            txtCorreo.Clear();
            txtPosicion.Text = string.Empty;
            this.Close();
        }

        private void txtPosicion_Enter(object sender, EventArgs e)
        {
            txtPosicion.DroppedDown = true;
        }
    }
}
