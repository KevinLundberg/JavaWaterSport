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
    class DykarkursList : IListor<Dykarkurs>, IService
    {
        private List<Dykarkurs> d_dykarkursList;

        public event EventHandler Updated;


        public DykarkursList()
        {
            d_dykarkursList = new List<Dykarkurs>();
        }


        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public void Add(Dykarkurs item)
        {
            item.setId(NextID());
            d_dykarkursList.Add(item);
            OnUpdated();
        }

        public void Remove(Dykarkurs item)
        {
            d_dykarkursList.Remove(item);
        }

        public Dykarkurs Get(int index)
        {
            return d_dykarkursList.ElementAt(index);
        }

        public int Count()
        {
            return d_dykarkursList.Count();
        }


        public Dykarkurs FindDatum(string title)
        {
            for (int i = 0; i < d_dykarkursList.Count(); i++)
            {
                if (d_dykarkursList[i].getDatum() == title)
                {
                    return d_dykarkursList[i];
                }
            }
            return null;
        }        

        public int GetIndexOfDatum(string datum)
        {
            for (int i = 0; i < d_dykarkursList.Count(); i++)
            {
                if (d_dykarkursList[i].getDatum() == datum)
                {
                    return i;
                }
            }
            return -1;
        }

        public object toArray()
        {
            var dykarkurser = from dykarkurs in d_dykarkursList select new
            {
                Tid = dykarkurs.getTid(), Dykinstruktör = dykarkurs.getDykinstruktör(), Datum = dykarkurs.getDatum()
            };

            return dykarkurser.ToArray();
        }


        public Dykarkurs Find(string strFind)
        {
            throw new NotImplementedException();
        }

        public int NextID()
        {
            return d_dykarkursList.Count() + 1;
        }
    }
}
