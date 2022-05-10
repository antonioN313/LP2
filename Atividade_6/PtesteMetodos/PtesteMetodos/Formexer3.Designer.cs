namespace PtesteMetodos
{
    partial class Formexer3
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
            this.txtboxPalavra1 = new System.Windows.Forms.TextBox();
            this.txtboxPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnRemOcor = new System.Windows.Forms.Button();
            this.btnRemOcorRe = new System.Windows.Forms.Button();
            this.btnInvRever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxPalavra1
            // 
            this.txtboxPalavra1.Location = new System.Drawing.Point(97, 34);
            this.txtboxPalavra1.Name = "txtboxPalavra1";
            this.txtboxPalavra1.Size = new System.Drawing.Size(188, 20);
            this.txtboxPalavra1.TabIndex = 0;
            // 
            // txtboxPalavra2
            // 
            this.txtboxPalavra2.Location = new System.Drawing.Point(97, 80);
            this.txtboxPalavra2.Name = "txtboxPalavra2";
            this.txtboxPalavra2.Size = new System.Drawing.Size(188, 20);
            this.txtboxPalavra2.TabIndex = 1;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(24, 41);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 2;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(27, 86);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnRemOcor
            // 
            this.btnRemOcor.Location = new System.Drawing.Point(167, 137);
            this.btnRemOcor.Name = "btnRemOcor";
            this.btnRemOcor.Size = new System.Drawing.Size(118, 42);
            this.btnRemOcor.TabIndex = 4;
            this.btnRemOcor.Text = "Remove Ocorrencias";
            this.btnRemOcor.UseVisualStyleBackColor = true;
            this.btnRemOcor.Click += new System.EventHandler(this.btnRemOcor_Click);
            // 
            // btnRemOcorRe
            // 
            this.btnRemOcorRe.Location = new System.Drawing.Point(314, 139);
            this.btnRemOcorRe.Name = "btnRemOcorRe";
            this.btnRemOcorRe.Size = new System.Drawing.Size(118, 40);
            this.btnRemOcorRe.TabIndex = 5;
            this.btnRemOcorRe.Text = "Remove Ocorrencias (replace)";
            this.btnRemOcorRe.UseVisualStyleBackColor = true;
            this.btnRemOcorRe.Click += new System.EventHandler(this.btnRemOcorRe_Click);
            // 
            // btnInvRever
            // 
            this.btnInvRever.Location = new System.Drawing.Point(27, 137);
            this.btnInvRever.Name = "btnInvRever";
            this.btnInvRever.Size = new System.Drawing.Size(118, 40);
            this.btnInvRever.TabIndex = 6;
            this.btnInvRever.Text = "Inverte (reverte)";
            this.btnInvRever.UseVisualStyleBackColor = true;
            this.btnInvRever.Click += new System.EventHandler(this.btnInvRever_Click);
            // 
            // Formexer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 317);
            this.Controls.Add(this.btnInvRever);
            this.Controls.Add(this.btnRemOcorRe);
            this.Controls.Add(this.btnRemOcor);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtboxPalavra2);
            this.Controls.Add(this.txtboxPalavra1);
            this.Name = "Formexer3";
            this.Text = "Formexer3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxPalavra1;
        private System.Windows.Forms.TextBox txtboxPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnRemOcor;
        private System.Windows.Forms.Button btnRemOcorRe;
        private System.Windows.Forms.Button btnInvRever;
    }
}