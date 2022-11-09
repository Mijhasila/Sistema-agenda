namespace CapaPresentacion.FormHijos
{
    partial class CrearCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCategoria));
            this.TxtIdCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.TxtNombreCategoria = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.BtnBuscarUsuario = new CapaPresentacion.RJButton();
            this.BtnGuardar = new CapaPresentacion.RJButton();
            this.BtnLimpiarDatos = new CapaPresentacion.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIdCategoria
            // 
            this.TxtIdCategoria.BackColor = System.Drawing.Color.White;
            this.TxtIdCategoria.Enabled = false;
            this.TxtIdCategoria.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCategoria.Location = new System.Drawing.Point(356, 12);
            this.TxtIdCategoria.Name = "TxtIdCategoria";
            this.TxtIdCategoria.Size = new System.Drawing.Size(32, 34);
            this.TxtIdCategoria.TabIndex = 0;
            this.TxtIdCategoria.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 186;
            this.label3.Text = "Id Usuario: ";
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdUsuario.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdUsuario.Location = new System.Drawing.Point(44, 69);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(95, 27);
            this.TxtIdUsuario.TabIndex = 184;
            this.TxtIdUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdUsuario_KeyDown);
            this.TxtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdUsuario_KeyPress);
            // 
            // TxtNombreCategoria
            // 
            this.TxtNombreCategoria.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreCategoria.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCategoria.Location = new System.Drawing.Point(44, 247);
            this.TxtNombreCategoria.Name = "TxtNombreCategoria";
            this.TxtNombreCategoria.Size = new System.Drawing.Size(320, 27);
            this.TxtNombreCategoria.TabIndex = 182;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 183;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 181;
            this.label1.Text = "Categoria:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 189;
            this.pictureBox2.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(43, 157);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(321, 27);
            this.TxtUsuario.TabIndex = 285;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 284;
            this.label2.Text = "Usuario";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.White;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(30, 151);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(347, 40);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 283;
            this.pictureBox12.TabStop = false;
            // 
            // BtnBuscarUsuario
            // 
            this.BtnBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarUsuario.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnBuscarUsuario.ColorBorde = System.Drawing.Color.Transparent;
            this.BtnBuscarUsuario.ColorBoton = System.Drawing.Color.ForestGreen;
            this.BtnBuscarUsuario.ColorTexto = System.Drawing.Color.White;
            this.BtnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarUsuario.Location = new System.Drawing.Point(174, 63);
            this.BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            this.BtnBuscarUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnBuscarUsuario.RadioBorde = 15;
            this.BtnBuscarUsuario.Size = new System.Drawing.Size(145, 40);
            this.BtnBuscarUsuario.TabIndex = 282;
            this.BtnBuscarUsuario.TamañoBorde = 0;
            this.BtnBuscarUsuario.Text = "Buscar";
            this.BtnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.ColorBorde = System.Drawing.Color.Transparent;
            this.BtnGuardar.ColorBoton = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.ColorTexto = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.Location = new System.Drawing.Point(43, 313);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnGuardar.RadioBorde = 15;
            this.BtnGuardar.Size = new System.Drawing.Size(155, 40);
            this.BtnGuardar.TabIndex = 187;
            this.BtnGuardar.TamañoBorde = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiarDatos
            // 
            this.BtnLimpiarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiarDatos.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLimpiarDatos.ColorBorde = System.Drawing.Color.Transparent;
            this.BtnLimpiarDatos.ColorBoton = System.Drawing.Color.RoyalBlue;
            this.BtnLimpiarDatos.ColorTexto = System.Drawing.Color.White;
            this.BtnLimpiarDatos.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarDatos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarDatos.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarDatos.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiarDatos.Image")));
            this.BtnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiarDatos.Location = new System.Drawing.Point(209, 313);
            this.BtnLimpiarDatos.Name = "BtnLimpiarDatos";
            this.BtnLimpiarDatos.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnLimpiarDatos.RadioBorde = 15;
            this.BtnLimpiarDatos.Size = new System.Drawing.Size(155, 40);
            this.BtnLimpiarDatos.TabIndex = 102;
            this.BtnLimpiarDatos.TamañoBorde = 0;
            this.BtnLimpiarDatos.Text = "Limpiar";
            this.BtnLimpiarDatos.UseVisualStyleBackColor = false;
            this.BtnLimpiarDatos.Click += new System.EventHandler(this.BtnLimpiarDatos_Click);
            // 
            // CrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 356);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.BtnBuscarUsuario);
            this.Controls.Add(this.TxtIdCategoria);
            this.Controls.Add(this.TxtIdUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreCategoria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CrearCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHijoCategoria";
            this.Load += new System.EventHandler(this.CrearCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private RJButton BtnGuardar;
        internal RJButton BtnLimpiarDatos;
        internal System.Windows.Forms.TextBox TxtIdUsuario;
        internal System.Windows.Forms.TextBox TxtNombreCategoria;
        internal System.Windows.Forms.TextBox TxtIdCategoria;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox12;
        private RJButton BtnBuscarUsuario;
    }
}