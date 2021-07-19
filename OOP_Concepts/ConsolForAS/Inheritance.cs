using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    class Base  // base class (parent) 
    {
        public string Name = "Siddhi";
        private int i = 20;//not accessible in child
        protected int j = 10;
        public void Print()              
        {
            Console.WriteLine("Public Hii");
        }
        protected void PrintData()
        {
            Console.WriteLine("Protected Hello");
        }
    }

    class Child : Base  // derived class (child)
    {
        Base B1 = new Base();
        public string SirName = "Bhand";
    }

    class Inheritance:Base
    {
        //static void Main(string[] args)
        //{
        //    Inheritance I = new Inheritance();
        //    I.PrintData();
        //    Child C1 = new Child();
        //    C1.Print();
        //    Console.WriteLine(C1.Name + " " + C1.SirName);
        //    Console.WriteLine("Protected Variable"+I.j);
           
        //}
       

    }  
}
