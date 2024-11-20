namespace Trabajo_final
{
    partial class Form2
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
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.rolBox = new System.Windows.Forms.TextBox();
            this.cedulaBox = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.cedulaLabel = new System.Windows.Forms.Label();
            this.rolLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(80, 90);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario para registrar personas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(220, 163);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(162, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
          
            // 
            // cedulaBox
            // 
            this.cedulaBox.Location = new System.Drawing.Point(220, 218);
            this.cedulaBox.Name = "cedulaBox";
            this.cedulaBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaBox.TabIndex = 5;
            this.cedulaBox.TextChanged += new System.EventHandler(this.cedulaBox_TextChanged);
            // 
            // rolBox
            // 
            this.rolBox.Location = new System.Drawing.Point(220, 278);
            this.rolBox.Name = "rolBox";
            this.rolBox.Size = new System.Drawing.Size(100, 20);
            this.rolBox.TabIndex = 4;
            this.rolBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(110, 165);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // cedulaLabel
            // 
            this.cedulaLabel.AutoSize = true;
            this.cedulaLabel.Location = new System.Drawing.Point(110, 225);
            this.cedulaLabel.Name = "cedulaLabel";
            this.cedulaLabel.Size = new System.Drawing.Size(40, 13);
            this.cedulaLabel.TabIndex = 7;
            this.cedulaLabel.Text = "Cédula";
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Location = new System.Drawing.Point(110, 285);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(23, 13);
            this.rolLabel.TabIndex = 8;
            this.rolLabel.Text = "Rol";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(441, 404);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Aceptar";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(700, 487);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.rolLabel);
            this.Controls.Add(this.cedulaLabel);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.cedulaBox);
            this.Controls.Add(this.rolBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox rolBox;
        private System.Windows.Forms.TextBox cedulaBox;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label cedulaLabel;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.Button acceptButton;
    }
}