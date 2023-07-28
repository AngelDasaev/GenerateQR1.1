
using Domain;
using System.Runtime.InteropServices;
using Common.Cache;

namespace Presentation
{
    public partial class MoldeoQueries : Form
    {
        CDo_productos objetoCDo = new CDo_productos();
        private string idProducto = null;
        private bool Editar = false;

        public MoldeoQueries()
        {
            InitializeComponent();
            dateMoldeo.Value = DateTime.Now;
        }

        private void MoldeoQueries_Load(object sender, EventArgs e)
        {
            MostrarRegistrosMoldeo();
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

        private void MostrarRegistrosMoldeo()
        {
            CDo_productos objeto = new CDo_productos();
            dataGridView1.DataSource = objeto.MostrarRegistrosMoldeo();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);

            //USUARIO PUEDE MODIFICAR EL ANCHO DE COLUMNAS
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
        }
        // METODO PARA ARRASTRAR FORM
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
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
        private void btnRestaurar1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnRestaurar1.Text = "1"; //son numeros debido al tipo de fuente (webdings) en el boton de restaurar o minimizar
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
                    objetoCDo.InsertMoldeo(txtNumParte.Text, txtNumSerial.Text, txtNumMaquina.Text, this.dateMoldeo.Text, txtUsuario.Text, txtNumReloj.Text);
                    MessageBox.Show("Se insertó correctamente");
                    MostrarRegistrosMoldeo();
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
                    objetoCDo.EditarRegistroMoldeo(txtNumParte.Text, txtNumSerial.Text, txtNumMaquina.Text, idProducto);
                    MessageBox.Show("Se editó correctamente");
                    MostrarRegistrosMoldeo();
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
            txtNumParte.ResetText();
            txtNumParte.Refresh();
            txtNumSerial.Clear();
            txtNumMaquina.Clear();
        }
        private void button3_Click(object sender, EventArgs e) //BOTON DE ELIMINAR
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                objetoCDo.EliminarRegistroMoldeo(idProducto);
                // Restablecer los IDs de las filas restantes
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["ID"].Value = i + 1; // Asignar nuevos valores incrementales a la columna ID
                }
                MessageBox.Show("Eliminado correctamente");
                MostrarRegistrosMoldeo();
            }

            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
        }
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesión?", "warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        private void btnUserRegister_Click(object sender, EventArgs e) //BOTON DE REGISTRO DE USUARIO
        {
            RegistroUsuarios registroForm = new RegistroUsuarios();
            registroForm.ShowDialog();
        }
        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PinturasQueries pinturasQueries = new PinturasQueries();
            pinturasQueries.Show();
            this.Hide();
        }

        #endregion
    }
}
