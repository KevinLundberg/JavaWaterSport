using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Controller
{
    class DykarkursList : IListor<Dykarkurs>, Iservice
    {
        private List<Dykarkurs> m_dykarkurslist;
        public event EventHandler Updated;

        public DykarkursList()
        {
            m_dykarkurslist = new List<Dykarkurs>();
        }

        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public void Add(Dykarkurs item)
        {
            item.setId(NextID());
            m_dykarkurslist.Add(item);
        }

        public void Remove(Dykarkurs item)
        {
            m_dykarkurslist.Remove(item);
        }

        public Dykarkurs Get(int index)
        {
            return m_dykarkurslist.ElementAt(index);
        }


        public int Count()
        {
            return m_dykarkurslist.Count();
        }


        public Dykarkurs FindKurs(string kurs)
        {
            for (int i=0; i < m_dykarkursList.Count(); i++)
            {
                if (m_dykarkurslist[i].getKurs()==kurs)
                {
                    return m_dykarkurslist[i];
                }
            }
            return null;
        }


        public int GetIndexOfKurs (string kurs)
        {
            for (int i=0; i < m_dykarkurslist.Count(); i++)
            {
                if (m_dykarkurslist[i].getKurs()==kurs)
                {
                    return 1;
                }
            }
            return -1;
        }

        public void Update
    }
}
