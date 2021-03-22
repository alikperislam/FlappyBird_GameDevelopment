namespace FlappyBirdApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.fbButtom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fbKus = new System.Windows.Forms.PictureBox();
            this.fbAlt5 = new System.Windows.Forms.PictureBox();
            this.fbUst5 = new System.Windows.Forms.PictureBox();
            this.fbAlt4 = new System.Windows.Forms.PictureBox();
            this.fbUst4 = new System.Windows.Forms.PictureBox();
            this.fbAlt3 = new System.Windows.Forms.PictureBox();
            this.fbUst3 = new System.Windows.Forms.PictureBox();
            this.fbAlt2 = new System.Windows.Forms.PictureBox();
            this.fbUst2 = new System.Windows.Forms.PictureBox();
            this.fbAlt = new System.Windows.Forms.PictureBox();
            this.fbUst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fbButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbKus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // fbButtom
            // 
            this.fbButtom.Image = ((System.Drawing.Image)(resources.GetObject("fbButtom.Image")));
            this.fbButtom.Location = new System.Drawing.Point(0, 549);
            this.fbButtom.Name = "fbButtom";
            this.fbButtom.Size = new System.Drawing.Size(1513, 93);
            this.fbButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbButtom.TabIndex = 5;
            this.fbButtom.TabStop = false;
            this.fbButtom.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(67, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Skor :";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lblSkor.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSkor.Location = new System.Drawing.Point(181, 584);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(35, 39);
            this.lblSkor.TabIndex = 8;
            this.lblSkor.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fbKus
            // 
            this.fbKus.Image = ((System.Drawing.Image)(resources.GetObject("fbKus.Image")));
            this.fbKus.Location = new System.Drawing.Point(32, 273);
            this.fbKus.Name = "fbKus";
            this.fbKus.Size = new System.Drawing.Size(50, 43);
            this.fbKus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbKus.TabIndex = 17;
            this.fbKus.TabStop = false;
            this.fbKus.Click += new System.EventHandler(this.fbKus_Click_1);
            // 
            // fbAlt5
            // 
            this.fbAlt5.Image = ((System.Drawing.Image)(resources.GetObject("fbAlt5.Image")));
            this.fbAlt5.Location = new System.Drawing.Point(1075, 261);
            this.fbAlt5.Name = "fbAlt5";
            this.fbAlt5.Size = new System.Drawing.Size(70, 288);
            this.fbAlt5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbAlt5.TabIndex = 27;
            this.fbAlt5.TabStop = false;
            // 
            // fbUst5
            // 
            this.fbUst5.Image = ((System.Drawing.Image)(resources.GetObject("fbUst5.Image")));
            this.fbUst5.Location = new System.Drawing.Point(1075, 0);
            this.fbUst5.Name = "fbUst5";
            this.fbUst5.Size = new System.Drawing.Size(70, 81);
            this.fbUst5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbUst5.TabIndex = 26;
            this.fbUst5.TabStop = false;
            // 
            // fbAlt4
            // 
            this.fbAlt4.Image = ((System.Drawing.Image)(resources.GetObject("fbAlt4.Image")));
            this.fbAlt4.Location = new System.Drawing.Point(387, 320);
            this.fbAlt4.Name = "fbAlt4";
            this.fbAlt4.Size = new System.Drawing.Size(70, 229);
            this.fbAlt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbAlt4.TabIndex = 25;
            this.fbAlt4.TabStop = false;
            // 
            // fbUst4
            // 
            this.fbUst4.Image = ((System.Drawing.Image)(resources.GetObject("fbUst4.Image")));
            this.fbUst4.Location = new System.Drawing.Point(387, 0);
            this.fbUst4.Name = "fbUst4";
            this.fbUst4.Size = new System.Drawing.Size(70, 96);
            this.fbUst4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbUst4.TabIndex = 24;
            this.fbUst4.TabStop = false;
            // 
            // fbAlt3
            // 
            this.fbAlt3.Image = ((System.Drawing.Image)(resources.GetObject("fbAlt3.Image")));
            this.fbAlt3.Location = new System.Drawing.Point(883, 348);
            this.fbAlt3.Name = "fbAlt3";
            this.fbAlt3.Size = new System.Drawing.Size(70, 201);
            this.fbAlt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbAlt3.TabIndex = 23;
            this.fbAlt3.TabStop = false;
            // 
            // fbUst3
            // 
            this.fbUst3.Image = ((System.Drawing.Image)(resources.GetObject("fbUst3.Image")));
            this.fbUst3.Location = new System.Drawing.Point(883, -11);
            this.fbUst3.Name = "fbUst3";
            this.fbUst3.Size = new System.Drawing.Size(70, 172);
            this.fbUst3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbUst3.TabIndex = 22;
            this.fbUst3.TabStop = false;
            // 
            // fbAlt2
            // 
            this.fbAlt2.Image = ((System.Drawing.Image)(resources.GetObject("fbAlt2.Image")));
            this.fbAlt2.Location = new System.Drawing.Point(629, 450);
            this.fbAlt2.Name = "fbAlt2";
            this.fbAlt2.Size = new System.Drawing.Size(70, 99);
            this.fbAlt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbAlt2.TabIndex = 21;
            this.fbAlt2.TabStop = false;
            // 
            // fbUst2
            // 
            this.fbUst2.Image = ((System.Drawing.Image)(resources.GetObject("fbUst2.Image")));
            this.fbUst2.Location = new System.Drawing.Point(629, 0);
            this.fbUst2.Name = "fbUst2";
            this.fbUst2.Size = new System.Drawing.Size(70, 245);
            this.fbUst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbUst2.TabIndex = 20;
            this.fbUst2.TabStop = false;
            // 
            // fbAlt
            // 
            this.fbAlt.Image = ((System.Drawing.Image)(resources.GetObject("fbAlt.Image")));
            this.fbAlt.Location = new System.Drawing.Point(161, 377);
            this.fbAlt.Name = "fbAlt";
            this.fbAlt.Size = new System.Drawing.Size(70, 172);
            this.fbAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbAlt.TabIndex = 19;
            this.fbAlt.TabStop = false;
            // 
            // fbUst
            // 
            this.fbUst.Image = ((System.Drawing.Image)(resources.GetObject("fbUst.Image")));
            this.fbUst.Location = new System.Drawing.Point(161, 0);
            this.fbUst.Name = "fbUst";
            this.fbUst.Size = new System.Drawing.Size(70, 201);
            this.fbUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbUst.TabIndex = 18;
            this.fbUst.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1237, 642);
            this.Controls.Add(this.fbAlt5);
            this.Controls.Add(this.fbUst5);
            this.Controls.Add(this.fbAlt4);
            this.Controls.Add(this.fbUst4);
            this.Controls.Add(this.fbAlt3);
            this.Controls.Add(this.fbUst3);
            this.Controls.Add(this.fbAlt2);
            this.Controls.Add(this.fbUst2);
            this.Controls.Add(this.fbAlt);
            this.Controls.Add(this.fbUst);
            this.Controls.Add(this.fbKus);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbButtom);
            this.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.fbButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbKus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox fbButtom;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox fbKus;
        private System.Windows.Forms.PictureBox fbAlt5;
        private System.Windows.Forms.PictureBox fbUst5;
        private System.Windows.Forms.PictureBox fbAlt4;
        private System.Windows.Forms.PictureBox fbUst4;
        private System.Windows.Forms.PictureBox fbAlt3;
        private System.Windows.Forms.PictureBox fbUst3;
        private System.Windows.Forms.PictureBox fbAlt2;
        private System.Windows.Forms.PictureBox fbUst2;
        private System.Windows.Forms.PictureBox fbAlt;
        private System.Windows.Forms.PictureBox fbUst;
    }
}

