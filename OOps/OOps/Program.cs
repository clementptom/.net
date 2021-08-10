using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    class Data
    {
        public void Sravan()
        {
            Console.WriteLine("Hi i am Sravan");
        }
        internal void Shivam()
        {
            Console.WriteLine("Hi i am Shivam...");
        
        }
        private void Lokesh()
        {
            Console.WriteLine("Hi i am Lokesh");
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data obj = new Data();
            obj.Sravan();
            obj.Shivam();

        }
    }
}
