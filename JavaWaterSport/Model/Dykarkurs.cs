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
        private string tid;
        private string dykinstruktör;
        private string datum;

        // default konstruktor
        public Dykarkurs()
        {
            this.tid = "null";
            this.dykinstruktör = "Ingen dykinstruktör";
            this.datum = "Inget datum";
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="tid">Dykarkurs tid</param>
        /// <param name="dykinstruktör">Dykarkurs dykinstruktör</param>
        /// <param name="datum">Dykarkurs datum</param>
        public Dykarkurs(string inTid, string inDykinstruktör, string inDatum)
        {
            this.tid = inTid;
            this.dykinstruktör = inDykinstruktör;
            this.datum = inDatum;
        }
        
       
        
        // metoder

        /// <summary>
        /// Return dykarkursens tid.
        /// </summary>
        /// <returns>Dykarkurs tid</returns>
        public string getTid()
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
        /// <param name="tid">Dykarkurs tid</param>
        public void setTid(string inTid)
        {
            this.tid = inTid;
        }

        /// <summary>
        /// Set dykarkursens dykinstruktör.
        /// </summary>
        /// <param name="dykinstruktör">Dykarkurs dykinstruktör</param>
        public void setDykinstruktör(string inDykinstruktör)
        {
            this.dykinstruktör = inDykinstruktör;
        }

        /// <summary>
        /// Set dykarkursens datum.
        /// </summary>
        /// <param name="datum">Dykarkurs datum</param>
        public void setDatum(string inDatum)
        {
            this.datum = inDatum;
        }

        /// <summary>
        /// Set och return dykarkursens id.
        /// </summary>
        /// <param name="id">Dykarkurs id</param>
        /// /// <returns>Dykarkurs id</returns>
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public override string ToString()
        {
            string response = "Id:" + this.Id + "\n" + "Tid:" + this.tid.ToString() + "\n" + "Dykinstruktör:" + this.dykinstruktör + "\n" + "Datum:" + this.datum;
            return response;
        }
    }
}
