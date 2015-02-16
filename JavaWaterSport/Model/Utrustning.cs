using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Model
{
    class Utrustning
    {
        // medlemsvariabler       
        private int Id;
        private int hyrTid;        
        private int utrustningTyp;
        private string datum;

        // default konstruktor
        public Utrustning()
        {
            this.hyrTid = 0;
            this.utrustningTyp = 0;
            this.datum = "Inget datum";
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="inHyrTid">Tid för uthyrning</param>
        /// <param name="inUtrustningsTyp">Vilken typ av utrustning som ska hyras</param>
        /// <param name="inDatum">Datum för uthyrning</param>
        public Utrustning(int inHyrTid, int inUtrustningTyp, string inDatum)
        {
            this.hyrTid = inHyrTid;
            this.utrustningTyp = inUtrustningTyp;
            this.datum = inDatum;
        }

        // Metoder
        public void setId(int inId)
        {
            this.Id = inId;
        }
        public int getId()
        {
            return this.Id;
        }

        /// <summary>
        /// Returnera tiden för uthyrning
        /// </summary>
        /// <returns>Hyrtid</returns>
        public int getHyrTid()
        {
            return this.hyrTid;
        }

        /// <summary>
        /// Returnera typ av utrustning
        /// </summary>
        /// <returns>Typ av utrustning</returns>
        public int getUtrustningTyp()
        {
            return this.utrustningTyp;
        }

        /// <summary>
        /// Returnera datum
        /// </summary>
        /// <returns>datum</returns>
        public string getDatum()
        {
            return this.datum;
        }

        /// <summary>
        /// Sätt hyrtid
        /// </summary>
        /// <param name="inHyrTid">hyrtid</param>
        public void setHyrTid(int inHyrTid)
        {
            this.hyrTid = inHyrTid;
        }

        /// <summary>
        /// Sätt typ av utrustning
        /// </summary>
        /// <param name="inUtrustningTyp">typ av utrustning</param>
        public void setUtrustningTyp(int inUtrustningTyp)
        {
            this.utrustningTyp = inUtrustningTyp;
        }

        /// <summary>
        /// Sätt datum
        /// </summary>
        /// <param name="inDatum">datum/param>
        public void setDatum(string inDatum)
        {
            this.datum = inDatum;
        }

        public override string ToString()
        {
            string response = "Id:" + this.Id + "\n" + "Hyrtid:" + this.hyrTid + "\n" + "Typ av utrustning " + this.utrustningTyp + "\n" + "Datum" + this.datum;
            return response;

        }
    }
}
