namespace Alquiler
{
    partial class FormUtilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtilidad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarAlquiler = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnAgregarHerramienta = new System.Windows.Forms.Button();
            this.btnListarAlquiler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipoLista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnioLista = new System.Windows.Forms.TextBox();
            this.txtMesLista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridAlquileres = new System.Windows.Forms.DataGridView();
            this.nroStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDeAlquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrid = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarH = new System.Windows.Forms.Button();
            this.txtCambioEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFuncionEstado = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStockAlquiler = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiasAlquilado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFuncionAgregar = new System.Windows.Forms.Button();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtContratoEstado = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnAgregarAlquiler);
            this.panel1.Controls.Add(this.btnCambiarEstado);
            this.panel1.Controls.Add(this.btnAgregarHerramienta);
            this.panel1.Controls.Add(this.btnListarAlquiler);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 716);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregarAlquiler
            // 
            this.btnAgregarAlquiler.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarAlquiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAlquiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAlquiler.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarAlquiler.Location = new System.Drawing.Point(51, 362);
            this.btnAgregarAlquiler.Name = "btnAgregarAlquiler";
            this.btnAgregarAlquiler.Size = new System.Drawing.Size(178, 44);
            this.btnAgregarAlquiler.TabIndex = 5;
            this.btnAgregarAlquiler.Text = "Agregar alquiler";
            this.btnAgregarAlquiler.UseVisualStyleBackColor = false;
            this.btnAgregarAlquiler.Click += new System.EventHandler(this.btnAgregarAlquiler_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarEstado.Location = new System.Drawing.Point(51, 312);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(178, 44);
            this.btnCambiarEstado.TabIndex = 4;
            this.btnCambiarEstado.Text = "Cambiar estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnAgregarHerramienta
            // 
            this.btnAgregarHerramienta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarHerramienta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarHerramienta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregarHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarHerramienta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarHerramienta.Location = new System.Drawing.Point(51, 256);
            this.btnAgregarHerramienta.Name = "btnAgregarHerramienta";
            this.btnAgregarHerramienta.Size = new System.Drawing.Size(178, 50);
            this.btnAgregarHerramienta.TabIndex = 3;
            this.btnAgregarHerramienta.Text = "Agregar herramienta";
            this.btnAgregarHerramienta.UseVisualStyleBackColor = false;
            this.btnAgregarHerramienta.Click += new System.EventHandler(this.btnAgregarHerramienta_Click);
            // 
            // btnListarAlquiler
            // 
            this.btnListarAlquiler.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListarAlquiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarAlquiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarAlquiler.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListarAlquiler.Location = new System.Drawing.Point(51, 206);
            this.btnListarAlquiler.Name = "btnListarAlquiler";
            this.btnListarAlquiler.Size = new System.Drawing.Size(178, 44);
            this.btnListarAlquiler.TabIndex = 2;
            this.btnListarAlquiler.Text = "Listar alquileres";
            this.btnListarAlquiler.UseVisualStyleBackColor = false;
            this.btnListarAlquiler.Click += new System.EventHandler(this.btnListarAlquiler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo:";
            this.label1.Visible = false;
            // 
            // comboTipoLista
            // 
            this.comboTipoLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoLista.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboTipoLista.FormattingEnabled = true;
            this.comboTipoLista.Items.AddRange(new object[] {
            "Pulidora",
            "Caladora"});
            this.comboTipoLista.Location = new System.Drawing.Point(357, 78);
            this.comboTipoLista.Name = "comboTipoLista";
            this.comboTipoLista.Size = new System.Drawing.Size(151, 29);
            this.comboTipoLista.TabIndex = 3;
            this.comboTipoLista.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(635, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año:";
            this.label2.Visible = false;
            // 
            // txtAnioLista
            // 
            this.txtAnioLista.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnioLista.Location = new System.Drawing.Point(690, 78);
            this.txtAnioLista.Name = "txtAnioLista";
            this.txtAnioLista.Size = new System.Drawing.Size(151, 28);
            this.txtAnioLista.TabIndex = 5;
            this.txtAnioLista.Visible = false;
            // 
            // txtMesLista
            // 
            this.txtMesLista.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMesLista.Location = new System.Drawing.Point(1010, 78);
            this.txtMesLista.Name = "txtMesLista";
            this.txtMesLista.Size = new System.Drawing.Size(151, 28);
            this.txtMesLista.TabIndex = 7;
            this.txtMesLista.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(955, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mes:";
            this.label3.Visible = false;
            // 
            // gridAlquileres
            // 
            this.gridAlquileres.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.gridAlquileres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlquileres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroStock,
            this.Tipo,
            this.Marca,
            this.FechaAlquiler,
            this.Nombre,
            this.Cedula,
            this.tiempoDeAlquiler,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAlquileres.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAlquileres.GridColor = System.Drawing.Color.Black;
            this.gridAlquileres.Location = new System.Drawing.Point(315, 206);
            this.gridAlquileres.Name = "gridAlquileres";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlquileres.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAlquileres.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridAlquileres.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAlquileres.RowTemplate.Height = 29;
            this.gridAlquileres.Size = new System.Drawing.Size(871, 481);
            this.gridAlquileres.TabIndex = 8;
            this.gridAlquileres.Visible = false;
            this.gridAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlquileres_CellContentClick);
            // 
            // nroStock
            // 
            this.nroStock.HeaderText = "Numero de Stock";
            this.nroStock.MinimumWidth = 6;
            this.nroStock.Name = "nroStock";
            this.nroStock.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // FechaAlquiler
            // 
            this.FechaAlquiler.HeaderText = "Fecha de alquiler";
            this.FechaAlquiler.MinimumWidth = 6;
            this.FechaAlquiler.Name = "FechaAlquiler";
            this.FechaAlquiler.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 125;
            // 
            // tiempoDeAlquiler
            // 
            this.tiempoDeAlquiler.HeaderText = "Dias alquilado";
            this.tiempoDeAlquiler.MinimumWidth = 6;
            this.tiempoDeAlquiler.Name = "tiempoDeAlquiler";
            this.tiempoDeAlquiler.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // btnGrid
            // 
            this.btnGrid.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGrid.Location = new System.Drawing.Point(663, 134);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(178, 44);
            this.btnGrid.TabIndex = 9;
            this.btnGrid.Text = "Listar alquileres";
            this.btnGrid.UseVisualStyleBackColor = false;
            this.btnGrid.Visible = false;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMarca.Location = new System.Drawing.Point(404, 202);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(151, 28);
            this.txtMarca.TabIndex = 11;
            this.txtMarca.Visible = false;
            this.txtMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(326, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Marca:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStock.Location = new System.Drawing.Point(404, 259);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(151, 28);
            this.txtStock.TabIndex = 13;
            this.txtStock.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(303, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nro Stock:";
            this.label5.Visible = false;
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Alquilado",
            "Devuelto"});
            this.comboEstado.Location = new System.Drawing.Point(1010, 201);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(151, 29);
            this.comboEstado.TabIndex = 14;
            this.comboEstado.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(931, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado:";
            this.label6.Visible = false;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Pulidora",
            "Caladora"});
            this.comboTipo.Location = new System.Drawing.Point(1010, 258);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(151, 29);
            this.comboTipo.TabIndex = 16;
            this.comboTipo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(955, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo:";
            this.label7.Visible = false;
            // 
            // btnAgregarH
            // 
            this.btnAgregarH.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAgregarH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregarH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarH.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarH.Location = new System.Drawing.Point(663, 312);
            this.btnAgregarH.Name = "btnAgregarH";
            this.btnAgregarH.Size = new System.Drawing.Size(178, 50);
            this.btnAgregarH.TabIndex = 18;
            this.btnAgregarH.Text = "Agregar herramienta";
            this.btnAgregarH.UseVisualStyleBackColor = false;
            this.btnAgregarH.Visible = false;
            this.btnAgregarH.Click += new System.EventHandler(this.btnAgregarH_Click);
            // 
            // txtCambioEstado
            // 
            this.txtCambioEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCambioEstado.Location = new System.Drawing.Point(875, 237);
            this.txtCambioEstado.Name = "txtCambioEstado";
            this.txtCambioEstado.Size = new System.Drawing.Size(151, 28);
            this.txtCambioEstado.TabIndex = 20;
            this.txtCambioEstado.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(774, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nro Stock:";
            this.label8.Visible = false;
            // 
            // btnFuncionEstado
            // 
            this.btnFuncionEstado.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFuncionEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFuncionEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFuncionEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFuncionEstado.Location = new System.Drawing.Point(663, 315);
            this.btnFuncionEstado.Name = "btnFuncionEstado";
            this.btnFuncionEstado.Size = new System.Drawing.Size(178, 44);
            this.btnFuncionEstado.TabIndex = 21;
            this.btnFuncionEstado.Text = "Cambiar estado";
            this.btnFuncionEstado.UseVisualStyleBackColor = false;
            this.btnFuncionEstado.Visible = false;
            this.btnFuncionEstado.Click += new System.EventHandler(this.btnFuncionEstado_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(417, 391);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 28);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(329, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nombre:";
            this.label9.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(718, 391);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 28);
            this.txtApellido.TabIndex = 25;
            this.txtApellido.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(629, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Apellido:";
            this.label10.Visible = false;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCedula.Location = new System.Drawing.Point(998, 391);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(151, 28);
            this.txtCedula.TabIndex = 27;
            this.txtCedula.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(915, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cedula:";
            this.label11.Visible = false;
            // 
            // txtStockAlquiler
            // 
            this.txtStockAlquiler.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStockAlquiler.Location = new System.Drawing.Point(417, 443);
            this.txtStockAlquiler.Name = "txtStockAlquiler";
            this.txtStockAlquiler.Size = new System.Drawing.Size(151, 28);
            this.txtStockAlquiler.TabIndex = 29;
            this.txtStockAlquiler.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(316, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nro Stock:";
            this.label12.Visible = false;
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(718, 446);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(151, 27);
            this.dateTimeFecha.TabIndex = 30;
            this.dateTimeFecha.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(645, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 31;
            this.label13.Text = "Fecha:";
            this.label13.Visible = false;
            // 
            // txtDiasAlquilado
            // 
            this.txtDiasAlquilado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiasAlquilado.Location = new System.Drawing.Point(998, 445);
            this.txtDiasAlquilado.Name = "txtDiasAlquilado";
            this.txtDiasAlquilado.Size = new System.Drawing.Size(151, 28);
            this.txtDiasAlquilado.TabIndex = 33;
            this.txtDiasAlquilado.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(942, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 21);
            this.label14.TabIndex = 32;
            this.label14.Text = "Dias:";
            this.label14.Visible = false;
            // 
            // btnFuncionAgregar
            // 
            this.btnFuncionAgregar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFuncionAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFuncionAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFuncionAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFuncionAgregar.Location = new System.Drawing.Point(663, 550);
            this.btnFuncionAgregar.Name = "btnFuncionAgregar";
            this.btnFuncionAgregar.Size = new System.Drawing.Size(178, 44);
            this.btnFuncionAgregar.TabIndex = 34;
            this.btnFuncionAgregar.Text = "Agregar alquiler";
            this.btnFuncionAgregar.UseVisualStyleBackColor = false;
            this.btnFuncionAgregar.Visible = false;
            this.btnFuncionAgregar.Click += new System.EventHandler(this.btnFuncionAgregar_Click);
            // 
            // txtContrato
            // 
            this.txtContrato.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContrato.Location = new System.Drawing.Point(718, 502);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(151, 28);
            this.txtContrato.TabIndex = 36;
            this.txtContrato.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(620, 505);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 21);
            this.label15.TabIndex = 35;
            this.label15.Text = "Contrato:";
            this.label15.Visible = false;
            // 
            // txtContratoEstado
            // 
            this.txtContratoEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContratoEstado.Location = new System.Drawing.Point(600, 237);
            this.txtContratoEstado.Name = "txtContratoEstado";
            this.txtContratoEstado.Size = new System.Drawing.Size(151, 28);
            this.txtContratoEstado.TabIndex = 38;
            this.txtContratoEstado.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(502, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 21);
            this.label16.TabIndex = 37;
            this.label16.Text = "Contrato:";
            this.label16.Visible = false;
            // 
            // FormUtilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1214, 715);
            this.Controls.Add(this.txtContratoEstado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnFuncionAgregar);
            this.Controls.Add(this.txtDiasAlquilado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.txtStockAlquiler);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFuncionEstado);
            this.Controls.Add(this.txtCambioEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAgregarH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.gridAlquileres);
            this.Controls.Add(this.txtMesLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnioLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTipoLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUtilidad";
            this.Text = "FormUtilidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUtilidad_FormClosing);
            this.Load += new System.EventHandler(this.FormUtilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnAgregarAlquiler;
        private Button btnCambiarEstado;
        private Button btnAgregarHerramienta;
        private Button btnListarAlquiler;
        private Label label1;
        private ComboBox comboTipoLista;
        private Label label2;
        private TextBox txtAnioLista;
        private TextBox txtMesLista;
        private Label label3;
        private DataGridView gridAlquileres;
        private DataGridViewTextBoxColumn nroStock;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn FechaAlquiler;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn tiempoDeAlquiler;
        private DataGridViewTextBoxColumn Estado;
        private Button btnGrid;
        private TextBox txtMarca;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private ComboBox comboEstado;
        private Label label6;
        private ComboBox comboTipo;
        private Label label7;
        private Button btnAgregarH;
        private TextBox txtCambioEstado;
        private Label label8;
        private Button btnFuncionEstado;
        private TextBox txtNombre;
        private Label label9;
        private TextBox txtApellido;
        private Label label10;
        private TextBox txtCedula;
        private Label label11;
        private TextBox txtStockAlquiler;
        private Label label12;
        private DateTimePicker dateTimeFecha;
        private Label label13;
        private TextBox txtDiasAlquilado;
        private Label label14;
        private Button btnFuncionAgregar;
        private TextBox txtContrato;
        private Label label15;
        private TextBox txtContratoEstado;
        private Label label16;
    }
}