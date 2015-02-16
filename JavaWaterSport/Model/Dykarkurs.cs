using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Model
{
    [Serializable]
    class Dykarkurs
    {
        // medlemsvariabler
        private int Id;
        private int tid;
        private string dykinstruktör;
        private string datum;

        // default konstruktor
        public Dykarkurs()
        {
            this.tid = 0;
            this.dykinstruktör = "Ingen dykinstruktör";
            this.datum = "Inget datum";
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="inTid">Dykarkurs tid</param>
        /// <param name="inDykinstruktör">Dykarkurs dykinstruktör</param>
        /// <param name="inDatum">Dykarkurs datum</param>
        public Dykarkurs(int inTid, 
                         string inDykinstruktör, 
                         string inDatum)
        {
            this.tid = inTid;
            this.dykinstruktör = inDykinstruktör;
            this.datum = inDatum;
        }

        // metoder
        public void setId(int inId)
        {
            this.Id = inId;
        }
        public int getId()
        {
            return this.Id;
        }

        /// <summary>
        /// Return dykarkursens tid.
        /// </summary>
        /// <returns>Dykarkurs tid</returns>
        public int getTid()
        {
            return this.tid;
        }

        /// <summary>
        /// Return dykarkursens dykinstruktör.
        /// </summary>
        /// <returns>Dykarkurs dykinstruktör</returns>
        public string getDykinstruktör()
        {
            return this.dykinstruktör;
        }

        /// <summary>
        /// Return dykarkursens datum.
        /// </summary>
        /// <returns>Dykarkurs datum</returns>
        public string getDatum()
        {
            return this.datum;
        }

        /// <summary>
        /// Set dykarkursens tid.
        /// </summary>
        /// <param name="inTitle">Dykarkurs tid</param>
        public void setTid(int inTid)
        {
            this.tid = inTid;
        }

        /// <summary>
        /// Set dykarkursens dykinstruktör.
        /// </summary>
        /// <param name="inTime">Dykarkurs dykinstruktör</param>
        public void setDykinstruktör(string inDykinstruktör)
        {
            this.dykinstruktör = inDykinstruktör;
        }

        /// <summary>
        /// Set dykarkursens datum.
        /// </summary>
        /// <param name="inGenre">Dykarkurs datum</param>
        public void setDatum(string inDatum)
        {
            this.datum = inDatum;
        }

        public override string ToString()
        {
            string response = "Id:" + this.Id + "\n" + "Tid:" + this.tid.ToString() + "\n" + "Dykinstruktör:" + this.dykinstruktör + "\n" + "Datum:" + this.datum;
            return response;
        }
    }
}
