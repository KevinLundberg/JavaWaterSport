﻿using System;
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
            InitializeComponent();
            try
            {
                dyklista = ServiceProvider
            }
        }

        private void btnÄndraDykarkurs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLäggTillDykarkurs_Click(object sender, EventArgs e)
        {

        }

        private void btnVisaDykarkurser_Click(object sender, EventArgs e)
        {

        }

        private void btnTabortDykarkurs_Click(object sender, EventArgs e)
        {

        }
    }
}
