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
    public partial class Resetle : Form
    {
        public Resetle()
        {
            InitializeComponent();
        }

        private void Gö_Click(object sender, EventArgs e)
        {
            if (tbxYeniSifre.Text.Equals(tbxTekrar.Text))
            {
                SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial catalog=sifremiYenile;integrated security=true");
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("update Sifrem set Password=@p1 where Id=@p2", sqlConnection);
                command.Parameters.AddWithValue("@p1", tbxYeniSifre.Text.ToString());
                command.Parameters.AddWithValue("@p2", 1);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("şifre değiştirme başarılı");
            }
            else
            {
                MessageBox.Show("şifre tekrarla uyuşmuyor");
            }
        }
    }
}
