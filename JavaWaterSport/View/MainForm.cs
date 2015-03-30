using JavaWaterSport.DAL;
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

        private void listaAllaDykarkurserIBiblioteketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyDykarkurs visaDykarkurser = new NyDykarkurs();
            visaDykarkurser.Show();
        }

        private void listaAllaTillgängligaDykarkurserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyDykarkurs listaDykarkurser = new NyDykarkurs();
            listaDykarkurser.Show();
        }

        private void läggTillNyDykarkursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyDykarkurs läggtillDykarkurs = new NyDykarkurs();
            läggtillDykarkurs.Show();
        }

        private void sparaKunderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayerDBA dba = new DataAccessLayerDBA();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
