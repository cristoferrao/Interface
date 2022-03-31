using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Photo 
    {
        public static Photo Load(string path)
        {
            Console.WriteLine("Photo to Filter is {0}",path);
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Saving Photo");
        }
    }
}
