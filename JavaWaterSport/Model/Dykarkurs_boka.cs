//-------------------------------------------------------------------------------------
// File name...................: Kund.cs
// Purpose.....................: Att skapa de varibler och metoder som behövs för bokningar i programme, samt att göra dessa åtkomliga.
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

namespace JavaWaterSport.Model
{
    [Serializable]
    class Dykarkurs_boka
    {
        //medlemsvariabler
        private int id;
        private string kundId;
        private string kursId;

        /// <summary>
        /// Set och return ID för bokningen
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// set och return Kund ID 
        /// </summary>
        public string KundID
        {
            get { return kundId; }
            set { kundId = value; }
        }

        /// <summary>
        /// set och return Kurs ID
        /// </summary>
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
