using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;


namespace ConsoleAppAccess.CollectionsEx
{
    class CollectionExample
    {
        public static void PrintValues(IEnumerable x)
        {
            // start with capital I is interface
            IEnumerator z = x.GetEnumerator();
            while (z.MoveNext())
            {
                Console.WriteLine(z.Current);
            }
        }
        public static void ArrayListEx()
        {
            try
            {
                ArrayList arrayList = new ArrayList();

                //implicitly boxking happening
                arrayList.Add(20);
                arrayList.Add("Siddhi");
                arrayList.Add(true);

                //implicitly converting into object
                foreach (object x in arrayList)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("With IEnumrable");
                CollectionExample.PrintValues(arrayList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally block will executed ");
            }

        }
        static void QueueEx()
        {
            try
            {
                Queue myQueue = new Queue();

                // Inserting the elements into the Queue
                myQueue.Enqueue("C#");
                myQueue.Enqueue(10);
                myQueue.Enqueue("Java");

                // Displaying the count of elements
                // contained in the Queue
                Console.Write("Total number of elements present in the Queue are: ");

                Console.WriteLine(myQueue.Count);

                // Displaying the beginning element of Queue
                Console.WriteLine("Beginning Item is: " + myQueue.Peek());
                foreach (object x in myQueue)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("With IEnumrable");
                CollectionExample.PrintValues(myQueue);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally block will executed ");
            }
        }

        static void StringCollectionEx()
        {
            try
            {
                StringCollection sc = new StringCollection();
                sc.Add("String collection");
                sc.Add("example");
                Console.WriteLine(sc.Count);

                foreach (object x in sc)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("With IEnumrable");
                CollectionExample.PrintValues(sc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally block will executed ");
            }
        }
      
        static void StackEx()
        {
            try
            {
                Stack myStack = new Stack();

                // Inserting the elements into the Stack
                myStack.Push("1st Element");
                myStack.Push(10);

                // Displaying the count of elements and stack contained in the Stack before removing all the elements
                Console.Write("Total number of elements in the Stack are : ");
                foreach (object x in myStack)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("With IEnumrable");
                CollectionExample.PrintValues(myStack);

                Console.WriteLine(myStack.Count);

                // Removing all elements from Stack
                myStack.Clear();

                // Displaying the count of elements contained in the Stack after removing all the elements
                Console.Write("Total number of elements in the Stack are : ");

                Console.WriteLine(myStack.Count);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally block will executed ");
            }
        }
        static void BitArrayEx()
        {
            try
            {
               // Creating a BitArray myBitArr
                BitArray myBitArr = new BitArray(3);

                // Initializing all the bits in myBitArr
                myBitArr[0] = false;
                myBitArr[1] = true;
                myBitArr[2] = true;

                // Printing the values in myBitArr
                Console.WriteLine("Initially the bits are as : ");
                foreach (object x in myBitArr)
                {
                    Console.WriteLine(x);
                }
                myBitArr.SetAll(false);

                // Printing the values in myBitArr
                // It should display all the bits as false
                Console.WriteLine("With IEnumrable");
                CollectionExample.PrintValues(myBitArr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally block will executed ");
            }
        }
        static void SortedListEx()
        {
            try
            {
                // Creating a sortedlist Using SortedList class
                SortedList my_slist1 = new SortedList();

                // Adding key/value pairs in SortedList using Add() method
                my_slist1.Add(2, "welcome");
                my_slist1.Add(7, "in");
                my_slist1.Add(4, ".net");
                my_slist1.Add(1, 1);

                foreach (DictionaryEntry pair in my_slist1)
                {
                    Console.WriteLine("{0} and {1}",
                              pair.Key, pair.Value);
                }
              
              //  CollectionExample.PrintValues(my_slist1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally block will executed ");
            }
        }
        static void HashTableEx()
        {
            try
            {
                // Create a hashtable
                // Using Hashtable class
                Hashtable my_hashtable1 = new Hashtable();

                // Adding key/value pair 
                // in the hashtable
                // Using Add() method
                my_hashtable1.Add("A1", "Welcome");
                my_hashtable1.Add("A2", "to");
                my_hashtable1.Add("A3", "GeeksforGeeks");

                Console.WriteLine("Key and Value pairs from my_hashtable1:");

                foreach (DictionaryEntry ele1 in my_hashtable1)
                {
                    Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
                }

                // Create another hashtable Using Hashtable class
                // and adding key/value pairs without using Add method
                Hashtable my_hashtable2 = new Hashtable() {
                                      {1, 250},
                                          {2, 234},
                                        {3, true},
                                         {4, "hi"}};

                Console.WriteLine("Key and Value pairs from my_hashtable2:");

                foreach (var ele2 in my_hashtable2.Keys)
                {
                    Console.WriteLine("{0}and {1}", ele2,
                                    my_hashtable2[ele2]);
                }
                //  CollectionExample.PrintValues(my_slist1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("finally block will executed ");
            }
        }
        //static void Main(string[] d)
        //{
        //    CollectionExample.ArrayListEx();
        //    CollectionExample.QueueEx();
        //    CollectionExample.StringCollectionEx();
        //    CollectionExample.StackEx();
        //    CollectionExample.BitArrayEx();
        //    CollectionExample.SortedListEx();
        //    CollectionExample.HashTableEx();
        //}
        // the below method is Iterationg the values from arrayList Using its Interface


    }
}