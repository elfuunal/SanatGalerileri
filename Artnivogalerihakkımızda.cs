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

namespace SanatGalerileriYönetim
{
    public partial class Artnivogalerihakkımızda : Form
    {
        private string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Initial Catalog=sanatgalerısı;Integrated Security=True;TrustServerCertificate=True";
        public Artnivogalerihakkımızda()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadDescription();
            LoadGalleryInfo();
        }
        private void LoadDescription()
        {
            string query = "SELECT Description FROM Descriptions WHERE Galleryname='Artnivo Sanat Galerisi'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        TextBox1.Text = reader["Description"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
        private void LoadGalleryInfo()
        {
            LoadLabelData("SELECT Address FROM Galleries WHERE Galleryname='Artnivo Sanat Galerisi'", label5);
            LoadLabelData("SELECT Email FROM Galleries WHERE Galleryname='Artnivo Sanat Galerisi'", label6);
            LoadLabelData("SELECT Phone FROM Galleries WHERE Galleryname='Artnivo Sanat Galerisi'", label7);
        }
        private void LoadLabelData(string query, Label label)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        label.Text = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
