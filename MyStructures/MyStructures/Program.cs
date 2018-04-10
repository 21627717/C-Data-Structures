using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Collection defined
            //Collections : structured data types that stores data and provides 
            //operations for adding,removing and reading data from collection
            #endregion

             #region ArrayList 
            //resizeable array that can pull multiple different data types
            ArrayList aList = new ArrayList();
            //collection t=methods that can be performed
            aList.Add("Enzokuhle");
            aList.Add(40);

            //collection properties that defines the collection
            //Console.WriteLine("count : {0}", aList.Count);
            //Console.WriteLine("capacity : {0}", aList.Capacity);

           

            //combining two ArrayLists

            ArrayList aList2 = new ArrayList();
            //adds an wide range of elements to the collection
            aList2.AddRange(new object[] { "A", "B", "c","z","x" });
            //swiping elements between arratlist objects
            aList.AddRange(aList2);
            //removes element at an specified index
            aList2.RemoveAt(0);
            //removes element(s) by specifying the starting index and maximum number of elements to be removed
            aList.RemoveRange(0, 1);

            //Console.WriteLine("whos siting in this index : {0}", aList2.IndexOf(0));
            //sorts the elements of the entire array list
            aList2.Sort();
            //reverses the order of the elemnts in the array
            aList2.Reverse();
            //insert the element at specified index
            aList2.Insert(1, "Turkey");

            //getting a subset of elememts by specifying the starting index and maximum number of elements
            ArrayList range = aList2.GetRange(0, 2);

            //foreach(object o in range)
            //{
            //    Console.WriteLine(o);
            //}

            //foreach (object o in aList)
            //{
            //    Console.WriteLine(o);
            //}

            //foreach (object o in aList2)
            //{
            //    Console.WriteLine(o);
            //}

            //copies the elements of the arraylist to a new array(string array)
            string[] myStringArray = (string[])aList2
                .ToArray(typeof(string));
            //declaring the new instance of string array and initializing it
            string[] customers = { "bob", "sally", "sue" };
            //new arraylist
            ArrayList custArrayList = new ArrayList();
            //from string array to arraylist
            custArrayList.AddRange(customers);

            Console.ReadLine();






            #endregion
            #region Dictionary
            //creates key-value pairs
            Dictionary<string, string> superheroes
                = new Dictionary<string, string>();
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Jason statum", "Transporter");
            superheroes.Add("Tom Cruise", "Jack Reacher");

            superheroes.Remove("Jason statum");
            Console.WriteLine("Jason is here? :{0}", superheroes.ContainsKey("Jason statum"));
            Console.WriteLine("Stronest man alive? :{0}", superheroes.ContainsValue("Superman"));

            superheroes.TryGetValue("Jack Reacher", out string mytest);
            Console.WriteLine($"Mission Impossible Guy :{mytest}");

            Console.ReadLine();


            #endregion


        }



    }
}
