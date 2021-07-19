using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    class Inheritance2
    {
        //static void Main(string[] args)
        //{
        //    Base1 b1 = new Base1();
        //    b1.print();

        //    Base2 b2 = new Base2();
        //    b2.Disp();
        //    b2.print();

        //    Base3 b3 = new Base3();
        //    b3.print();
        //    b3.Show();
        //    b3.Disp();

        //    Base2 b4 = new Base3();
        //    b4.Disp();
        //    b4.print();

        //    Base1 b5 = new Base2();
        //    b5.print();

        //}
    }

        class Base1
        {
            public void print()
            {
                Console.WriteLine("Hii");
            }
         
        }
        class Base2 : Base1
        {
            public void Disp()
            {
                Console.WriteLine("Hello");
            }
           
        }
        class Base3 : Base2
        {
            public void Show()
            {
                Console.WriteLine("Hello world");
            }

        }
    
}
