using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    class DistributorWithoutSubdistributors: AbstractDistributor
    {
        public DistributorWithoutSubdistributors(int SalesCount)
        {
            this.SalesCount = SalesCount;
        }

        public override float GetProfit()
        {
            return this.SalesCount * this.ProfitPerSale;
        }
    }
}
