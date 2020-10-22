namespace EnergyEnterprise.BL
{
    public class LimitedCustomer : Customer
    {
        /// <summary>
        /// Потребители с лимитом.
        /// </summary>
        /// <param name="energyConsumed">Количество потребленной энергии.</param>
        /// <param name="rateCoefficient">Коэффициент тарифа.</param>
        /// <param name="limitCount">Количество энергии до включения коэффициента.</param>
        public LimitedCustomer(double energyConsumed, double rateCoefficient = 1/3f, int limitCount = 150) : base(energyConsumed)
        {
            this.rateCoefficient = rateCoefficient;
            totalCostEnergy = TotalCostRate(energyConsumed, costEnergy, rateCoefficient, limitCount);
        }
        protected override double TotalCostRate(double energyConsumed, double costEnergy, double rateCoefficient, int limitCount)
        {
            return energyConsumed <= limitCount ? costEnergy * energyConsumed :
                costEnergy * limitCount + (rateCoefficient * costEnergy + costEnergy) * (energyConsumed - limitCount);
        }
    }
}
