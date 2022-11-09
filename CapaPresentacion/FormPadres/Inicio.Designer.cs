namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnGestionAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAgendaPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCalendario = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDirectorio = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnControlPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRegistrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEquipos = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEquipo = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEquipoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReunion = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCrearEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.UserName = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGestionAgenda,
            this.BtnControlPersonal,
            this.BtnEquipos,
            this.BtnCategorias,
            this.BtnReunion,
            this.BtnCrearEntrada});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 60);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnGestionAgenda
            // 
            this.BtnGestionAgenda.AutoSize = false;
            this.BtnGestionAgenda.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnGestionAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgendaPersonal,
            this.BtnCalendario,
            this.BtnDirectorio,
            this.BtnTareas,
            this.BtnNotas});
            this.BtnGestionAgenda.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BtnGestionAgenda.ForeColor = System.Drawing.Color.White;
            this.BtnGestionAgenda.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestionAgenda.Image")));
            this.BtnGestionAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGestionAgenda.Name = "BtnGestionAgenda";
            this.BtnGestionAgenda.Size = new System.Drawing.Size(200, 60);
            this.BtnGestionAgenda.Text = "Gestion Agenda";
            this.BtnGestionAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnGestionAgenda.MouseLeave += new System.EventHandler(this.BtnAgenda_MouseLeave);
            this.BtnGestionAgenda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAgenda_MouseMove);
            // 
            // BtnAgendaPersonal
            // 
            this.BtnAgendaPersonal.AutoSize = false;
            this.BtnAgendaPersonal.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnAgendaPersonal.ForeColor = System.Drawing.Color.White;
            this.BtnAgendaPersonal.Name = "BtnAgendaPersonal";
            this.BtnAgendaPersonal.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnAgendaPersonal.Size = new System.Drawing.Size(230, 50);
            this.BtnAgendaPersonal.Text = "Agenda Personal";
            this.BtnAgendaPersonal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgendaPersonal.Click += new System.EventHandler(this.BtnAgendaPersonal_Click);
            // 
            // BtnCalendario
            // 
            this.BtnCalendario.AutoSize = false;
            this.BtnCalendario.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnCalendario.ForeColor = System.Drawing.Color.White;
            this.BtnCalendario.Name = "BtnCalendario";
            this.BtnCalendario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnCalendario.Size = new System.Drawing.Size(230, 50);
            this.BtnCalendario.Text = "Calendario";
            this.BtnCalendario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalendario.Click += new System.EventHandler(this.BtnCalendario_Click);
            this.BtnCalendario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCalendario_MouseMove);
            // 
            // BtnDirectorio
            // 
            this.BtnDirectorio.AutoSize = false;
            this.BtnDirectorio.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnDirectorio.ForeColor = System.Drawing.Color.White;
            this.BtnDirectorio.Name = "BtnDirectorio";
            this.BtnDirectorio.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnDirectorio.Size = new System.Drawing.Size(230, 50);
            this.BtnDirectorio.Text = "Directorio";
            this.BtnDirectorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDirectorio.Click += new System.EventHandler(this.BtnDirectorio_Click);
            this.BtnDirectorio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnDirectorio_MouseMove);
            // 
            // BtnTareas
            // 
            this.BtnTareas.AutoSize = false;
            this.BtnTareas.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnTareas.ForeColor = System.Drawing.Color.White;
            this.BtnTareas.Name = "BtnTareas";
            this.BtnTareas.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnTareas.Size = new System.Drawing.Size(230, 50);
            this.BtnTareas.Text = "Tareas";
            this.BtnTareas.Click += new System.EventHandler(this.BtnTareas_Click);
            this.BtnTareas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnTareas_MouseMove);
            // 
            // BtnNotas
            // 
            this.BtnNotas.AutoSize = false;
            this.BtnNotas.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnNotas.ForeColor = System.Drawing.Color.White;
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.BtnNotas.Size = new System.Drawing.Size(230, 50);
            this.BtnNotas.Text = "Notas";
            this.BtnNotas.Click += new System.EventHandler(this.BtnNotas_Click);
            this.BtnNotas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnNotas_MouseMove);
            // 
            // BtnControlPersonal
            // 
            this.BtnControlPersonal.AutoSize = false;
            this.BtnControlPersonal.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnControlPersonal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRegistrarUsuario});
            this.BtnControlPersonal.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BtnControlPersonal.ForeColor = System.Drawing.Color.White;
            this.BtnControlPersonal.Image = ((System.Drawing.Image)(resources.GetObject("BtnControlPersonal.Image")));
            this.BtnControlPersonal.Name = "BtnControlPersonal";
            this.BtnControlPersonal.Size = new System.Drawing.Size(250, 60);
            this.BtnControlPersonal.Text = "Control del Personal";
            this.BtnControlPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnControlPersonal.MouseLeave += new System.EventHandler(this.BtnControlPersonal_MouseLeave);
            this.BtnControlPersonal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnControlPersonal_MouseMove);
            // 
            // BtnRegistrarUsuario
            // 
            this.BtnRegistrarUsuario.AutoSize = false;
            this.BtnRegistrarUsuario.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(250, 40);
            this.BtnRegistrarUsuario.Text = "Registrar Usuario";
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            this.BtnRegistrarUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnRegistrarUsuario_MouseMove);
            // 
            // BtnEquipos
            // 
            this.BtnEquipos.AutoSize = false;
            this.BtnEquipos.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnEquipos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEquipo,
            this.BtnEquipoUsuarios});
            this.BtnEquipos.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BtnEquipos.ForeColor = System.Drawing.Color.White;
            this.BtnEquipos.Image = ((System.Drawing.Image)(resources.GetObject("BtnEquipos.Image")));
            this.BtnEquipos.Name = "BtnEquipos";
            this.BtnEquipos.Size = new System.Drawing.Size(152, 60);
            this.BtnEquipos.Text = "Equipos";
            this.BtnEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnEquipos.MouseLeave += new System.EventHandler(this.BtnEquipos_MouseLeave);
            this.BtnEquipos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEquipos_MouseMove);
            // 
            // BtnEquipo
            // 
            this.BtnEquipo.AutoSize = false;
            this.BtnEquipo.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnEquipo.ForeColor = System.Drawing.Color.White;
            this.BtnEquipo.Name = "BtnEquipo";
            this.BtnEquipo.Size = new System.Drawing.Size(330, 50);
            this.BtnEquipo.Text = "Registrar Equipo";
            this.BtnEquipo.Click += new System.EventHandler(this.BtnEquipo_Click);
            // 
            // BtnEquipoUsuarios
            // 
            this.BtnEquipoUsuarios.AutoSize = false;
            this.BtnEquipoUsuarios.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnEquipoUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnEquipoUsuarios.Name = "BtnEquipoUsuarios";
            this.BtnEquipoUsuarios.Size = new System.Drawing.Size(330, 50);
            this.BtnEquipoUsuarios.Text = "Registrar Equipo de Usuario";
            this.BtnEquipoUsuarios.Click += new System.EventHandler(this.BtnEquipoUsuarios_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.AutoSize = false;
            this.BtnCategorias.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnCategorias.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BtnCategorias.ForeColor = System.Drawing.Color.White;
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(152, 60);
            this.BtnCategorias.Text = "Categorias";
            this.BtnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // BtnReunion
            // 
            this.BtnReunion.AutoSize = false;
            this.BtnReunion.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnReunion.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BtnReunion.ForeColor = System.Drawing.Color.White;
            this.BtnReunion.Name = "BtnReunion";
            this.BtnReunion.Size = new System.Drawing.Size(152, 60);
            this.BtnReunion.Text = "Reuniones";
            this.BtnReunion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnReunion.Click += new System.EventHandler(this.BtnReunion_Click);
            this.BtnReunion.MouseLeave += new System.EventHandler(this.BtnReunion_MouseLeave);
            this.BtnReunion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnReunion_MouseMove);
            // 
            // BtnCrearEntrada
            // 
            this.BtnCrearEntrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem});
            this.BtnCrearEntrada.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearEntrada.ForeColor = System.Drawing.Color.White;
            this.BtnCrearEntrada.Name = "BtnCrearEntrada";
            this.BtnCrearEntrada.Size = new System.Drawing.Size(111, 56);
            this.BtnCrearEntrada.Text = "Entradas";
            this.BtnCrearEntrada.Click += new System.EventHandler(this.BtnCrearEntrada_Click);
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.BackColor = System.Drawing.Color.RoyalBlue;
            this.UserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(942, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(395, 30);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "UserName";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 60);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1132, 593);
            this.Contenedor.TabIndex = 3;
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.UserName);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnGestionAgenda;
        private System.Windows.Forms.ToolStripMenuItem BtnCalendario;
        private System.Windows.Forms.ToolStripMenuItem BtnDirectorio;
        private System.Windows.Forms.ToolStripMenuItem BtnNotas;
        private System.Windows.Forms.ToolStripMenuItem BtnReunion;
        private System.Windows.Forms.ToolStripMenuItem BtnControlPersonal;
        private System.Windows.Forms.ToolStripMenuItem BtnRegistrarUsuario;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.ToolStripMenuItem BtnTareas;
        private System.Windows.Forms.ToolStripMenuItem BtnEquipos;
        private System.Windows.Forms.ToolStripMenuItem BtnCrearEntrada;
        private System.Windows.Forms.ToolStripMenuItem BtnCategorias;
        private System.Windows.Forms.ToolStripMenuItem BtnEquipo;
        private System.Windows.Forms.ToolStripMenuItem BtnEquipoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem BtnAgendaPersonal;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
    }
}

