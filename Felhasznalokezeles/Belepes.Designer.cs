namespace FelhasznaloKezeles
{
    partial class Belepes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Belepes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFelhasznalo = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.btnBelepes = new System.Windows.Forms.Button();
            this.btnRegisztral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jelszó:";
            // 
            // tbFelhasznalo
            // 
            this.tbFelhasznalo.Location = new System.Drawing.Point(238, 116);
            this.tbFelhasznalo.Name = "tbFelhasznalo";
            this.tbFelhasznalo.Size = new System.Drawing.Size(242, 20);
            this.tbFelhasznalo.TabIndex = 0;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(238, 149);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '♠';
            this.tbJelszo.Size = new System.Drawing.Size(242, 20);
            this.tbJelszo.TabIndex = 1;
            // 
            // btnBelepes
            // 
            this.btnBelepes.Location = new System.Drawing.Point(238, 175);
            this.btnBelepes.Name = "btnBelepes";
            this.btnBelepes.Size = new System.Drawing.Size(138, 23);
            this.btnBelepes.TabIndex = 2;
            this.btnBelepes.Text = "Belépés";
            this.btnBelepes.UseVisualStyleBackColor = true;
            this.btnBelepes.Click += new System.EventHandler(this.btnBelepes_Click);
            // 
            // btnRegisztral
            // 
            this.btnRegisztral.Location = new System.Drawing.Point(238, 204);
            this.btnRegisztral.Name = "btnRegisztral";
            this.btnRegisztral.Size = new System.Drawing.Size(138, 23);
            this.btnRegisztral.TabIndex = 3;
            this.btnRegisztral.Text = "Regisztráció";
            this.btnRegisztral.UseVisualStyleBackColor = true;
            this.btnRegisztral.Click += new System.EventHandler(this.btnRegisztral_Click);
            // 
            // Belepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(629, 341);
            this.Controls.Add(this.btnRegisztral);
            this.Controls.Add(this.btnBelepes);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Belepes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFelhasznalo;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Button btnBelepes;
        private System.Windows.Forms.Button btnRegisztral;
    }
}

