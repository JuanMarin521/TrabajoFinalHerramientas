namespace Trabajo_final
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.cedulaLabel = new System.Windows.Forms.Label();
            this.cedulaBox = new System.Windows.Forms.TextBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Formulario para eliminar personas";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(120, 138);
            this.close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(112, 35);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // cedulaLabel
            // 
            this.cedulaLabel.AutoSize = true;
            this.cedulaLabel.Location = new System.Drawing.Point(165, 283);
            this.cedulaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cedulaLabel.Name = "cedulaLabel";
            this.cedulaLabel.Size = new System.Drawing.Size(59, 20);
            this.cedulaLabel.TabIndex = 9;
            this.cedulaLabel.Text = "Cédula";
            // 
            // cedulaBox
            // 
            this.cedulaBox.Location = new System.Drawing.Point(330, 272);
            this.cedulaBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cedulaBox.Name = "cedulaBox";
            this.cedulaBox.Size = new System.Drawing.Size(148, 26);
            this.cedulaBox.TabIndex = 8;
            this.cedulaBox.TextChanged += new System.EventHandler(this.cedulaBox_TextChanged);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(594, 595);
            this.aceptarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(150, 35);
            this.aceptarButton.TabIndex = 10;
            this.aceptarButton.Text = "Eliminar Persona";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 898);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cedulaLabel);
            this.Controls.Add(this.cedulaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label cedulaLabel;
        private System.Windows.Forms.TextBox cedulaBox;
        private System.Windows.Forms.Button aceptarButton;
    }
}