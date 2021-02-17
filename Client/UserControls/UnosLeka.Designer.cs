namespace Client.UserControls
{
    partial class UnosLeka
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxImeLeka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKategorijaLeka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxBolesti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxImeLeka
            // 
            this.textBoxImeLeka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxImeLeka.Location = new System.Drawing.Point(58, 35);
            this.textBoxImeLeka.Name = "textBoxImeLeka";
            this.textBoxImeLeka.Size = new System.Drawing.Size(183, 20);
            this.textBoxImeLeka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime leka";
            // 
            // textBoxKategorijaLeka
            // 
            this.textBoxKategorijaLeka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKategorijaLeka.Location = new System.Drawing.Point(57, 74);
            this.textBoxKategorijaLeka.Name = "textBoxKategorijaLeka";
            this.textBoxKategorijaLeka.Size = new System.Drawing.Size(183, 20);
            this.textBoxKategorijaLeka.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategorija leka";
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSacuvaj.Location = new System.Drawing.Point(57, 186);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(183, 23);
            this.buttonSacuvaj.TabIndex = 5;
            this.buttonSacuvaj.Text = "Sacuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bolest";
            // 
            // listBoxBolesti
            // 
            this.listBoxBolesti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxBolesti.FormattingEnabled = true;
            this.listBoxBolesti.Location = new System.Drawing.Point(58, 115);
            this.listBoxBolesti.Name = "listBoxBolesti";
            this.listBoxBolesti.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxBolesti.Size = new System.Drawing.Size(182, 56);
            this.listBoxBolesti.TabIndex = 7;
            // 
            // UnosLeka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.listBoxBolesti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKategorijaLeka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImeLeka);
            this.Name = "UnosLeka";
            this.Size = new System.Drawing.Size(298, 235);
            this.Load += new System.EventHandler(this.UnosLeka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImeLeka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKategorijaLeka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxBolesti;
    }
}
