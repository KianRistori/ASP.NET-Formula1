using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP.NET_Formula1
{
    using Models;
    using System.IO;

    public class Formula1Store
    {
        static Formula1Store()
        {
            LoadData();
        }

        public IEnumerable<Engine> Engines => engines;
        public IEnumerable<Team> Teams => teams;
        public IEnumerable<Driver> Drivers => drivers;

        public void SaveChanges()
        {
            StreamWriter sw = new StreamWriter("Data/Motori.txt");
            foreach (var e in engines)
            {
                sw.WriteLine($"{e.EngineId};{e.Name}");
            }
            sw.Close();

            sw = new StreamWriter("Data/Scuderie.txt");
            foreach (var t in teams)
            {
                sw.WriteLine($"{t.TeamId};{t.Name};{t.EngineId}");
            }
            sw.Close();

            sw = new StreamWriter("Data/Piloti.txt");
            foreach (var d in drivers)
            {
                sw.WriteLine($"{d.DriverId};{d.LastName};{d.FirstName};{d.TeamId};{d.Score}");
            }
            sw.Close();
        }


        #region CARICAMENTO DATI

        static void LoadData()
        {
            LoadEngines();
            LoadTeams();
            LoadDrivers();
            LoadNavigationProperties();
        }

        internal static void LoadNavigationProperties()
        {
            foreach (var team in teams)
            {
                team.Engine = engines.Find(e=>e.EngineId == team.EngineId);
            }

            foreach (var driver in drivers)
            {
                driver.Team = teams.Find(t => t.TeamId == driver.TeamId);
            }
        }

        private static void LoadEngines()
        {
            string[] rows = File.ReadAllLines("Data/Motori.txt");
            foreach (var row in rows)
            {
                var fields = row.Split(';');
                engines.Add(new Engine { EngineId = int.Parse(fields[0]), Name = fields[1].Trim() });
            }
        }
        private static void LoadTeams()
        {
            string[] rows = File.ReadAllLines("Data/Scuderie.txt");
            foreach (var row in rows)
            {
                var fields = row.Split(';');
                teams.Add(new Team
                {
                    TeamId = int.Parse(fields[0]),
                    Name = fields[1].Trim(),
                    EngineId = int.Parse(fields[2])
                });
            }
        }
        private static void LoadDrivers()
        {
            string[] rows = File.ReadAllLines("Data/Piloti.txt");
            foreach (var row in rows)
            {
                var fields = row.Split(';');
                drivers.Add(new Driver
                {
                    DriverId = int.Parse(fields[0]),
                    LastName = fields[1].Trim(),
                    FirstName = fields[2].Trim(),
                    TeamId = int.Parse(fields[3]),
                    Score = double.Parse(fields[4]),
                });
            }
        }

        static List<Engine> engines = new List<Engine>();
        static List<Team> teams = new List<Team>();
        static List<Driver> drivers = new List<Driver>();
        #endregion
    }

    public static class Formula1Extension
    {
        public static void Add(this IEnumerable<Engine> items, Engine e)
        {
            List<Engine> engines = items as List<Engine>;
            e.EngineId = engines[engines.Count - 1].EngineId + 1;
            engines.Add(e);
        }

        public static void Add(this IEnumerable<Team> items, Team t)
        {
            List<Team> teams = items as List<Team>;
            t.TeamId = teams[teams.Count - 1].TeamId + 1;
            teams.Add(t);
            Formula1Store.LoadNavigationProperties();
        }

        public static void Add(this IEnumerable<Driver> items, Driver d)
        {
            List<Driver> drivers = items as List<Driver>;
            d.DriverId = drivers[drivers.Count - 1].DriverId + 1;
            drivers.Add(d);
            Formula1Store.LoadNavigationProperties();
        }

        public static Engine Find(this IEnumerable<Engine> engines, int id)
        {
            return engines.First(t => t.EngineId == id);
        }

        public static Team Find(this IEnumerable<Team> teams, int id)
        {
            return teams.First(t => t.TeamId == id);
        }

        public static Driver Find(this IEnumerable<Driver> drivers, int id)
        {
            return drivers.First(t => t.DriverId == id);
        }
    }
}
