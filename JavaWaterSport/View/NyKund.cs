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
using JavaWaterSport.Model;

namespace JavaWaterSport.View
{
    public partial class NyKund : Form
    {
        private KundList kundList;
        private DykarkursList dykList;
        private BokningsList bokList;                

        public NyKund()
        {
            try
            {
                kundList = ServiceProvider.GetKundService();
                dykList = ServiceProvider.GetDykarkursService();
                bokList = ServiceProvider.GetBokningsService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            InitializeComponent();
            dykList.Updated += new EventHandler(dykService_Update);            
            kundList.Updated += new EventHandler(kundService_Update);
            bokList.Updated += new EventHandler(bokList_Update);
            initListView();
        }

        private void bokList_Update(object sender, EventArgs e)
        {
            updateBokListView();
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

            //Lägg till kolummner
            lvwDykarkurs.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwDykarkurs.Columns.Add("Tid     ", -2, HorizontalAlignment.Left);
            lvwDykarkurs.Columns.Add("Dykinstruktör", -2, HorizontalAlignment.Left);
            lvwDykarkurs.Columns.Add("Datum", -2, HorizontalAlignment.Left);

            //Egenskaper för boknings-listview
            lvwBokningar.FullRowSelect = true;
            lvwBokningar.GridLines = true;

            //Lägg till kolummner
            lvwBokningar.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Kund ID", -2, HorizontalAlignment.Left);
            lvwBokningar.Columns.Add("Kurs ID", -2, HorizontalAlignment.Left);

            updateListView();
            updateDykListView();
            updateBokListView();
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
        private void updateBokListView()
        {
            lvwBokningar.Items.Clear();
            string[] columns = new string[3];
            ListViewItem item;

            for (int i = 0; i < bokList.Count(); i++)
            {
                columns[0] = bokList.Get(i).ID.ToString();
                columns[1] = bokList.Get(i).KundID.ToString();
                columns[2] = bokList.Get(i).KursID.ToString();
                item = new ListViewItem(columns);
                lvwBokningar.Items.Add(item);
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
            try
            {
                Dykarkurs_boka item = new Dykarkurs_boka(Convert.ToInt32(lblKundID.Text), Convert.ToInt32(lblKursID.Text));
                bokList.Add(item);
            }
            catch (Exception)
            {                
                MessageBox.Show("Markera i respektive lista");
            }
        }

        private void btnTaBortBokning_Click(object sender, EventArgs e)
        {
            try
            {
                string bokningsID = lvwBokningar.SelectedItems[0].Text;
                Dykarkurs_boka bokning = bokList.Find(bokningsID);
                bokList.Remove(bokning);                
            }

            catch
            {
                MessageBox.Show("Markera en bokning för att radera!");
            }
        }

        //private void AddTestData()
        //{
        //    Kund item = new Kund("15", "Määk");
        //    item = new Kund("17", "Kenny");
        //    item = new Kund("3", "Benny");
        //    item = new Kund("5", "Uffe");
        //    item = new Kund("8", "Thörn");
        //    kundList.Add(item);

        //    Dykarkurs items = new Dykarkurs("2", "Yngve", "15-02-15");
        //    items = new Dykarkurs("2", "Anton", "15-02-15");
        //    items = new Dykarkurs("2", "Button", "15-02-15");
        //    items = new Dykarkurs("2", "Macke", "15-02-15");
        //    dykList.Add(items);

        //    updateListView();
        //    updateDykListView();
        //}

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
                lblKundID.Text = kundID;

            }
            catch(Exception)
            {
               
            }
        }

        private void lvwDykarkurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string kursID = lvwDykarkurs.SelectedItems[0].Text;
                lblKursID.Text = kursID;               
            }
            catch (Exception)
            {
                
            }
        }        
    }
}
