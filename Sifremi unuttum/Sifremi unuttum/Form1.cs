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

namespace Sifremi_unuttum
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
     
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SifreSıfırla sifreSıfırla = new SifreSıfırla();
            sifreSıfırla.ShowDialog();
            this.Show();
        }
        string userName;
        string password;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial catalog=sifremiYenile;integrated security=true");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from Sifrem",sqlConnection);
            SqlDataReader reader= command.ExecuteReader();
            while (reader.Read())
            { userName = reader[1].ToString();
              password = reader[2].ToString();

            }
           


            if (tbxKullanıcıadi.Text.Equals(userName) && tbxSifre.Text.Equals(password))
            {
                 tbxKullanıcıadi.Hide();
                tbxSifre.Hide();
                lblkullaniciadi.Hide();
                lblSifregir.Hide();
                MessageBox.Show("Giriş başarılı");
               
            }
            else
            {
                MessageBox.Show("Şifre hatalı");
            }
            sqlConnection.Close();
            reader.Close();

        }
    }
}
