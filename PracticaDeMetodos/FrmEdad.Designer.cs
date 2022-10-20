namespace PracticaDeMetodos
{
    partial class FrmEdad
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
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(308, 95);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 1;
            // 
            // btnEdad
            // 
            this.btnEdad.Location = new System.Drawing.Point(333, 164);
            this.btnEdad.Name = "btnEdad";
            this.btnEdad.Size = new System.Drawing.Size(75, 23);
            this.btnEdad.TabIndex = 2;
            this.btnEdad.Text = "Ok";
            this.btnEdad.UseVisualStyleBackColor = true;
            this.btnEdad.Click += new System.EventHandler(this.btnEdad_Click);
            // 
            // FrmEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Name = "FrmEdad";
            this.Text = "FrmEdad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnEdad;
    }
}