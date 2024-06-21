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
    public partial class GallerySoyutSantçılar : Form
    {
        public GallerySoyutSantçılar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedArtist = comboBox1.Text;
            if (!string.IsNullOrEmpty(selectedArtist))
            {
                // SQL bağlantı dizesi
                string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                // SQL sorgusu
                string query = @"
                    SELECT TOP (1000) [ArtistId]
                         ,[ArtistName]
                         ,[ArtistBio]
                         ,[ArtistCountry]
                         ,[GalleryName]
                         ,[image]
                    FROM [sanatgalerısı].[dbo].[Artists]
                    WHERE [ArtistName] = @ArtistName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ekleme
                        command.Parameters.AddWithValue("@ArtistName", selectedArtist);

                        try
                        {
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // ArtistName değerini label3'e atıyoruz
                                    label3.Text = reader["ArtistName"].ToString();

                                    // ArtistBio değerini richTextBox1'e atıyoruz
                                    richTextBox1.Text = reader["ArtistBio"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Sanatçı bulunamadı.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sanatçı seçiniz.");
            }
        }
    }
}
