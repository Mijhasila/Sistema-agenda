namespace CapaPresentacion.FormPadres
{
    partial class FormCalendario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendario));
            this.GridViewCalendario = new System.Windows.Forms.DataGridView();
            this.TxtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFechaInicio2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new CapaPresentacion.RJButton();
            this.BtnQuitarFiltro2 = new CapaPresentacion.RJButton();
            this.BtnFiltrarDesde = new CapaPresentacion.RJButton();
            this.BtnQuitarFiltro = new CapaPresentacion.RJButton();
            this.BtnFiltrar = new CapaPresentacion.RJButton();
            this.BtnImprimir = new CapaPresentacion.RJButton();
            this.TxtExportar = new CapaPresentacion.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCalendario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewCalendario
            // 
            this.GridViewCalendario.AllowUserToAddRows = false;
            this.GridViewCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewCalendario.BackgroundColor = System.Drawing.Color.White;
            this.GridViewCalendario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewCalendario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewCalendario.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewCalendario.EnableHeadersVisualStyles = false;
            this.GridViewCalendario.Location = new System.Drawing.Point(2, 131);
            this.GridViewCalendario.MultiSelect = false;
            this.GridViewCalendario.Name = "GridViewCalendario";
            this.GridViewCalendario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewCalendario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewCalendario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.GridViewCalendario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewCalendario.RowTemplate.Height = 35;
            this.GridViewCalendario.Size = new System.Drawing.Size(1127, 409);
            this.GridViewCalendario.TabIndex = 183;
            // 
            // TxtFechaFinal
            // 
            this.TxtFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.TxtFechaFinal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaFinal.Location = new System.Drawing.Point(209, 74);
            this.TxtFechaFinal.Name = "TxtFechaFinal";
            this.TxtFechaFinal.Size = new System.Drawing.Size(192, 30);
            this.TxtFechaFinal.TabIndex = 187;
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.TxtFechaInicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaInicio.Location = new System.Drawing.Point(6, 74);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(192, 30);
            this.TxtFechaInicio.TabIndex = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 190;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 191;
            this.label2.Text = "Hasta";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.BackColor = System.Drawing.Color.White;
            this.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(150, 44);
            this.TxtBusqueda.Multiline = true;
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(200, 34);
            this.TxtBusqueda.TabIndex = 193;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 22);
            this.label12.TabIndex = 192;
            this.label12.Text = "Buscar Equipo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 196;
            this.label4.Text = "Desde";
            // 
            // TxtFechaInicio2
            // 
            this.TxtFechaInicio2.CustomFormat = "dd/MM/yyyy";
            this.TxtFechaInicio2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaInicio2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaInicio2.Location = new System.Drawing.Point(11, 74);
            this.TxtFechaInicio2.Name = "TxtFechaInicio2";
            this.TxtFechaInicio2.Size = new System.Drawing.Size(192, 30);
            this.TxtFechaInicio2.TabIndex = 195;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFechaInicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtFechaFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnQuitarFiltro);
            this.groupBox1.Controls.Add(this.BtnFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 118);
            this.groupBox1.TabIndex = 199;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por Rango";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnQuitarFiltro2);
            this.groupBox2.Controls.Add(this.TxtFechaInicio2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnFiltrarDesde);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(656, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 118);
            this.groupBox2.TabIndex = 200;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Desde";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TxtBusqueda);
            this.groupBox3.Controls.Add(this.BtnBuscar);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1102, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 118);
            this.groupBox3.TabIndex = 201;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar Por Equipo";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnBuscar.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.BtnBuscar.ColorBoton = System.Drawing.Color.ForestGreen;
            this.BtnBuscar.ColorTexto = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(356, 40);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.BtnBuscar.RadioBorde = 15;
            this.BtnBuscar.Size = new System.Drawing.Size(120, 40);
            this.BtnBuscar.TabIndex = 194;
            this.BtnBuscar.TamañoBorde = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnQuitarFiltro2
            // 
            this.BtnQuitarFiltro2.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnQuitarFiltro2.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.BtnQuitarFiltro2.ColorBoton = System.Drawing.Color.RoyalBlue;
            this.BtnQuitarFiltro2.ColorTexto = System.Drawing.Color.White;
            this.BtnQuitarFiltro2.FlatAppearance.BorderSize = 0;
            this.BtnQuitarFiltro2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitarFiltro2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitarFiltro2.ForeColor = System.Drawing.Color.White;
            this.BtnQuitarFiltro2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQuitarFiltro2.Location = new System.Drawing.Point(306, 65);
            this.BtnQuitarFiltro2.Name = "BtnQuitarFiltro2";
            this.BtnQuitarFiltro2.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.BtnQuitarFiltro2.RadioBorde = 15;
            this.BtnQuitarFiltro2.Size = new System.Drawing.Size(121, 40);
            this.BtnQuitarFiltro2.TabIndex = 198;
            this.BtnQuitarFiltro2.TamañoBorde = 0;
            this.BtnQuitarFiltro2.Text = "Quitar Filtro";
            this.BtnQuitarFiltro2.UseVisualStyleBackColor = false;
            this.BtnQuitarFiltro2.Click += new System.EventHandler(this.BtnQuitarFiltro2_Click);
            // 
            // BtnFiltrarDesde
            // 
            this.BtnFiltrarDesde.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnFiltrarDesde.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.BtnFiltrarDesde.ColorBoton = System.Drawing.Color.ForestGreen;
            this.BtnFiltrarDesde.ColorTexto = System.Drawing.Color.White;
            this.BtnFiltrarDesde.FlatAppearance.BorderSize = 0;
            this.BtnFiltrarDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrarDesde.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrarDesde.ForeColor = System.Drawing.Color.White;
            this.BtnFiltrarDesde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFiltrarDesde.Location = new System.Drawing.Point(209, 66);
            this.BtnFiltrarDesde.Name = "BtnFiltrarDesde";
            this.BtnFiltrarDesde.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.BtnFiltrarDesde.RadioBorde = 15;
            this.BtnFiltrarDesde.Size = new System.Drawing.Size(91, 40);
            this.BtnFiltrarDesde.TabIndex = 197;
            this.BtnFiltrarDesde.TamañoBorde = 0;
            this.BtnFiltrarDesde.Text = "Filtrar";
            this.BtnFiltrarDesde.UseVisualStyleBackColor = false;
            this.BtnFiltrarDesde.Click += new System.EventHandler(this.BtnFiltrarDesde_Click);
            // 
            // BtnQuitarFiltro
            // 
            this.BtnQuitarFiltro.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnQuitarFiltro.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.BtnQuitarFiltro.ColorBoton = System.Drawing.Color.RoyalBlue;
            this.BtnQuitarFiltro.ColorTexto = System.Drawing.Color.White;
            this.BtnQuitarFiltro.FlatAppearance.BorderSize = 0;
            this.BtnQuitarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitarFiltro.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitarFiltro.ForeColor = System.Drawing.Color.White;
            this.BtnQuitarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQuitarFiltro.Location = new System.Drawing.Point(505, 66);
            this.BtnQuitarFiltro.Name = "BtnQuitarFiltro";
            this.BtnQuitarFiltro.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.BtnQuitarFiltro.RadioBorde = 15;
            this.BtnQuitarFiltro.Size = new System.Drawing.Size(121, 40);
            this.BtnQuitarFiltro.TabIndex = 189;
            this.BtnQuitarFiltro.TamañoBorde = 0;
            this.BtnQuitarFiltro.Text = "Quitar Filtro";
            this.BtnQuitarFiltro.UseVisualStyleBackColor = false;
            this.BtnQuitarFiltro.Click += new System.EventHandler(this.BtnQuitarFiltro_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnFiltrar.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.BtnFiltrar.ColorBoton = System.Drawing.Color.ForestGreen;
            this.BtnFiltrar.ColorTexto = System.Drawing.Color.White;
            this.BtnFiltrar.FlatAppearance.BorderSize = 0;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.ForeColor = System.Drawing.Color.White;
            this.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFiltrar.Location = new System.Drawing.Point(407, 66);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.BtnFiltrar.RadioBorde = 15;
            this.BtnFiltrar.Size = new System.Drawing.Size(91, 40);
            this.BtnFiltrar.TabIndex = 188;
            this.BtnFiltrar.TamañoBorde = 0;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimir.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnImprimir.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.BtnImprimir.ColorBoton = System.Drawing.Color.MidnightBlue;
            this.BtnImprimir.ColorTexto = System.Drawing.Color.White;
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimir.Location = new System.Drawing.Point(919, 69);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnImprimir.RadioBorde = 15;
            this.BtnImprimir.Size = new System.Drawing.Size(200, 56);
            this.BtnImprimir.TabIndex = 185;
            this.BtnImprimir.TamañoBorde = 0;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // TxtExportar
            // 
            this.TxtExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtExportar.BackColor = System.Drawing.Color.ForestGreen;
            this.TxtExportar.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.TxtExportar.ColorBoton = System.Drawing.Color.ForestGreen;
            this.TxtExportar.ColorTexto = System.Drawing.Color.White;
            this.TxtExportar.FlatAppearance.BorderSize = 0;
            this.TxtExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtExportar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExportar.ForeColor = System.Drawing.Color.White;
            this.TxtExportar.Image = ((System.Drawing.Image)(resources.GetObject("TxtExportar.Image")));
            this.TxtExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtExportar.Location = new System.Drawing.Point(919, 7);
            this.TxtExportar.Name = "TxtExportar";
            this.TxtExportar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TxtExportar.RadioBorde = 15;
            this.TxtExportar.Size = new System.Drawing.Size(200, 56);
            this.TxtExportar.TabIndex = 184;
            this.TxtExportar.TamañoBorde = 0;
            this.TxtExportar.Text = "Exportar";
            this.TxtExportar.UseVisualStyleBackColor = false;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 546);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridViewCalendario);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.TxtExportar);
            this.Name = "FormCalendario";
            this.Text = "Filtrar Por Rango";
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCalendario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewCalendario;
        private RJButton BtnImprimir;
        private RJButton TxtExportar;
        private RJButton BtnQuitarFiltro;
        private RJButton BtnFiltrar;
        internal System.Windows.Forms.DateTimePicker TxtFechaFinal;
        internal System.Windows.Forms.DateTimePicker TxtFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RJButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DateTimePicker TxtFechaInicio2;
        private RJButton BtnQuitarFiltro2;
        private RJButton BtnFiltrarDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}