using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    class DistributorWithSubdidtributors:AbstractDistributor
    {
        private List<AbstractDistributor> Subdistributors;

        public DistributorWithSubdidtributors(int SalesCount)
        {
            this.SalesCount = SalesCount;
            this.HaveSubdistributos = true;
            this.Subdistributors = new List<AbstractDistributor>();
        }

        public void AddSubdistributor (AbstractDistributor Subdistributor)
        {
            this.Subdistributors.Add(Subdistributor);
        }
        public override float GetProfit()
        {
            float ProfitSubdistributors = 0;
            foreach (AbstractDistributor dist in this.Subdistributors)
                ProfitSubdistributors += dist.GetProfit();
            return this.SalesCount * this.ProfitPerSale + ProfitSubdistributors*this.ProfitFromSubdistributorsCoefficient;
        }
    }
}
