namespace Trabajo_final
{
    partial class Form6
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
            this.aceptButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cedulaBox = new System.Windows.Forms.TextBox();
            this.identMatBox = new System.Windows.Forms.TextBox();
            this.CantidadBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Formulario para registrar devolucion";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(91, 97);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 6;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // aceptButton
            // 
            this.aceptButton.Location = new System.Drawing.Point(461, 369);
            this.aceptButton.Name = "aceptButton";
            this.aceptButton.Size = new System.Drawing.Size(75, 23);
            this.aceptButton.TabIndex = 8;
            this.aceptButton.Text = "Aceptar";
            this.aceptButton.UseVisualStyleBackColor = true;
            this.aceptButton.Click += new System.EventHandler(this.aceptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cedula persona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Identificador material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cedulaBox
            // 
            this.cedulaBox.Location = new System.Drawing.Point(254, 196);
            this.cedulaBox.Name = "cedulaBox";
            this.cedulaBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaBox.TabIndex = 12;
            // 
            // identMatBox
            // 
            this.identMatBox.Location = new System.Drawing.Point(254, 252);
            this.identMatBox.Name = "identMatBox";
            this.identMatBox.Size = new System.Drawing.Size(100, 20);
            this.identMatBox.TabIndex = 13;
            // 
            // CantidadBox
            // 
            this.CantidadBox.Location = new System.Drawing.Point(254, 299);
            this.CantidadBox.Name = "CantidadBox";
            this.CantidadBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadBox.TabIndex = 14;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(700, 487);
            this.Controls.Add(this.CantidadBox);
            this.Controls.Add(this.identMatBox);
            this.Controls.Add(this.cedulaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aceptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button aceptButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cedulaBox;
        private System.Windows.Forms.TextBox identMatBox;
        private System.Windows.Forms.TextBox CantidadBox;
    }
}