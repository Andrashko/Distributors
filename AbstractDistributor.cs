using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    abstract  class AbstractDistributor
    {
        public int SalesCount { get; set; }
        protected bool HaveSubdistributos = false;
        protected float ProfitPerSale = 100f;
        protected float ProfitFromSubdistributorsCoefficient = 0.05f;
        public abstract float GetProfit();

    }
}
