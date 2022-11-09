namespace CapaPresentacion.FormPadres
{
    partial class FormEquipoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipoUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExportar = new CapaPresentacion.RJButton();
            this.BtnImprimir = new CapaPresentacion.RJButton();
            this.GridViewEquipoUsuario = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCrearNuevo = new CapaPresentacion.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEquipoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1114, 546);
            this.label2.TabIndex = 202;
            // 
            // BtnExportar
            // 
            this.BtnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnExportar.ColorBorde = System.Drawing.Color.PaleVioletRed;
            this.BtnExportar.ColorBoton = System.Drawing.Color.ForestGreen;
            this.BtnExportar.ColorTexto = System.Drawing.Color.White;
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportar.Image")));
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportar.Location = new System.Drawing.Point(902, 7);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnExportar.RadioBorde = 15;
            this.BtnExportar.Size = new System.Drawing.Size(200, 56);
            this.BtnExportar.TabIndex = 204;
            this.BtnExportar.TamañoBorde = 0;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
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
            this.BtnImprimir.Location = new System.Drawing.Point(696, 7);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnImprimir.RadioBorde = 15;
            this.BtnImprimir.Size = new System.Drawing.Size(200, 56);
            this.BtnImprimir.TabIndex = 205;
            this.BtnImprimir.TamañoBorde = 0;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // GridViewEquipoUsuario
            // 
            this.GridViewEquipoUsuario.AllowUserToAddRows = false;
            this.GridViewEquipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewEquipoUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewEquipoUsuario.BackgroundColor = System.Drawing.Color.White;
            this.GridViewEquipoUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewEquipoUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewEquipoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewEquipoUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewEquipoUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewEquipoUsuario.EnableHeadersVisualStyles = false;
            this.GridViewEquipoUsuario.Location = new System.Drawing.Point(2, 69);
            this.GridViewEquipoUsuario.MultiSelect = false;
            this.GridViewEquipoUsuario.Name = "GridViewEquipoUsuario";
            this.GridViewEquipoUsuario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewEquipoUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewEquipoUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.GridViewEquipoUsuario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewEquipoUsuario.RowTemplate.Height = 35;
            this.GridViewEquipoUsuario.Size = new System.Drawing.Size(1111, 471);
            this.GridViewEquipoUsuario.TabIndex = 206;
            this.GridViewEquipoUsuario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridViewEquipoUsuario_CellPainting);
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
            this.BtnCrearNuevo.Location = new System.Drawing.Point(13, 7);
            this.BtnCrearNuevo.Name = "BtnCrearNuevo";
            this.BtnCrearNuevo.RadioBorde = 15;
            this.BtnCrearNuevo.Size = new System.Drawing.Size(200, 56);
            this.BtnCrearNuevo.TabIndex = 207;
            this.BtnCrearNuevo.TamañoBorde = 0;
            this.BtnCrearNuevo.Text = "Crear Nuevo";
            this.BtnCrearNuevo.UseVisualStyleBackColor = false;
            this.BtnCrearNuevo.Click += new System.EventHandler(this.BtnCrearNuevo_Click);
            // 
            // FormEquipoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 546);
            this.Controls.Add(this.GridViewEquipoUsuario);
            this.Controls.Add(this.BtnCrearNuevo);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.label2);
            this.Name = "FormEquipoUsuarios";
            this.Text = "FormEquipoUsuarios";
            this.Load += new System.EventHandler(this.FormEquipoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEquipoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private RJButton BtnExportar;
        private RJButton BtnImprimir;
        private System.Windows.Forms.DataGridView GridViewEquipoUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private RJButton BtnCrearNuevo;
    }
}