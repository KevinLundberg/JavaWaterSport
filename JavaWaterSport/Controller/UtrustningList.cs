using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaWaterSport.Service;
using JavaWaterSport.Model;
using JavaWaterSport.Controller;

namespace JavaWaterSport.Controller
{
    class UtrustningList : IListor<Utrustning>, IService
    {
        private List<Utrustning> u_utrustninglist;
        public event EventHandler Updated;


        public UtrustningList()
        {
            u_utrustninglist = new List<Utrustning>();
        }

        
        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public Utrustning Get(int index)
        {
            return u_utrustninglist.ElementAt(index);
        }

        public int Count()
        {
            return u_utrustninglist.Count();
        }

        public Utrustning FindDatum(string title)
        {
            for (int i = 0; i < u_utrustninglist.Count(); i++)
            {
                if (u_utrustninglist[i].getDatum() == title)
                {
                    return u_utrustninglist[i];
                }
            }
            return null;
        }

        public int GetIndexOfDatum (string datum)
        {
            for (int i = 0; i < u_utrustninglist.Count(); i++)
            {
                if (u_utrustninglist[i].getDatum() == datum)
                {
                    return i;
                }
            }
            return -1;
        }
    }

}
