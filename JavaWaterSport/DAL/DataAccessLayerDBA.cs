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
        private SqlDataAdapter mMoviesAdapter;
        private DataSet mDataSet;
        private String mConnectionString;

        public DataAccessLayerDBA()
        {
            mConnectionString = @"Data Source=RUBAND-SQLSERVE\RUBIRAMSSQLSERVE; Initial Catalog=JwatterSports; User ID=JSports;Password=JSports";

            msqlConnection = new SqlConnection(mConnectionString);

            msqlConnection.Open();

            CreateIfNotCreateIfNotExists();

            msqlConnection.Close();
        }
        
        private void CreateIfNotCreateIfNotExists()
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

        public void SaveMoviesToDatabase()
        {
            msqlConnection.Open();
            string sqlString;
            List<string> sqlList = new List<string>();
            KundList kunder = ServiceProvider.GetKundService();
            SqlCommand cmd;
            sqlString = "delete from dbo.movies;";
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
                sqlString = "insert into dbo.movies(id,title,genre,directorid,age,path,runtime) values(" +
                            kunder.Get(i).ID + ",'" +
                            kunder.Get(i).PersonligID + "','" +
                            kunder.Get(i).Namn + "'," + ");";
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
