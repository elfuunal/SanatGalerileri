using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatGalerileriYönetim
{
    public partial class Ar_insanlaştırma : Form
    {
        private string connectionString = "Data Source=ELIFUNAL\\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Ar_insanlaştırma()
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
            LoadExhibition("You");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadExhibition("Times Change");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadExhibition("Sight");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadExhibition("Seen");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadExhibition("Sadness");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadExhibition("On My Mind");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadExhibition("Mistakes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadExhibition("Anxiety");
        }
    }
}
