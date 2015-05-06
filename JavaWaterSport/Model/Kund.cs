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

        /// <summary>
        /// Set och return kundens namn
        /// </summary>
        public string Namn
        {
            get {return namn;}
            set { namn = value; }
        }

        /// <summary>
        /// Set och return kundens personliga ID
        /// </summary>
        public string PersonligID
        {
            get { return personligId; }
            set { personligId = value; }
        }

        /// <summary>
        /// Set och return ID
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="personligID">Kundens personliga ID</param>
        /// <param name="name">Kundens namn</param>
        public Kund(string personligID, string name)
        {
            this.namn = name;
            this.personligId = personligID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return personligId + " | " + namn;
        }
    }
}
