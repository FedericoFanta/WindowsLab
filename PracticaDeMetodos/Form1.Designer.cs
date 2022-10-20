namespace PracticaDeMetodos
{
    partial class Form1
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
            this.btnArea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiametro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.txtBase1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.btnTrapecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(17, 133);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(188, 28);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Calcular area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(69, 56);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(121, 20);
            this.txtBase.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura=";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(69, 94);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(121, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calculamos el area de un rectangulo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Diametro de un circulo";
            // 
            // btnDiametro
            // 
            this.btnDiametro.Location = new System.Drawing.Point(316, 89);
            this.btnDiametro.Name = "btnDiametro";
            this.btnDiametro.Size = new System.Drawing.Size(139, 23);
            this.btnDiametro.TabIndex = 7;
            this.btnDiametro.Text = "Calcular Diametro";
            this.btnDiametro.UseVisualStyleBackColor = true;
            this.btnDiametro.Click += new System.EventHandler(this.btnDiametro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese Radio:";
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(355, 52);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(100, 20);
            this.txtDiametro.TabIndex = 9;
            // 
            // txtBase1
            // 
            this.txtBase1.Location = new System.Drawing.Point(316, 202);
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.Size = new System.Drawing.Size(100, 20);
            this.txtBase1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Base 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Altura";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(316, 168);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(100, 20);
            this.txtAlt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Area de un trapecio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Base 2";
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(316, 230);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(100, 20);
            this.txtBase2.TabIndex = 16;
            // 
            // btnTrapecio
            // 
            this.btnTrapecio.Location = new System.Drawing.Point(309, 256);
            this.btnTrapecio.Name = "btnTrapecio";
            this.btnTrapecio.Size = new System.Drawing.Size(146, 23);
            this.btnTrapecio.TabIndex = 17;
            this.btnTrapecio.Text = "Calcular Area Trapecio";
            this.btnTrapecio.UseVisualStyleBackColor = true;
            this.btnTrapecio.Click += new System.EventHandler(this.btnTrapecio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 298);
            this.Controls.Add(this.btnTrapecio);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBase1);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDiametro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiametro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.TextBox txtBase1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBase2;
        private System.Windows.Forms.Button btnTrapecio;
    }
}

