using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Model
{
    [Serializable]
    class Kund
    {
        private int m_id;
        private string m_personalId;
        private string m_name;

        public string Name
        {
            get {return m_name;}
            set { m_name = value; }
        }

        public string PersonalID
        {
            get { return m_personalId; }
            set { m_personalId = value; }
        }

        public int ID
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public Kund(string personalID, string name)
        {
            this.m_name = name;
            this.m_personalId = personalID;
        }

        public override string ToString()
        {
            return m_personalId + " | " + m_name;
        }
    }
}
