using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    class Number
    {

        static public int t = 104;
        public static void total()
        {
            Console.WriteLine(t);
            int i = 10;
            Console.WriteLine(i);
        }
     
    }
    sealed class SealedClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Modifire
    {
        //static void Main(string[] args)
        //{ 
        //    Number.total();
        //    SealedClass slc = new SealedClass();
        //    int total = slc.Add(6, 4);
        //    Console.WriteLine(total);
        //}

    }
}
