using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Oyunlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sorularim;Integrated Security=True");

        int sayac = 0;
        int puan = 0;
        int zaman = 20;
       
        private void btn_Basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;

            btn_A.BackColor = Color.White;
            btn_B.BackColor = Color.White;
            btn_C.BackColor = Color.White;
            btn_D.BackColor = Color.White;

            btn_Basla.Enabled = false;
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            btn_Basla.Text = "SONRAKİ";
            sayac++;
            lbl_Soru.Text = sayac.ToString();
            if (sayac == 1)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Soru1 order by NEWID() ", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["Soru"].ToString();
                    btn_A.Text = oku["a"].ToString();
                    btn_B.Text = oku["b"].ToString();
                    btn_C.Text = oku["c"].ToString();
                    btn_D.Text = oku["d"].ToString();
                    lbl_Dogru.Text = oku["Dogru"].ToString();
                }
                baglanti.Close();
            }

            if (sayac == 2)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Soru2 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["Soru"].ToString();
                    btn_A.Text = oku["a"].ToString();
                    btn_B.Text = oku["b"].ToString();
                    btn_C.Text = oku["c"].ToString();
                    btn_D.Text = oku["d"].ToString();
                    lbl_Dogru.Text = oku["Dogru"].ToString();
                }
                baglanti.Close();
            }

            if (sayac == 3)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Soru3 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["Soru"].ToString();
                    btn_A.Text = oku["a"].ToString();
                    btn_B.Text = oku["b"].ToString();
                    btn_C.Text = oku["c"].ToString();
                    btn_D.Text = oku["d"].ToString();
                    lbl_Dogru.Text = oku["Dogru"].ToString();
                }
                baglanti.Close();
            }

            if (sayac == 4)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Soru4 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["Soru"].ToString();
                    btn_A.Text = oku["a"].ToString();
                    btn_B.Text = oku["b"].ToString();
                    btn_C.Text = oku["c"].ToString();
                    btn_D.Text = oku["d"].ToString();
                    lbl_Dogru.Text = oku["Dogru"].ToString();
                }
                baglanti.Close();
            }

            if (sayac == 5)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Soru5 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["Soru"].ToString();
                    btn_A.Text = oku["a"].ToString();
                    btn_B.Text = oku["b"].ToString();
                    btn_C.Text = oku["c"].ToString();
                    btn_D.Text = oku["d"].ToString();
                    lbl_Dogru.Text = oku["Dogru"].ToString();
                }
                baglanti.Close();
            }

            if (sayac == 6)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Soru6 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["Soru"].ToString();
                    btn_A.Text = oku["a"].ToString();
                    btn_B.Text = oku["b"].ToString();
                    btn_C.Text = oku["c"].ToString();
                    btn_D.Text = oku["d"].ToString();
                    lbl_Dogru.Text = oku["Dogru"].ToString();
                }
                baglanti.Close();
            }

            if (sayac == 7)
            {
                btn_Basla.Text = "OYUN BİTTİ";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Soru7 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku["Soru"].ToString();
                    btn_A.Text = oku["a"].ToString();
                    btn_B.Text = oku["b"].ToString();
                    btn_C.Text = oku["c"].ToString();
                    btn_D.Text = oku["d"].ToString();
                    lbl_Dogru.Text = oku["Dogru"].ToString();
                }
                baglanti.Close();
            }

            if (sayac==8)
            {
                Form1 anaSayfa = new Form1();
                anaSayfa.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_Soru.Text = sayac.ToString();
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            if(btn_A.Text==lbl_Dogru.Text)
            {
                puan = puan + 10;
                lbl_Puan.Text = puan.ToString();
                btn_A.BackColor = Color.Green;
            }
            else
            {
                btn_A.BackColor = Color.Red;
            }
            btn_Basla.Enabled = true;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            if (btn_B.Text == lbl_Dogru.Text)
            {
                puan = puan + 10;
                lbl_Puan.Text = puan.ToString();
                btn_B.BackColor = Color.Green;
            }
            else
            {
                btn_B.BackColor = Color.Red;
            }
            btn_Basla.Enabled = true;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            if (btn_C.Text == lbl_Dogru.Text)
            {
                puan = puan + 10;
                lbl_Puan.Text = puan.ToString();
                btn_C.BackColor = Color.Green;
            }
            else
            {
                btn_C.BackColor = Color.Red;
            }
            btn_Basla.Enabled = true;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            if (btn_D.Text == lbl_Dogru.Text)
            {
                puan = puan + 10;
                lbl_Puan.Text = puan.ToString();
                btn_D.BackColor = Color.Green;
            }
            else
            {
                btn_D.BackColor = Color.Red;
            }
            btn_Basla.Enabled = true;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lbl_Sure.Text = zaman.ToString();

            if(zaman==0)
            {
                timer1.Enabled = false;
                btn_Basla.Enabled = true;
                btn_A.Enabled = false;
                btn_B.Enabled = false;
                btn_C.Enabled = false;
                btn_D.Enabled = false;
            }
        }
    }
}
