namespace CapaPresentacion.FormHijos
{
    partial class CrearReunion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearReunion));
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtIdEReunion = new System.Windows.Forms.TextBox();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.TxtIndice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtObjetivo = new System.Windows.Forms.TextBox();
            this.TxtLugar = new System.Windows.Forms.TextBox();
            this.TxtAgenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new CapaPresentacion.RJButton();
            this.BtnLimpiarDatos = new CapaPresentacion.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFecha
            // 
            this.TxtFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtFecha.CustomFormat = "dd/MM/yyyy";
            this.TxtFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFecha.Location = new System.Drawing.Point(709, 82);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(192, 30);
            this.TxtFecha.TabIndex = 333;
            // 
            // TxtIdEReunion
            // 
            this.TxtIdEReunion.Location = new System.Drawing.Point(822, 13);
            this.TxtIdEReunion.Name = "TxtIdEReunion";
            this.TxtIdEReunion.Size = new System.Drawing.Size(26, 22);
            this.TxtIdEReunion.TabIndex = 332;
            this.TxtIdEReunion.Text = "0";
            this.TxtIdEReunion.Visible = false;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(868, 13);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(26, 22);
            this.TxtIdUsuario.TabIndex = 331;
            this.TxtIdUsuario.Text = "0";
            this.TxtIdUsuario.Visible = false;
            // 
            // TxtIndice
            // 
            this.TxtIndice.Location = new System.Drawing.Point(923, 13);
            this.TxtIndice.Name = "TxtIndice";
            this.TxtIndice.Size = new System.Drawing.Size(26, 22);
            this.TxtIndice.TabIndex = 330;
            this.TxtIndice.Text = "-1";
            this.TxtIndice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(747, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 329;
            this.label1.Text = "Fecha";
            // 
            // TxtObjetivo
            // 
            this.TxtObjetivo.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtObjetivo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObjetivo.Location = new System.Drawing.Point(29, 185);
            this.TxtObjetivo.Name = "TxtObjetivo";
            this.TxtObjetivo.Size = new System.Drawing.Size(192, 27);
            this.TxtObjetivo.TabIndex = 323;
            // 
            // TxtLugar
            // 
            this.TxtLugar.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLugar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLugar.Location = new System.Drawing.Point(276, 185);
            this.TxtLugar.Name = "TxtLugar";
            this.TxtLugar.Size = new System.Drawing.Size(390, 27);
            this.TxtLugar.TabIndex = 324;
            // 
            // TxtAgenda
            // 
            this.TxtAgenda.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAgenda.Enabled = false;
            this.TxtAgenda.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAgenda.Location = new System.Drawing.Point(29, 85);
            this.TxtAgenda.Name = "TxtAgenda";
            this.TxtAgenda.Size = new System.Drawing.Size(637, 27);
            this.TxtAgenda.TabIndex = 325;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 25);
            this.label11.TabIndex = 320;
            this.label11.Text = "Objetivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 322;
            this.label8.Text = "Lugar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 321;
            this.label10.Text = "Titulo";
            // 
            // TxtDuracion
            // 
            this.TxtDuracion.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDuracion.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDuracion.Location = new System.Drawing.Point(722, 185);
            this.TxtDuracion.Name = "TxtDuracion";
            this.TxtDuracion.Size = new System.Drawing.Size(192, 27);
            this.TxtDuracion.TabIndex = 335;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 334;
            this.label2.Text = "Duracion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 336;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.White;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(16, 178);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(220, 40);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 328;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(264, 178);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(424, 40);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 327;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(672, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 326;
            this.pictureBox2.TabStop = false;
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
            this.BtnGuardar.Location = new System.Drawing.Point(641, 282);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnGuardar.RadioBorde = 15;
            this.BtnGuardar.Size = new System.Drawing.Size(155, 40);
            this.BtnGuardar.TabIndex = 338;
            this.BtnGuardar.TamañoBorde = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
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
            this.BtnLimpiarDatos.Location = new System.Drawing.Point(802, 282);
            this.BtnLimpiarDatos.Name = "BtnLimpiarDatos";
            this.BtnLimpiarDatos.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnLimpiarDatos.RadioBorde = 15;
            this.BtnLimpiarDatos.Size = new System.Drawing.Size(155, 40);
            this.BtnLimpiarDatos.TabIndex = 337;
            this.BtnLimpiarDatos.TamañoBorde = 0;
            this.BtnLimpiarDatos.Text = "Limpiar";
            this.BtnLimpiarDatos.UseVisualStyleBackColor = false;
            // 
            // CrearReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 329);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnLimpiarDatos);
            this.Controls.Add(this.TxtDuracion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtIdEReunion);
            this.Controls.Add(this.TxtIdUsuario);
            this.Controls.Add(this.TxtIndice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtObjetivo);
            this.Controls.Add(this.TxtLugar);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.TxtAgenda);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Name = "CrearReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearReunion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker TxtFecha;
        private System.Windows.Forms.TextBox TxtIdEReunion;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.TextBox TxtIndice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtObjetivo;
        private System.Windows.Forms.TextBox TxtLugar;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox TxtAgenda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtDuracion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private RJButton BtnGuardar;
        internal RJButton BtnLimpiarDatos;
    }
}