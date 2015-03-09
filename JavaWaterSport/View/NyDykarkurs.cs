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

namespace JavaWaterSport.View
{
    public partial class NyDykarkurs : Form
    {
        private DykarkursList dyklista;
        public NyDykarkurs()
        {            
            InitializeComponent();
            try
            {
                //dyklista = ServiceProvider
            }
        }
    }
}
