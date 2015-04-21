using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak")).ToList();

            //print the kayakProducts to the console using a foreach loop.
            foreach (string kayakThing in kayakProducts)
            {
                Console.WriteLine(kayakThing);
            }

            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();

            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (string shoeStuff in shoeProducts)
            {
                Console.WriteLine(shoeStuff);
            }

            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.Contains("ball")).ToList();

            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach (string ballStuff in ballProducts)
            {
                Console.WriteLine(ballStuff);
            }

            //sort ballProducts alphabetically and print them to the console.
            foreach (string ballStuff in ballProducts.OrderBy(x=> x))
            {
                Console.WriteLine(ballStuff);
            }

            //print the product with the longest name to the console using the .First() extension.
            string longest = products.OrderByDescending(x => x.Length).First();
            Console.WriteLine(longest);

            //print the product with the shortest name to the console using the .First() extension.
            string shortest = products.OrderBy(x => x.Length).First();
            Console.WriteLine(shortest);

            //print the product with the 3rd shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).  
            string thirShort = products.OrderBy(x => x.ToList().Count).ElementAt(2);
            Console.WriteLine(thirShort);

            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()). 
            string secLong = products.OrderByDescending(x => x.ToList().Count).ElementAt(1);
            Console.WriteLine(secLong);

            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            string reversedProducts = products.OrderByDescending(x => x.Length).First();
            Console.WriteLine(reversedProducts);

            //print out the reversedProducts to the console using a foreach loop.
            foreach (char reverSa in reversedProducts)
            {
                Console.WriteLine(reverSa);
            }

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list
            foreach (string theList in products.OrderByDescending(x => x.Length))
            {
                Console.WriteLine(theList);
            }



            //FILL IN THE FUNCTIONS BELOW TO MAKE THE TESTS PASS
            Console.ReadKey();
        }

        public static string LongestName(List<string> inputList)
        {
            string varIn = inputList.OrderByDescending(x => x.Length).First();
            //with the input list, return the item with the longest name
            return varIn;
        }

        public static string ShortestName(List<string> inputList)
        {
            string shorMan = inputList.OrderBy(x => x.Length).First();
            //with the input list, return the item with the shortest name
            return shorMan;
        }

        public static string SecondLongestName(List<string> inputList)
        {
            string twoTone = inputList.OrderByDescending(x => x.ToList().Count).ElementAt(1);
            //with the input list, return the item with the second longest name
            return twoTone;
        }

        public static string ThirdShortestName(List<string> inputList)
        {
            string thirtyGlock = inputList.OrderBy(x => x.ToList().Count).ElementAt(2);
            //with the input list, return the item with the third shortest name
            return thirtyGlock;
        }

        public static List<string> BallProducts(List<string> inputList)
        {
            List<string> itHasIt = inputList.Where(x => x.Contains("ball")).ToList();
            //with the input list, return a list with only the the products that contain the word ball
            return itHasIt;
        }
        public static List<string> EndInS(List<string> inputList)
        {
            List<string> endIt = inputList.Where(x => x.EndsWith("s")).ToList();
            //with the input list, return a list with only the the products that end with the letter s
            return endIt;
        }
    }
}