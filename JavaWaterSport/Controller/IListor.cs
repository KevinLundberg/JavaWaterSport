// ----------------------------------
// File name.........: DykarkursList.cs
// Purpose ..........: Generella funktioner för lista
// Programmer........: Kevin Lundberg
// Date..............: 2014-12-03
// Version...........: 1.0
// Changed...........: 2015-05-06
// ------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.Controller
{
    interface IListor<T>
    {
        void Add(T item);
        void Remove(T item);
        T Get(int index);
        int Count();
        T Find(string strFind);
        int NextID();
    }
}
