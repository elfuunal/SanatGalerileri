using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatGalerileriYönetim
{
    public partial class DSG_KeremKirazResimSergisi : Form
    {
        public DSG_KeremKirazResimSergisi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                     FROM [sanatgalerısı].[dbo].[Exhibition]
                     WHERE [EserName] = 'A'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string eserName = reader["EserName"].ToString();
                    string eserAciklama = reader["EserAçıklama"].ToString();
                    string artist = reader["Artist"].ToString();
                    byte[] photoData = (byte[])reader["Photo"];

                    // Label'lara verileri yerleştirme
                    label3.Text = "Adsız";
                    label5.Text = eserAciklama;
                    label4.Text = artist;

                    // Resmi panel1'e yerleştirme
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        panel11.BackgroundImage = Image.FromStream(ms);
                        panel11.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                     FROM [sanatgalerısı].[dbo].[Exhibition]
                     WHERE [EserName] = 'B'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string eserName = reader["EserName"].ToString();
                    string eserAciklama = reader["EserAçıklama"].ToString();
                    string artist = reader["Artist"].ToString();
                    byte[] photoData = (byte[])reader["Photo"];

                    // Label'lara verileri yerleştirme
                    label3.Text = "Adsız";
                    label5.Text = eserAciklama;
                    label4.Text = artist;

                    // Resmi panel1'e yerleştirme
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        panel11.BackgroundImage = Image.FromStream(ms);
                        panel11.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                     FROM [sanatgalerısı].[dbo].[Exhibition]
                     WHERE [EserName] = 'C'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string eserName = reader["EserName"].ToString();
                    string eserAciklama = reader["EserAçıklama"].ToString();
                    string artist = reader["Artist"].ToString();
                    byte[] photoData = (byte[])reader["Photo"];

                    // Label'lara verileri yerleştirme
                    label3.Text = "Adsız";
                    label5.Text = eserAciklama;
                    label4.Text = artist;

                    // Resmi panel1'e yerleştirme
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        panel11.BackgroundImage = Image.FromStream(ms);
                        panel11.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

                reader.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                     FROM [sanatgalerısı].[dbo].[Exhibition]
                     WHERE [EserName] = 'D'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string eserName = reader["EserName"].ToString();
                    string eserAciklama = reader["EserAçıklama"].ToString();
                    string artist = reader["Artist"].ToString();
                    byte[] photoData = (byte[])reader["Photo"];

                    // Label'lara verileri yerleştirme
                    label3.Text = "Adsız";
                    label5.Text = eserAciklama;
                    label4.Text = artist;

                    // Resmi panel1'e yerleştirme
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        panel11.BackgroundImage = Image.FromStream(ms);
                        panel11.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

                reader.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                     FROM [sanatgalerısı].[dbo].[Exhibition]
                     WHERE [EserName] = 'E'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string eserName = reader["EserName"].ToString();
                    string eserAciklama = reader["EserAçıklama"].ToString();
                    string artist = reader["Artist"].ToString();
                    byte[] photoData = (byte[])reader["Photo"];

                    // Label'lara verileri yerleştirme
                    label3.Text = "Adsız";
                    label5.Text = eserAciklama;
                    label4.Text = artist;

                    // Resmi panel1'e yerleştirme
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        panel11.BackgroundImage = Image.FromStream(ms);
                        panel11.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

                reader.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                     FROM [sanatgalerısı].[dbo].[Exhibition]
                     WHERE [EserName] = 'F'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string eserName = reader["EserName"].ToString();
                    string eserAciklama = reader["EserAçıklama"].ToString();
                    string artist = reader["Artist"].ToString();
                    byte[] photoData = (byte[])reader["Photo"];

                    // Label'lara verileri yerleştirme
                    label3.Text = "Adsız";
                    label5.Text = eserAciklama;
                    label4.Text = artist;

                    // Resmi panel1'e yerleştirme
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        panel11.BackgroundImage = Image.FromStream(ms);
                        panel11.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

                reader.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                     FROM [sanatgalerısı].[dbo].[Exhibition]
                     WHERE [EserName] = 'G'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string eserName = reader["EserName"].ToString();
                    string eserAciklama = reader["EserAçıklama"].ToString();
                    string artist = reader["Artist"].ToString();
                    byte[] photoData = (byte[])reader["Photo"];

                    // Label'lara verileri yerleştirme
                    label3.Text = "Adsız";
                    label5.Text = eserAciklama;
                    label4.Text = artist;

                    // Resmi panel1'e yerleştirme
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        panel11.BackgroundImage = Image.FromStream(ms);
                        panel11.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

                reader.Close();
            }
        }
    }
}
