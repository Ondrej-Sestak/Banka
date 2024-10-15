
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
            this.btVytvoritUcet.Location = new System.Drawing.Point(12, 165);
            this.btVytvoritUcet.Name = "btVytvoritUcet";
            this.btVytvoritUcet.Size = new System.Drawing.Size(104, 34);
            this.btVytvoritUcet.TabIndex = 11;
            this.btVytvoritUcet.Text = "Vytvořit nový účet";
            this.btVytvoritUcet.UseVisualStyleBackColor = true;
            this.btVytvoritUcet.Click += new System.EventHandler(this.btVytvoritUcet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Heslo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Přihlašovací jméno";
            // 
            // tbHeslo
            // 
            this.tbHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHeslo.Location = new System.Drawing.Point(12, 115);
            this.tbHeslo.Name = "tbHeslo";
            this.tbHeslo.Size = new System.Drawing.Size(214, 26);
            this.tbHeslo.TabIndex = 8;
            this.tbHeslo.Text = "1234";
            // 
            // tbPrihlasovaciJmeno
            // 
            this.tbPrihlasovaciJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrihlasovaciJmeno.Location = new System.Drawing.Point(12, 44);
            this.tbPrihlasovaciJmeno.Name = "tbPrihlasovaciJmeno";
            this.tbPrihlasovaciJmeno.Size = new System.Drawing.Size(214, 26);
            this.tbPrihlasovaciJmeno.TabIndex = 7;
            this.tbPrihlasovaciJmeno.Text = "FialaMatej";
            // 
            // btPrihlasit
            // 
            this.btPrihlasit.Location = new System.Drawing.Point(122, 165);
            this.btPrihlasit.Name = "btPrihlasit";
            this.btPrihlasit.Size = new System.Drawing.Size(104, 34);
            this.btPrihlasit.TabIndex = 6;
            this.btPrihlasit.Text = "Přihlásit";
            this.btPrihlasit.UseVisualStyleBackColor = true;
            this.btPrihlasit.Click += new System.EventHandler(this.btPrihlasit_Click);
            // 
            // FormPrihlaseni
            // 
            this.AcceptButton = this.btPrihlasit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 237);
            this.Controls.Add(this.btVytvoritUcet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeslo);
            this.Controls.Add(this.tbPrihlasovaciJmeno);
            this.Controls.Add(this.btPrihlasit);
            this.Name = "FormPrihlaseni";
            this.Text = "Příhlášení";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrihlaseni_FormClosing);
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

