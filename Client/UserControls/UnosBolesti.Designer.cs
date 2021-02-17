namespace Client.UserControls
{
    partial class UnosBolesti
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
            this.textBoxNazivBolesti = new System.Windows.Forms.TextBox();
            this.textBoxKategorijaBolesti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSacuvajBolest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNazivBolesti
            // 
            this.textBoxNazivBolesti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNazivBolesti.Location = new System.Drawing.Point(29, 46);
            this.textBoxNazivBolesti.Name = "textBoxNazivBolesti";
            this.textBoxNazivBolesti.Size = new System.Drawing.Size(143, 20);
            this.textBoxNazivBolesti.TabIndex = 0;
            // 
            // textBoxKategorijaBolesti
            // 
            this.textBoxKategorijaBolesti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKategorijaBolesti.Location = new System.Drawing.Point(29, 97);
            this.textBoxKategorijaBolesti.Name = "textBoxKategorijaBolesti";
            this.textBoxKategorijaBolesti.Size = new System.Drawing.Size(143, 20);
            this.textBoxKategorijaBolesti.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv bolesti";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategorija bolesti";
            // 
            // buttonSacuvajBolest
            // 
            this.buttonSacuvajBolest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSacuvajBolest.Location = new System.Drawing.Point(29, 139);
            this.buttonSacuvajBolest.Name = "buttonSacuvajBolest";
            this.buttonSacuvajBolest.Size = new System.Drawing.Size(143, 23);
            this.buttonSacuvajBolest.TabIndex = 4;
            this.buttonSacuvajBolest.Text = "Sacuvaj";
            this.buttonSacuvajBolest.UseVisualStyleBackColor = true;
            this.buttonSacuvajBolest.Click += new System.EventHandler(this.buttonSacuvajBolest_Click);
            // 
            // UnosBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.buttonSacuvajBolest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKategorijaBolesti);
            this.Controls.Add(this.textBoxNazivBolesti);
            this.Name = "UnosBolesti";
            this.Size = new System.Drawing.Size(200, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazivBolesti;
        private System.Windows.Forms.TextBox textBoxKategorijaBolesti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSacuvajBolest;
    }
}
