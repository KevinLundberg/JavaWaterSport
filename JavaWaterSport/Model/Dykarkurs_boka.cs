using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Model
{
    [Serializable]
    class Dykarkurs_boka
    {
        private int id;
        private string kundId;
        private string kursId;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string KundID
        {
            get { return kundId; }
            set { kundId = value; }
        }

        public string KursID
        {
            get { return kursId; }
            set { kursId = value; }
        }

        public Dykarkurs_boka(string kundID, string kursID)
        {
            this.kundId = kundID;
            this.kursId = kursID;
        }


    }
}
