namespace Manav_ürün_kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.tum_silme = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.degistime = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.d_bul = new System.Windows.Forms.Button();
            this.d_kt_sebze = new System.Windows.Forms.RadioButton();
            this.d_kt_meyve = new System.Windows.Forms.RadioButton();
            this.d_u_f = new System.Windows.Forms.TextBox();
            this.d_u_a = new System.Windows.Forms.TextBox();
            this.d_u_k = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.silme = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.s_bul = new System.Windows.Forms.Button();
            this.s_kt_sebze = new System.Windows.Forms.RadioButton();
            this.s_kt_meyve = new System.Windows.Forms.RadioButton();
            this.s_u_f = new System.Windows.Forms.TextBox();
            this.s_u_a = new System.Windows.Forms.TextBox();
            this.s_u_k = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.ekleme = new System.Windows.Forms.Button();
            this.e_kt_sebze = new System.Windows.Forms.RadioButton();
            this.e_kt_meyve = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.e_u_f = new System.Windows.Forms.TextBox();
            this.e_u_a = new System.Windows.Forms.TextBox();
            this.e_u_k = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tum_silme);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Name = "panel1";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Name = "label14";
            // 
            // tum_silme
            // 
            this.tum_silme.BackColor = System.Drawing.Color.Brown;
            this.tum_silme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.tum_silme, "tum_silme");
            this.tum_silme.ForeColor = System.Drawing.Color.White;
            this.tum_silme.Name = "tum_silme";
            this.tum_silme.UseVisualStyleBackColor = false;
            this.tum_silme.Click += new System.EventHandler(this.tum_silme_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Peru;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kod,
            this.ad,
            this.fiyat,
            this.kategori});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kod
            // 
            this.kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.kod, "kod");
            this.kod.Name = "kod";
            // 
            // ad
            // 
            this.ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ad, "ad");
            this.ad.Name = "ad";
            // 
            // fiyat
            // 
            this.fiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.fiyat, "fiyat");
            this.fiyat.Name = "fiyat";
            // 
            // kategori
            // 
            this.kategori.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.kategori, "kategori");
            this.kategori.Name = "kategori";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Name = "label9";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.degistime);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.d_bul);
            this.panel3.Controls.Add(this.d_kt_sebze);
            this.panel3.Controls.Add(this.d_kt_meyve);
            this.panel3.Controls.Add(this.d_u_f);
            this.panel3.Controls.Add(this.d_u_a);
            this.panel3.Controls.Add(this.d_u_k);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // degistime
            // 
            this.degistime.BackColor = System.Drawing.Color.SaddleBrown;
            this.degistime.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.degistime, "degistime");
            this.degistime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.degistime.Name = "degistime";
            this.degistime.UseVisualStyleBackColor = false;
            this.degistime.Click += new System.EventHandler(this.degistime_Click_1);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // d_bul
            // 
            this.d_bul.BackColor = System.Drawing.Color.Transparent;
            this.d_bul.BackgroundImage = global::Manav_ürün_kayıt.Properties.Resources.bul_butonu;
            resources.ApplyResources(this.d_bul, "d_bul");
            this.d_bul.Name = "d_bul";
            this.d_bul.UseVisualStyleBackColor = false;
            this.d_bul.Click += new System.EventHandler(this.d_bul_Click_1);
            // 
            // d_kt_sebze
            // 
            resources.ApplyResources(this.d_kt_sebze, "d_kt_sebze");
            this.d_kt_sebze.Name = "d_kt_sebze";
            this.d_kt_sebze.TabStop = true;
            this.d_kt_sebze.UseVisualStyleBackColor = true;
            // 
            // d_kt_meyve
            // 
            resources.ApplyResources(this.d_kt_meyve, "d_kt_meyve");
            this.d_kt_meyve.Name = "d_kt_meyve";
            this.d_kt_meyve.TabStop = true;
            this.d_kt_meyve.UseVisualStyleBackColor = true;
            // 
            // d_u_f
            // 
            resources.ApplyResources(this.d_u_f, "d_u_f");
            this.d_u_f.Name = "d_u_f";
            // 
            // d_u_a
            // 
            resources.ApplyResources(this.d_u_a, "d_u_a");
            this.d_u_a.Name = "d_u_a";
            // 
            // d_u_k
            // 
            resources.ApplyResources(this.d_u_k, "d_u_k");
            this.d_u_k.Name = "d_u_k";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Name = "label5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.silme);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.s_bul);
            this.panel2.Controls.Add(this.s_kt_sebze);
            this.panel2.Controls.Add(this.s_kt_meyve);
            this.panel2.Controls.Add(this.s_u_f);
            this.panel2.Controls.Add(this.s_u_a);
            this.panel2.Controls.Add(this.s_u_k);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // silme
            // 
            this.silme.BackColor = System.Drawing.Color.SaddleBrown;
            this.silme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.silme, "silme");
            this.silme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.silme.Name = "silme";
            this.silme.UseVisualStyleBackColor = false;
            this.silme.Click += new System.EventHandler(this.silme_Click_1);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // s_bul
            // 
            this.s_bul.BackColor = System.Drawing.Color.Transparent;
            this.s_bul.BackgroundImage = global::Manav_ürün_kayıt.Properties.Resources.bul_butonu;
            resources.ApplyResources(this.s_bul, "s_bul");
            this.s_bul.Name = "s_bul";
            this.s_bul.UseVisualStyleBackColor = false;
            this.s_bul.Click += new System.EventHandler(this.s_bul_Click_1);
            // 
            // s_kt_sebze
            // 
            resources.ApplyResources(this.s_kt_sebze, "s_kt_sebze");
            this.s_kt_sebze.Name = "s_kt_sebze";
            this.s_kt_sebze.TabStop = true;
            this.s_kt_sebze.UseVisualStyleBackColor = true;
            // 
            // s_kt_meyve
            // 
            resources.ApplyResources(this.s_kt_meyve, "s_kt_meyve");
            this.s_kt_meyve.Name = "s_kt_meyve";
            this.s_kt_meyve.TabStop = true;
            this.s_kt_meyve.UseVisualStyleBackColor = true;
            // 
            // s_u_f
            // 
            resources.ApplyResources(this.s_u_f, "s_u_f");
            this.s_u_f.Name = "s_u_f";
            // 
            // s_u_a
            // 
            resources.ApplyResources(this.s_u_a, "s_u_a");
            this.s_u_a.Name = "s_u_a";
            // 
            // s_u_k
            // 
            resources.ApplyResources(this.s_u_k, "s_u_k");
            this.s_u_k.Name = "s_u_k";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.ekleme);
            this.panel4.Controls.Add(this.e_kt_sebze);
            this.panel4.Controls.Add(this.e_kt_meyve);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.e_u_f);
            this.panel4.Controls.Add(this.e_u_a);
            this.panel4.Controls.Add(this.e_u_k);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // ekleme
            // 
            this.ekleme.BackColor = System.Drawing.Color.SaddleBrown;
            this.ekleme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ekleme, "ekleme");
            this.ekleme.ForeColor = System.Drawing.Color.White;
            this.ekleme.Name = "ekleme";
            this.ekleme.UseVisualStyleBackColor = false;
            this.ekleme.Click += new System.EventHandler(this.ekleme_Click);
            // 
            // e_kt_sebze
            // 
            resources.ApplyResources(this.e_kt_sebze, "e_kt_sebze");
            this.e_kt_sebze.Name = "e_kt_sebze";
            this.e_kt_sebze.UseVisualStyleBackColor = true;
            // 
            // e_kt_meyve
            // 
            resources.ApplyResources(this.e_kt_meyve, "e_kt_meyve");
            this.e_kt_meyve.Name = "e_kt_meyve";
            this.e_kt_meyve.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // e_u_f
            // 
            resources.ApplyResources(this.e_u_f, "e_u_f");
            this.e_u_f.Name = "e_u_f";
            // 
            // e_u_a
            // 
            resources.ApplyResources(this.e_u_a, "e_u_a");
            this.e_u_a.Name = "e_u_a";
            this.e_u_a.TextChanged += new System.EventHandler(this.e_u_a_TextChanged);
            // 
            // e_u_k
            // 
            resources.ApplyResources(this.e_u_k, "e_u_k");
            this.e_u_k.Name = "e_u_k";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Manav_ürün_kayıt.Properties.Resources.image__1___2_;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button degistime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button d_bul;
        private System.Windows.Forms.RadioButton d_kt_sebze;
        private System.Windows.Forms.RadioButton d_kt_meyve;
        private System.Windows.Forms.TextBox d_u_f;
        private System.Windows.Forms.TextBox d_u_a;
        private System.Windows.Forms.TextBox d_u_k;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button silme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button s_bul;
        private System.Windows.Forms.RadioButton s_kt_sebze;
        private System.Windows.Forms.RadioButton s_kt_meyve;
        private System.Windows.Forms.TextBox s_u_f;
        private System.Windows.Forms.TextBox s_u_a;
        private System.Windows.Forms.TextBox s_u_k;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ekleme;
        private System.Windows.Forms.RadioButton e_kt_sebze;
        private System.Windows.Forms.RadioButton e_kt_meyve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox e_u_f;
        private System.Windows.Forms.TextBox e_u_a;
        private System.Windows.Forms.TextBox e_u_k;
        private System.Windows.Forms.Button tum_silme;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
    }
}

