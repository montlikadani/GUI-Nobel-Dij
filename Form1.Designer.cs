namespace NobelDij {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.evUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.szh = new System.Windows.Forms.TextBox();
            this.orszag = new System.Windows.Forms.TextBox();
            this.adatokMentese = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.evUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Év:";
            // 
            // evUpDown
            // 
            this.evUpDown.Location = new System.Drawing.Point(107, 45);
            this.evUpDown.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.evUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.evUpDown.Name = "evUpDown";
            this.evUpDown.Size = new System.Drawing.Size(100, 26);
            this.evUpDown.TabIndex = 1;
            this.evUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.evUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sz/H:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ország:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(107, 84);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(326, 26);
            this.nev.TabIndex = 5;
            this.nev.WordWrap = false;
            // 
            // szh
            // 
            this.szh.Location = new System.Drawing.Point(107, 122);
            this.szh.Name = "szh";
            this.szh.Size = new System.Drawing.Size(163, 26);
            this.szh.TabIndex = 6;
            this.szh.WordWrap = false;
            // 
            // orszag
            // 
            this.orszag.Location = new System.Drawing.Point(107, 161);
            this.orszag.Name = "orszag";
            this.orszag.Size = new System.Drawing.Size(71, 26);
            this.orszag.TabIndex = 7;
            this.orszag.WordWrap = false;
            // 
            // adatokMentese
            // 
            this.adatokMentese.Location = new System.Drawing.Point(148, 251);
            this.adatokMentese.Name = "adatokMentese";
            this.adatokMentese.Size = new System.Drawing.Size(178, 31);
            this.adatokMentese.TabIndex = 8;
            this.adatokMentese.Text = "Adatok mentése";
            this.adatokMentese.UseVisualStyleBackColor = true;
            this.adatokMentese.Click += new System.EventHandler(this.adatokMentese_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 308);
            this.Controls.Add(this.adatokMentese);
            this.Controls.Add(this.orszag);
            this.Controls.Add(this.szh);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.evUpDown);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Orvosi Nobel-díjasok";
            ((System.ComponentModel.ISupportInitialize)(this.evUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown evUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox szh;
        private System.Windows.Forms.TextBox orszag;
        private System.Windows.Forms.Button adatokMentese;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

