using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    class StaticCon
    {
        static int a = 10;
        int x = 50;
        static StaticCon()
        {
            a++;
            Console.WriteLine("value of static:" + a);
        }
        public StaticCon(String s)
        {
            Console.WriteLine("Name:" + s);
        }
        //static void Main(string[] args)
        //{
        //    StaticCon obj = new StaticCon("Siddhi");
        //}
    }
}
