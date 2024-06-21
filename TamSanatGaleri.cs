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
    public partial class TamSanatGaleri : Form
    {
        public TamSanatGaleri()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new TamSanatSergileri();
            nextForm.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new TamSanatHakkında();
            nextForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new Anasayfa();
            nextForm.Show();
            this.Close();
        }
    }
}
