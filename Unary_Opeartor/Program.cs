using System;

namespace Assigmnet_3
{
    class Program
    {
        int x = 20;
        void Print()
        {
            int x = 10;
            Console.WriteLine(x);
        }
        void IfElseLadder()
        {
            int i = 20;

            if (i == 10)
                Console.WriteLine("i is 10");
            else if (i == 15)
                Console.WriteLine("i is 15");
            else if (i == 20)
                Console.WriteLine("i is 20");
            
        }
        public void UnaryOperator()
        {
            int a = 10, res;

            // post-increment example:
            res = a++;
            Console.WriteLine("a is {0} and res is {1}", a, res);//a is 11 and res is 10
            
            // post-decrement example:
            res = a--;
            Console.WriteLine("a is {0} and res is {1}", a, res);//a is 10 and res is 11

            // pre-increment example:
            res = ++a;
            Console.WriteLine("a is {0} and res is {1}", a, res);//a is 11 and res is 11

            // pre-decrement example:
            res = --a;
            Console.WriteLine("a is {0} and res is {1}", a, res);//a is 10 and res is 10


        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();
            Console.WriteLine(p.x);
            p.IfElseLadder();
            p.UnaryOperator();
            int i = 2;
            switch (i)
            {
                case 1:Console.WriteLine("1");
                    break;
                case 2:Console.WriteLine("2");
                    return;
            }
            
        }
    }
}
