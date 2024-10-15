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
            this.btVlozit = new System.Windows.Forms.Button();
            this.lbCastka = new System.Windows.Forms.Label();
            this.btSporiciUcet = new System.Windows.Forms.Button();
            this.btBeznyUcet = new System.Windows.Forms.Button();
            this.lbSporiciUcet = new System.Windows.Forms.Label();
            this.lbBeznyUcet = new System.Windows.Forms.Label();
            this.lbJmeno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBeznyPoslat
            // 
            this.btBeznyPoslat.Location = new System.Drawing.Point(44, 321);
            this.btBeznyPoslat.Margin = new System.Windows.Forms.Padding(6);
            this.btBeznyPoslat.Name = "btBeznyPoslat";
            this.btBeznyPoslat.Size = new System.Drawing.Size(150, 44);
            this.btBeznyPoslat.TabIndex = 15;
            this.btBeznyPoslat.Text = "Poslat";
            this.btBeznyPoslat.UseVisualStyleBackColor = true;
            this.btBeznyPoslat.Visible = false;
            // 
            // btVlozit
            // 
            this.btVlozit.Location = new System.Drawing.Point(44, 242);
            this.btVlozit.Margin = new System.Windows.Forms.Padding(6);
            this.btVlozit.Name = "btVlozit";
            this.btVlozit.Size = new System.Drawing.Size(150, 44);
            this.btVlozit.TabIndex = 14;
            this.btVlozit.Text = "Vložit ";
            this.btVlozit.UseVisualStyleBackColor = true;
            this.btVlozit.Visible = false;
            // 
            // lbCastka
            // 
            this.lbCastka.AutoSize = true;
            this.lbCastka.Location = new System.Drawing.Point(66, 194);
            this.lbCastka.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCastka.Name = "lbCastka";
            this.lbCastka.Size = new System.Drawing.Size(0, 25);
            this.lbCastka.TabIndex = 13;
            // 
            // btSporiciUcet
            // 
            this.btSporiciUcet.Location = new System.Drawing.Point(186, 403);
            this.btSporiciUcet.Margin = new System.Windows.Forms.Padding(6);
            this.btSporiciUcet.Name = "btSporiciUcet";
            this.btSporiciUcet.Size = new System.Drawing.Size(150, 44);
            this.btSporiciUcet.TabIndex = 12;
            this.btSporiciUcet.Text = "Vytvořit ";
            this.btSporiciUcet.UseVisualStyleBackColor = true;
            // 
            // btBeznyUcet
            // 
            this.btBeznyUcet.Location = new System.Drawing.Point(186, 111);
            this.btBeznyUcet.Margin = new System.Windows.Forms.Padding(6);
            this.btBeznyUcet.Name = "btBeznyUcet";
            this.btBeznyUcet.Size = new System.Drawing.Size(150, 44);
            this.btBeznyUcet.TabIndex = 11;
            this.btBeznyUcet.Text = "Vytvořit ";
            this.btBeznyUcet.UseVisualStyleBackColor = true;
            this.btBeznyUcet.Click += new System.EventHandler(this.btBeznyUcet_Click);
            // 
            // lbSporiciUcet
            // 
            this.lbSporiciUcet.AutoSize = true;
            this.lbSporiciUcet.Location = new System.Drawing.Point(38, 413);
            this.lbSporiciUcet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSporiciUcet.Name = "lbSporiciUcet";
            this.lbSporiciUcet.Size = new System.Drawing.Size(125, 25);
            this.lbSporiciUcet.TabIndex = 10;
            this.lbSporiciUcet.Text = "Spořící účet";
            // 
            // lbBeznyUcet
            // 
            this.lbBeznyUcet.AutoSize = true;
            this.lbBeznyUcet.Location = new System.Drawing.Point(38, 121);
            this.lbBeznyUcet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbBeznyUcet.Name = "lbBeznyUcet";
            this.lbBeznyUcet.Size = new System.Drawing.Size(119, 25);
            this.lbBeznyUcet.TabIndex = 9;
            this.lbBeznyUcet.Text = "Běžný účet";
            // 
            // lbJmeno
            // 
            this.lbJmeno.AutoSize = true;
            this.lbJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbJmeno.Location = new System.Drawing.Point(34, 24);
            this.lbJmeno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbJmeno.Name = "lbJmeno";
            this.lbJmeno.Size = new System.Drawing.Size(145, 48);
            this.lbJmeno.TabIndex = 8;
            this.lbJmeno.Text = "Jméno";
            // 
            // FormSpravaUctu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 558);
            this.Controls.Add(this.btBeznyPoslat);
            this.Controls.Add(this.btVlozit);
            this.Controls.Add(this.lbCastka);
            this.Controls.Add(this.btSporiciUcet);
            this.Controls.Add(this.btBeznyUcet);
            this.Controls.Add(this.lbSporiciUcet);
            this.Controls.Add(this.lbBeznyUcet);
            this.Controls.Add(this.lbJmeno);
            this.Name = "FormSpravaUctu";
            this.Text = "FormSpravaUctu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBeznyPoslat;
        private System.Windows.Forms.Button btVlozit;
        private System.Windows.Forms.Label lbCastka;
        private System.Windows.Forms.Button btSporiciUcet;
        private System.Windows.Forms.Button btBeznyUcet;
        private System.Windows.Forms.Label lbSporiciUcet;
        private System.Windows.Forms.Label lbBeznyUcet;
        private System.Windows.Forms.Label lbJmeno;
    }
}