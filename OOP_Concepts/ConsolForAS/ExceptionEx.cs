using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolForAS
{
    
    class ExceptionEx
    {
        static void Division()
        {
            try
            {
                int a = 20;
                int b = 5;
                int c = a / b;
                Console.WriteLine(c);
                try
                {
                    int[] arr = new int[3];
                    arr[3] = 10;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Final block");
            }
        }
        public static void Main(string[] args)
        {
            ExceptionEx.Division();
        }
    }
}
