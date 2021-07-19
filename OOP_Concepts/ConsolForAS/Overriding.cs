using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    class Overriding
    {
        //static void Main(string[] args)
        //{
        //    Bank B1 = new Bank();
        //    B1.Method();
        //    Bank B2 = new ICICI();
        //    B2.Method();
        //    ICICI B3 = new ICICI();
        //    B3.Method();
        //    //ICICI B3 = new Bank(); this will show error
        //}
    }
    class Bank
    {
        public virtual float Method()
        {
            float ir = 4.5F;
            Console.WriteLine(ir);
            return ir;
        }
    }

    class ICICI: Bank
    {
        public override float Method()
        {
            float ir = 4.9F;
            Console.WriteLine(ir);
            return ir;
        }
    }
}
