using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sonhaftaproje
{
    public partial class Form1 : Form
    {
        SqlConnection Baglanti = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            Baglanti.ConnectionString = "Server=LAPTOP-HM45C1D4\\SQLEXPRESS;Database=GorselProgramlama;User Id=Tasarim;Password=123; connection timeout=30;";
          
        }

        int sayac = 1; //sayaç o da başlat


        private void button1_Click(object sender, EventArgs e)
        {
            //sql bağlantısı açma buttonu
            Baglanti.Open();
            MessageBox.Show("Bağlantı Açıldı");
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // sql bağlantısı kapatma buttonu
           // Baglanti.Close();
           // MessageBox.Show("Bağlantı kapandı");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (sayac == 6)
            {
                Baglanti.Close();
                MessageBox.Show("Bağlantı kapandı");
                timer1.Stop();
            }
            else if (sayac <6)
            {
                sayac += 1;
            }


        }


        //problem: Bağlantı açıldıktan sonra 30 saniye sonra bağlantıyı kapat
        //özel şart : 30 saniye geçip geçmediğine her 5 saniyede bir bakması gerekiyor.
        //1.bağlantıyı aç --- 1.button
        //2. timer başlatmak --- 1.button
        //3.3o saniye geçti mi?--- timer tick function
        //4. evet ise : bağlantıyı kapat --- timer tick function
        //5. hayır ise: 3.adıma geri dön --- timer tick function

    }
}
