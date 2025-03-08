using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Manav_ürün_kayıt
{
    public class Liste
    {
        Dugum bas;
        Dugum son;
        public Liste()
        {
            bas = null;
            son = null;
        }
        string dosyayolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "veriler.txt");
        public bool ekle(int kd, string a, double f, string kt)
        {
            Dugum yeni = new Dugum(kd, a, f, kt);
            if (bas == null)
            {
                bas = son = yeni;
                return true;
            }
            else
            {
                if (kod_kontrolu(kd) == false)
                {
                    Dugum gecici = bas;
                    if (yeni.u_kod < bas.u_kod)
                    {
                        yeni.sonraki = bas;
                        bas.onceki = yeni;
                        bas = yeni;
                        return true;
                    }
                    else
                    {
                        while (gecici.sonraki != null && yeni.u_kod >= gecici.sonraki.u_kod)
                        {
                            gecici = gecici.sonraki;
                        }
                        if (gecici == son)
                        {
                            son.sonraki = yeni;
                            yeni.onceki = son;
                            son = yeni;
                            return true;
                        }
                        else
                        {
                            yeni.sonraki = gecici.sonraki;
                            if (gecici.sonraki != null)
                            {
                                gecici.sonraki.onceki = yeni;
                                gecici.sonraki = yeni;
                                yeni.onceki = gecici;
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu numaralı koda sahip ürün mevcut!");
                    return false;
                }
            }
            return false;
        }
        public void sil(int kd)
        {
            Dugum gecici = bas;
            if (bas == null)
            {
                MessageBox.Show("Ürün listesi boş!");
            }
            else
            {
                while (gecici != null && gecici.u_kod != kd)
                {
                    gecici = gecici.sonraki;
                }
                if (gecici != null)
                {
                    if (gecici == bas)
                    {
                        bas = gecici.sonraki;
                    }
                    else if (gecici == son)
                    {
                        son = gecici.onceki;
                        son.sonraki = null;
                    }
                    else
                    {
                        gecici.onceki.sonraki = gecici.sonraki;
                        gecici.sonraki.onceki = gecici.onceki;
                    }
                }
                else
                {
                    MessageBox.Show("Aranan Ürün listede yok!");
                }
            }
        }
        public void degistir(int kd, string ad, double f, string kt)
        {
            Dugum yeni = new Dugum(kd, ad, f, kt);
            Dugum gecici = bas;
            if (bas == null)
            {
                MessageBox.Show("Ürün listesi boş!");
            }
            else
            {
                if (kod_kontrolu(kd) == true)
                {
                    while (gecici != null && kd != gecici.u_kod)
                    {
                        gecici = gecici.sonraki;
                    }
                    gecici.u_adı = yeni.u_adı;
                    gecici.u_fiyat = yeni.u_fiyat;
                    gecici.u_kategori = yeni.u_kategori;
                }
            }
        }
        public bool bulundu_mu(TextBox k, TextBox a, TextBox f)
        {
            if (!string.IsNullOrEmpty(k.Text))
            {
                if (!string.IsNullOrEmpty(a.Text) && !string.IsNullOrEmpty(f.Text))
                {
                    return true;
                }
                else { MessageBox.Show("\"BULL\" butonuna bastığınızdan emin olun!"); }
            }
            return false;
        }
        public bool kod_kontrolu(int k)
        {
            Dugum gecici = bas;
            if (bas != null)
            {
                while (gecici != null)
                {
                    if (gecici.u_kod == k)
                    {
                        return true;
                    }
                    gecici = gecici.sonraki;
                }
            }
            return false;
        }
        public bool veri_kontrolü(TextBox k, TextBox a, TextBox f, RadioButton m, RadioButton s)
        {
            int i; double d;
            if (!(string.IsNullOrEmpty(k.Text)))
            {
                if (!(string.IsNullOrEmpty(a.Text)))
                {
                    if (!a.Text.Contains("#") && !a.Text.Contains(";"))
                    {
                        if (!(string.IsNullOrEmpty(f.Text)))
                        {
                            if (m.Checked || s.Checked)
                            {
                                if ((int.TryParse(k.Text, out i) && double.TryParse(f.Text, out d)))
                                {
                                    return true;
                                }
                                else { MessageBox.Show("Uyarı! \nLütfen ürün kodu ve ya fıyatı için sayı girdiğinizden emin olun"); }
                            }
                            else { MessageBox.Show("Uyarı! \nÜrün kategorisi seçilmedi!"); }
                        }
                        else { MessageBox.Show("Uyarı! \nÜrün fiyatı boş olamaz!"); }
                    }
                    else { MessageBox.Show("Lütfen Ürün adında özel karakterler(\" # \" ve ya \" ; \") kullanmayın"); }
                }
                else { MessageBox.Show("Uyarı! \nÜrün adı boş olamaz!"); }
            }
            else { MessageBox.Show("Uyarı! \nÜrün kodu boş olamaz!"); }
            return false;
        }
        public void bul(TextBox ad, TextBox fiyat, int kd, RadioButton meyve, RadioButton sebze)
        {
            Dugum gecici = bas;
            if (kod_kontrolu(kd) == true)
            {
                while (gecici != null && kd != gecici.u_kod)
                {
                    gecici = gecici.sonraki;
                }
                ad.Text = gecici.u_adı;
                fiyat.Text = gecici.u_fiyat.ToString();
                if (gecici.u_kategori == "MEYVE")
                {
                    meyve.Checked = true;
                    sebze.Checked = false;
                }
                else
                {
                    meyve.Checked = false;
                    sebze.Checked = true;
                }
            }
        }
        public string kategori_secimi(RadioButton meyyve, RadioButton sebze)
        {
            string secim = "meyve";
            if (meyyve.Checked) { secim = meyyve.Text; return secim; }
            else if (sebze.Checked) { secim = sebze.Text; return secim; }
            return secim;
        }
        public void dosya_silme(DataGridView dataGridView)
        {
            if (File.Exists(dosyayolu))
            {
                File.Delete(dosyayolu);
                Dugum gecici = bas;
                while (gecici != null)
                {
                    Dugum temp = gecici.sonraki;
                    gecici.onceki = null;
                    gecici.sonraki = null;
                    gecici = temp;
                }
                bas = null;
                dataGridView.Rows.Clear();
            }
            else { MessageBox.Show("Silinecek Dosya Yok!"); }
        } 
        public void Datagridviewdan_dosyaya_yaz(DataGridView dataGridView)
        {
            if (File.Exists(dosyayolu))
            {
                using (StreamWriter yaz = new StreamWriter(dosyayolu))
                {
                    Dugum gecici = bas;
                    while (gecici != null)
                    {
                        dataGridView.Rows.Add(gecici.u_kod, gecici.u_adı, gecici.u_fiyat, gecici.u_kategori);
                        yaz.Write(gecici.u_kod + ";" + gecici.u_adı + ";" + gecici.u_fiyat + ";" + gecici.u_kategori + "#");
                        gecici = gecici.sonraki;
                    }
                }
            }
            else { File.Create(dosyayolu).Close(); }
        }
        public void dosyadan_datagridviewe_ve_dugume_ekle(DataGridView dataGridView)
        {
            try
            {
                if (File.Exists(dosyayolu))
                {
                    using (StreamReader oku = new StreamReader(dosyayolu))
                    {
                        string satir;
                        int i; double d;
                        int satirSayaci = 0;
                        while ((satir = oku.ReadLine()) != null)
                        {
                            string[] dugumler = satir.Split('#');
                            foreach (string veriler in dugumler)
                            {
                                string[] veri = veriler.Split(';');
                                if (veri.Length < 4)
                                {
                                    Array.Resize(ref veri, 4);
                                    veri[3] = " ";
                                }
                                if (!string.IsNullOrEmpty(veri[0]) && !string.IsNullOrEmpty(veri[2]))
                                {
                                    if (int.TryParse(veri[0], out i) && double.TryParse(veri[2], out d))
                                    {
                                        if (!kod_kontrolu(Convert.ToInt32(veri[0])))
                                        {
                                            dataGridView.Rows.Add(veri[0], veri[1], veri[2], veri[3]);
                                            ekle(Convert.ToInt32(veri[0]), veri[1], Convert.ToDouble(veri[2]), veri[3]);
                                        }
                                    }
                                }
                                else { break; }
                                satirSayaci++;
                            }
                        }
                    }
                }
                else
                {
                    File.Create(dosyayolu).Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
