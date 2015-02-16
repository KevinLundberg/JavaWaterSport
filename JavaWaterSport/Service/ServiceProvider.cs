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
        static KundList _KundService;
        //static MovieList _movieService;
        //public static KundList GetKundService()
        //{
        //    if (_KundService == null)
        //        _KundService = new KundList();

        //    return _KundService;
        //}

        public static KundList GetKundService()
        {
            if (_KundService == null)
            {
                try
                {
                    _KundService = new KundList();
                }
                catch (Exception)
                {

                    throw;
                }

            }

            return _KundService;
        }
    }
}
