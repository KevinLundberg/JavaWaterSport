using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JavaWaterSport.Controller;
using JavaWaterSport.DAL;
using JavaWaterSportSystem;
using JavaWaterSport.Model;

namespace JavaWaterSport.View
{
    public partial class NyDykarkurs : Form
    {
        private DykarkursList dykarkursLista;
        public NyDykarkurs()
        {        
            
            try
            {
                dykarkursLista = ServiceProvider.GetDykarkursService();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            InitializeComponent();
            dykarkursLista.Updated += new EventHandler(dykarkursService_Update);
            initListView();
        }

        private void dykarkursService_Update(object sender, EventArgs e)
        {
            updateListView();
        }

        private void initListView()
        {
            lvwDykarkurser.FullRowSelect = true;
            lvwDykarkurser.GridLines = true;

            //Lägg till kolummner
            lvwDykarkurser.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwDykarkurser.Columns.Add("Tid     ", -2, HorizontalAlignment.Left);
            lvwDykarkurser.Columns.Add("Dykinstruktör", -2, HorizontalAlignment.Left);
            lvwDykarkurser.Columns.Add("Datum", -2, HorizontalAlignment.Left);

            updateListView();
        }

        private void updateListView()
        {
            lvwDykarkurser.Items.Clear();
            string[] columns = new string[4];
            ListViewItem item;

            for (int i = 0; i < dykarkursLista.Count(); i++)
            {
                columns[0] = dykarkursLista.Get(i).ID.ToString();
                columns[1] = dykarkursLista.Get(i).getTid();
                columns[2] = dykarkursLista.Get(i).getDykinstruktör();
                columns[3] = dykarkursLista.Get(i).getDatum();
                item = new ListViewItem(columns);
                lvwDykarkurser.Items.Add(item);
            }
        }        


        private void btnÄndraDykarkurs_Click(object sender, EventArgs e)
        {
            
        }       

        private void btnVisaDykarkurser_Click(object sender, EventArgs e)
        {

        }

        private void btnLäggTillDykarkurs_Click(object sender, EventArgs e)
        {
            try
            {
                dykarkursLista.Add(new Dykarkurs(tbxTid.Text, cbxDykinstruktörer.SelectedItem.ToString(), tbxDatum.Text));
        }
            catch (Exception)
            {
                MessageBox.Show("Fyll i alla uppgifter!");
            }
        }

        private void btnTabortDykarkurs_Click(object sender, EventArgs e)
        {
            try
            { 
                string dykarkursID = lvwDykarkurser.SelectedItems[0].Text;
                Dykarkurs dykarkurs = dykarkursLista.Find(dykarkursID);
                dykarkursLista.Remove(dykarkurs);

                tbxDatum.Clear();
                tbxTid.Clear();
                cbxDykinstruktörer.ResetText();
            }

            catch
            {
                MessageBox.Show("Markera en dykarkurs för att radera!");
            }
        }

        private void lvwDykarkurser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbxDatum.Clear();
                tbxTid.Clear();
                cbxDykinstruktörer.ResetText();
                string dykarkursID = lvwDykarkurser.SelectedItems[0].Text;
                Dykarkurs dykarkurs = dykarkursLista.Find(dykarkursID);
                tbxDatum.Text = dykarkurs.getDatum();
                tbxTid.Text = dykarkurs.getTid();
                cbxDykinstruktörer.Text = dykarkurs.getDykinstruktör();               
            }

            catch (Exception)
            {
                
                
            }
        }
    }
}
