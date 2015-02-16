using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSportSystem
{
    [Serializable]
    class Kund
    {
        // medlemsvariabler
        private int id;
        private string personligId;
        private string namn;

        public string Namn
        {
            get {return namn;}
            set { namn = value; }
        }

        public string PersonaligID
        {
            get { return personligId; }
            set { personligId = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Kund(string personligID, string name)
        {
            this.namn = name;
            this.personligId = personligID;
        }

        public override string ToString()
        {
            return personligId + " | " + namn;
        }
    }
}
