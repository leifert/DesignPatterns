using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace Singleton
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> _capitals;
        private static SingletonDatabase _instance;

        private SingletonDatabase()
        {
            Console.WriteLine("Initializing database");

            var batches = File.ReadAllLines("capitals.txt").Batch(2);

            _capitals = batches.ToDictionary(
                list=> list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1)));
        }

        public static SingletonDatabase GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SingletonDatabase();
            }
            return _instance;
        }
        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}
