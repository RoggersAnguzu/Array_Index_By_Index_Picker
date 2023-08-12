using System;
namespace Program
{
    public class Array_Searcher
    {
        static void Main(string[]args)
        {
            int selection = 0;
            try
            {
                Console.WriteLine("Enter the Number range to Select option from: ");
                selection = int.Parse(Console.ReadLine());
            }
            catch (FormatException) { Console.WriteLine("Please Avail the right format!"); }

            int [] Box=new int[selection];

            for(int i = 0; i < selection; i++)
            {
                Console.WriteLine($"Enter the number {i+1}: ");
                int x =int.Parse(Console.ReadLine());

                Box[i] = x;              
            }
            Console.WriteLine("These are the numbers that add up to 12: ");
            bool pairDiscovered = false;

            for (int i = 0; i < selection; i++)
            {
                for(int j=i+1;j<selection;j++)
                {
                    if (Box[i] + Box[j]==12)
                    {
                        Console.WriteLine($"index {i} number ({Box[i]})+ index{j} number {Box[j]}");
                        pairDiscovered= true;
                    }
                }
            }
            if(!pairDiscovered)
            {
                Console.WriteLine("There is no pair that can add up to 12");
            }
        }
    }
}