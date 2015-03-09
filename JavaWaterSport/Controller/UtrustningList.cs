using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaWaterSport.DAL;
using JavaWaterSport.Service;
using JavaWaterSportSystem;
using JavaWaterSport.Model;
using System.IO;

namespace JavaWaterSport.Controller
{
    class UtrustningList : IListor<Utrustning>, IService
    {
        private List<Utrustning> u_utrustning;

        public event EventHandler Updated;


        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public UtrustningList()
        {
            u_utrustning = new List<Utrustning>();
            try
            {
                if(File.Exists("UtrustningLista.DAT"))
                {
                    u_utrustning = BinarySerialization<List<Utrustning>>.BinaryDeSerialize("UtrustningLista.DAT");
                }
            }
            catch (Exception ex)
            {

                throw new CustomException(ex.Message);
            }
        }
    }
}
