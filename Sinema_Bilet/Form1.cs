using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  class Film
        {
            public string dil;
            public string yıl;
            public string süre;
            public string yönetmen;
            public Film(string dil1,string yıl1,string süre1,string yönetmen1)
            {
                dil= dil1;
                yıl = yıl1;
                süre = süre1;
                yönetmen = yönetmen1;
                
            }
        }  
      
  
       
        

        
        public static string rickDil = "Türkçe";
        public static string rickYıl = "2020";
        public static string ricksüre = "50dk";
        public static string rickyönetmen = "Arif Can Gök";
        public static string jokerDil="Türkçe";
        public static string jokerYıl="2019";
        public static string jokerSüre="2 Saat 15 dk";
        public static string jokerYönetmen="Todd Philips";
       
        public static string filmadı;
        public static string acıklama;
        private void Form1_Load(object sender, EventArgs e)
        {   
            
            timer1.Enabled = true;
            timer2.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {//kayan yazı
            label1.Text=label1.Text.Substring(1)+label1.Text.Substring(0,1);   
        }

        private void timer2_Tick(object sender, EventArgs e)
        {//tarih ve saat
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmadı = button1.Text;
            
            
            BiletSatıs biletSatıs=new BiletSatıs();
            biletSatıs.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            filmadı = button2.Text;
            BiletSatıs biletSatıs = new BiletSatıs();
            biletSatıs.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            filmadı = button3.Text;
            BiletSatıs biletSatıs = new BiletSatıs();
            biletSatıs.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filmadı = button4.Text;
            BiletSatıs biletSatıs = new BiletSatıs();
            biletSatıs.Show();
            this.Hide();
        }
    }
}
