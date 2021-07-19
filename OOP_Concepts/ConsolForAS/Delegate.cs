using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    public delegate void CalDel(int no1, int no2);//delegate declaration
    public class example
    {
        public void add(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
    class Delegate
    {
        //static void Main(string[] args)
        //{
        //    example e = new example();
        //    CalDel cd = new CalDel(e.add);//delegate instatiation
        //    CalDel cd1 = e.sub;
        //    CalDel cd2 = new CalDel(e.mul);
        //    CalDel cd3 = e.div;
        //    CalDel cd4=cd+cd1+cd2+cd3;
            
        //    cd4.Invoke(10, 10);
        //    Console.WriteLine(cd4);

        //}
    }
}
