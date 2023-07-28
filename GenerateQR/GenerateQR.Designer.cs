namespace GenerateQR
{
    partial class GenerateQR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtDate = new TextBox();
            txtSerialNum = new TextBox();
            txtPartNum = new TextBox();
            lblDate = new Label();
            lblPartNum = new Label();
            lblSerialNum = new Label();
            btnPrintQR = new Button();
            panel1 = new Panel();
            qrPicture = new PictureBox();
            date = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrPicture).BeginInit();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(153, 40);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(473, 23);
            txtDate.TabIndex = 0;
            // 
            // txtSerialNum
            // 
            txtSerialNum.Location = new System.Drawing.Point(153, 128);
            txtSerialNum.Name = "txtSerialNum";
            txtSerialNum.Size = new System.Drawing.Size(473, 23);
            txtSerialNum.TabIndex = 2;
            // 
            // txtPartNum
            // 
            txtPartNum.Location = new System.Drawing.Point(153, 84);
            txtPartNum.Name = "txtPartNum";
            txtPartNum.Size = new System.Drawing.Size(473, 23);
            txtPartNum.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(153, 22);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(31, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            // 
            // lblPartNum
            // 
            lblPartNum.AutoSize = true;
            lblPartNum.Location = new System.Drawing.Point(153, 66);
            lblPartNum.Name = "lblPartNum";
            lblPartNum.Size = new System.Drawing.Size(75, 15);
            lblPartNum.TabIndex = 4;
            lblPartNum.Text = "Part Number";
            // 
            // lblSerialNum
            // 
            lblSerialNum.AutoSize = true;
            lblSerialNum.Location = new System.Drawing.Point(153, 110);
            lblSerialNum.Name = "lblSerialNum";
            lblSerialNum.Size = new System.Drawing.Size(82, 15);
            lblSerialNum.TabIndex = 5;
            lblSerialNum.Text = "Serial Number";
            // 
            // btnPrintQR
            // 
            btnPrintQR.Location = new System.Drawing.Point(346, 185);
            btnPrintQR.Name = "btnPrintQR";
            btnPrintQR.Size = new System.Drawing.Size(75, 23);
            btnPrintQR.TabIndex = 6;
            btnPrintQR.Text = "Print QR";
            btnPrintQR.UseVisualStyleBackColor = true;
            btnPrintQR.Click += btnPrintQR_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(qrPicture);
            panel1.Location = new System.Drawing.Point(153, 242);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(473, 339);
            panel1.TabIndex = 7;
            // 
            // qrPicture
            // 
            qrPicture.Dock = DockStyle.Fill;
            qrPicture.Location = new System.Drawing.Point(0, 0);
            qrPicture.Name = "qrPicture";
            qrPicture.Size = new System.Drawing.Size(473, 339);
            qrPicture.TabIndex = 8;
            qrPicture.TabStop = false;
            // 
            // date
            // 
            date.Enabled = true;
            date.Tick += date_Tick;
            // 
            // GenerateQR
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(802, 602);
            Controls.Add(panel1);
            Controls.Add(btnPrintQR);
            Controls.Add(lblSerialNum);
            Controls.Add(lblPartNum);
            Controls.Add(lblDate);
            Controls.Add(txtPartNum);
            Controls.Add(txtSerialNum);
            Controls.Add(txtDate);
            Name = "GenerateQR";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)qrPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDate;
        private TextBox txtSerialNum;
        private TextBox txtPartNum;
        private Label lblDate;
        private Label lblPartNum;
        private Label lblSerialNum;
        private Button btnPrintQR;
        private Panel panel1;
        private PictureBox qrPicture;
        private System.Windows.Forms.Timer date;
    }
}