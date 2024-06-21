using System;
using System.Windows.Forms;

namespace SanatGalerileriYönetim
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            //bu kod, veritabınından galleries tablosunu getiriyordu, lakin click yapınca butona yönlendirme işlemi olmadı.
            //this.galleriesTableAdapter.Fill(this.sanatgalerısıDataSet.Galleries);

            // Veritabınından bilgileri çektiğim zaman buton kısmı akktif çalışmadığı için manuel bir şekilde girdim.

            comboBox1.Items.Add("Artnivo Galeri");
            comboBox1.Items.Add("Doku Sanat Galerisi");
            comboBox1.Items.Add("Galeri Soyut"); 
            comboBox1.Items.Add("Tam Sanat Galeri");           
            comboBox1.Items.Add("Elif Galerisi"); //Daha EKLENMEDİ.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedValue = comboBox1.SelectedItem.ToString();
                Form nextForm = null;

                
                if (selectedValue == "Tam Sanat Galeri")
                {
                    nextForm = new TamSanatGaleri();
                }
                else if (selectedValue == "Artnivo Galeri")
                {
                    nextForm = new ArtnivoGaleri();
                }
                else if (selectedValue == "Doku Sanat Galerisi")
                {
                    nextForm = new DokuSanatGalerisi();
                }
                else if (selectedValue == "Galeri Soyut")
                {
                    nextForm = new GallerySoyut();
                }
                else
                {
                    MessageBox.Show("Bu galeri düzenlenmekte, lütfen diğer galerilerden seçiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (nextForm != null)
                {
                    nextForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
