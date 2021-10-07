using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokEkstresi
{
    public partial class Form1 : Form
    {
        TestDBEntities dbContext;
        public Form1()
        {
            dbContext = new TestDBEntities();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gcStokEkstresi.DataSource = dbContext.sp_Stok_Ekstresi(null, null, null); //bütün veriler gelir.
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBaslangicTarihi.Text != "" && txtBitisTarihi.Text != "") //başlangıç ve bitiş tarihleri girmek zorunlu yapılmıştır.
                {
                    string malKodu = txtMalKodu.Text == "" ? null : txtMalKodu.Text; //mal kodu girilmediyse veri null a çevrilip stored procedure'a atılır.       
                    int baslangicTarihi = Convert.ToInt32(Convert.ToDateTime(txtBaslangicTarihi.Text).ToOADate());
                    int bitisTarihi = Convert.ToInt32(Convert.ToDateTime(txtBitisTarihi.Text).ToOADate());

                    gcStokEkstresi.DataSource = dbContext.sp_Stok_Ekstresi(malKodu, baslangicTarihi, bitisTarihi);
                }
                else
                {
                    MessageBox.Show("Lütfen iki tarihi de giriniz");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen tarih kısmını formata uygun bir şekilde doldurunuz (DD.MM.YYYY)");
            }
            catch (Exception) //Beklemediğimiz bir hata durumunda buradaki catch bloğuna girecektir.
            {
                MessageBox.Show("Bir hata oluştu");
            }
        }
    }
}
