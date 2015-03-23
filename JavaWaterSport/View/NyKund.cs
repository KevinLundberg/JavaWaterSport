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

            InitializeComponent();
            kundList.Updated += new EventHandler(kundService_Update);
            initListView();
        }

        private void kundService_Update(object sender, EventArgs e)
        {
            updateListView();
        }

        private void btnRegistreraKund_Click(object sender, EventArgs e)
        {
            kundList.Add(new Kund(tbxPersonligID.Text, tbxNamn.Text));
        }

        private void initListView()
        {
            lvwKunder.FullRowSelect = true;
            lvwKunder.GridLines = true;

            //Lägg till kolummner
            lvwKunder.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwKunder.Columns.Add("Kundnummer", -2, HorizontalAlignment.Left);
            lvwKunder.Columns.Add("Namn", -2, HorizontalAlignment.Left);
            
            updateListView();
        }

        //private void 

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

        private void lvwKunder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbxNamn.Clear();
                tbxPersonligID.Clear();
                string kundID = lvwKunder.SelectedItems[0].Text;
                Kund kund = kundList.FindID(kundID);
                tbxNamn.Text = kund.Namn;
                tbxPersonligID.Text = kund.PersonligID;
            }
            catch(Exception)
            {
                MessageBox.Show("Fel: Ta hjälp av André");
            }
        }
    }
}
