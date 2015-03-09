using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaWaterSport.Controller;

namespace JavaWaterSportSystem
{
    class ServiceProvider
    {
        static KundList _kundService;
        static DykarkursList _dykarkursService;
        public static DykarkursList GetDykarkursService()
        {
            if (_dykarkursService == null)
                try
                {
                    _dykarkursService = new DykarkursList();
                }
                catch (Exception)
                {

                    throw;
                }


            return _dykarkursService;
        }

        public static KundList GetKundService()
        {
            if (_kundService == null)
            {
                try
                {
                    _kundService = new KundList();
                }
                catch (Exception)
                {

                    throw;
                }

            }

            return _kundService;
        }
    }
}
