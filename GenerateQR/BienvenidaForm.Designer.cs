namespace Presentation
{
    partial class BienvenidaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BienvenidaForm));
            qpLogo = new PictureBox();
            lblBienvenido = new Label();
            panel1 = new Panel();
            lblUsuario = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)qpLogo).BeginInit();
            SuspendLayout();
            // 
            // qpLogo
            // 
            qpLogo.BackColor = System.Drawing.Color.Transparent;
            qpLogo.Image = (System.Drawing.Image)resources.GetObject("qpLogo.Image");
            qpLogo.Location = new System.Drawing.Point(87, 73);
            qpLogo.Name = "qpLogo";
            qpLogo.Size = new System.Drawing.Size(357, 215);
            qpLogo.SizeMode = PictureBoxSizeMode.Zoom;
            qpLogo.TabIndex = 1;
            qpLogo.TabStop = false;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            lblBienvenido.Font = new Font("Verdana", 42F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenido.ForeColor = System.Drawing.Color.White;
            lblBienvenido.Location = new System.Drawing.Point(525, 73);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new System.Drawing.Size(392, 67);
            lblBienvenido.TabIndex = 2;
            lblBienvenido.Text = "BIENVENIDO";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(25, 35, 49);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(311, 391);
            panel1.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = System.Drawing.Color.Transparent;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = System.Drawing.Color.White;
            lblUsuario.Location = new System.Drawing.Point(662, 154);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(96, 29);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = System.Drawing.Color.FromArgb(2, 128, 144);
            progressBar1.ForeColor = SystemColors.ControlText;
            progressBar1.Location = new System.Drawing.Point(540, 265);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(352, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 5;
            // 
            // BienvenidaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 47, 66);
            ClientSize = new System.Drawing.Size(1000, 391);
            Controls.Add(qpLogo);
            Controls.Add(progressBar1);
            Controls.Add(lblUsuario);
            Controls.Add(panel1);
            Controls.Add(lblBienvenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BienvenidaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BienvenidaForm";
            Load += BienvenidaForm_Load;
            ((System.ComponentModel.ISupportInitialize)qpLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox qpLogo;
        private Label lblBienvenido;
        private Panel panel1;
        private Label lblUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ProgressBar progressBar1;
    }
}