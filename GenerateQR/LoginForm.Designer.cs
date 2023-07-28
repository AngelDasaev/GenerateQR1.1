namespace Presentation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtUsuario = new TextBox();
            lblLogin = new Label();
            btnAcceder = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblError = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(25, 35, 49);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(239, 346);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Location = new System.Drawing.Point(12, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(212, 148);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = System.Drawing.Color.LightGray;
            txtUsuario.Location = new System.Drawing.Point(3, 31);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(541, 31);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Ingresa tu usuario...";
            txtUsuario.UseSystemPasswordChar = true;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = System.Drawing.Color.White;
            lblLogin.Location = new System.Drawing.Point(487, 38);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new System.Drawing.Size(190, 30);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "INICIAR SESIÓN";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcceder.ForeColor = System.Drawing.Color.LightGray;
            btnAcceder.Location = new System.Drawing.Point(301, 235);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new System.Drawing.Size(547, 40);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(874, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(853, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(15, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(3, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 21);
            label1.TabIndex = 5;
            label1.Text = "Ingresa tu usuario";
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblError.AutoSize = true;
            lblError.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = System.Drawing.Color.DarkGray;
            lblError.Image = (System.Drawing.Image)resources.GetObject("lblError.Image");
            lblError.ImageAlign = ContentAlignment.TopLeft;
            lblError.Location = new System.Drawing.Point(3, 63);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(48, 21);
            lblError.TabIndex = 6;
            lblError.Text = " Error";
            lblError.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtUsuario, 0, 1);
            tableLayoutPanel1.Controls.Add(lblError, 0, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(301, 88);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(547, 106);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ClientSize = new System.Drawing.Size(901, 346);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblLogin);
            Controls.Add(btnAcceder);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            MouseDown += LoginForm_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private Label lblLogin;
        private Button btnAcceder;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label lblError;
        private TableLayoutPanel tableLayoutPanel1;
    }
}