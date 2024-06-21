using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SanatGalerileriYönetim
{
    public partial class Ar_enstalasyon : Form
    {
        private string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Ar_enstalasyon()
        {
            InitializeComponent();
        }

        private void LoadExhibition(string eserNameQuery)
        {
            string query = $@"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                              FROM [sanatgalerısı].[dbo].[Exhibition]
                              WHERE [EserName] = @EserName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EserName", eserNameQuery);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    label3.Text = reader["EserName"].ToString();
                    label5.Text = reader["EserAçıklama"].ToString();
                    label4.Text = reader["Artist"].ToString();
                    byte[] photoData = (byte[])reader["Photo"];

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
            LoadExhibition("İçindeyim & Büsbütün Dışında, No:1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadExhibition("İçindeyim & Büsbütün Dışında, No: 4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadExhibition("İçindeyim & Büsbütün Dışında, No:5\r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadExhibition("Gökyüzüne Uzanan Sonsuz Sütunlar Tasnifin Bedenleri Kavuklar Anıt No1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadExhibition("h143 (Karinca Evi Serisinden)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadExhibition("Adalet");
        }
    }
}
