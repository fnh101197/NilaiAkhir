using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Nilai_Akhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isEmpety(string username, string password)
        {
            if (absensi.Equals("") && t1.Equals("") && t2.Equals("") && t3.Equals("") && t4.Equals("")
            && t5.Equals("") && praktikum.Equals("") && nilaiuts.Equals("") && nilaiuas.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a = 0.0;//Deklarasi TipeData
            double nt1 = 0.0;
            double nt2 = 0.0;
            double nt3 = 0.0;
            double nt4 = 0.0;
            double nt5 = 0.0;
            double np = 0.0;
            double nuts = 0.0;
            double nuas = 0.0;
            double akhir = 0.0;
            string komen;
            a = Double.Parse(absensi.Text);//Deklarasi Variable
            nt1 = Double.Parse(t1.Text);
            nt2 = Double.Parse(t2.Text);
            nt3 = Double.Parse(t3.Text);
            nt4 = Double.Parse(t4.Text);
            nt5 = Double.Parse(t5.Text);
            np = Double.Parse(praktikum.Text);
            nuts = Double.Parse(nilaiuts.Text);
            nuas = Double.Parse(nilaiuas.Text);
            akhir = ((a * 10 / 100) + ((((nt1 + nt2 + nt3 + nt4 + nt5) * 2) / 10) * 20 / 100) +
            (np * 25 / 100) + (nuts * 20 / 100) + (nuas * 25 / 100));
            nilaiakhir.Text = akhir.ToString("n2");//Parameter Penghitungan Nilai Akhir
            if (akhir >= 80)//Looping Untuk Menentukan Predikat Nilai
                komen = "A";
            else if (akhir >= 70)
                komen = "B";
            else if (akhir >= 60)
                komen = "C";
            else if (akhir >= 50)
                komen = "D";
            else
                komen = "E";
            predikat.Text = komen;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            absensi.Clear();//sistem penghapusan Komponen sesuai nama Komponen
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            praktikum.Clear();
            nilaiuts.Clear();
            nilaiuas.Clear();
            nilaiakhir.Clear();
            predikat.Clear();
            nama.SelectedIndex = -1;
            matkul.SelectedIndex = -1;
        }

        private void nama_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nama.Items.Add("Fajar");
            nama.Items.Add("Nur");
            nama.Items.Add("Hidayat");
            nama.Items.Add("Fanha");
            nama.Items.Add("Nurhi");
            matkul.Items.Add("Pemrograman Web 1");
            matkul.Items.Add("Pemrograman Visual 1");
            matkul.Items.Add("Pemrograman Berorientasi Objek");
            matkul.Items.Add("Analisis Perancangan Sistem");
            matkul.Items.Add("Pendidikan Kewarganegaraan");
            matkul.Items.Add("Sistem Informasi Manajemen");
            matkul.Items.Add("Teknik Animasi dan Multimedia");
            matkul.Items.Add("Jaringan Komputer");
        }
    }
}
