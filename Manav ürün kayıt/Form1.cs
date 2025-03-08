using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav_ürün_kayıt
{
    public partial class Form1 : Form
    {
        Liste liste=new Liste();
        public Form1()
        {
            InitializeComponent();
            panel1.Location = new Point((ClientSize.Width - panel1.Width) / 2,
                                        (ClientSize.Height - panel1.Height) / 2);
            panel1.BackColor=Color.FromArgb(180, 10, 20, 0);
            dataGridView1.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12,FontStyle.Bold);
            liste.dosyadan_datagridviewe_ve_dugume_ekle(dataGridView1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point((ClientSize.Width - panel1.Width) / 2,
                                        (ClientSize.Height - panel1.Height) / 2);
        }
        private async void ekleme_Click(object sender, EventArgs e)
        {
            if (liste.veri_kontrolü(e_u_k, e_u_a, e_u_f, e_kt_meyve, e_kt_sebze) == true)
            {
                if (ekleme.BackColor == Color.SaddleBrown)
                {
                    ekleme.BackColor = Color.Gold;
                    ekleme.ForeColor = Color.Black;
                    ekleme.Text = "Ekleniyor...";
                    ekleme.Enabled = false;
                    await Task.Delay(1000);

                    if (liste.ekle(Convert.ToInt32(e_u_k.Text.Trim()), e_u_a.Text, Convert.ToDouble(e_u_f.Text.Trim()), liste.kategori_secimi(e_kt_meyve, e_kt_sebze)) == true)
                    {
                        dataGridView1.Rows.Clear();
                        liste.dosyadan_datagridviewe_ve_dugume_ekle(dataGridView1);
                        dataGridView1.Rows.Clear();
                        liste.Datagridviewdan_dosyaya_yaz(dataGridView1);

                        ekleme.BackColor = Color.Lime;
                        ekleme.Text = "Eklendi!";
                        await Task.Delay(1300);

                        e_u_k.Clear();
                        e_u_a.Clear();
                        e_u_f.Clear();
                        if (e_kt_meyve.Checked || e_kt_sebze.Checked)
                        {
                            e_kt_meyve.Checked = false;
                            e_kt_sebze.Checked = false;
                        }
                    }
                    else 
                    {
                        ekleme.BackColor = Color.Red;
                        ekleme.Text = "Eklenemedi!";
                        await Task.Delay(1000);
                    }
                    ekleme.Enabled = true;
                    ekleme.BackColor = Color.SaddleBrown;
                    ekleme.ForeColor = Color.White;
                    ekleme.Text = "EKLE";
                }
            }
        }
        private async void silme_Click_1(object sender, EventArgs e)
        {
            if (liste.bulundu_mu(s_u_k, s_u_a, s_u_f) == true)
            {
                if (!string.IsNullOrEmpty(s_u_k.Text))
                {
                    DialogResult result = MessageBox.Show("Ürün Kaydını silmek istediğinizden emin misiniz?", "Evet-Hayır", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (silme.BackColor == Color.SaddleBrown)
                        {
                            silme.BackColor = Color.Gold;
                            silme.ForeColor = Color.Black;
                            silme.Text = "Siliniyor...";
                            silme.Enabled = false;
                            await Task.Delay(1500);

                            liste.dosyadan_datagridviewe_ve_dugume_ekle(dataGridView1);
                            liste.sil(Convert.ToInt32(s_u_k.Text));
                            dataGridView1.Rows.Clear();
                            liste.Datagridviewdan_dosyaya_yaz(dataGridView1);

                            silme.BackColor = Color.Red;
                            silme.Text = "Silindi!";
                            await Task.Delay(1500);

                            s_u_k.Clear();
                            s_u_a.Clear();  
                            s_u_f.Clear();
                            d_u_k.Clear();
                            d_u_a.Clear();
                            d_u_f.Clear();

                            if (s_kt_meyve.Checked || s_kt_sebze.Checked)
                            {
                                s_kt_meyve.Checked = false;
                                s_kt_sebze.Checked = false;
                            }
                            if (d_kt_meyve.Checked || d_kt_sebze.Checked)
                            {
                                d_kt_meyve.Checked = false;
                                d_kt_sebze.Checked = false;
                            }

                            silme.Enabled = true;
                            silme.BackColor = Color.SaddleBrown;
                            silme.ForeColor = Color.White;
                            silme.Text = "SİL";
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Kayıt silinmedi!");
                    }
                }
            }
        }

        private async void degistime_Click_1(object sender, EventArgs e)
        {
            if (liste.bulundu_mu(d_u_k, d_u_a, d_u_f) == true)
            {
                if (!string.IsNullOrEmpty(d_u_k.Text))
                {
                    if (liste.veri_kontrolü(d_u_k, d_u_a, d_u_f, d_kt_meyve, d_kt_sebze) == true)
                    {
                        if (degistime.BackColor == Color.SaddleBrown)
                        {
                            degistime.BackColor = Color.Gold;
                            degistime.ForeColor = Color.Black;
                            degistime.Text = "Değiştiriliyor...";
                            degistime.Enabled = false;
                            await Task.Delay(1500);

                            liste.dosyadan_datagridviewe_ve_dugume_ekle(dataGridView1);
                            liste.degistir(Convert.ToInt32(d_u_k.Text), d_u_a.Text, Convert.ToDouble(d_u_f.Text), liste.kategori_secimi(d_kt_meyve, d_kt_sebze));
                            dataGridView1.Rows.Clear();
                            liste.Datagridviewdan_dosyaya_yaz(dataGridView1);

                            degistime.BackColor = Color.LightBlue;
                            degistime.Text = "Değiştirildi!";
                            await Task.Delay(1500);

                            d_u_k.Clear();
                            d_u_a.Clear();
                            d_u_f.Clear();
                            s_u_k.Clear();
                            s_u_a.Clear();
                            s_u_f.Clear();

                            if (d_kt_meyve.Checked || d_kt_sebze.Checked)
                            {
                                d_kt_meyve.Checked = false;
                                d_kt_sebze.Checked = false;
                            }
                            if (s_kt_meyve.Checked || s_kt_sebze.Checked)
                            {
                                s_kt_meyve.Checked = false;
                                s_kt_sebze.Checked = false;
                            }

                            degistime.Enabled = true;
                            degistime.BackColor = Color.SaddleBrown;
                            degistime.ForeColor = Color.White;
                            degistime.Text = "DEĞİŞTİR";
                            d_u_k.Enabled = true;
                        }
                    }
                }
            }
        }

        private void s_bul_Click_1(object sender, EventArgs e)
        {
            if (liste.veri_kontrolü(s_u_k, s_u_a, s_u_f, s_kt_meyve, s_kt_sebze) == true)
            {
                if (liste.kod_kontrolu(Convert.ToInt32(s_u_k.Text)) == true)
                {
                    liste.bul(s_u_a, s_u_f, Convert.ToInt32(s_u_k.Text), s_kt_meyve, s_kt_sebze);
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı!");
                }
            }
        }

        private void d_bul_Click_1(object sender, EventArgs e)
        {
            if (liste.veri_kontrolü(d_u_k, d_u_a, d_u_f, d_kt_meyve, d_kt_sebze) == true)
            {
                if(liste.kod_kontrolu(Convert.ToInt32(d_u_k.Text)) == true)
                {
                    liste.bul(d_u_a, d_u_f, Convert.ToInt32(d_u_k.Text), d_kt_meyve, d_kt_sebze);
                    if (liste.bulundu_mu(d_u_k, d_u_a, d_u_f) == true)
                    {
                        d_u_k.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı!");
                }
            }
            else { MessageBox.Show("Ürün kodunu giriniz!"); }
        }
        private async void tum_silme_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm Listeyi silmek istediğinizden emin misiniz?", "Evet-Hayır", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (tum_silme.BackColor == Color.Brown)
                {
                    tum_silme.BackColor = Color.Red;
                    tum_silme.Text = "Siliniyor...";
                    tum_silme.Enabled = false;
                    await Task.Delay(2000);

                    liste.dosya_silme(dataGridView1);
                    dataGridView1.Rows.Clear();

                    tum_silme.Text = "Tüm liste SİLİNDİ!";
                    await Task.Delay(2000);

                    tum_silme.Enabled = true;
                    tum_silme.BackColor = Color.Brown;
                    tum_silme.Text = "TÜM LİSTEYİ TEMİZLE";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 )
            {

                var hucredegeri = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                d_u_k.Text=hucredegeri.ToString();
                liste.bul(d_u_a, d_u_f, Convert.ToInt32(hucredegeri), d_kt_meyve, d_kt_sebze);
                if (liste.bulundu_mu(d_u_k, d_u_a, d_u_f) == true)
                {
                    d_u_k.Enabled = false;
                }
                s_u_k.Text = hucredegeri.ToString();
                if (liste.kod_kontrolu(Convert.ToInt32(hucredegeri)) == true)
                {
                    liste.bul(s_u_a, s_u_f, Convert.ToInt32(hucredegeri), s_kt_meyve, s_kt_sebze);
                }
            }
        }

        private void e_u_a_TextChanged(object sender, EventArgs e)
        {
        }
    }
    public class Dugum
    {
        public int u_kod;
        public string u_adı;
        public double u_fiyat;
        public string u_kategori;
        public Dugum sonraki;
        public Dugum onceki;
        public Dugum(int kod, string ad, double fiyat, string kategori)
        {
            this.u_kod = kod;
            this.u_adı = ad;
            this.u_fiyat = fiyat;
            this.u_kategori = kategori;
            sonraki = null;
            onceki = null;
        }
    }
}
