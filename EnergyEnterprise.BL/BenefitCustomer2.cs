namespace EnergyEnterprise.BL
{
    public class BenefitCustomer2 : Customer
    {
        /// <summary>
        /// Льготники - 2.
        /// </summary>
        /// <param name="energyConsumed">Количество потребленной энергии.</param>
        /// <param name="limitCount">Количество бесплатной энергии.</param>
        public BenefitCustomer2(double energyConsumed, int limitCount = 50) : base(energyConsumed)
        {
            totalCostEnergy = TotalCostRate(energyConsumed, costEnergy, rateCoefficient: 1, limitCount);
        }

        protected override double TotalCostRate(double energyConsumed, double costEnergy, double rateCoefficient, int limitCount)
        {
            return energyConsumed <= 50 ? 0 :
                (energyConsumed - 50) * costEnergy;
        }
    }
}
