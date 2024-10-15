namespace Banka
{
    partial class FormNovyUcet
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbHesloZnovu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHeslo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrihlasovaciJmeno = new System.Windows.Forms.TextBox();
            this.tbPrijmeni = new System.Windows.Forms.TextBox();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            this.btVytvorit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Heslo znovu";
            // 
            // tbHesloZnovu
            // 
            this.tbHesloZnovu.Location = new System.Drawing.Point(409, 173);
            this.tbHesloZnovu.Margin = new System.Windows.Forms.Padding(6);
            this.tbHesloZnovu.Name = "tbHesloZnovu";
            this.tbHesloZnovu.Size = new System.Drawing.Size(282, 31);
            this.tbHesloZnovu.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Heslo";
            // 
            // tbHeslo
            // 
            this.tbHeslo.Location = new System.Drawing.Point(409, 88);
            this.tbHeslo.Margin = new System.Windows.Forms.Padding(6);
            this.tbHeslo.Name = "tbHeslo";
            this.tbHeslo.Size = new System.Drawing.Size(282, 31);
            this.tbHeslo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Přihlašovací jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Příjmení";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Jméno";
            // 
            // tbPrihlasovaciJmeno
            // 
            this.tbPrihlasovaciJmeno.Location = new System.Drawing.Point(69, 260);
            this.tbPrihlasovaciJmeno.Margin = new System.Windows.Forms.Padding(6);
            this.tbPrihlasovaciJmeno.Name = "tbPrihlasovaciJmeno";
            this.tbPrihlasovaciJmeno.Size = new System.Drawing.Size(282, 31);
            this.tbPrihlasovaciJmeno.TabIndex = 19;
            // 
            // tbPrijmeni
            // 
            this.tbPrijmeni.Location = new System.Drawing.Point(69, 175);
            this.tbPrijmeni.Margin = new System.Windows.Forms.Padding(6);
            this.tbPrijmeni.Name = "tbPrijmeni";
            this.tbPrijmeni.Size = new System.Drawing.Size(282, 31);
            this.tbPrijmeni.TabIndex = 16;
            // 
            // tbJmeno
            // 
            this.tbJmeno.Location = new System.Drawing.Point(69, 98);
            this.tbJmeno.Margin = new System.Windows.Forms.Padding(6);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(282, 31);
            this.tbJmeno.TabIndex = 15;
            // 
            // btVytvorit
            // 
            this.btVytvorit.Location = new System.Drawing.Point(527, 229);
            this.btVytvorit.Margin = new System.Windows.Forms.Padding(6);
            this.btVytvorit.Name = "btVytvorit";
            this.btVytvorit.Size = new System.Drawing.Size(168, 67);
            this.btVytvorit.TabIndex = 25;
            this.btVytvorit.Text = "Vytvořit";
            this.btVytvorit.UseVisualStyleBackColor = true;
            this.btVytvorit.Click += new System.EventHandler(this.btVytvorit_Click);
            // 
            // FormNovyUcet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 373);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbHesloZnovu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHeslo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrihlasovaciJmeno);
            this.Controls.Add(this.tbPrijmeni);
            this.Controls.Add(this.tbJmeno);
            this.Controls.Add(this.btVytvorit);
            this.Name = "FormNovyUcet";
            this.Text = "FormVytvoritUcet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHesloZnovu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbHeslo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrihlasovaciJmeno;
        private System.Windows.Forms.TextBox tbPrijmeni;
        private System.Windows.Forms.TextBox tbJmeno;
        private System.Windows.Forms.Button btVytvorit;
    }
}