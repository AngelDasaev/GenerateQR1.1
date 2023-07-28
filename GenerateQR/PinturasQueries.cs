
using Common.Cache;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace Presentation
{
    public partial class PinturasQueries : Form
    {
        CDo_productos objetoCDo = new CDo_productos();
        private string idProducto = null;
        private bool Editar = false;

        public PinturasQueries()
        {
            InitializeComponent();
            datePintura.Value = DateTime.Now;
        }
        private void PinturasQueries_Load(object sender, EventArgs e)
        {
            MostrarRegistrosPintura();
            DatosdeUsuario();
            //Gestion de permisos
            if (UserCache.Posicion == Positions.Supervisor || UserCache.Posicion == Positions.Operador)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnImprimir.Visible = false;
                btnUserRegister.Visible = false;
            }
        }

        #region METODOS
        //Metodo para cargar y mostrar datos de usuario dentro de la plataforma
        private void DatosdeUsuario()
        {
            txtUsuario.Text = UserCache.Nombre + " " + UserCache.Apellido;
            txtNumReloj.Text = UserCache.NumeroReloj.ToString();
        }

        private void MostrarRegistrosPintura()
        {
            CDo_productos objeto = new CDo_productos();
            dataGridView1.DataSource = objeto.MostrarRegistrosPintura();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);

            //USUARIO PUEDE MODIFICAR EL ANCHO DE COLUMNAS
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
        }
        // METODO PARA ARRASTRAR FORM
        private void panelBarraTitulo_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region COMBO BOX PARA NUMERO DE PARTE
        private void txtNumParte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNumParte.SelectedItem != null)
            {
                string selectedValue = txtNumParte.SelectedItem.ToString();

                if (selectedValue.Equals("M4A4G03002"))
                {
                    txtDescrip.Text = "UPPER ASSY";
                    txtNumMaquina.Text = "21";
                }
                else if (selectedValue.Equals("M1E4G03028"))
                {
                    txtDescrip.Text = "UPPER ASSY";
                    txtNumMaquina.Text = "21";
                }
                else if (selectedValue.Equals("M1E4G03029"))
                {
                    txtDescrip.Text = "LOWER HOUSING";
                    txtNumMaquina.Text = "27";
                }
            }
        }
        #endregion

        #region FUNCIONES DE BOTONES
        #region Max, Restaurar y cerrar
        private void btnRestaurar1_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnRestaurar1.Text = "1";
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                btnRestaurar1.Text = "2";
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e) //BOTON DE GUARDADO
        {
            //INSERCION DE DATOS
            if (Editar == false)
            {
                try
                {
                    objetoCDo.InsertPintura(txtNumParte.Text, txtNumSerial.Text, txtNumMaquina.Text, this.datePintura.Text, txtUsuario.Text, txtNumReloj.Text);
                    MessageBox.Show("Se insertó correctamente");
                    MostrarRegistrosPintura();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pueden insertar los datos por: " + ex);
                }
            }
            //EDICION DE DATOS
            if (Editar == true)
            {
                try
                {
                    objetoCDo.EditarRegistroPintura(txtNumParte.Text, txtNumSerial.Text, txtNumMaquina.Text, idProducto);
                    MessageBox.Show("Se editó correctamente");
                    MostrarRegistrosPintura();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pueden editar los datos por: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //BOTON DE EDITAR
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNumParte.Text = dataGridView1.CurrentRow.Cells["Numero_de_Parte"].Value.ToString();
                txtNumSerial.Text = dataGridView1.CurrentRow.Cells["Numero_de_Serie"].Value.ToString();
                txtNumMaquina.Text = dataGridView1.CurrentRow.Cells["Numero_de_Maquina"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar");
            }
        }

        private void limpiarForm()
        {
            m
            txtNumSerial.Clear();
            txtNumMaquina.Clear();
        }
        private void button3_Click(object sender, EventArgs e) //BOTON DE ELIMINAR
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                objetoCDo.EliminarRegistroPintura(idProducto);
                // Restablecer los IDs de las filas restantes
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["ID"].Value = i + 1; // Asignar nuevos valores incrementales a la columna ID
                }
                MessageBox.Show("Eliminado correctamente");
                MostrarRegistrosPintura();
            }

            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
        }
        //**************************************                                                               MODIFICAR. Funciona pero da error
        private void btnImprimir_Click(object sender, EventArgs e) //BOTON DE IMPRIMIR
        {
            dataGridView1.SelectAll();
            DataObject copyData = dataGridView1.GetClipboardContent();
            if (copyData != null)
            {
                Clipboard.SetDataObject(copyData);
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlapp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlWbook;
                Microsoft.Office.Interop.Excel.Worksheet xlsheet;
                object missedData = System.Reflection.Missing.Value;
                xlWbook = xlapp.Workbooks.Add(missedData);

                xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                for (int x = 1; x < dataGridView1.Columns.Count + 1; x++)
                {
                    xlsheet.Cells[1, x] = dataGridView1.Columns[x - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xlsheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
                xlr.Select();

                //xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //Esta linea tira un error. Saca el resultado pero detiene el programa
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagenTabla = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagenTabla, new System.Drawing.Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagenTabla, 0, 0);
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesión?", "warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }
        private void btnUserRegister_Click_1(object sender, EventArgs e)
        {
            RegistroUsuarios menuPrincipal = new RegistroUsuarios();
            menuPrincipal.ShowDialog();
        }
        private void btnCerrar1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MoldeoQueries moldeoQueries = new MoldeoQueries();
            moldeoQueries.Show();
            this.Hide();
        }
        #endregion
    }
}
