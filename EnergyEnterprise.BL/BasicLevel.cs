using System.Linq;

namespace EnergyEnterprise.BL
{
    public class BasicLevel : IBasicLevel
    {
        private readonly Customer[] arrayCustomers;
        public BasicLevel(Customer[] arrayCustomers)
        {
            this.arrayCustomers = arrayCustomers;
        }
        public Customer[] SortByTotalCost()
        {
            return arrayCustomers.OrderBy(x => x.GetTotalCostEnergyValue()).ToArray();
        }

        public Customer[] SortByTypeCustomer()
        {
            return arrayCustomers.OrderBy(x => x.GetType() == typeof(BenefitCustomer2))
                                  .ThenBy(x => x.GetType() == typeof(BenefitCustomer1))
                                  .ThenBy(x => x.GetType() == typeof(LimitedCustomer))
                                  .ThenBy(x => x.GetType() == typeof(RegularCustomer))
                                  .ToArray();
        }

        public Customer[] SortDescByEnergyConsumed()
        {
            return arrayCustomers.OrderByDescending(x => x.GetEnergyConsumed()).ToArray();
        }

        public double TotalBenefitsCots()
        {
            return arrayCustomers.Select(x => x.GetEnergyConsumed() * x.GetCurrentCostEnergy()).Sum() - TotalCostFromAllCustomers();
        }

        public double TotalCostFromAllCustomers()
        {
            return arrayCustomers.Select(x => x.GetTotalCostEnergyValue()).Sum();
        }
    }
}
