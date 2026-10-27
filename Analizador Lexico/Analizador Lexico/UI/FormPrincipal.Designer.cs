namespace AnalizadorLexico.UI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.DataGridView dgvSimbolos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvSimbolos = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.RichTextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnEscanear = new System.Windows.Forms.Button();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblTokens = new System.Windows.Forms.Label();
            this.lblSimbolos = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalLineas = new System.Windows.Forms.Label();
            this.lblTotalTokens = new System.Windows.Forms.Label();
            this.lblTotalErrores = new System.Windows.Forms.Label();
            this.lblTiempoAnalisis = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLinea = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCodigoFuente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.sfdExportar = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErrores
            // 
            this.dgvErrores.AllowUserToAddRows = false;
            this.dgvErrores.AllowUserToDeleteRows = false;
            this.dgvErrores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrores.BackgroundColor = System.Drawing.Color.White;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Location = new System.Drawing.Point(4, 48);
            this.dgvErrores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvErrores.MultiSelect = false;
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.ReadOnly = true;
            this.dgvErrores.RowHeadersWidth = 62;
            this.dgvErrores.Size = new System.Drawing.Size(1941, 165);
            this.dgvErrores.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos de código|*.txt;*.cs|Todos los archivos|*.*";
            // 
            // dgvSimbolos
            // 
            this.dgvSimbolos.AllowUserToAddRows = false;
            this.dgvSimbolos.AllowUserToDeleteRows = false;
            this.dgvSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSimbolos.BackgroundColor = System.Drawing.Color.White;
            this.dgvSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimbolos.Location = new System.Drawing.Point(4, 49);
            this.dgvSimbolos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSimbolos.MultiSelect = false;
            this.dgvSimbolos.Name = "dgvSimbolos";
            this.dgvSimbolos.ReadOnly = true;
            this.dgvSimbolos.RowHeadersWidth = 62;
            this.dgvSimbolos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSimbolos.Size = new System.Drawing.Size(1092, 217);
            this.dgvSimbolos.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(6, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(796, 527);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.Text = "";
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnAbrir.FlatAppearance.BorderSize = 4;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(33, 52);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(332, 97);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "             Cargar Archivo";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnEscanear
            // 
            this.btnEscanear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(218)))), ((int)(((byte)(117)))));
            this.btnEscanear.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnEscanear.FlatAppearance.BorderSize = 4;
            this.btnEscanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscanear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanear.ForeColor = System.Drawing.Color.White;
            this.btnEscanear.Location = new System.Drawing.Point(386, 52);
            this.btnEscanear.Margin = new System.Windows.Forms.Padding(0);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(332, 98);
            this.btnEscanear.TabIndex = 1;
            this.btnEscanear.Text = "             Ejecutar Análisis";
            this.btnEscanear.UseVisualStyleBackColor = false;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToAddRows = false;
            this.dgvTokens.AllowUserToDeleteRows = false;
            this.dgvTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTokens.BackgroundColor = System.Drawing.Color.White;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Location = new System.Drawing.Point(4, 48);
            this.dgvTokens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTokens.MultiSelect = false;
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.ReadOnly = true;
            this.dgvTokens.RowHeadersVisible = false;
            this.dgvTokens.RowHeadersWidth = 62;
            this.dgvTokens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTokens.Size = new System.Drawing.Size(1092, 215);
            this.dgvTokens.TabIndex = 3;
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.White;
            this.lblErrores.Location = new System.Drawing.Point(66, 5);
            this.lblErrores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(224, 40);
            this.lblErrores.TabIndex = 6;
            this.lblErrores.Text = "Errores  léxicos";
            // 
            // lblTokens
            // 
            this.lblTokens.AutoSize = true;
            this.lblTokens.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokens.ForeColor = System.Drawing.Color.White;
            this.lblTokens.Location = new System.Drawing.Point(78, 5);
            this.lblTokens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(235, 40);
            this.lblTokens.TabIndex = 7;
            this.lblTokens.Text = "Tabla de Tokens";
            // 
            // lblSimbolos
            // 
            this.lblSimbolos.AutoSize = true;
            this.lblSimbolos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbolos.ForeColor = System.Drawing.Color.White;
            this.lblSimbolos.Location = new System.Drawing.Point(80, 6);
            this.lblSimbolos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimbolos.Name = "lblSimbolos";
            this.lblSimbolos.Size = new System.Drawing.Size(266, 40);
            this.lblSimbolos.TabIndex = 8;
            this.lblSimbolos.Text = "Tabla de Símbolos";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExportar.FlatAppearance.BorderSize = 4;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(1677, 52);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(300, 98);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "             Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.btnEscanear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(18, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2018, 1042);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.07692F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 322F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalLineas, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalTokens, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalErrores, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTiempoAnalisis, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox11, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(885, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 142);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblTotalLineas
            // 
            this.lblTotalLineas.AutoSize = true;
            this.lblTotalLineas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLineas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalLineas.Location = new System.Drawing.Point(444, 2);
            this.lblTotalLineas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLineas.Name = "lblTotalLineas";
            this.lblTotalLineas.Size = new System.Drawing.Size(206, 32);
            this.lblTotalLineas.TabIndex = 17;
            this.lblTotalLineas.Text = "Total de líneas: 0";
            // 
            // lblTotalTokens
            // 
            this.lblTotalTokens.AutoSize = true;
            this.lblTotalTokens.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTokens.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalTokens.Location = new System.Drawing.Point(99, 2);
            this.lblTotalTokens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTokens.Name = "lblTotalTokens";
            this.lblTotalTokens.Size = new System.Drawing.Size(202, 31);
            this.lblTotalTokens.TabIndex = 11;
            this.lblTotalTokens.Text = "Total de tokens: 0";
            // 
            // lblTotalErrores
            // 
            this.lblTotalErrores.AutoSize = true;
            this.lblTotalErrores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalErrores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalErrores.Location = new System.Drawing.Point(99, 72);
            this.lblTotalErrores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalErrores.Name = "lblTotalErrores";
            this.lblTotalErrores.Size = new System.Drawing.Size(205, 31);
            this.lblTotalErrores.TabIndex = 18;
            this.lblTotalErrores.Text = "Total de errores: 0";
            // 
            // lblTiempoAnalisis
            // 
            this.lblTiempoAnalisis.AutoSize = true;
            this.lblTiempoAnalisis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoAnalisis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTiempoAnalisis.Location = new System.Drawing.Point(444, 72);
            this.lblTiempoAnalisis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoAnalisis.Name = "lblTiempoAnalisis";
            this.lblTiempoAnalisis.Size = new System.Drawing.Size(274, 31);
            this.lblTiempoAnalisis.TabIndex = 19;
            this.lblTiempoAnalisis.Text = "Tiempo de análisis: 0 ms";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Analizador_Lexico.Properties.Resources.simbolos;
            this.pictureBox9.Location = new System.Drawing.Point(6, 7);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(81, 57);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Analizador_Lexico.Properties.Resources.error1;
            this.pictureBox10.Location = new System.Drawing.Point(6, 77);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(81, 57);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Analizador_Lexico.Properties.Resources.tiempo;
            this.pictureBox12.Location = new System.Drawing.Point(348, 77);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(84, 57);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Analizador_Lexico.Properties.Resources.lineas;
            this.pictureBox11.Location = new System.Drawing.Point(348, 7);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(86, 57);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 22;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox7.Image = global::Analizador_Lexico.Properties.Resources.exportacion;
            this.pictureBox7.Location = new System.Drawing.Point(1746, 72);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(66, 55);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(218)))), ((int)(((byte)(117)))));
            this.pictureBox6.Image = global::Analizador_Lexico.Properties.Resources.play;
            this.pictureBox6.Location = new System.Drawing.Point(408, 72);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(82, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(207)))));
            this.pictureBox2.Image = global::Analizador_Lexico.Properties.Resources.carpeta;
            this.pictureBox2.Location = new System.Drawing.Point(64, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.lblLinea);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblCodigoFuente);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Location = new System.Drawing.Point(30, 198);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 583);
            this.panel3.TabIndex = 12;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(10, 58);
            this.lblLinea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(0, 20);
            this.lblLinea.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Analizador_Lexico.Properties.Resources.codigo_fuente;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblCodigoFuente
            // 
            this.lblCodigoFuente.AutoSize = true;
            this.lblCodigoFuente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFuente.ForeColor = System.Drawing.Color.White;
            this.lblCodigoFuente.Location = new System.Drawing.Point(68, 5);
            this.lblCodigoFuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoFuente.Name = "lblCodigoFuente";
            this.lblCodigoFuente.Size = new System.Drawing.Size(217, 40);
            this.lblCodigoFuente.TabIndex = 8;
            this.lblCodigoFuente.Text = "Código Fuente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.dgvErrores);
            this.panel2.Controls.Add(this.lblErrores);
            this.panel2.Location = new System.Drawing.Point(32, 814);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1950, 217);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Analizador_Lexico.Properties.Resources.alerta;
            this.pictureBox5.Location = new System.Drawing.Point(12, 5);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.dgvSimbolos);
            this.panel4.Controls.Add(this.lblSimbolos);
            this.panel4.Location = new System.Drawing.Point(880, 511);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1101, 271);
            this.panel4.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Analizador_Lexico.Properties.Resources.T__simbolos;
            this.pictureBox4.Location = new System.Drawing.Point(4, 5);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.dgvTokens);
            this.panel5.Controls.Add(this.lblTokens);
            this.panel5.Location = new System.Drawing.Point(880, 198);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1101, 268);
            this.panel5.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Analizador_Lexico.Properties.Resources.Tabla_de_T;
            this.pictureBox3.Location = new System.Drawing.Point(4, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1962, 8);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 45);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(80, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 40);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Analizador Léxico";
            // 
            // sfdExportar
            // 
            this.sfdExportar.DefaultExt = "csv";
            this.sfdExportar.Filter = "Archivos CSV (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt";
            this.sfdExportar.Title = "Guardar resultados del análisis";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Analizador_Lexico.Properties.Resources.Analizador;
            this.pictureBox8.Location = new System.Drawing.Point(18, 8);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(69, 45);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizador Léxico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimbolos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtCodigo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblTokens;
        private System.Windows.Forms.Label lblSimbolos;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCodigoFuente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.SaveFileDialog sfdExportar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalTokens;
        private System.Windows.Forms.Label lblTotalErrores;
        private System.Windows.Forms.Label lblTiempoAnalisis;
        private System.Windows.Forms.Label lblTotalLineas;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblLinea;
    }
}

