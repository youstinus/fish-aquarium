using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using FishAquarium.Models2;
using MySql.Data.MySqlClient;

namespace FishAquarium.Repos2
{
    public class DegaluTipasRepository
    {
        public List<DegaluTipas> getDegaluTipai()
        {
            List<DegaluTipas> degaluTipai = new List<DegaluTipas>();

            string conn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            string sqlquery = @"SELECT a.id, a.name FROM "+Globals.dbPrefix+"degalu_tipai a";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
            mySqlConnection.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter(mySqlCommand);
            DataTable dt = new DataTable();
            mda.Fill(dt);
            mySqlConnection.Close();

            foreach (DataRow item in dt.Rows)
            {
                degaluTipai.Add(new DegaluTipas
                {
                    id = Convert.ToInt32(item["id"]),
                    pavadinimas = Convert.ToString(item["name"])
                });
            }

            return degaluTipai;
        }
    }
}