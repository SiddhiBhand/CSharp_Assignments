using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    interface Interface
    {

    }
    interface Interface1
    {
        public void Simple()
        {

        }
    }
    interface Interface2
    {

    }
    interface Interface3:Interface1,Interface2
    {

    }
    public class test: Interface1,Interface2,Interface3
    {
        void Show()
        {
            Console.WriteLine("Hii");
        }
    }
    public abstract class TestExample: test,Interface1,Interface2
    {

    }
    class Example
    {
        //public static void Main()
        //{
        //    test t = new test();
        //    t.Show();
        //}
    }
}
