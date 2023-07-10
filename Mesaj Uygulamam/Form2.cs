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

namespace Mesaj_Uygulamam
{
    public partial class Form2 : Form
    {

        SqlConnection dbbağlanti = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=ChatMesaj;Integrated Security=True");


        public Form2()
        {
            InitializeComponent();
        }


        public string kullanıcıadim;

    
        private void Form2_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            dbbağlanti.Open();
            labelkullanıcıadım.Text = kullanıcıadim;
            SqlCommand logine = new SqlCommand("Select * from Table_Kullanıcı Where KullanıcıAdı=@p1", dbbağlanti);
            logine.Parameters.AddWithValue("@p1", labelkullanıcıadım.Text);

            SqlDataReader tara = logine.ExecuteReader();

            while (tara.Read())
            {
                labelisim.Text = tara[1].ToString();
                labelsoyisim.Text = tara[2].ToString();
                listBox1.Items.Add(tara[5].ToString());
                labelkimisim.Text = tara[6].ToString();
                label6.Text = tara[7].ToString();
            }
            dbbağlanti.Close();

          

      
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "BİLGİLERİM";

            if (button2.Text == label9.Text)
            {
                panel5.Visible = false;
                panel4.Visible = false;
                panel2.Visible = true;
            }
           

          





        }

        private void button3_Click(object sender, EventArgs e)
        {
          


            label9.Text = "KULLANICILAR";

            if (button3.Text == label9.Text)
            {
              
                panel5.Visible = false;
                panel4.Visible = true;
            }
         


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            dbbağlanti.Open();

            SqlCommand hepsiniala = new SqlCommand("Select Ad,SoyAd,KullanıcıAdı from Table_Kullanıcı", dbbağlanti);

            SqlDataAdapter dt = new SqlDataAdapter(hepsiniala);

            DataTable dr = new DataTable();

            dt.Fill(dr);

            dataGridView1.DataSource = dr;

            dbbağlanti.Close();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
         //   label8.Text = dataGridView1.SelectedRows[e.Rowindex].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = "MESAJ GÖNDER";

            if (button1.Text == label9.Text)
            {
               
                    panel5.Visible = true;
               // panel2.Visible = false;
            }
           
           
        }
    }
}
