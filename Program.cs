using System;

namespace Example1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            AbstractDistributor dist = DistributorCreator.CreateDisributor();
            Console.WriteLine(String.Format("Total profit: {0}", dist.GetProfit()));
            Console.ReadLine();
        }
    }
}
