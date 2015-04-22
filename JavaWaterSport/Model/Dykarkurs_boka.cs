using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Model
{
    class Dykarkurs_boka
    {
        private int id;
        private int kundId;
        private int kursId;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int KundID
        {
            get { return kundId; }
            set { kundId = value; }
        }

        public int KursID
        {
            get { return kursId; }
            set { kursId = value; }
        }

        public Dykarkurs_boka(int kundID, int kursID)
        {
            this.kundId = kundID;
            this.kursId = kursID;
        }


    }
}
