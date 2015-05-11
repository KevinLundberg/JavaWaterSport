using JavaWaterSport.Controller;
using JavaWaterSportSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaWaterSport.DAL
{
    class DataAccessLayerDBA
    {

        private SqlConnection msqlConnection;
        private SqlDataAdapter mKunderAdapter;
        private DataSet mDataSet;
        private String mConnectionString;

        public DataAccessLayerDBA()
        {
            mConnectionString = @"Data Source=RUBAND-SQLSERVE\RUBIRAMSSQLSERVE; Initial Catalog=JwatterSports; User ID=JSports;Password=JSports";

            msqlConnection = new SqlConnection(mConnectionString);

            msqlConnection.Open();

            CreateIfNotExists();

            msqlConnection.Close();
        }
        
        private void CreateIfNotExists()
        {
            List<string> sqlList = new List<string>();

            sqlList.Add("USE JwatterSports");
            sqlList.Add("DROP TABLE [dbo].[Kund];");
            sqlList.Add("DROP TABLE [dbo].[Dykarkurs];");
            sqlList.Add("DROP TABLE [dbo].[Dykarkurs_boka];");
            sqlList.Add("CREATE TABLE [dbo].[Kund] ([Id] INT NOT NULL, [PersonligID] VARCHAR (50) NULL, [Namn] VARCHAR (50) NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");            
            sqlList.Add("CREATE TABLE [dbo].[Dykarkurs] ([Id] INT NOT NULL, [Tid] VARCHAR (50) NULL, [Dykinstruktör] VARCHAR (50) NULL, [Datum] VARCHAR (50) NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[Dykarkurs_boka] ([Id] INT NOT NULL, [KundID]  VARCHAR (50) NULL, [KursID]  VARCHAR (50) NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");   

            SqlCommand cmd;
            foreach (var sql in sqlList)
            {
                try
                {
                    cmd = new SqlCommand(sql, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void SaveKunderToDatabase()
        {
            msqlConnection.Open();
            string sqlString;
            List<string> sqlList = new List<string>();
            KundList kunder = ServiceProvider.GetKundService();
            SqlCommand cmd;
            sqlString = "delete from dbo.kund;";
            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            for (int i = 0; i < kunder.Count(); i++)
            {
                sqlString = "insert into dbo.kund(ID, PersonligID, Namn) values(" + kunder.Get(i).ID + ",'" + kunder.Get(i).PersonligID + "','" + kunder.Get(i).Namn + "');";
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }

            msqlConnection.Close();
        }

        public void SaveDykarkurserToDatabase()
        {
            msqlConnection.Open();
            string sqlString;
            List<string> sqlList = new List<string>();
            DykarkursList dykkurs = ServiceProvider.GetDykarkursService();
            SqlCommand cmd;
            sqlString = "delete from dbo.dykarkurs;";
            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            for (int i = 0; i < dykkurs.Count(); i++)
            {
                sqlString = "insert into dbo.dykarkurs(ID, Tid, Dykinstruktör, Datum) values(" + dykkurs.Get(i).ID + ",'" + dykkurs.Get(i).getTid() + "','" + dykkurs.Get(i).getDykinstruktör() + "','" + dykkurs.Get(i).getDatum() + "');";
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }

            msqlConnection.Close();
        }

        public void SaveBokningToDatabase()
        {
            msqlConnection.Open();
            string sqlString;
            List<string> sqlList = new List<string>();
            BokningsList bokningar = ServiceProvider.GetBokningsService();
            SqlCommand cmd;
            sqlString = "delete from dbo.dykarkurs_boka;";
            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            for (int i = 0; i < bokningar.Count(); i++)
            {
                sqlString = "insert into dbo.dykarkurs_boka(ID, KundID, KursID) values(" + bokningar.Get(i).ID + ",'" + bokningar.Get(i).KundID + "','" + bokningar.Get(i).KursID + "');";
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }

            msqlConnection.Close();
        }
    }
}
