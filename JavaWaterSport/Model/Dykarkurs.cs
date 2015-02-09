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
        private int Id;
        private int time;
        private string instruktör;
        private string datum;

        public Dykarkurs()
        {
            this.time = 0;
            this.instruktör = "Ingen instruktör";
            this.datum = "Inget datum";
        }
    }
}
