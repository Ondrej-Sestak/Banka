namespace Banka
{
    partial class FormSpravaUctu
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
            this.btBeznyPoslat = new System.Windows.Forms.Button();
            this.lbCastka = new System.Windows.Forms.Label();
            this.btSporiciUcet = new System.Windows.Forms.Button();
            this.btBeznyUcet = new System.Windows.Forms.Button();
            this.lbSporiciUcet = new System.Windows.Forms.Label();
            this.lbBeznyUcet = new System.Windows.Forms.Label();
            this.lbJmeno = new System.Windows.Forms.Label();
            this.lboxBezneUcty = new System.Windows.Forms.ListBox();
            this.lboxSporiciUcty = new System.Windows.Forms.ListBox();
            this.btSporiciPoslat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBeznyPoslat
            // 
            this.btBeznyPoslat.Location = new System.Drawing.Point(158, 110);
            this.btBeznyPoslat.Name = "btBeznyPoslat";
            this.btBeznyPoslat.Size = new System.Drawing.Size(75, 23);
            this.btBeznyPoslat.TabIndex = 15;
            this.btBeznyPoslat.Text = "Poslat";
            this.btBeznyPoslat.UseVisualStyleBackColor = true;
            this.btBeznyPoslat.Visible = false;
            // 
            // lbCastka
            // 
            this.lbCastka.AutoSize = true;
            this.lbCastka.Location = new System.Drawing.Point(33, 101);
            this.lbCastka.Name = "lbCastka";
            this.lbCastka.Size = new System.Drawing.Size(0, 13);
            this.lbCastka.TabIndex = 13;
            // 
            // btSporiciUcet
            // 
            this.btSporiciUcet.Location = new System.Drawing.Point(158, 231);
            this.btSporiciUcet.Name = "btSporiciUcet";
            this.btSporiciUcet.Size = new System.Drawing.Size(75, 23);
            this.btSporiciUcet.TabIndex = 12;
            this.btSporiciUcet.Text = "Vytvořit ";
            this.btSporiciUcet.UseVisualStyleBackColor = true;
            this.btSporiciUcet.Click += new System.EventHandler(this.btSporiciUcet_Click);
            // 
            // btBeznyUcet
            // 
            this.btBeznyUcet.Location = new System.Drawing.Point(158, 81);
            this.btBeznyUcet.Name = "btBeznyUcet";
            this.btBeznyUcet.Size = new System.Drawing.Size(75, 23);
            this.btBeznyUcet.TabIndex = 11;
            this.btBeznyUcet.Text = "Vytvořit ";
            this.btBeznyUcet.UseVisualStyleBackColor = true;
            this.btBeznyUcet.Click += new System.EventHandler(this.btBeznyUcet_Click);
            // 
            // lbSporiciUcet
            // 
            this.lbSporiciUcet.AutoSize = true;
            this.lbSporiciUcet.Location = new System.Drawing.Point(19, 215);
            this.lbSporiciUcet.Name = "lbSporiciUcet";
            this.lbSporiciUcet.Size = new System.Drawing.Size(68, 13);
            this.lbSporiciUcet.TabIndex = 10;
            this.lbSporiciUcet.Text = "Spořící účet";
            // 
            // lbBeznyUcet
            // 
            this.lbBeznyUcet.AutoSize = true;
            this.lbBeznyUcet.Location = new System.Drawing.Point(19, 63);
            this.lbBeznyUcet.Name = "lbBeznyUcet";
            this.lbBeznyUcet.Size = new System.Drawing.Size(60, 13);
            this.lbBeznyUcet.TabIndex = 9;
            this.lbBeznyUcet.Text = "Běžné účty";
            // 
            // lbJmeno
            // 
            this.lbJmeno.AutoSize = true;
            this.lbJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbJmeno.Location = new System.Drawing.Point(17, 12);
            this.lbJmeno.Name = "lbJmeno";
            this.lbJmeno.Size = new System.Drawing.Size(76, 25);
            this.lbJmeno.TabIndex = 8;
            this.lbJmeno.Text = "Jméno";
            // 
            // lboxBezneUcty
            // 
            this.lboxBezneUcty.FormattingEnabled = true;
            this.lboxBezneUcty.Location = new System.Drawing.Point(22, 79);
            this.lboxBezneUcty.Name = "lboxBezneUcty";
            this.lboxBezneUcty.Size = new System.Drawing.Size(118, 108);
            this.lboxBezneUcty.TabIndex = 16;
            // 
            // lboxSporiciUcty
            // 
            this.lboxSporiciUcty.FormattingEnabled = true;
            this.lboxSporiciUcty.Location = new System.Drawing.Point(22, 231);
            this.lboxSporiciUcty.Name = "lboxSporiciUcty";
            this.lboxSporiciUcty.Size = new System.Drawing.Size(118, 108);
            this.lboxSporiciUcty.TabIndex = 17;
            // 
            // btSporiciPoslat
            // 
            this.btSporiciPoslat.Location = new System.Drawing.Point(158, 260);
            this.btSporiciPoslat.Name = "btSporiciPoslat";
            this.btSporiciPoslat.Size = new System.Drawing.Size(75, 23);
            this.btSporiciPoslat.TabIndex = 18;
            this.btSporiciPoslat.Text = "Poslat";
            this.btSporiciPoslat.UseVisualStyleBackColor = true;
            this.btSporiciPoslat.Visible = false;
            // 
            // FormSpravaUctu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 371);
            this.Controls.Add(this.btSporiciPoslat);
            this.Controls.Add(this.lboxSporiciUcty);
            this.Controls.Add(this.lboxBezneUcty);
            this.Controls.Add(this.btBeznyPoslat);
            this.Controls.Add(this.lbCastka);
            this.Controls.Add(this.btSporiciUcet);
            this.Controls.Add(this.btBeznyUcet);
            this.Controls.Add(this.lbSporiciUcet);
            this.Controls.Add(this.lbBeznyUcet);
            this.Controls.Add(this.lbJmeno);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSpravaUctu";
            this.Text = "FormSpravaUctu";
            this.Load += new System.EventHandler(this.FormSpravaUctu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBeznyPoslat;
        private System.Windows.Forms.Label lbCastka;
        private System.Windows.Forms.Button btSporiciUcet;
        private System.Windows.Forms.Button btBeznyUcet;
        private System.Windows.Forms.Label lbSporiciUcet;
        private System.Windows.Forms.Label lbBeznyUcet;
        private System.Windows.Forms.Label lbJmeno;
        private System.Windows.Forms.ListBox lboxBezneUcty;
        private System.Windows.Forms.ListBox lboxSporiciUcty;
        private System.Windows.Forms.Button btSporiciPoslat;
    }
}