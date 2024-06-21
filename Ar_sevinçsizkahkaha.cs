using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SanatGalerileriYönetim
{
    public partial class Ar_sevinçsizkahkaha : Form
    {
        private string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Ar_sevinçsizkahkaha()
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
            LoadExhibition("Ben İkna Oldum");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadExhibition("Yine Sıramız Değişmedi\r\n");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadExhibition("Mono-İzler #1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadExhibition("Bir Hayalim var -II\r\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadExhibition("Unheard");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadExhibition("Bir Hayalim var");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadExhibition("Kırmızı Araba");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadExhibition("Mono-İzler #4");
        }
    }
}
