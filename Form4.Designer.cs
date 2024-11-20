namespace Trabajo_final
{
    partial class Form4
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
            this.registarButton = new System.Windows.Forms.Button();
            this.cedulaLabel = new System.Windows.Forms.Label();
            this.identificadorLabel = new System.Windows.Forms.Label();
            this.cedulaBox = new System.Windows.Forms.TextBox();
            this.identificadorBox = new System.Windows.Forms.TextBox();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.cantidadBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Formulario para registrar prestamos";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(122, 149);
            this.close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(112, 35);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // registarButton
            // 
            this.registarButton.Location = new System.Drawing.Point(634, 580);
            this.registarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registarButton.Name = "registarButton";
            this.registarButton.Size = new System.Drawing.Size(112, 35);
            this.registarButton.TabIndex = 6;
            this.registarButton.Text = "Registrar";
            this.registarButton.UseVisualStyleBackColor = true;
            this.registarButton.Click += new System.EventHandler(this.registarButton_Click);
            // 
            // cedulaLabel
            // 
            this.cedulaLabel.AutoSize = true;
            this.cedulaLabel.Location = new System.Drawing.Point(134, 335);
            this.cedulaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cedulaLabel.Name = "cedulaLabel";
            this.cedulaLabel.Size = new System.Drawing.Size(59, 20);
            this.cedulaLabel.TabIndex = 7;
            this.cedulaLabel.Text = "Cedula";
            // 
            // identificadorLabel
            // 
            this.identificadorLabel.AutoSize = true;
            this.identificadorLabel.Location = new System.Drawing.Point(134, 411);
            this.identificadorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.identificadorLabel.Name = "identificadorLabel";
            this.identificadorLabel.Size = new System.Drawing.Size(157, 20);
            this.identificadorLabel.TabIndex = 8;
            this.identificadorLabel.Text = "Identificador material";
            // 
            // cedulaBox
            // 
            this.cedulaBox.Location = new System.Drawing.Point(318, 331);
            this.cedulaBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cedulaBox.Name = "cedulaBox";
            this.cedulaBox.Size = new System.Drawing.Size(181, 26);
            this.cedulaBox.TabIndex = 9;
            this.cedulaBox.TextChanged += new System.EventHandler(this.cedulaBox_TextChanged);
            // 
            // identificadorBox
            // 
            this.identificadorBox.Location = new System.Drawing.Point(318, 400);
            this.identificadorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.identificadorBox.Name = "identificadorBox";
            this.identificadorBox.Size = new System.Drawing.Size(181, 26);
            this.identificadorBox.TabIndex = 10;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(134, 480);
            this.cantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(73, 20);
            this.cantidadLabel.TabIndex = 11;
            this.cantidadLabel.Text = "Cantidad";
            // 
            // cantidadBox
            // 
            this.cantidadBox.Location = new System.Drawing.Point(318, 475);
            this.cantidadBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(181, 26);
            this.cantidadBox.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 898);
            this.Controls.Add(this.cantidadBox);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.identificadorBox);
            this.Controls.Add(this.cedulaBox);
            this.Controls.Add(this.identificadorLabel);
            this.Controls.Add(this.cedulaLabel);
            this.Controls.Add(this.registarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button registarButton;
        private System.Windows.Forms.Label cedulaLabel;
        private System.Windows.Forms.Label identificadorLabel;
        private System.Windows.Forms.TextBox cedulaBox;
        private System.Windows.Forms.TextBox identificadorBox;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.TextBox cantidadBox;
    }
}