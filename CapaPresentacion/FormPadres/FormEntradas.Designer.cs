
namespace CapaPresentacion.FormPadres
{
    partial class FormEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntradas));
            this.GridViewEntradas = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnImprimir = new CapaPresentacion.RJButton();
            this.TxtExportar = new CapaPresentacion.RJButton();
            this.BtnCrearNuevo = new CapaPresentacion.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewEntradas
            // 
            this.GridViewEntradas.AllowUserToAddRows = false;
            this.GridViewEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewEntradas.BackgroundColor = System.Drawing.Color.White;
            this.GridViewEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewEntradas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewEntradas.EnableHeadersVisualStyles = false;
            this.GridViewEntradas.Location = new System.Drawing.Point(4, 73);
            this.GridViewEntradas.Name = "GridViewEntradas";
            this.GridViewEntradas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewEntradas.RowHeadersVisible = false;
            this.GridViewEntradas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.GridViewEntradas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewEntradas.RowTemplate.Height = 35;
            this.GridViewEntradas.Size = new System.Drawing.Size(1111, 530);
            this.GridViewEntradas.TabIndex = 187;
            this.GridViewEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewEntradas_CellContentClick);
            this.GridViewEntradas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridViewEntradas_CellPainting);
            // 
            // Editar
            // 
            this.Editar.FillWeight = 20F;
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 20F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.BtnImprimir.Location = new System.Drawing.Point(699, 11);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnImprimir.RadioBorde = 15;
            this.BtnImprimir.Size = new System.Drawing.Size(200, 56);
            this.BtnImprimir.TabIndex = 189;
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
            this.TxtExportar.Location = new System.Drawing.Point(905, 11);
            this.TxtExportar.Name = "TxtExportar";
            this.TxtExportar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TxtExportar.RadioBorde = 15;
            this.TxtExportar.Size = new System.Drawing.Size(200, 56);
            this.TxtExportar.TabIndex = 188;
            this.TxtExportar.TamañoBorde = 0;
            this.TxtExportar.Text = "Exportar";
            this.TxtExportar.UseVisualStyleBackColor = false;
            this.TxtExportar.Click += new System.EventHandler(this.TxtExportar_Click);
            // 
            // BtnCrearNuevo
            // 
            this.BtnCrearNuevo.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnCrearNuevo.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.BtnCrearNuevo.ColorBoton = System.Drawing.Color.MidnightBlue;
            this.BtnCrearNuevo.ColorTexto = System.Drawing.Color.White;
            this.BtnCrearNuevo.FlatAppearance.BorderSize = 0;
            this.BtnCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearNuevo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnCrearNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearNuevo.Location = new System.Drawing.Point(15, 11);
            this.BtnCrearNuevo.Name = "BtnCrearNuevo";
            this.BtnCrearNuevo.RadioBorde = 15;
            this.BtnCrearNuevo.Size = new System.Drawing.Size(200, 56);
            this.BtnCrearNuevo.TabIndex = 190;
            this.BtnCrearNuevo.TamañoBorde = 0;
            this.BtnCrearNuevo.Text = "Crear Nuevo";
            this.BtnCrearNuevo.UseVisualStyleBackColor = false;
            this.BtnCrearNuevo.Click += new System.EventHandler(this.BtnCrearNuevo_Click_1);
            // 
            // FormEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 615);
            this.Controls.Add(this.GridViewEntradas);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.TxtExportar);
            this.Controls.Add(this.BtnCrearNuevo);
            this.Name = "FormEntradas";
            this.Text = "FormEntradas";
            this.Load += new System.EventHandler(this.FormEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewEntradas;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private RJButton BtnImprimir;
        private RJButton TxtExportar;
        private RJButton BtnCrearNuevo;
    }
}