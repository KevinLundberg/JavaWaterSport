using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JavaWaterSport.DAL;
using JavaWaterSportSystem;
using JavaWaterSport.Controller;

namespace JavaWaterSport.View
{
    public partial class NyKund : Form
    {
        private KundList kundList;
        private DykarkursList dykList;

        public NyKund()
        {
            try
            {
                kundList = ServiceProvider.GetKundService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                dykList = ServiceProvider.GetDykarkursService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            InitializeComponent();
            dykList.Updated += new EventHandler(dykService_Update);            
            kundList.Updated += new EventHandler(kundService_Update);
            initListView();
        }


        private void dykService_Update(object sender, EventArgs e)
        {
 	        updateDykListView();
        }

        private void kundService_Update(object sender, EventArgs e)
        {
            updateListView();
        }

        private void initListView()
        {
            //Egenskaper för Kund-listview
            lvwKunder.FullRowSelect = true;
            lvwKunder.GridLines = true;

            //Lägg till kolummner
            lvwKunder.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwKunder.Columns.Add("Kundnummer", -2, HorizontalAlignment.Left);
            lvwKunder.Columns.Add("Namn", -2, HorizontalAlignment.Left);

            //Egenskaper för dykarkurs-listview
            lvwDykarkurs.FullRowSelect = true;
            lvwDykarkurs.GridLines = true;

            lvwDykarkurs.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwDykarkurs.Columns.Add("Tid     ", -2, HorizontalAlignment.Left);
            lvwDykarkurs.Columns.Add("Dykinstruktör", -2, HorizontalAlignment.Left);
            lvwDykarkurs.Columns.Add("Datum", -2, HorizontalAlignment.Left);

            updateListView();
            updateDykListView();
        }         

        private void updateListView()
        {
            lvwKunder.Items.Clear();
            string[] columns = new string[3];
            ListViewItem item;

            for (int i = 0; i < kundList.Count(); i++)
            {
                columns[0] = kundList.Get(i).ID.ToString();
                columns[1] = kundList.Get(i).PersonligID;
                columns[2] = kundList.Get(i).Namn;
                item = new ListViewItem(columns);
                lvwKunder.Items.Add(item);
            }            
        }

        private void updateDykListView()
        {
            lvwDykarkurs.Items.Clear();
            string[] columns = new string[4];
            ListViewItem item;

            for (int index = 0; index < dykList.Count(); index++)
            {
                columns[0] = dykList.Get(index).ID.ToString();
                columns[1] = dykList.Get(index).getTid();
                columns[2] = dykList.Get(index).getDykinstruktör();
                columns[3] = dykList.Get(index).getDatum();
                item = new ListViewItem(columns);
                lvwDykarkurs.Items.Add(item);
            }
        }

        private void btnTaBortKund_Click(object sender, EventArgs e)
        {
            try
            {
                string kundID = lvwKunder.SelectedItems[0].Text;
                Kund kund = kundList.Find(kundID);
                kundList.Remove(kund);

                tbxNamn.Clear();
                tbxPersonligID.Clear();
                updateListView();
            }

            catch
            {
                MessageBox.Show("Markera en kund för att radera!");
            }
        }

        private void btnRegistreraKund_Click(object sender, EventArgs e)
        {
            try
            {
                kundList.Add(new Kund(tbxPersonligID.Text, tbxNamn.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Fyll i alla uppgifter!");
            }
        }

        private void btnBokaDykarkurs_Click(object sender, EventArgs e)
        {

        }

        private void lvwKunder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbxNamn.Clear();
                tbxPersonligID.Clear();
                string kundID = lvwKunder.SelectedItems[0].Text;
                Kund kund = kundList.Find(kundID);
                tbxNamn.Text = kund.Namn;
                tbxPersonligID.Text = kund.PersonligID;
            }
            catch(Exception)
            {
               
            }
        }            
    }
}
