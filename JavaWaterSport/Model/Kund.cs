using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Model
{
    [Serializable]
    class Kund
    {
        private int k_id;
        private string k_personligId;
        private string k_namn;

        public string Namn
        {
            get {return k_namn;}
            set { k_namn = value; }
        }

        public string PersonaligID
        {
            get { return k_personligId; }
            set { k_personligId = value; }
        }

        public int ID
        {
            get { return k_id; }
            set { k_id = value; }
        }

        public Kund(string personligID, string name)
        {
            this.k_namn = name;
            this.k_personligId = personligID;
        }

        public override string ToString()
        {
            return k_personligId + " | " + k_namn;
        }
    }
}
