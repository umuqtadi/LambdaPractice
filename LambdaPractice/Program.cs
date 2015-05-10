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
            foreach (string kayak in kayakProducts)
            {
                Console.WriteLine(kayak);
            }

            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();

            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (string shoe in shoeProducts)
            {
                Console.WriteLine(shoe);
            }

            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.Contains("ball")).ToList();

            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach (string ball in ballProducts)
            {
                Console.WriteLine(ball);
            }

            //sort ballProducts alphabetically and print them to the console.
            foreach (string ball in ballProducts.OrderBy(x=>x))
            {
                Console.WriteLine(ball);
            }

            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine(products.OrderByDescending(x =>x.Length).First());

            //print the product with the shortest name to the console using the .First() extension.
            Console.WriteLine(products.OrderBy(x=>x.Length).First());   

            //print the product with the 3rd shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine(products.OrderBy(x=>x.Length).Skip(2).First());

            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()). 
            Console.WriteLine(ballProducts.OrderByDescending(x=>x.Length).ElementAt(1));

            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            List<string> reversedProducts = products.OrderByDescending(x => x.Length).ToList();

            //print out the reversedProducts to the console using a foreach loop.
            foreach (string reverse in reversedProducts)
            {
                Console.WriteLine(reverse);
            }

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list
            foreach (string what in products.OrderByDescending(x=>x.Length))
            {
                Console.WriteLine(what);
            }


            //FILL IN THE FUNCTIONS BELOW TO MAKE THE TESTS PASS
            Console.ReadKey();
        }

        public static string LongestName(List<string> inputList)
        {
            string first = inputList.OrderByDescending(x => x.Length).First().ToString();
            //with the input list, return the item with the longest name
            return first;
        }

        public static string ShortestName(List<string> inputList)
        {
            string last = inputList.OrderBy(x => x.Length).First();
            //with the input list, return the item with the shortest name
            return last;
        }

        public static string SecondLongestName(List<string> inputList)
        {
            string second = inputList.OrderByDescending(x => x.Length).ElementAt(1);
            //with the input list, return the item with the second longest name
            return second;
        }
        
        public static string ThirdShortestName(List<string> inputList)
        {
            string third = inputList.OrderBy(x => x.Length).ElementAt(2);
            //with the input list, return the item with the third shortest name
            return third;
        }

        public static List<string> BallProducts(List<string> inputList)
        {
            List<string> ballList = inputList.Where(x => x.Contains("ball")).ToList();
            //with the input list, return a list with only the the products that contain the word ball
            return ballList;
        }
        public static List<string> EndInS(List<string> inputList)
        {
            List<string> ending = inputList.Where(x => x.EndsWith("s")).ToList();
            //with the input list, return a list with only the the products that end with the letter s
            return ending;
        }
    }
}