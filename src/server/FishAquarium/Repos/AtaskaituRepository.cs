﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using Zuvytes.ViewModels;

namespace Zuvytes.Repos
{
    public class AtaskaituRepository
    {
        public List<PaslauguAtaskaitaViewModel> getUzsakytosPaslaugos(DateTime ?nuo, DateTime ?iki)
        {
            List<PaslauguAtaskaitaViewModel> paslaugos = new List<PaslauguAtaskaitaViewModel>();
            string conn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            string sqlquery = @"select a.id, a.pavadinimas, sum(b.kiekis) as kiekis, sum(b.kiekis*b.kaina) as suma from "+Globals.dbPrefix+"paslaugos a, "+Globals.dbPrefix+"uzsakytos_paslaugos b, "+Globals.dbPrefix+@"sutartys c
	                            where a.id=b.fk_paslauga and b.fk_sutartis=c.nr 
                                and c.sutarties_data>=IFNULL(?nuo, c.sutarties_data) and c.sutarties_data <= IFNULL(?iki, c.sutarties_data)
                                group by a.id, a.pavadinimas order by suma desc";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
            mySqlCommand.Parameters.Add("?nuo", MySqlDbType.DateTime).Value = nuo;
            mySqlCommand.Parameters.Add("?iki", MySqlDbType.DateTime).Value = iki;
            mySqlConnection.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter(mySqlCommand);
            DataTable dt = new DataTable();
            mda.Fill(dt);
            mySqlConnection.Close();

            foreach (DataRow item in dt.Rows)
            {
                paslaugos.Add(new PaslauguAtaskaitaViewModel
                {
                    id = Convert.ToInt32(item["id"]),
                    pavadinimas = Convert.ToString(item["pavadinimas"]),
                    kiekis = Convert.ToInt32(item["kiekis"]),
                    suma = Convert.ToDecimal(item["suma"])
                });
            }
            return paslaugos;
        }

        public PslgAtaskaitaViewModel getBedraSumaUzsakytuPaslaugu(DateTime? nuo, DateTime? iki)
        {
            PslgAtaskaitaViewModel viso = new PslgAtaskaitaViewModel();
            string conn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            string sqlquery = @"select sum(b.kiekis) as kiekis, sum(b.kiekis*b.kaina) as suma from "+Globals.dbPrefix+"paslaugos a, "+Globals.dbPrefix+"uzsakytos_paslaugos b, "+Globals.dbPrefix+@"sutartys c
	                            where a.id=b.fk_paslauga and b.fk_sutartis=c.nr 
                                and c.sutarties_data>=IFNULL(?nuo, c.sutarties_data) and c.sutarties_data <= IFNULL(?iki, c.sutarties_data)";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
            mySqlCommand.Parameters.Add("?nuo", MySqlDbType.DateTime).Value = nuo;
            mySqlCommand.Parameters.Add("?iki", MySqlDbType.DateTime).Value = iki;
            mySqlConnection.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter(mySqlCommand);
            DataTable dt = new DataTable();
            mda.Fill(dt);
            mySqlConnection.Close();

            foreach (DataRow item in dt.Rows)
            {
                viso.visoUzsakyta = Convert.ToInt32(item["kiekis"] == System.DBNull.Value ? 0 : item["kiekis"]);
                viso.bendraSuma = Convert.ToDecimal(item["suma"] == System.DBNull.Value ? 0 : item["suma"]);
            }

            return viso;
        }

