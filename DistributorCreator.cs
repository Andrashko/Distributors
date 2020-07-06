using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    class DistributorCreator
    {
        public static AbstractDistributor CreateDisributor()
        {
            try
            {
                Console.WriteLine("Please enter sale count");
                int SaleCont = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Does disributor have subdistriburo? y/n");
                string HasSubdistributor = Console.ReadLine();
                switch (HasSubdistributor)
                {
                    case "n":
                        return new DistributorWithoutSubdistributors(SaleCont);
                        break;
                    case "y":
                        Console.WriteLine("Please enter subdistributor count");
                        int SubdistributorCont = Convert.ToInt32(Console.ReadLine());
                        DistributorWithSubdidtributors result = new DistributorWithSubdidtributors(SaleCont);

                        for (int i = 0; i < SubdistributorCont; i++)
                            result.AddSubdistributor(CreateDisributor());
                        return result;
                        break;
                    default:
                        throw new Exception("Wrong input");
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
