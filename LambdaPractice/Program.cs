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
            //using the .where lamda function to check within the list to see if anything contains "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak")).ToList();

            //print the kayakProducts to the console using a foreach loop.

            foreach (string kayakThing in kayakProducts)
            {
                Console.WriteLine(kayakThing);
            }

            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            //using .where to look through the list and then .contains to see if the word "Shoes" is present in any string in the list
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();

            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (string shoeStuff in shoeProducts)
            {
                Console.WriteLine(shoeStuff);
            }

            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            //using .where to search through the list and then .contains to see if anything in the list has "ball" in it
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
            //use order bydescending to sort list from longest to shortest, then use .first to retrieve the first word which is the longest
            string longest = products.OrderByDescending(x => x.Length).First();
            Console.WriteLine(longest);

            //print the product with the shortest name to the console using the .First() extension.
            //orderby to make the list from shortest to longest, then using first to pick out the first string which is the shortest
            string shortest = products.OrderBy(x => x.Length).First();
            Console.WriteLine(shortest);

            //print the product with the 3rd shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            //use .orderby to sort the list from shortest to longest and then .elementat to get the 2nd index, which is actually the 3rd string
            string thirShort = products.OrderBy(x => x.ToList().Count).ElementAt(2);
            Console.WriteLine(thirShort);

            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()). 
            //use .orderbydescending to sort the list from longest to shortest and then .elementat to pull out the index 1, which is the second word
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
            //order by descending puts the list in order from longest to shortest and then I took the first, which is the longest word
            string varIn = inputList.OrderByDescending(x => x.Length).First();
            //with the input list, return the item with the longest name
            return varIn;
        }

        public static string ShortestName(List<string> inputList)
        {
            //order by orders the list from shortest to longest. Then I took the first which it the shortest
            string shorMan = inputList.OrderBy(x => x.Length).First();
            //with the input list, return the item with the shortest name
            return shorMan;
        }

        public static string SecondLongestName(List<string> inputList)
        {
            //orderby descending which orders list from longest to shortest. Then to grab the second longest word, i went to index 1, which is actually the second thing in the list
            string twoTone = inputList.OrderByDescending(x => x.ToList().Count).ElementAt(1);
            //with the input list, return the item with the second longest name
            return twoTone;
        }

        public static string ThirdShortestName(List<string> inputList)
        {
            //orderby orders list from shortest to longest and then to grab the 3rd shortest word I took the second index. Index is always one less that number of things in the list because indexes start with 0
            string thirtyGlock = inputList.OrderBy(x => x.ToList().Count).ElementAt(2);
            //with the input list, return the item with the third shortest name
            return thirtyGlock;
        }

        public static List<string> BallProducts(List<string> inputList)
        {
            //used the .where lambda function to look through the list and see if any words contain ball
            List<string> itHasIt = inputList.Where(x => x.Contains("ball")).ToList();
            //with the input list, return a list with only the the products that contain the word ball
            return itHasIt;
        }
        public static List<string> EndInS(List<string> inputList)
        {
            //using the .where lamdba function to check through the list, then use endswith to see if anything in the list ends with the letter 's'
            List<string> endIt = inputList.Where(x => x.EndsWith("s")).ToList();
            //with the input list, return a list with only the the products that end with the letter s
            return endIt;
        }
    }
}