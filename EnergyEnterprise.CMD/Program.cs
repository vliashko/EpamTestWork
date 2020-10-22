using EnergyEnterprise.BL;
using System;

namespace EnergyEnterprise.CMD
{
    class Program
    {
        static void Main()
        {
            Customer[] arrayCustomers =
            {
                new RegularCustomer(150),
                new RegularCustomer(50),
                new RegularCustomer(210),
                new BenefitCustomer1(60),
                new BenefitCustomer1(10),
                new BenefitCustomer2(160),
                new LimitedCustomer(250),
                new BenefitCustomer1(60),
                new BenefitCustomer2(310),
                new LimitedCustomer(180),
                new LimitedCustomer(120),
                new BenefitCustomer2(70)
            };

            BasicLevel basicLevel = new BasicLevel(arrayCustomers);

            arrayCustomers = basicLevel.SortDescByEnergyConsumed();
            foreach (Customer element in arrayCustomers)
            {
                Console.WriteLine(element.GetEnergyConsumed());
            }
            Console.WriteLine();

            arrayCustomers = basicLevel.SortByTotalCost();
            foreach (Customer element in arrayCustomers)
            {
                Console.WriteLine(element.GetTotalCostEnergyValue());
            }
            Console.WriteLine();

            arrayCustomers = basicLevel.SortByTypeCustomer();
            foreach (Customer element in arrayCustomers)
            {
                Console.WriteLine(element.GetType());
            }
            Console.WriteLine();

            Console.WriteLine(basicLevel.TotalCostFromAllCustomers());
            Console.WriteLine();

            Console.WriteLine(basicLevel.TotalBenefitsCots());
        }
    }
}
