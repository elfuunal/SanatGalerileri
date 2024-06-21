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
    public partial class TamSanatSergileri : Form
    {
        public TamSanatSergileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new TS_19mayıssergisi();
            nextForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new TS_dijitalsergi();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form nextForm = null;
            nextForm = new TS_atasanatgalersi();
            nextForm.Show();
        }
    }
}
