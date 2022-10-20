namespace PracticaDeMetodos
{
    partial class FrmMultiplicar
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
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.txtMultiplicar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(415, 189);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 0;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // txtMultiplicar
            // 
            this.txtMultiplicar.Location = new System.Drawing.Point(415, 108);
            this.txtMultiplicar.Name = "txtMultiplicar";
            this.txtMultiplicar.Size = new System.Drawing.Size(100, 20);
            this.txtMultiplicar.TabIndex = 1;
            this.txtMultiplicar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese un numero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMultiplicar);
            this.Controls.Add(this.btnMultiplicar);
            this.Name = "FrmMultiplicar";
            this.Text = "FrmMultiplicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.TextBox txtMultiplicar;
        private System.Windows.Forms.Label label1;
    }
}