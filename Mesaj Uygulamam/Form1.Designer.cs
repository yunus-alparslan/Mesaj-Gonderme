namespace Mesaj_Uygulamam
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxk = new System.Windows.Forms.TextBox();
            this.textBoxsifr = new System.Windows.Forms.TextBox();
            this.textBoxsec = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttongirisyap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mesaj_Uygulamam.Properties.Resources.icons8_customer_120px_2;
            this.pictureBox1.Location = new System.Drawing.Point(317, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxk
            // 
            this.textBoxk.Location = new System.Drawing.Point(333, 181);
            this.textBoxk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxk.Name = "textBoxk";
            this.textBoxk.Size = new System.Drawing.Size(115, 22);
            this.textBoxk.TabIndex = 1;
            this.textBoxk.TabStop = false;
            this.textBoxk.Click += new System.EventHandler(this.textBox1_Click);
            this.textBoxk.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxsifr
            // 
            this.textBoxsifr.Location = new System.Drawing.Point(333, 213);
            this.textBoxsifr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxsifr.Name = "textBoxsifr";
            this.textBoxsifr.Size = new System.Drawing.Size(115, 22);
            this.textBoxsifr.TabIndex = 2;
            this.textBoxsifr.TabStop = false;
            this.textBoxsifr.Click += new System.EventHandler(this.textBox2_Click);
            this.textBoxsifr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxsec
            // 
            this.textBoxsec.Location = new System.Drawing.Point(333, 245);
            this.textBoxsec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxsec.Name = "textBoxsec";
            this.textBoxsec.Size = new System.Drawing.Size(115, 22);
            this.textBoxsec.TabIndex = 3;
            this.textBoxsec.TabStop = false;
            this.textBoxsec.Click += new System.EventHandler(this.textBox3_Click);
            this.textBoxsec.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(365, 339);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            // 
            // buttongirisyap
            // 
            this.buttongirisyap.BackColor = System.Drawing.Color.Red;
            this.buttongirisyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttongirisyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongirisyap.ForeColor = System.Drawing.Color.White;
            this.buttongirisyap.Location = new System.Drawing.Point(345, 308);
            this.buttongirisyap.Name = "buttongirisyap";
            this.buttongirisyap.Size = new System.Drawing.Size(90, 28);
            this.buttongirisyap.TabIndex = 5;
            this.buttongirisyap.Text = "Giris Yap";
            this.buttongirisyap.UseVisualStyleBackColor = false;
            this.buttongirisyap.Click += new System.EventHandler(this.buttongirisyap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A2B133";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(352, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 34);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttongirisyap);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBoxsec);
            this.Controls.Add(this.textBoxsifr);
            this.Controls.Add(this.textBoxk);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxk;
        private System.Windows.Forms.TextBox textBoxsifr;
        private System.Windows.Forms.TextBox textBoxsec;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttongirisyap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

