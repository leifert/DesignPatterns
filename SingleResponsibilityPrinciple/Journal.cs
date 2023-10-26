using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++count}: {text}");
            return count;
        }
        public void Remove(int index)
        {
            _entries.RemoveAt( index );
        }
        public override string ToString()
        {
            return string.Join( Environment.NewLine, _entries );
        }

        //Porusuje SRP
        //public void Save(string filename)
        //{
        //    File.WriteAllText(filename, ToString());
        //}
        //public static Journal Load(string filename) 
        //{

        //}
        //public void Load(Uri uri)
        //{

        //}
    }
}
