namespace CesarM
{
    partial class Form1
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
            this.txtlistas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesifrar = new System.Windows.Forms.Button();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtlistas
            // 
            this.txtlistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlistas.FormattingEnabled = true;
            this.txtlistas.Location = new System.Drawing.Point(69, 179);
            this.txtlistas.Name = "txtlistas";
            this.txtlistas.Size = new System.Drawing.Size(149, 117);
            this.txtlistas.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cifrado";
            // 
            // btnDesifrar
            // 
            this.btnDesifrar.Location = new System.Drawing.Point(173, 93);
            this.btnDesifrar.Name = "btnDesifrar";
            this.btnDesifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDesifrar.TabIndex = 10;
            this.btnDesifrar.Text = "Desifrar";
            this.btnDesifrar.UseVisualStyleBackColor = true;
            this.btnDesifrar.Click += new System.EventHandler(this.btnDesifrar_Click);
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(34, 93);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 9;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cesar";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(46, 32);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(193, 39);
            this.txtCadena.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(310, 313);
            this.Controls.Add(this.txtlistas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox txtlistas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesifrar;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCadena;
    }
}

