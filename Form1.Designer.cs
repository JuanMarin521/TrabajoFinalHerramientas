namespace Trabajo_final
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.botonHistorial = new System.Windows.Forms.Button();
            this.panelObjetosSubMenu = new System.Windows.Forms.Panel();
            this.btnIncreCantiObjetos = new System.Windows.Forms.Button();
            this.btnRegistrarDevolucion = new System.Windows.Forms.Button();
            this.btnRegistrarMaterial = new System.Windows.Forms.Button();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.botonObjetos = new System.Windows.Forms.Button();
            this.panelPersonasSubMenu = new System.Windows.Forms.Panel();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.btnRegistrarPersona = new System.Windows.Forms.Button();
            this.botonPersonas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelFormularioHijo = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.panelObjetosSubMenu.SuspendLayout();
            this.panelPersonasSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuLateral.Controls.Add(this.botonHistorial);
            this.panelMenuLateral.Controls.Add(this.panelObjetosSubMenu);
            this.panelMenuLateral.Controls.Add(this.botonObjetos);
            this.panelMenuLateral.Controls.Add(this.panelPersonasSubMenu);
            this.panelMenuLateral.Controls.Add(this.botonPersonas);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 645);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // botonHistorial
            // 
            this.botonHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonHistorial.FlatAppearance.BorderSize = 0;
            this.botonHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonHistorial.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonHistorial.Location = new System.Drawing.Point(0, 432);
            this.botonHistorial.Name = "botonHistorial";
            this.botonHistorial.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botonHistorial.Size = new System.Drawing.Size(250, 45);
            this.botonHistorial.TabIndex = 5;
            this.botonHistorial.Text = "Historial";
            this.botonHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonHistorial.UseVisualStyleBackColor = true;
            this.botonHistorial.Click += new System.EventHandler(this.botonHistorial_Click);
            // 
            // panelObjetosSubMenu
            // 
            this.panelObjetosSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelObjetosSubMenu.Controls.Add(this.btnIncreCantiObjetos);
            this.panelObjetosSubMenu.Controls.Add(this.btnRegistrarDevolucion);
            this.panelObjetosSubMenu.Controls.Add(this.btnRegistrarMaterial);
            this.panelObjetosSubMenu.Controls.Add(this.btnRegistrarPrestamo);
            this.panelObjetosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelObjetosSubMenu.Location = new System.Drawing.Point(0, 274);
            this.panelObjetosSubMenu.Name = "panelObjetosSubMenu";
            this.panelObjetosSubMenu.Size = new System.Drawing.Size(250, 158);
            this.panelObjetosSubMenu.TabIndex = 4;
            this.panelObjetosSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelObjetosSubMenu_Paint);
            // 
            // btnIncreCantiObjetos
            // 
            this.btnIncreCantiObjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncreCantiObjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncreCantiObjetos.FlatAppearance.BorderSize = 0;
            this.btnIncreCantiObjetos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnIncreCantiObjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreCantiObjetos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncreCantiObjetos.Location = new System.Drawing.Point(0, 120);
            this.btnIncreCantiObjetos.Name = "btnIncreCantiObjetos";
            this.btnIncreCantiObjetos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIncreCantiObjetos.Size = new System.Drawing.Size(250, 40);
            this.btnIncreCantiObjetos.TabIndex = 3;
            this.btnIncreCantiObjetos.Text = "Incrementar cantidad de objeto";
            this.btnIncreCantiObjetos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncreCantiObjetos.UseVisualStyleBackColor = false;
            this.btnIncreCantiObjetos.Click += new System.EventHandler(this.btnIncreCantiObjetos_Click);
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarDevolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(0, 80);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(250, 40);
            this.btnRegistrarDevolucion.TabIndex = 2;
            this.btnRegistrarDevolucion.Text = "Registrar devolución";
            this.btnRegistrarDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            this.btnRegistrarDevolucion.Click += new System.EventHandler(this.btnRegistrarDevolucion_Click);
            // 
            // btnRegistrarMaterial
            // 
            this.btnRegistrarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarMaterial.FlatAppearance.BorderSize = 0;
            this.btnRegistrarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrarMaterial.Location = new System.Drawing.Point(0, 40);
            this.btnRegistrarMaterial.Name = "btnRegistrarMaterial";
            this.btnRegistrarMaterial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarMaterial.Size = new System.Drawing.Size(250, 40);
            this.btnRegistrarMaterial.TabIndex = 1;
            this.btnRegistrarMaterial.Text = "Registrar material";
            this.btnRegistrarMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarMaterial.UseVisualStyleBackColor = false;
            this.btnRegistrarMaterial.Click += new System.EventHandler(this.btnRegistrarMaterial_Click);
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarPrestamo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(250, 40);
            this.btnRegistrarPrestamo.TabIndex = 0;
            this.btnRegistrarPrestamo.Text = "Registrar prestamo";
            this.btnRegistrarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // botonObjetos
            // 
            this.botonObjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonObjetos.FlatAppearance.BorderSize = 0;
            this.botonObjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonObjetos.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonObjetos.Location = new System.Drawing.Point(0, 229);
            this.botonObjetos.Name = "botonObjetos";
            this.botonObjetos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botonObjetos.Size = new System.Drawing.Size(250, 45);
            this.botonObjetos.TabIndex = 3;
            this.botonObjetos.Text = "Objetos";
            this.botonObjetos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonObjetos.UseVisualStyleBackColor = true;
            this.botonObjetos.Click += new System.EventHandler(this.botonObjetos_Click);
            // 
            // panelPersonasSubMenu
            // 
            this.panelPersonasSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelPersonasSubMenu.Controls.Add(this.btnEliminarPersona);
            this.panelPersonasSubMenu.Controls.Add(this.btnRegistrarPersona);
            this.panelPersonasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPersonasSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelPersonasSubMenu.Name = "panelPersonasSubMenu";
            this.panelPersonasSubMenu.Size = new System.Drawing.Size(250, 84);
            this.panelPersonasSubMenu.TabIndex = 2;
            this.panelPersonasSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPersonasSubMenu_Paint);
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarPersona.FlatAppearance.BorderSize = 0;
            this.btnEliminarPersona.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEliminarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarPersona.Location = new System.Drawing.Point(0, 40);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminarPersona.Size = new System.Drawing.Size(250, 40);
            this.btnEliminarPersona.TabIndex = 1;
            this.btnEliminarPersona.Text = "Eliminar persona";
            this.btnEliminarPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPersona.UseVisualStyleBackColor = false;
            this.btnEliminarPersona.Click += new System.EventHandler(this.btnEliminarPersona_Click);
            // 
            // btnRegistrarPersona
            // 
            this.btnRegistrarPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarPersona.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPersona.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrarPersona.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarPersona.Name = "btnRegistrarPersona";
            this.btnRegistrarPersona.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarPersona.Size = new System.Drawing.Size(250, 40);
            this.btnRegistrarPersona.TabIndex = 0;
            this.btnRegistrarPersona.Text = "Registrar persona";
            this.btnRegistrarPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPersona.UseVisualStyleBackColor = false;
            this.btnRegistrarPersona.Click += new System.EventHandler(this.btnRegistrarPersona_Click);
            // 
            // botonPersonas
            // 
            this.botonPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonPersonas.FlatAppearance.BorderSize = 0;
            this.botonPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonas.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonPersonas.Location = new System.Drawing.Point(0, 100);
            this.botonPersonas.Name = "botonPersonas";
            this.botonPersonas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botonPersonas.Size = new System.Drawing.Size(250, 45);
            this.botonPersonas.TabIndex = 1;
            this.botonPersonas.Text = "Personas";
            this.botonPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonPersonas.UseVisualStyleBackColor = true;
            this.botonPersonas.Click += new System.EventHandler(this.botonPersonas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Gray;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.Gray;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(250, 545);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(684, 100);
            this.panelInferior.TabIndex = 2;
            this.panelInferior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInferior_Paint);
            // 
            // panelFormularioHijo
            // 
            this.panelFormularioHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioHijo.Location = new System.Drawing.Point(250, 0);
            this.panelFormularioHijo.Name = "panelFormularioHijo";
            this.panelFormularioHijo.Size = new System.Drawing.Size(684, 545);
            this.panelFormularioHijo.TabIndex = 3;
            this.panelFormularioHijo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularioHijo_Paint);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 645);
            this.Controls.Add(this.panelFormularioHijo);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelMenuLateral);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "UserControl1";
            this.Text = "Form1";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelObjetosSubMenu.ResumeLayout(false);
            this.panelPersonasSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button botonHistorial;
        private System.Windows.Forms.Panel panelObjetosSubMenu;
        private System.Windows.Forms.Button btnIncreCantiObjetos;
        private System.Windows.Forms.Button btnRegistrarDevolucion;
        private System.Windows.Forms.Button btnRegistrarMaterial;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.Button botonObjetos;
        private System.Windows.Forms.Panel panelPersonasSubMenu;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.Button btnRegistrarPersona;
        private System.Windows.Forms.Button botonPersonas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelFormularioHijo;
    }
}

