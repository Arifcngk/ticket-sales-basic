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
    public partial class BiletSatıs : Form
    {
        public BiletSatıs()
        {
            InitializeComponent();
        }
        public static int bilet;
        private void BiletSatıs_Load(object sender, EventArgs e)
        {
            
            label1.Text = Form1.filmadı;
            if (label1.Text== "RİCK AND MORTY")
            {
                Form1.Film flm = new Form1.Film("Türkçe","2010","45dk","Mehmet Sezer");
                label7.Text = flm.dil;
                label8.Text = flm.yıl;
                label9.Text = flm.süre;
                label10.Text = flm.yönetmen;
              
            }
            else if (label1.Text=="JOKER")
            {

                Form1.Film flm = new Form1.Film("Türkçe Altyazı", "2020", "1 Saat 35Dk", "Arif Can Gök");
                label7.Text = flm.dil;
                label8.Text = flm.yıl;
                label9.Text = flm.süre;
                label10.Text = flm.yönetmen;

            }
            else if (label1.Text=="ANKA")
            {
                Form1.Film flm = new Form1.Film("Türkçe ", "2022", "2 Saat 35Dk", "Atakan Çalıkoğlu");
                label7.Text = flm.dil;
                label8.Text = flm.yıl;
                label9.Text = flm.süre;
                label10.Text = flm.yönetmen;
            }
            else if (label1.Text == "MATRİX")
            {
                Form1.Film flm = new Form1.Film("Türkçe Altyazı ", "1990", "1 Saat 50 Dk ", "Selin Avcı");
                label7.Text = flm.dil;
                label8.Text = flm.yıl;
                label9.Text = flm.süre;
                label10.Text = flm.yönetmen;
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm=new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)

        {  
            int sonuc;
            int cıktı=0;
           
            bilet=Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
                {
                sonuc = bilet * 12;
                
               label14.Text = sonuc.ToString();
                cıktı = 30 - bilet;
                label16.Text = cıktı.ToString();
                KoltukSec koltuk = new KoltukSec();
                koltuk.ShowDialog();

            }
            if (radioButton2.Checked)
            {
                sonuc = bilet * 8;
                label14.Text = sonuc.ToString();
                cıktı = 30 - bilet;
                label16.Text = cıktı.ToString();
                KoltukSec koltuk = new KoltukSec();
                koltuk.ShowDialog();
            }
           


        }
    }
}
