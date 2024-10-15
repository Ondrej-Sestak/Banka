
namespace Banka
{
    partial class FormPrihlaseni
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
            this.btVytvoritUcet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeslo = new System.Windows.Forms.TextBox();
            this.tbPrihlasovaciJmeno = new System.Windows.Forms.TextBox();
            this.btPrihlasit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVytvoritUcet
            // 
            this.btVytvoritUcet.Location = new System.Drawing.Point(24, 317);
            this.btVytvoritUcet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btVytvoritUcet.Name = "btVytvoritUcet";
            this.btVytvoritUcet.Size = new System.Drawing.Size(208, 65);
            this.btVytvoritUcet.TabIndex = 11;
            this.btVytvoritUcet.Text = "Vytvořit nový účet";
            this.btVytvoritUcet.UseVisualStyleBackColor = true;
            this.btVytvoritUcet.Click += new System.EventHandler(this.btVytvoritUcet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Heslo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Přihlašovací jméno";
            // 
            // tbHeslo
            // 
            this.tbHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHeslo.Location = new System.Drawing.Point(24, 221);
            this.tbHeslo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbHeslo.Name = "tbHeslo";
            this.tbHeslo.Size = new System.Drawing.Size(424, 44);
            this.tbHeslo.TabIndex = 8;
            this.tbHeslo.Text = "1234";
            // 
            // tbPrihlasovaciJmeno
            // 
            this.tbPrihlasovaciJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrihlasovaciJmeno.Location = new System.Drawing.Point(24, 85);
            this.tbPrihlasovaciJmeno.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPrihlasovaciJmeno.Name = "tbPrihlasovaciJmeno";
            this.tbPrihlasovaciJmeno.Size = new System.Drawing.Size(424, 44);
            this.tbPrihlasovaciJmeno.TabIndex = 7;
            this.tbPrihlasovaciJmeno.Text = "FialaMatej";
            // 
            // btPrihlasit
            // 
            this.btPrihlasit.Location = new System.Drawing.Point(244, 317);
            this.btPrihlasit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btPrihlasit.Name = "btPrihlasit";
            this.btPrihlasit.Size = new System.Drawing.Size(208, 65);
            this.btPrihlasit.TabIndex = 6;
            this.btPrihlasit.Text = "Přihlásit";
            this.btPrihlasit.UseVisualStyleBackColor = true;
            this.btPrihlasit.Click += new System.EventHandler(this.btPrihlasit_Click);
            // 
            // FormPrihlaseni
            // 
            this.AcceptButton = this.btPrihlasit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 456);
            this.Controls.Add(this.btVytvoritUcet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeslo);
            this.Controls.Add(this.tbPrihlasovaciJmeno);
            this.Controls.Add(this.btPrihlasit);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormPrihlaseni";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrihlaseni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVytvoritUcet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHeslo;
        private System.Windows.Forms.TextBox tbPrihlasovaciJmeno;
        private System.Windows.Forms.Button btPrihlasit;
    }
}

