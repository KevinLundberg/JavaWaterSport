using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Model
{
    class Dykarkurs_boka
    {
        private int ID;
        private int KundID;
        private int KursID;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int kundID
        {
            get { return kundID; }
            set { kundID = value; }
        }

        public int kursID
        {
            get { return KursID; }
            set { KursID = value; }
        }

        public Dykarkurs_boka(int KundId, int KursId)
        {
            this.KundID = KundId;
            this.KursID = KursId;
        }


    }
}
