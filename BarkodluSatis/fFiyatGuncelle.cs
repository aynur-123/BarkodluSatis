using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fFiyatGuncelleme : Form
    {
        public fFiyatGuncelleme()
        {
            InitializeComponent();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                using (var db= new BarkodDbEntities())
                {
                    if(db.Urun.Any(x=> x.Barkod==tBarkod.Text))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == tBarkod.Text).SingleOrDefault();
                        lBarkod.Text = getir.Barkod;
                        lUrunAdi.Text = getir.UrunAd;
                        Double mevcutfiyat = Convert.ToDouble(getir.SatisFiyat);
                        lMevcutFiyat.Text = mevcutfiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("ÜRÜN KAYITLI DEĞİL");
                    }
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if(tYeniFiyat.Text!="" && lBarkod.Text!="")
            {
                using (var db=new BarkodDbEntities())
                {
                    var guncellenecek = db.Urun.Where(x => x.Barkod == lBarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyat = Islemler.DoubleYap(tYeniFiyat.Text);
                    //yeni fiyat girildiği için kdv oranı tekrar hesaplanır
                    int kdvorani = Convert.ToInt16(guncellenecek.KdvOrani);
                    Math.Round(Islemler.DoubleYap(tYeniFiyat.Text) * kdvorani/100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Yeni Fiyat Kaydedildi");
                    lBarkod.Text = "";
                    lUrunAdi.Text = "";
                    lMevcutFiyat.Text = "";
                    tYeniFiyat.Clear();
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Barkod okutunuz!");
                tBarkod.Focus();
            }
        }

        private void fFiyatGuncelleme_Load(object sender, EventArgs e)
        {
            lBarkod.Text = "";
            lMevcutFiyat.Text = "";
            lUrunAdi.Text = "";
        }
    }
}
