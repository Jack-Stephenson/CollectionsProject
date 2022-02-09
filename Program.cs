using System;
using System.Collections.Generic;

namespace CollectionsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] stringArr = {"Jack", "Mike", "Sam", "Anders"};
            bool[] boolArr = {true, false, true, false, true, false, true, false, true, false};
            List<string> flavors = new List<string>() {"Chocolate", "Vanilla", "Strawberry", "Americone Dream", "Mint"};
            Console.WriteLine("Length of list=" + flavors.Count);
            Console.WriteLine("3rd flavor=" + flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine("Length of list (after removing)=" + flavors.Count);
            Dictionary<string, string> favoriteFlavor = new Dictionary<string, string>();
            for(int i=0;i<stringArr.Length;i++)
            {
                Random random = new Random();
                string flavor = flavors[random.Next(0, flavors.Count)];
                favoriteFlavor.Add(stringArr[i], flavor);
            }
            foreach (var person in favoriteFlavor)
            {
                Console.WriteLine(person.Key + '|' + person.Value);
            }
        }
    }
}
