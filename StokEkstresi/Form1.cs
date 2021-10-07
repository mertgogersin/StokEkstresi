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
            gcStokEkstresi.DataSource = dbContext.sp_Stok_Ekstresi(null, null, null);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                string malKodu = txtMalKodu.Text;
                int baslangicTarihi = Convert.ToInt32(Convert.ToDateTime(txtBaslangicTarihi.Text).ToOADate());
                int bitisTarihi = Convert.ToInt32(Convert.ToDateTime(txtBitisTarihi.Text).ToOADate());
                gcStokEkstresi.DataSource = dbContext.sp_Stok_Ekstresi(malKodu, baslangicTarihi, bitisTarihi);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen tarih kısmını formata uygun bir şekilde doldurunuz (DD.MM.YYYY)");
            }
        }
    }
}
