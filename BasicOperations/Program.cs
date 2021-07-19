using System;

namespace BasicOperations
{
    class Program
    {
        public void Implicit()
        {
            Console.WriteLine("implicit type Casting");
            int myint = 9;
            float myfloat = myint;
            Console.WriteLine(myint);
            Console.WriteLine(myfloat);
        }
        public void Explicit()
        {
            Console.WriteLine("explicit type Casting");
            double mydouble = 9.70;
            int myint = (int)mydouble;
            Console.WriteLine(mydouble);
            Console.WriteLine(myint);
        }
        public void TCUsingMethod()
        {
            Console.WriteLine("Type Casting using Method");
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine("convert int to string:{0}", Convert.ToString(myInt));    // convert int to string
            Console.WriteLine("convert int to double:{0}", Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine("convert double to int:{0}", Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine("convert bool to string:{0}", Convert.ToString(myBool));   // convert bool to string

        }
        public void Boxing()
        {
            int num = 1000;
            // boxing
            object obj = num;
            Console.WriteLine("Num:" + num);
            Console.WriteLine("Obj" + obj);
        }

        public void Unboxing()
        {
            // assigned int value
            // 20 to num
            int num1 = 20;

            // boxing
            object obj1 = num1;

            // unboxing
            int i = (int)obj1;

            // Display result
            Console.WriteLine("Value of obj1 object is : " + obj1);
            Console.WriteLine("Value of i is : " + i);
        }
        public void Arithmetic()
        {
            int result;
            int x = 20, y = 5;
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);

            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);

            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);

            result = (x / y);
            Console.WriteLine("Division Operator: " + result);

            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
        }
        public void Relational()
        {
            bool result;
            int x = 10, y = 5;
            result = (x == y);
            Console.WriteLine("Equal to Operator: " + result);

            result = (x > y);
            Console.WriteLine("Greater than Operator: " + result);

            result = (x < y);
            Console.WriteLine("Less than Operator: " + result);

            result = (x >= y);
            Console.WriteLine("Greater than or Equal to: " + result);

            result = (x <= y);
            Console.WriteLine("Lesser than or Equal to: " + result);

            result = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result);
        }
        public void Logical()
        {
            bool a = true, b = false, result;
            result = a && b;
            Console.WriteLine("AND Operator: " + result);
            result = a || b;
            Console.WriteLine("OR Operator: " + result);
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
        }
        public void Conditional()
        {
            int x = 5, y = 10, result;
            result = x > y ? x : y;
            Console.WriteLine("Result: " + result);
        }
        public void UnaryOp()
        {
            int a = 10, res;

            // post-increment example:
            res = a++;
            Console.WriteLine("a is {0} and res is {1}", a, res);

            // post-decrement example:
            res = a--;
            Console.WriteLine("a is {0} and res is {1}", a, res);

            // pre-increment example:
            res = ++a;
            Console.WriteLine("a is {0} and res is {1}", a, res);

            // pre-decrement example:
            res = --a;
            Console.WriteLine("a is {0} and res is {1}", a, res);

        }
        public void Bitwise()
        {
            int x = 5, y = 10, result;

            result = x & y;
            Console.WriteLine("Bitwise AND: " + result);

            result = x | y;
            Console.WriteLine("Bitwise OR: " + result);

            result = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result);

            result = ~x;
            Console.WriteLine("Bitwise Complement: " + result);
        }
        public void Assignment()
        {
            int x = 15;

            // it means x = x + 10
            x += 10;
            Console.WriteLine("Add Assignment Operator: " + x);

            // initalize variable x again
            x = 20;

            // it means x = x - 5
            x -= 5;
            Console.WriteLine("Subtract Assignment Operator: " + x);

            // initalize variable x again
            x = 15;

            // it means x = x * 5
            x *= 5;
            Console.WriteLine("Multiply Assignment Operator: " + x);

            // initalize variable x again
            x = 25;

            // it means x = x / 5
            x /= 5;
            Console.WriteLine("Division Assignment Operator: " + x);

            // initalize variable x again
            x = 25;

            // it means x = x % 5
            x %= 5;
            Console.WriteLine("Modulo Assignment Operator: " + x);


        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Implicit();
            p.Explicit();
            p.TCUsingMethod();
            p.Boxing();
            p.Unboxing();
            p.Arithmetic();
            p.Relational();
            p.Logical();
            p.Conditional();
            p.UnaryOp();
            p.Bitwise();
            p.Assignment();
        }
    }
}
