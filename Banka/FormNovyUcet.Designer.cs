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
            this.label7.Location = new System.Drawing.Point(183, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Heslo znovu";
            // 
            // tbHesloZnovu
            // 
            this.tbHesloZnovu.Location = new System.Drawing.Point(185, 71);
            this.tbHesloZnovu.Name = "tbHesloZnovu";
            this.tbHesloZnovu.Size = new System.Drawing.Size(143, 20);
            this.tbHesloZnovu.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Heslo";
            // 
            // tbHeslo
            // 
            this.tbHeslo.Location = new System.Drawing.Point(185, 27);
            this.tbHeslo.Name = "tbHeslo";
            this.tbHeslo.Size = new System.Drawing.Size(143, 20);
            this.tbHeslo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Přihlašovací jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Příjmení";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Jméno";
            // 
            // tbPrihlasovaciJmeno
            // 
            this.tbPrihlasovaciJmeno.Location = new System.Drawing.Point(15, 116);
            this.tbPrihlasovaciJmeno.Name = "tbPrihlasovaciJmeno";
            this.tbPrihlasovaciJmeno.Size = new System.Drawing.Size(143, 20);
            this.tbPrihlasovaciJmeno.TabIndex = 19;
            // 
            // tbPrijmeni
            // 
            this.tbPrijmeni.Location = new System.Drawing.Point(15, 72);
            this.tbPrijmeni.Name = "tbPrijmeni";
            this.tbPrijmeni.Size = new System.Drawing.Size(143, 20);
            this.tbPrijmeni.TabIndex = 16;
            // 
            // tbJmeno
            // 
            this.tbJmeno.Location = new System.Drawing.Point(15, 32);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(143, 20);
            this.tbJmeno.TabIndex = 15;
            // 
            // btVytvorit
            // 
            this.btVytvorit.Location = new System.Drawing.Point(245, 100);
            this.btVytvorit.Name = "btVytvorit";
            this.btVytvorit.Size = new System.Drawing.Size(84, 35);
            this.btVytvorit.TabIndex = 25;
            this.btVytvorit.Text = "Vytvořit";
            this.btVytvorit.UseVisualStyleBackColor = true;
            this.btVytvorit.Click += new System.EventHandler(this.btVytvorit_Click);
            // 
            // FormNovyUcet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 163);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNovyUcet";
            this.Text = "Vytvoření nového účtu";
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