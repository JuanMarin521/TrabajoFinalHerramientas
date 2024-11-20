namespace Trabajo_final
{
    partial class Form7
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
            this.incrementarButton = new System.Windows.Forms.Button();
            this.identMatLabel = new System.Windows.Forms.Label();
            this.identMatBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadMatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Formulario para incrementar cantidad de objetos";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(115, 99);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 6;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // incrementarButton
            // 
            this.incrementarButton.Location = new System.Drawing.Point(429, 355);
            this.incrementarButton.Name = "incrementarButton";
            this.incrementarButton.Size = new System.Drawing.Size(75, 23);
            this.incrementarButton.TabIndex = 8;
            this.incrementarButton.Text = "Aceptar";
            this.incrementarButton.UseVisualStyleBackColor = true;
            this.incrementarButton.Click += new System.EventHandler(this.incrementarButton_Click);
            // 
            // identMatLabel
            // 
            this.identMatLabel.AutoSize = true;
            this.identMatLabel.Location = new System.Drawing.Point(143, 180);
            this.identMatLabel.Name = "identMatLabel";
            this.identMatLabel.Size = new System.Drawing.Size(104, 13);
            this.identMatLabel.TabIndex = 10;
            this.identMatLabel.Text = "Identificador material";
            // 
            // identMatBox
            // 
            this.identMatBox.Location = new System.Drawing.Point(278, 177);
            this.identMatBox.Name = "identMatBox";
            this.identMatBox.Size = new System.Drawing.Size(100, 20);
            this.identMatBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad material";
            // 
            // cantidadMatBox
            // 
            this.cantidadMatBox.Location = new System.Drawing.Point(278, 230);
            this.cantidadMatBox.Name = "cantidadMatBox";
            this.cantidadMatBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadMatBox.TabIndex = 14;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(700, 584);
            this.Controls.Add(this.cantidadMatBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.identMatBox);
            this.Controls.Add(this.identMatLabel);
            this.Controls.Add(this.incrementarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button incrementarButton;
        private System.Windows.Forms.Label identMatLabel;
        private System.Windows.Forms.TextBox identMatBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidadMatBox;
    }
}