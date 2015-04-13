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
            sqlList.Add("CREATE TABLE [dbo].[Kund] ([Id] INT NOT NULL, [PersonligID] VARCHAR (50) NULL, [Namn] VARCHAR (50) NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");

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
                sqlString = "insert into dbo.kund(ID, PersonligID, Namn) values(" + kunder.Get(i).ID + ",'" + kunder.Get(i).PersonligID + "','" + kunder.Get(i).Namn + "'," + ");";
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
