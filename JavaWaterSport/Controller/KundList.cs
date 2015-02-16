using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaWaterSport.Model;
using JavaWaterSport.Service;
using JavaWaterSport.Controller;

namespace JavaWaterSport.Controller
{
    class KundList : IListor<Kund>, IService 
    {
        private List<Kund> k_kundList;
        public event EventHandler Updated;

        public KundList()
        {
            k_kundList = new List<Kund>();
        }


        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public void Add(Kund item)
        {
            item.setId(NextID());
            k_kundList.Add(item);
        }

        public void Remove(Kund item)
        {
            k_kundList.Remove(item);
        }

        public Kund Get(int index)
        {
            return k_kundList.ElementAt(index);
        }

        public int Count()
        {
            return k_kundList.Count();
        }


        public Kund FindTitle(string title)
        {
            for (int i = 0; i < k_kundList.Count(); i++)
            {
                // if (k_kundList[i].getTitle() == title)
                {
                    return k_kundList[i];
                }
            }
            return null;
        }

        public int GetIndexOfTitle(string title)
        {
            for (int i = 0; i < k_kundList.Count(); i++)
            {
                //if (k_kundList[i].getTitle() == title)
                {
                    return i;
                }
            }
            return -1;
        }

        public void UpdateImagePath(Kund kund, string path)
        {
           // kund.setPath(path);
            k_kundList.Remove(kund);
            k_kundList.Add(kund);
        }

        public object toArray()
        {

            var kunder = from kund in k_kundList
                         select new
                         {
                             //Title = kund.getTitle(),
                             //Runtime = kund.getTime(),
                             //Genre = kund.getGenre(),
                             //Director = kund.getDirector(),
                             //Age = kund.getAge()

                         };

            return kunder.ToArray();
        }


        public Kund Find(string strFind)
        {
            throw new NotImplementedException();
        }

        public int NextID()
        {
            return k_kundList.Count() + 1;
        }
    }
}
