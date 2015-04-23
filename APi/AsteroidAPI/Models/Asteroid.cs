using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace AsteroidAPI
{
    public class Asteroid
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float FurthestPoint { get; set; }
        public float NearestPoint { get; set; }
        public string ClosestDate { get; set; }
        public float Speed { get; set; }
        public float ClosestEarth{get; set;}
        public float Inclination { get; set; }
        public string DateOfPosition { get; set; }
        public bool Hazard { get; set; }
        public string Designation { get; set; }
        public float OrbitDegrees { get; set; }
        public Asteroid()
        {

        }

        public Asteroid(int ID)
        {

        }


        //Unused function
        public static Asteroid[] GetAsteroidsHazard()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"select *
                                 from asteroids where (pha =1 and earth_moid is not null AND earth_moid < 0.004) OR (NAME is not null AND Pha=1 AND earth_moid is not null)
                                 order by name DESC, earth_moid desc";
                SqlCommand CMD = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                Asteroid[] AsteroidsList = new Asteroid[table.Rows.Count];
                foreach (DataRow row in table.Rows)
                {
                    Asteroid ast = new Asteroid();
                    ast.ID = int.Parse(row["ID"].ToString());
                    ast.Name = row["packed_designation"].ToString();                    
                    ast.FurthestPoint = int.Parse(row["aphelion_distance"].ToString());
                    ast.NearestPoint = int.Parse(row["perihelion_distance"].ToString());
                    ast.Speed = int.Parse(row["period"].ToString());
                    ast.ClosestDate = row["perihelion_date"].ToString();
                    ast.ClosestEarth = float.Parse(row["earth_moid"].ToString());
                    ast.Hazard = Convert.ToBoolean(row["pha"]);
                    ast.Inclination = float.Parse(row["inclination"].ToString());
                    AsteroidsList[table.Rows.IndexOf(row)] = ast;
                }
                return AsteroidsList;
            }

        }



        //We use this function to call asteroids from our database
        public static Asteroid[] GetAsteroids()
        {

            //Opens connection and selects the asteroids that we decided would be the most important to show information for in the beginning stages of the project
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"select *
                                 from asteroids where (pha =1 and earth_moid is not null AND earth_moid < 0.004) OR (NAME is not null AND Pha=1 AND earth_moid is not null)
                                 order by name DESC, earth_moid desc";
                SqlCommand CMD = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                Asteroid[] AsteroidsList = new Asteroid[table.Rows.Count];
               foreach(DataRow row in table.Rows)
               {
                    Asteroid ast = new Asteroid();
                    ast.ID = int.Parse(row["ID"].ToString());
                    ast.Name = row["Name"].ToString();
                    ast.Designation = row["packed_designation"].ToString();    
                    ast.FurthestPoint = float.Parse(row["aphelion_distance"].ToString());
                    ast.NearestPoint = float.Parse(row["perihelion_distance"].ToString());
                    ast.Speed = float.Parse(row["period"].ToString());
                    ast.ClosestDate = row["perihelion_date"].ToString();                    
                    ast.Hazard = Convert.ToBoolean(row["pha"]);
                    ast.Inclination = float.Parse(row["inclination"].ToString());
                    ast.ClosestEarth = float.Parse(row["earth_moid"].ToString());
                    ast.OrbitDegrees = float.Parse(row["argument_of_perihelion"].ToString());
                    AsteroidsList[table.Rows.IndexOf(row)] = ast;

               }
               return AsteroidsList;                
            }            
        }


    }
}