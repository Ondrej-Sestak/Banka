namespace Banka
{
    partial class FormPoslatPenize
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
            this.cbUcty = new System.Windows.Forms.ComboBox();
            this.lbNazevUctu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btPoslat = new System.Windows.Forms.Button();
            this.nupCastka = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupCastka)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUcty
            // 
            this.cbUcty.Location = new System.Drawing.Point(15, 67);
            this.cbUcty.Name = "cbUcty";
            this.cbUcty.Size = new System.Drawing.Size(199, 21);
            this.cbUcty.TabIndex = 0;
            this.cbUcty.SelectedIndexChanged += new System.EventHandler(this.cbUcty_SelectedIndexChanged);
            // 
            // lbNazevUctu
            // 
            this.lbNazevUctu.AutoSize = true;
            this.lbNazevUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNazevUctu.Location = new System.Drawing.Point(11, 9);
            this.lbNazevUctu.Name = "lbNazevUctu";
            this.lbNazevUctu.Size = new System.Drawing.Size(126, 20);
            this.lbNazevUctu.TabIndex = 1;
            this.lbNazevUctu.Text = "Název + typ účtu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Účty";
            // 
            // btPoslat
            // 
            this.btPoslat.Location = new System.Drawing.Point(15, 158);
            this.btPoslat.Name = "btPoslat";
            this.btPoslat.Size = new System.Drawing.Size(99, 29);
            this.btPoslat.TabIndex = 3;
            this.btPoslat.Text = "Poslat";
            this.btPoslat.UseVisualStyleBackColor = true;
            this.btPoslat.Click += new System.EventHandler(this.btPoslat_Click);
            // 
            // nupCastka
            // 
            this.nupCastka.Location = new System.Drawing.Point(15, 120);
            this.nupCastka.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupCastka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCastka.Name = "nupCastka";
            this.nupCastka.Size = new System.Drawing.Size(120, 20);
            this.nupCastka.TabIndex = 4;
            this.nupCastka.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Částka(Kč)";
            // 
            // FormPoslatPenize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupCastka);
            this.Controls.Add(this.btPoslat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNazevUctu);
            this.Controls.Add(this.cbUcty);
            this.Name = "FormPoslatPenize";
            this.Text = "FormPoslatPenize";
            this.Load += new System.EventHandler(this.FormPoslatPenize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCastka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUcty;
        private System.Windows.Forms.Label lbNazevUctu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPoslat;
        private System.Windows.Forms.NumericUpDown nupCastka;
        private System.Windows.Forms.Label label2;
    }
}