using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaWaterSport.Service;
using JavaWaterSport.Controller;
using JavaWaterSport.Model;
using JavaWaterSport.DAL;

namespace JavaWaterSport.Controller
{
    class DykarkursList : IListor<Dykarkurs>, IService
    {
        private List<Dykarkurs> d_dykarkursList;

        public event EventHandler Updated;
        
        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }
        public DykarkursList()
        {
            d_dykarkursList = new List<Dykarkurs>();
        }

        public void Add(Dykarkurs item)
        {
            item.ID = NextID();
            d_dykarkursList.Add(item);
            OnUpdated();
        }

        public void Remove(Dykarkurs item)
        {
            d_dykarkursList.Remove(item);
            OnUpdated();
        }

        public Dykarkurs Get(int index)
        {
            return d_dykarkursList.ElementAt(index);
        }

        public int Count()
        {
            return d_dykarkursList.Count();
        }

        public Dykarkurs Find(string strFind)
        {

            var me = (from dykarkurs in d_dykarkursList where dykarkurs.ID.ToString() == strFind select dykarkurs).First();
            return me;
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

        public int NextID()
        {
            return d_dykarkursList.Count() + 1;
        }

        public void SaveToDBA()
        {
            DataAccessLayerDBA dba = new DataAccessLayerDBA();
            dba.SaveDykarkurserToDatabase();
        }
    }
}
