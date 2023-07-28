namespace Presentation
{
    partial class RegistroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            tableLayoutPanel1 = new TableLayoutPanel();
            txtPosicion = new ComboBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtNumReloj = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNumTarjeta = new TextBox();
            label3 = new Label();
            label7 = new Label();
            btnGuardarUser = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0509987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.9490051F));
            tableLayoutPanel1.Controls.Add(txtPosicion, 1, 2);
            tableLayoutPanel1.Controls.Add(txtCorreo, 1, 5);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(txtNumReloj, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(txtApellido, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(txtNumTarjeta, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(55, 138);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new System.Drawing.Size(451, 271);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtPosicion
            // 
            txtPosicion.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPosicion.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtPosicion.Dock = DockStyle.Fill;
            txtPosicion.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPosicion.FormattingEnabled = true;
            txtPosicion.Items.AddRange(new object[] { "Administrador", "Supervisor", "Operador" });
            txtPosicion.Location = new System.Drawing.Point(125, 93);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new System.Drawing.Size(323, 28);
            txtPosicion.TabIndex = 3;
            txtPosicion.Enter += txtPosicion_Enter;
            // 
            // txtCorreo
            // 
            txtCorreo.Dock = DockStyle.Fill;
            txtCorreo.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new System.Drawing.Point(125, 228);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(323, 29);
            txtCorreo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new System.Drawing.Point(125, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(323, 29);
            txtNombre.TabIndex = 1;
            // 
            // txtNumReloj
            // 
            txtNumReloj.Dock = DockStyle.Fill;
            txtNumReloj.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumReloj.Location = new System.Drawing.Point(125, 138);
            txtNumReloj.Name = "txtNumReloj";
            txtNumReloj.Size = new System.Drawing.Size(323, 29);
            txtNumReloj.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Right;
            label6.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(27, 225);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 46);
            label6.TabIndex = 5;
            label6.Text = "CORREO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(15, 45);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 45);
            label4.TabIndex = 3;
            label4.Text = "APELLIDO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(13, 90);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 45);
            label5.TabIndex = 4;
            label5.Text = "POSICION";
            // 
            // txtApellido
            // 
            txtApellido.Dock = DockStyle.Fill;
            txtApellido.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new System.Drawing.Point(125, 48);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(323, 29);
            txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(34, 135);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 45);
            label2.TabIndex = 1;
            label2.Text = "# RELOJ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(10, 180);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 45);
            label1.TabIndex = 0;
            label1.Text = "# TARJETA";
            // 
            // txtNumTarjeta
            // 
            txtNumTarjeta.Dock = DockStyle.Fill;
            txtNumTarjeta.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumTarjeta.Location = new System.Drawing.Point(125, 183);
            txtNumTarjeta.Name = "txtNumTarjeta";
            txtNumTarjeta.Size = new System.Drawing.Size(323, 29);
            txtNumTarjeta.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(22, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 45);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(221, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(242, 29);
            label7.TabIndex = 1;
            label7.Text = "Registro de usuarios";
            // 
            // btnGuardarUser
            // 
            btnGuardarUser.BackColor = SystemColors.ButtonHighlight;
            btnGuardarUser.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarUser.Location = new System.Drawing.Point(221, 432);
            btnGuardarUser.Name = "btnGuardarUser";
            btnGuardarUser.Size = new System.Drawing.Size(117, 35);
            btnGuardarUser.TabIndex = 7;
            btnGuardarUser.Text = "Guardar";
            btnGuardarUser.UseVisualStyleBackColor = false;
            btnGuardarUser.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(7, 133, 149);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(647, 55);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new System.Drawing.Point(619, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(16, 16);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new System.Drawing.Point(356, 432);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(117, 35);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RegistroUsuarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkGray;
            ClientSize = new System.Drawing.Size(647, 580);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(btnGuardarUser);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroUsuarios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNumTarjeta;
        private TextBox txtApellido;
        private TextBox txtNumReloj;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Button btnGuardarUser;
        private PictureBox pictureBox1;
        private Button btnCancelar;
        private ComboBox txtPosicion;
    }
}