using System;

namespace CollectionHierarchy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AddCollection addCollevtion = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            var input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                Console.Write($"{addCollevtion.Add(item)} ");
            }
            Console.WriteLine();

            foreach (var item in input)
            {
                Console.Write($"{addRemoveCollection.Add(item)} ");
            }
            Console.WriteLine();

            foreach (var item in input)
            {
                Console.Write($"{myList.Add(item)} ");
            }
            Console.WriteLine();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{addRemoveCollection.Remove()} ");
            }
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{myList.Remove()} ");
            }
            Console.WriteLine();
        }
    }
}
