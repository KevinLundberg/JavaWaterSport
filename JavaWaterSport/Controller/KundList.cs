﻿//-------------------------------------------------------------------------------------
// File name...................: KundList.cs
// Purpose.....................: Att samla och hämta information
//                               i en lista om kunden.
//                            
// Programmer..................: Marcus Östmo   
// Date........................: 2014-12-03
// Version.....................:
// Changed.....................: 2015-03-30
//--------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaWaterSport.Service;
using JavaWaterSport.DAL;
using System.IO;
using JavaWaterSportSystem;

namespace JavaWaterSport.Controller
{
    class KundList : IListor<Kund>, IService 
    {
        private List<Kund> k_kundList;

        public event EventHandler Updated;

        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public KundList()
        {
            k_kundList = new List<Kund>();
            try
            {
                if (File.Exists("KundLista.DAT"))
                {
                    k_kundList = BinarySerialization<List<Kund>>.BinaryDeSerialize("KundLista.DAT");
                }
            }
            catch (Exception ex)
            {

                throw new CustomException(ex.Message);
            }
        }

		public void Add(Kund item)
		{
            item.ID = NextID();
            k_kundList.Add(item);
            OnUpdated();
		}

		public void Remove(Kund item)
		{
            k_kundList.Remove(item);
            OnUpdated();
		}

		public Kund Get(int index)
		{
            return k_kundList.ElementAt(index);
		}

		public int Count()
		{
            return k_kundList.Count();
		}

		public Kund Find(string strFind)
		{

            var me = (from kund in k_kundList where kund.ID.ToString() == strFind select kund).First();
            return me;
		}



        public int NextID()
        {
            return k_kundList.Count() + 1;
        }

        /// <summary>
        /// BinarySerialize is a method in the MemberList class that 
        /// Serialize (save object from the program into files) using 
        /// binary serialization.
        /// </summary>
        /// <returns>true or cast an exception</returns>
        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Kund>>.FileName = "KundLista.DAT";
                BinarySerialization<List<Kund>>.BinarySerialize(k_kundList);
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }

            return true;
        }

        public void SaveToDBA()
        {
            DataAccessLayerDBA dba = new DataAccessLayerDBA();
            dba.SaveKunderToDatabase();
        }
    }
}
