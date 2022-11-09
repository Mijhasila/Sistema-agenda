namespace CapaPresentacion.FormHijos
{
    partial class CrearAgendaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearAgendaPersonal));
            this.TxtIdAgenda = new System.Windows.Forms.TextBox();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnGuardar = new CapaPresentacion.RJButton();
            this.BtnLimpiarDatos = new CapaPresentacion.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscarEntrada = new CapaPresentacion.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIdAgenda
            // 
            this.TxtIdAgenda.Location = new System.Drawing.Point(310, 8);
            this.TxtIdAgenda.Name = "TxtIdAgenda";
            this.TxtIdAgenda.Size = new System.Drawing.Size(26, 22);
            this.TxtIdAgenda.TabIndex = 338;
            this.TxtIdAgenda.Visible = false;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdUsuario.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdUsuario.Location = new System.Drawing.Point(21, 79);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(90, 27);
            this.TxtIdUsuario.TabIndex = 336;
            this.TxtIdUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdUsuario_KeyDown);
            this.TxtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdUsuario_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 335;
            this.label10.Text = "Id Usuario";
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
            this.BtnGuardar.Location = new System.Drawing.Point(12, 250);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnGuardar.RadioBorde = 15;
            this.BtnGuardar.Size = new System.Drawing.Size(155, 40);
            this.BtnGuardar.TabIndex = 340;
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
            this.BtnLimpiarDatos.Location = new System.Drawing.Point(178, 250);
            this.BtnLimpiarDatos.Name = "BtnLimpiarDatos";
            this.BtnLimpiarDatos.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnLimpiarDatos.RadioBorde = 15;
            this.BtnLimpiarDatos.Size = new System.Drawing.Size(155, 40);
            this.BtnLimpiarDatos.TabIndex = 339;
            this.BtnLimpiarDatos.TamañoBorde = 0;
            this.BtnLimpiarDatos.Text = "Limpiar";
            this.BtnLimpiarDatos.UseVisualStyleBackColor = false;
            this.BtnLimpiarDatos.Click += new System.EventHandler(this.BtnLimpiarDatos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 337;
            this.pictureBox2.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(21, 175);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(312, 27);
            this.TxtUsuario.TabIndex = 342;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 343;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 341;
            this.label1.Text = "Usuario";
            // 
            // TxtBuscarEntrada
            // 
            this.TxtBuscarEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarEntrada.BackColor = System.Drawing.Color.ForestGreen;
            this.TxtBuscarEntrada.ColorBorde = System.Drawing.Color.Transparent;
            this.TxtBuscarEntrada.ColorBoton = System.Drawing.Color.ForestGreen;
            this.TxtBuscarEntrada.ColorTexto = System.Drawing.Color.White;
            this.TxtBuscarEntrada.FlatAppearance.BorderSize = 0;
            this.TxtBuscarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtBuscarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarEntrada.ForeColor = System.Drawing.Color.White;
            this.TxtBuscarEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtBuscarEntrada.Location = new System.Drawing.Point(144, 73);
            this.TxtBuscarEntrada.Name = "TxtBuscarEntrada";
            this.TxtBuscarEntrada.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TxtBuscarEntrada.RadioBorde = 15;
            this.TxtBuscarEntrada.Size = new System.Drawing.Size(145, 40);
            this.TxtBuscarEntrada.TabIndex = 344;
            this.TxtBuscarEntrada.TamañoBorde = 0;
            this.TxtBuscarEntrada.Text = "Buscar";
            this.TxtBuscarEntrada.UseVisualStyleBackColor = false;
            // 
            // CrearAgendaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 299);
            this.Controls.Add(this.TxtBuscarEntrada);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnLimpiarDatos);
            this.Controls.Add(this.TxtIdAgenda);
            this.Controls.Add(this.TxtIdUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Name = "CrearAgendaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearAgendaPersonal";
            this.Load += new System.EventHandler(this.CrearAgendaPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton BtnGuardar;
        internal RJButton BtnLimpiarDatos;
        internal System.Windows.Forms.TextBox TxtIdAgenda;
        internal System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private RJButton TxtBuscarEntrada;
    }
}