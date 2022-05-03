namespace PtesteMetodos
{
    partial class Formexer2
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
            this.txtBxPalavra1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxPalavra2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra 1";
            // 
            // txtBxPalavra1
            // 
            this.txtBxPalavra1.Location = new System.Drawing.Point(98, 27);
            this.txtBxPalavra1.Name = "txtBxPalavra1";
            this.txtBxPalavra1.Size = new System.Drawing.Size(127, 20);
            this.txtBxPalavra1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palavra 2";
            // 
            // txtBxPalavra2
            // 
            this.txtBxPalavra2.Location = new System.Drawing.Point(98, 62);
            this.txtBxPalavra2.Name = "txtBxPalavra2";
            this.txtBxPalavra2.Size = new System.Drawing.Size(127, 20);
            this.txtBxPalavra2.TabIndex = 3;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(29, 130);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(80, 42);
            this.btnComparar.TabIndex = 4;
            this.btnComparar.Text = "Comparar Textos";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Inserir Palavra 1 em 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Inserir ** na Palavra 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Formexer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 203);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtBxPalavra2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxPalavra1);
            this.Controls.Add(this.label1);
            this.Name = "Formexer2";
            this.Text = "Formexer2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPalavra1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxPalavra2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}