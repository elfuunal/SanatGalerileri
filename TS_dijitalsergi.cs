using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SanatGalerileriYönetim
{
    public partial class TS_dijitalsergi : Form
    {
        private string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public TS_dijitalsergi()
        {
            InitializeComponent();
        }

        private void LoadExhibitionData(string eserName)
        {
            string query = $@"SELECT TOP 1 [GalleryName], [ExhibitionName], [EserName], [EserAçıklama], [Artist], [Photo]
                              FROM [sanatgalerısı].[dbo].[Exhibition]
                              WHERE [EserName] = @EserName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EserName", eserName);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string eserAciklama = reader["EserAçıklama"].ToString();
                    string artist = reader["Artist"].ToString();
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

        private void button11_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("11");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("10");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("12");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("13");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            LoadExhibitionData("14");
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
