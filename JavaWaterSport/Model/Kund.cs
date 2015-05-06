//-------------------------------------------------------------------------------------
// File name...................: Kund.cs
// Purpose.....................: Att skapa de varibler och metoder som behövs för kunden i programmet. Samt att göra dessa åtkomliga.
//                            
// Programmer..................: Marcus Östmo
// Date........................: 2014-12-03
// Version.....................: 
// Changed.....................: 2015-05-06
//--------------------------------------------------------------------------------------
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
        /// Konstruktor
        /// </summary>
        /// <param name="personligId">Kund personligId</param>
        /// <param name="namn">Kund namn</param>
        public Kund(string personligID, string name)
        {
            this.namn = name;
            this.personligId = personligID;
        }

        /// <summary>
        /// Set och return kundens namn.
        /// </summary>
        /// <param name="namn">Kund namn</param>
        /// <returns>Kund namn</returns>
        public string Namn
        {
            get {return namn;}
            set { namn = value; }
        }

        /// <summary>
        /// Set och return kundens personliga ID.
        /// </summary>
        /// <param name="personligId">Kund personligId</param>
        /// <returns>Kund namn</returns>
        public string PersonligID
        {
            get { return personligId; }
            set { personligId = value; }
        }

        /// <summary>
        /// Set och return kundens ID.
        /// </summary>
        /// <param name="id">Kund id</param>
        /// <returns>Kund id</returns>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return personligId + " | " + namn;
        }
    }
}
