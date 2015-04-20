﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaWaterSport.Service;
using JavaWaterSport.DAL;
using System.IO;
using JavaWaterSport.Model;

namespace JavaWaterSport.Controller
{
    class BokningsList : IListor<Dykarkurs_boka>, IService
    {
        private List<Dykarkurs_boka> b_bokningsList;

        public event EventHandler Updated;

        protected void OnUpdated()
        {
            if (Updated != null)
                Updated(this, EventArgs.Empty);
        }

        public BokningsList()
        {
            b_bokningsList = new List<Dykarkurs_boka>();
            try
            {
                if (File.Exists("BokingsLista.DAT"))
                {
                    b_bokningsList = BinarySerialization<List<Dykarkurs_boka>>.BinaryDeSerialize("BokingsLista.DAT");
                }
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }
        }

        public void Add(Dykarkurs_boka item)
        {
            item.id = this.NextID();
            b_bokningsList.Add(item);
            OnUpdated();
        }

        public void Remove(Dykarkurs_boka item)
        {
            b_bokningsList.Remove(item);
            OnUpdated();
        }

        public Dykarkurs_boka Get(int index)
        {
            return b_bokningsList.ElementAt(index);
        }

        public int Count()
        {
            return b_bokningsList.Count();
        }

        public Dykarkurs_boka Find(string strFind)
        {

            var me = (from dykarkurs_boka in b_bokningsList where dykarkurs_boka.id.ToString() == strFind select dykarkurs_boka).First();
            return me;
        }

        public int NextID()
        {
            return b_bokningsList.Count() + 1;
        }

        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Dykarkurs_boka>>.FileName = "BokingsLista.DAT";
                BinarySerialization<List<Dykarkurs_boka>>.BinarySerialize(b_bokningsList);
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }

            return true;
        }


       
    }
}
