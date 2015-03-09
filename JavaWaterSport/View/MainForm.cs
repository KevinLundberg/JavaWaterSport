using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaWaterSport.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void visaAllaKunderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyKund nykund = new NyKund();
            nykund.Show();
        }

        private void registreraNyKundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyKund registreraKund = new NyKund();
            registreraKund.Show();
        }

        private void bokaDykarkursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyKund bokaDykkurs = new NyKund();
            bokaDykkurs.Show();
        }

        private void hyrUtrustningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyKund hyrUtrustning = new NyKund();
            hyrUtrustning.Show();
        }
    }
}
