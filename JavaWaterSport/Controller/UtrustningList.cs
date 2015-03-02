using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaWaterSport.Service;
using JavaWaterSport.Controller;
using JavaWaterSport.Model;

namespace JavaWaterSport.Controller
{
    class UtrustningList : IListor<Utrustning>, IService
    {
        private List<Utrustning> u_utrustningList;
        public event EventHandler Updated;


        public UtrustningList()
        {
            u_utrustningList = new List<Utrustning>();
        }


        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public void Add(Utrustning item)
        {
            item.setId(NextID());
            u_utrustningList.Add(item);
        }

        public void Remove(Utrustning item)
        {
            u_utrustningList.Remove(item);
        }

        public Utrustning Get(int index)
        {
            return u_utrustningList.ElementAt(index);
        }

        public int Count()
        {
            return u_utrustningList.Count();
        }


        public Utrustning FindDatum(string title)
        {
            for (int i = 0; i < u_utrustningList.Count(); i++)
            {
                if (u_utrustningList[i].getDatum() == title)
                {
                    return u_utrustningList[i];
                }
            }
            return null;
        }

        public int GetIndexOfDatum(string title)
        {
            for (int i = 0; i < u_utrustningList.Count(); i++)
            {
                if (u_utrustningList[i].getDatum() == title)
                {
                    return i;
                }
            }
            return -1;
        }

        public object toArray()
        {
            var utrustningar = from utrustning in u_utrustningList select new
            {
                HyrTid = utrustning.getHyrTid(),
                UtrustningTyp = utrustning.getUtrustningTyp(),
                Datum = utrustning.getDatum()
            };

            return utrustningar.ToArray();
        }


        public Dykarkurs Find(string strFind)
        {
            throw new NotImplementedException();
        }

        public int NextID()
        {
            return u_utrustningList.Count() + 1;
        }
    }
}
