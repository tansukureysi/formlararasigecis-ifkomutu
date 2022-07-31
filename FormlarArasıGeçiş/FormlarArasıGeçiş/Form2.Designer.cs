namespace FormlarArasıGeçiş
{
    partial class Form2
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
            this.renk = new System.Windows.Forms.Label();
            this.renkcombo = new System.Windows.Forms.ComboBox();
            this.calistirbutton = new System.Windows.Forms.Button();
            this.cikti = new System.Windows.Forms.Label();
            this.renkbutonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.MinimumSize = new System.Drawing.Size(300, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // renk
            // 
            this.renk.AutoSize = true;
            this.renk.Location = new System.Drawing.Point(34, 111);
            this.renk.Name = "renk";
            this.renk.Size = new System.Drawing.Size(70, 13);
            this.renk.TabIndex = 2;
            this.renk.Text = "Renk Seçimi:";
            // 
            // renkcombo
            // 
            this.renkcombo.FormattingEnabled = true;
            this.renkcombo.Items.AddRange(new object[] {
            "Kırmızı",
            "Pembe",
            "Siyah",
            "Yeşil",
            "Mavi",
            "Turuncu"});
            this.renkcombo.Location = new System.Drawing.Point(171, 108);
            this.renkcombo.Name = "renkcombo";
            this.renkcombo.Size = new System.Drawing.Size(216, 21);
            this.renkcombo.TabIndex = 4;
            // 
            // calistirbutton
            // 
            this.calistirbutton.BackColor = System.Drawing.Color.GhostWhite;
            this.calistirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calistirbutton.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calistirbutton.ForeColor = System.Drawing.Color.RosyBrown;
            this.calistirbutton.Location = new System.Drawing.Point(171, 168);
            this.calistirbutton.Name = "calistirbutton";
            this.calistirbutton.Size = new System.Drawing.Size(216, 32);
            this.calistirbutton.TabIndex = 5;
            this.calistirbutton.Text = "ÇALIŞTIR";
            this.calistirbutton.UseVisualStyleBackColor = false;
            this.calistirbutton.Click += new System.EventHandler(this.calistirbutton_Click);
            // 
            // cikti
            // 
            this.cikti.AutoSize = true;
            this.cikti.BackColor = System.Drawing.Color.Thistle;
            this.cikti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikti.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikti.ForeColor = System.Drawing.Color.White;
            this.cikti.Location = new System.Drawing.Point(12, 247);
            this.cikti.MinimumSize = new System.Drawing.Size(300, 30);
            this.cikti.Name = "cikti";
            this.cikti.Size = new System.Drawing.Size(300, 33);
            this.cikti.TabIndex = 6;
            this.cikti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // renkbutonu
            // 
            this.renkbutonu.Location = new System.Drawing.Point(12, 338);
            this.renkbutonu.Name = "renkbutonu";
            this.renkbutonu.Size = new System.Drawing.Size(300, 45);
            this.renkbutonu.TabIndex = 7;
            this.renkbutonu.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(493, 435);
            this.Controls.Add(this.renkbutonu);
            this.Controls.Add(this.cikti);
            this.Controls.Add(this.calistirbutton);
            this.Controls.Add(this.renkcombo);
            this.Controls.Add(this.renk);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label renk;
        private System.Windows.Forms.ComboBox renkcombo;
        private System.Windows.Forms.Button calistirbutton;
        private System.Windows.Forms.Label cikti;
        private System.Windows.Forms.Button renkbutonu;
    }
}