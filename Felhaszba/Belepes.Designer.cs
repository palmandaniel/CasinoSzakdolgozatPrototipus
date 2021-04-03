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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFelhasznalo = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.btnBelepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // tbFelhasznalo
            // 
            this.tbFelhasznalo.Location = new System.Drawing.Point(174, 79);
            this.tbFelhasznalo.Name = "tbFelhasznalo";
            this.tbFelhasznalo.Size = new System.Drawing.Size(138, 20);
            this.tbFelhasznalo.TabIndex = 2;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(174, 112);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '♠';
            this.tbJelszo.Size = new System.Drawing.Size(138, 20);
            this.tbJelszo.TabIndex = 3;
            // 
            // btnBelepes
            // 
            this.btnBelepes.Location = new System.Drawing.Point(174, 138);
            this.btnBelepes.Name = "btnBelepes";
            this.btnBelepes.Size = new System.Drawing.Size(138, 23);
            this.btnBelepes.TabIndex = 4;
            this.btnBelepes.Text = "Belépés";
            this.btnBelepes.UseVisualStyleBackColor = true;
            this.btnBelepes.Click += new System.EventHandler(this.btnBelepes_Click);
            // 
            // Belepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.btnBelepes);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Belepes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFelhasznalo;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Button btnBelepes;
    }
}

