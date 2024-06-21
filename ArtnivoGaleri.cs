using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatGalerileriYönetim
{
    public partial class ArtnivoGaleri : Form
    {
        public ArtnivoGaleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Artnivogalerisergileri();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Artnivogalerisanatçıları();
            nextForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Artnivogalerihakkımızda();
            nextForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Anasayfa();
            nextForm.Show();
            this.Close();
        }
    }
}
