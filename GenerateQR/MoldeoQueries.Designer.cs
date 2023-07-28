namespace Presentation
{
    partial class MoldeoQueries
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoldeoQueries));
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Numero_de_Parte = new DataGridViewTextBoxColumn();
            Numero_de_Serie = new DataGridViewTextBoxColumn();
            Numero_de_Maquina = new DataGridViewTextBoxColumn();
            Fecha_de_Moldeo = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Numero_de_Reloj = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            label1 = new Label();
            txtNumMaquina = new TextBox();
            txtNumSerial = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateMoldeo = new DateTimePicker();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtNumParte = new ComboBox();
            txtDescrip = new TextBox();
            PanelContenedor = new Panel();
            panelBotones = new TableLayoutPanel();
            btnEditar = new Button();
            btnImprimir = new Button();
            btnEliminar = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblUsuario = new Label();
            lblNumReloj = new Label();
            txtUsuario = new TextBox();
            txtNumReloj = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panelBarraTitulo = new Panel();
            btnLogout = new Button();
            button1 = new Button();
            btnRestaurar1 = new Button();
            btnCerrar1 = new Button();
            btnUserRegister = new Button();
            label6 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            PanelContenedor.SuspendLayout();
            panelBotones.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelBarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Numero_de_Parte, Numero_de_Serie, Numero_de_Maquina, Fecha_de_Moldeo, Usuario, Numero_de_Reloj });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new System.Drawing.Point(40, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1165, 424);
            dataGridView1.TabIndex = 10;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Numero_de_Parte
            // 
            Numero_de_Parte.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Numero_de_Parte.DataPropertyName = "Numero_de_Parte";
            Numero_de_Parte.FillWeight = 140F;
            Numero_de_Parte.HeaderText = "Numero de Parte";
            Numero_de_Parte.Name = "Numero_de_Parte";
            Numero_de_Parte.ReadOnly = true;
            // 
            // Numero_de_Serie
            // 
            Numero_de_Serie.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Numero_de_Serie.DataPropertyName = "Numero_de_Serie";
            Numero_de_Serie.FillWeight = 128.82814F;
            Numero_de_Serie.HeaderText = "Numero de Serie";
            Numero_de_Serie.Name = "Numero_de_Serie";
            Numero_de_Serie.ReadOnly = true;
            // 
            // Numero_de_Maquina
            // 
            Numero_de_Maquina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Numero_de_Maquina.DataPropertyName = "Numero_de_Maquina";
            Numero_de_Maquina.FillWeight = 74.65334F;
            Numero_de_Maquina.HeaderText = "Numero de Maquina";
            Numero_de_Maquina.Name = "Numero_de_Maquina";
            Numero_de_Maquina.ReadOnly = true;
            // 
            // Fecha_de_Moldeo
            // 
            Fecha_de_Moldeo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha_de_Moldeo.DataPropertyName = "Fecha_de_Moldeo";
            Fecha_de_Moldeo.HeaderText = "Fecha de Moldeo";
            Fecha_de_Moldeo.Name = "Fecha_de_Moldeo";
            Fecha_de_Moldeo.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Usuario.DataPropertyName = "Usuario";
            Usuario.FillWeight = 120F;
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Numero_de_Reloj
            // 
            Numero_de_Reloj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Numero_de_Reloj.DataPropertyName = "Numero_de_Reloj";
            Numero_de_Reloj.FillWeight = 80F;
            Numero_de_Reloj.HeaderText = "Numero de Reloj";
            Numero_de_Reloj.Name = "Numero_de_Reloj";
            Numero_de_Reloj.ReadOnly = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = System.Drawing.Color.Transparent;
            btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new System.Drawing.Point(641, 226);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(108, 107);
            btnGuardar.TabIndex = 6;
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(41, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(139, 20);
            label1.TabIndex = 9;
            label1.Text = "Número de Parte";
            // 
            // txtNumMaquina
            // 
            txtNumMaquina.Dock = DockStyle.Fill;
            txtNumMaquina.Font = new Font("Microsoft JhengHei", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumMaquina.Location = new System.Drawing.Point(186, 69);
            txtNumMaquina.Name = "txtNumMaquina";
            txtNumMaquina.ReadOnly = true;
            txtNumMaquina.Size = new System.Drawing.Size(300, 30);
            txtNumMaquina.TabIndex = 3;
            // 
            // txtNumSerial
            // 
            txtNumSerial.Dock = DockStyle.Fill;
            txtNumSerial.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumSerial.Location = new System.Drawing.Point(157, 3);
            txtNumSerial.Name = "txtNumSerial";
            txtNumSerial.Size = new System.Drawing.Size(315, 39);
            txtNumSerial.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(13, 87);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(138, 20);
            label4.TabIndex = 12;
            label4.Text = "Fecha de Moldeo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(166, 20);
            label3.TabIndex = 11;
            label3.Text = "Número de Máquina";
            // 
            // dateMoldeo
            // 
            dateMoldeo.CustomFormat = "yyyy-MM-dd";
            dateMoldeo.Dock = DockStyle.Fill;
            dateMoldeo.DropDownAlign = LeftRightAlignment.Right;
            dateMoldeo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateMoldeo.Format = DateTimePickerFormat.Custom;
            dateMoldeo.Location = new System.Drawing.Point(157, 68);
            dateMoldeo.Name = "dateMoldeo";
            dateMoldeo.Size = new System.Drawing.Size(315, 39);
            dateMoldeo.TabIndex = 4;
            dateMoldeo.Value = new DateTime(2023, 7, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 20);
            label2.TabIndex = 10;
            label2.Text = "Número de Serie";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 154F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(dateMoldeo, 1, 1);
            tableLayoutPanel1.Controls.Add(txtNumSerial, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(641, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(475, 130);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // txtNumParte
            // 
            txtNumParte.Dock = DockStyle.Fill;
            txtNumParte.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNumParte.FlatStyle = FlatStyle.Flat;
            txtNumParte.Font = new Font("Microsoft JhengHei", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumParte.FormattingEnabled = true;
            txtNumParte.Items.AddRange(new object[] { "M4A4G03002", "M1E4G03028", "M1E4G03029" });
            txtNumParte.Location = new System.Drawing.Point(186, 3);
            txtNumParte.Name = "txtNumParte";
            txtNumParte.Size = new System.Drawing.Size(300, 30);
            txtNumParte.TabIndex = 14;
            txtNumParte.SelectedIndexChanged += txtNumParte_SelectedIndexChanged;
            // 
            // txtDescrip
            // 
            txtDescrip.Dock = DockStyle.Fill;
            txtDescrip.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescrip.Location = new System.Drawing.Point(186, 39);
            txtDescrip.Name = "txtDescrip";
            txtDescrip.ReadOnly = true;
            txtDescrip.Size = new System.Drawing.Size(300, 25);
            txtDescrip.TabIndex = 15;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = System.Drawing.Color.DarkGray;
            PanelContenedor.BorderStyle = BorderStyle.Fixed3D;
            PanelContenedor.Controls.Add(panelBotones);
            PanelContenedor.Controls.Add(btnGuardar);
            PanelContenedor.Controls.Add(groupBox2);
            PanelContenedor.Controls.Add(groupBox1);
            PanelContenedor.Controls.Add(panelBarraTitulo);
            PanelContenedor.Controls.Add(dataGridView1);
            PanelContenedor.Controls.Add(tableLayoutPanel1);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new System.Drawing.Point(0, 0);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new System.Drawing.Size(1243, 794);
            PanelContenedor.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.ColumnCount = 3;
            panelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            panelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            panelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            panelBotones.Controls.Add(btnEditar, 0, 0);
            panelBotones.Controls.Add(btnImprimir, 2, 0);
            panelBotones.Controls.Add(btnEliminar, 1, 0);
            panelBotones.Location = new System.Drawing.Point(772, 226);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 1;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBotones.Size = new System.Drawing.Size(344, 100);
            panelBotones.TabIndex = 24;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = System.Drawing.Color.Transparent;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new System.Drawing.Point(3, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(108, 94);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button2_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Dock = DockStyle.Fill;
            btnImprimir.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new System.Drawing.Point(231, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(110, 94);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.Color.Transparent;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new System.Drawing.Point(117, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(108, 94);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(40, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(548, 143);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de Usuario";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.8098145F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.1901855F));
            tableLayoutPanel4.Controls.Add(lblUsuario, 0, 0);
            tableLayoutPanel4.Controls.Add(lblNumReloj, 0, 1);
            tableLayoutPanel4.Controls.Add(txtUsuario, 1, 0);
            tableLayoutPanel4.Controls.Add(txtNumReloj, 1, 1);
            tableLayoutPanel4.Location = new System.Drawing.Point(30, 20);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new System.Drawing.Size(489, 103);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = System.Drawing.Color.Transparent;
            lblUsuario.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new System.Drawing.Point(110, 15);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(67, 20);
            lblUsuario.TabIndex = 16;
            lblUsuario.Text = "Usuario";
            // 
            // lblNumReloj
            // 
            lblNumReloj.Anchor = AnchorStyles.Right;
            lblNumReloj.AutoSize = true;
            lblNumReloj.BackColor = System.Drawing.Color.Transparent;
            lblNumReloj.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumReloj.Location = new System.Drawing.Point(41, 67);
            lblNumReloj.Name = "lblNumReloj";
            lblNumReloj.Size = new System.Drawing.Size(136, 20);
            lblNumReloj.TabIndex = 9;
            lblNumReloj.Text = "Numero de Reloj";
            // 
            // txtUsuario
            // 
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Microsoft JhengHei", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new System.Drawing.Point(183, 10);
            txtUsuario.Margin = new Padding(3, 10, 3, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new System.Drawing.Size(303, 30);
            txtUsuario.TabIndex = 13;
            // 
            // txtNumReloj
            // 
            txtNumReloj.Dock = DockStyle.Fill;
            txtNumReloj.Font = new Font("Microsoft JhengHei", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumReloj.Location = new System.Drawing.Point(183, 61);
            txtNumReloj.Margin = new Padding(3, 10, 3, 3);
            txtNumReloj.Name = "txtNumReloj";
            txtNumReloj.ReadOnly = true;
            txtNumReloj.Size = new System.Drawing.Size(303, 30);
            txtNumReloj.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(40, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(548, 143);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información General";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4233131F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5766869F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(txtNumParte, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtNumMaquina, 1, 2);
            tableLayoutPanel3.Controls.Add(txtDescrip, 1, 1);
            tableLayoutPanel3.Location = new System.Drawing.Point(30, 21);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(489, 103);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(2, 128, 144);
            panelBarraTitulo.Controls.Add(btnLogout);
            panelBarraTitulo.Controls.Add(button1);
            panelBarraTitulo.Controls.Add(btnRestaurar1);
            panelBarraTitulo.Controls.Add(btnCerrar1);
            panelBarraTitulo.Controls.Add(btnUserRegister);
            panelBarraTitulo.Controls.Add(label6);
            panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new System.Drawing.Size(1239, 40);
            panelBarraTitulo.TabIndex = 21;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = System.Drawing.Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Image = (System.Drawing.Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new System.Drawing.Point(1003, 8);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(117, 23);
            btnLogout.TabIndex = 27;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(908, 8);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(89, 23);
            button1.TabIndex = 31;
            button1.Text = "Pintura";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnRestaurar1
            // 
            btnRestaurar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar1.BackgroundImageLayout = ImageLayout.Center;
            btnRestaurar1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnRestaurar1.FlatAppearance.BorderSize = 0;
            btnRestaurar1.FlatStyle = FlatStyle.Popup;
            btnRestaurar1.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestaurar1.ForeColor = System.Drawing.Color.White;
            btnRestaurar1.Location = new System.Drawing.Point(1159, 8);
            btnRestaurar1.Name = "btnRestaurar1";
            btnRestaurar1.Size = new System.Drawing.Size(25, 23);
            btnRestaurar1.TabIndex = 30;
            btnRestaurar1.Text = "2";
            btnRestaurar1.TextAlign = ContentAlignment.TopCenter;
            btnRestaurar1.UseVisualStyleBackColor = true;
            btnRestaurar1.Click += btnRestaurar1_Click;
            // 
            // btnCerrar1
            // 
            btnCerrar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar1.BackColor = System.Drawing.Color.FromArgb(2, 128, 144);
            btnCerrar1.BackgroundImageLayout = ImageLayout.Center;
            btnCerrar1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnCerrar1.FlatAppearance.BorderSize = 0;
            btnCerrar1.FlatStyle = FlatStyle.Popup;
            btnCerrar1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar1.ForeColor = System.Drawing.Color.White;
            btnCerrar1.Location = new System.Drawing.Point(1190, 8);
            btnCerrar1.Name = "btnCerrar1";
            btnCerrar1.Size = new System.Drawing.Size(25, 23);
            btnCerrar1.TabIndex = 25;
            btnCerrar1.Text = "X";
            btnCerrar1.UseVisualStyleBackColor = true;
            btnCerrar1.Click += btnCerrar1_Click;
            // 
            // btnUserRegister
            // 
            btnUserRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUserRegister.BackColor = System.Drawing.Color.Transparent;
            btnUserRegister.Cursor = Cursors.Hand;
            btnUserRegister.FlatAppearance.BorderSize = 0;
            btnUserRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            btnUserRegister.FlatStyle = FlatStyle.Flat;
            btnUserRegister.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserRegister.ForeColor = System.Drawing.Color.White;
            btnUserRegister.Image = (System.Drawing.Image)resources.GetObject("btnUserRegister.Image");
            btnUserRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserRegister.Location = new System.Drawing.Point(767, 6);
            btnUserRegister.Name = "btnUserRegister";
            btnUserRegister.Size = new System.Drawing.Size(135, 28);
            btnUserRegister.TabIndex = 28;
            btnUserRegister.Text = "Agregar Usuario";
            btnUserRegister.TextAlign = ContentAlignment.MiddleRight;
            btnUserRegister.UseVisualStyleBackColor = false;
            btnUserRegister.Click += btnUserRegister_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Image = (System.Drawing.Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new System.Drawing.Point(51, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 26);
            label6.TabIndex = 22;
            label6.Text = "Moldeo";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // MoldeoQueries
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(1243, 794);
            Controls.Add(PanelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MoldeoQueries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Moldeo";
            WindowState = FormWindowState.Maximized;
            Load += MoldeoQueries_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            PanelContenedor.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panelBarraTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtNumMaquina;
        private TextBox txtNumSerial;
        private Label label4;
        private Label label3;
        private DateTimePicker dateMoldeo;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel PanelContenedor;
        private Panel panelBarraTitulo;
        private Label label6;
        private ComboBox txtNumParte;
        private TextBox txtDescrip;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblNumReloj;
        private PrintPreviewDialog printPreviewDialog1;
        private TableLayoutPanel panelBotones;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtNumReloj;
        private Button btnLogout;
        private Button btnUserRegister;
        private Button btnCerrar1;
        private Button btnRestaurar1;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Numero_de_Parte;
        private DataGridViewTextBoxColumn Numero_de_Serie;
        private DataGridViewTextBoxColumn Numero_de_Maquina;
        private DataGridViewTextBoxColumn Fecha_de_Moldeo;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Numero_de_Reloj;
    }
}