        public List<SAtaskaitaViewModel> getAtaskaitaSutartciu(DateTime? nuo, DateTime? iki)
        {
            List<SAtaskaitaViewModel> sutartys = new List<SAtaskaitaViewModel>();
            string conn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            string sqlquery = @"select a.nr, a.sutarties_data, k.vardas, k.pavarde, k.asmens_kodas, a.kaina, IFNULL(sum(ps.kaina*ps.kiekis), 0) paslaugu_kaina,
                                t.bendra_suma, s.bendra_suma bendra_suma_paslaugu from "+Globals.dbPrefix+@"sutartys a
	                                                inner join "+Globals.dbPrefix+@"klientai k on k.asmens_kodas=a.fk_klientas
                                                    left join "+Globals.dbPrefix+@"uzsakytos_paslaugos ps on ps.fk_sutartis=a.nr
                                                    left join (select x.asmens_kodas, sum(z.kaina) as bendra_suma from "+Globals.dbPrefix+@"sutartys z, "+Globals.dbPrefix+@"klientai x where x.asmens_kodas=z.fk_klientas
                                                               and z.sutarties_data>=IFNULL(?nuo, z.sutarties_data) and z.sutarties_data<=IFNULL(?iki, z.sutarties_data)
                                                               group by x.asmens_kodas) as t on t.asmens_kodas = k.asmens_kodas
                                                    left join (select kk.asmens_kodas, IFNULL(sum(uzs.kiekis*uzs.kaina), 0) as bendra_suma from "+Globals.dbPrefix+@"sutartys aa
              	                                                inner join "+Globals.dbPrefix+@"klientai kk on kk.asmens_kodas=aa.fk_klientas
                                                                left join "+Globals.dbPrefix+@"uzsakytos_paslaugos uzs on uzs.fk_sutartis=aa.nr 
                                                               where aa.sutarties_data>=IFNULL(?nuo, aa.sutarties_data) and aa.sutarties_data<=IFNULL(?iki, aa.sutarties_data)
                                                               group by kk.asmens_kodas) as s on s.asmens_kodas = k.asmens_kodas
                                                    where a.sutarties_data>=IFNULL(?nuo, a.sutarties_data) and a.sutarties_data<=IFNULL(?iki, a.sutarties_data)
                                                    group by a.nr, k.pavarde
                                                    order by k.pavarde ASC";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
            mySqlCommand.Parameters.Add("?nuo", MySqlDbType.DateTime).Value = nuo;
            mySqlCommand.Parameters.Add("?iki", MySqlDbType.DateTime).Value = iki;
            mySqlConnection.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter(mySqlCommand);
            DataTable dt = new DataTable();
            mda.Fill(dt);
            mySqlConnection.Close();

            foreach (DataRow item in dt.Rows)
            {
                sutartys.Add(new SAtaskaitaViewModel
                {
                    nr = Convert.ToInt32(item["nr"]),
                    sutartiesData = Convert.ToDateTime(item["sutarties_data"]),
                    asmensKodas = Convert.ToString(item["asmens_kodas"]),
                    vardas = Convert.ToString(item["vardas"]),
                    pavarde = Convert.ToString(item["pavarde"]),
                    kaina = Convert.ToDecimal(item["kaina"]),
                    paslauguKaina = Convert.ToDecimal(item["paslaugu_kaina"]),
                    bendraSuma = Convert.ToDecimal(item["bendra_suma"]),
                    bendraSumaPaslaug = Convert.ToDecimal(item["bendra_suma_paslaugu"])
                });
            }
            return sutartys;
        }

        public List<VeluojanciosSutartysViewModel> getVeluojanciosGrazinti(DateTime? nuo, DateTime? iki)
        {
            List<VeluojanciosSutartysViewModel> sutartys = new List<VeluojanciosSutartysViewModel>();
            string conn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            string sqlquery = @"select a.nr, a.sutarties_data, Concat(b.vardas, ' ',b.pavarde) as klientas, a.planuojama_grazinimo_data_laikas, 
		                            if(IFNULL(a.faktine_grazinimo_data_laikas,'0000-00-00') like '0000%', 'negražinta', a.faktine_grazinimo_data_laikas) as grazinimo_data   
                                    from "+Globals.dbPrefix+"sutartys a, "+Globals.dbPrefix+@"klientai b 
	                            where b.asmens_kodas=a.fk_klientas
                                and (DATEDIFF(a.faktine_grazinimo_data_laikas, a.planuojama_grazinimo_data_laikas)>=1
                                or IFNULL(a.faktine_grazinimo_data_laikas, '0000-00-00') like '0000%' and DATEDIFF(NOW(), a.planuojama_grazinimo_data_laikas)>=1 )
                                and a.sutarties_data>=IFNULL(?nuo, a.sutarties_data) and a.sutarties_data<=IFNULL(?iki, a.sutarties_data)";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlquery, mySqlConnection);
            mySqlCommand.Parameters.Add("?nuo", MySqlDbType.DateTime).Value = nuo;
            mySqlCommand.Parameters.Add("?iki", MySqlDbType.DateTime).Value = iki;
            mySqlConnection.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter(mySqlCommand);
            DataTable dt = new DataTable();
            mda.Fill(dt);
            mySqlConnection.Close();

            foreach (DataRow item in dt.Rows)
            {
                sutartys.Add(new VeluojanciosSutartysViewModel
                {
                    nr = Convert.ToInt32(item["nr"]),
                    sutartiesData = Convert.ToDateTime(item["sutarties_data"]),
                    klientas = Convert.ToString(item["klientas"]),
                    planuojamaGrData = Convert.ToDateTime(item["planuojama_grazinimo_data_laikas"]),
                    faktineGrData = Convert.ToString(item["grazinimo_data"])
                    
                });
            }
            return sutartys;
        }

    }
}