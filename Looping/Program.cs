using System;

namespace Looping
{
    class Program
    {
        public void IfExample()
        {
            int i = 5;
            int j = 10;
            if (i == j)
            {
                Console.WriteLine("Hi");
            }    
        }
        public void IfelseExample()
        {
            Console.WriteLine("Output of if Else");
            int i = 5;
            int j = 10;
            if (i == j)
            {
                Console.WriteLine("Hi");
            }
            else
            {
                Console.WriteLine("Bye");
            }
        }
        public void IfelseLadder()
        {
            int i = 15;
            Console.WriteLine("Output of Else if Ladder");
            if (i == 10)
                Console.WriteLine("i is 10");
            else if (i == 15)
                Console.WriteLine("i is 15");
            else if (i == 20)
                Console.WriteLine("i is 20");
            else
                Console.WriteLine("i is not present");
        }

        public void NestedIf()
        {
            Console.WriteLine("Output of Nested If");
            int i = 10;
            if (i == 10)
            {
                if (i < 12)
                    Console.WriteLine("i is smaller than 12 ");
                else
                    Console.WriteLine("i is greater than 15");
            }
        }
        public void WhileLoop()
        {
            Console.WriteLine("Output of While loop");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void DoWhile()
        {
            int i = 0;
            Console.WriteLine("Output of do while");
            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

            } while (i < 5);
        }
        public void ForLoop()
        {
            Console.WriteLine("Output of for Loop");
            for(int i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine("i= {0}", i);
            }

        }
        public void ForEach()
        {
            Console.WriteLine("Output of foreach");
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the Choice");
            //string val = Console.ReadLine();
            //int choice= Convert.ToInt32(val);
            // Console.WriteLine("Your choice is", +choice);
            int choice = 2;
            switch (choice)
            {
                case 1: p.IfExample();
                    break;
                case 2: p.IfelseExample();
                    goto case 3;
                case 3:p.ForLoop();
                    break;
                default: Console.WriteLine("Not Match");
                    break;
            }
            
           p.IfelseLadder();
           p.NestedIf();
           
           p.DoWhile();
           p.ForEach();
           p.WhileLoop();
        }
    }
}
