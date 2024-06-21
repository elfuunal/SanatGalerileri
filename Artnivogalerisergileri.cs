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
    public partial class Artnivogalerisergileri : Form
    {
        public Artnivogalerisergileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Ar_Heykelsergisi();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Ar_insanlaştırma();
            nextForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Ar_sevinçsizkahkaha();
            nextForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Ar_enstalasyon();
            nextForm.Show();
        }
    }
}
