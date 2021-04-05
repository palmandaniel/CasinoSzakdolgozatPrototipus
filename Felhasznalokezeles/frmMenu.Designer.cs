namespace FelhasznaloKezeles
{
    partial class frmMenu
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnLottok = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 124);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLottok
            // 
            this.btnLottok.Location = new System.Drawing.Point(28, 61);
            this.btnLottok.Name = "btnLottok";
            this.btnLottok.Size = new System.Drawing.Size(128, 124);
            this.btnLottok.TabIndex = 2;
            this.btnLottok.Text = "Lottók";
            this.btnLottok.UseVisualStyleBackColor = true;
            this.btnLottok.Click += new System.EventHandler(this.btnLottok_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 124);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(430, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 124);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 257);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLottok);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.Text = "PalmaCasino - Főmenü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLottok;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}