using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Mesaj_Uygulamam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection dbbağlanti = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=ChatMesaj;Integrated Security=True");

        int randomkeyim;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxk.Text = "Kullanıcı Adı";
            textBoxk.ForeColor = Color.Gray;
            this.textBoxsifr.Text = "Sifre";
            this.textBoxsifr.ForeColor = Color.Gray;
            textBoxsec.Text = "Sec Code";
            textBoxsec.ForeColor = Color.Gray;



            randomver();

        }

        void randomver()
        {

            Random sec = new Random();
            randomkeyim = sec.Next(300, 500);
            label1.Text = "A" + "2" + "B" + randomkeyim;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBoxk.Text == "Kullanıcı Adı")
            {
                textBoxk.Clear();
                textBoxk.ForeColor = Color.Black;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (this.textBoxsifr.Text == "Sifre")
            {
                this.textBoxsifr.Clear();
                this.textBoxsifr.ForeColor = Color.Black;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBoxsec.Text == "Sec Code")
            {
                textBoxsec.Clear();
                textBoxsec.ForeColor = Color.Black;
            }
        }

        private void buttongirisyap_Click(object sender, EventArgs e)
        {

            dbbağlanti.Open();
            SqlCommand logine = new SqlCommand("Select * from Table_Kullanıcı Where KullanıcıAdı=@p1 and Sifre=@p2",dbbağlanti);
            logine.Parameters.AddWithValue("@p1", textBoxk.Text);
            logine.Parameters.AddWithValue("@p2", textBoxsifr.Text);

            SqlDataReader tara = logine.ExecuteReader();



            if (label1.Text == textBoxsec.Text)
            {
                if (tara.Read())
                {
                    Form2 login = new Form2();
                    MessageBox.Show("Başarılı Şekilde Giriş Yaptınız Yönlendiriliyorsunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login.kullanıcıadim = textBoxk.Text;
                    login.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                randomver();
                MessageBox.Show("Güvenlik Kodunu Kontrol Ediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



         


            dbbağlanti.Close();

        }
    }
}
