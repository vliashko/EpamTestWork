namespace EnergyEnterprise.BL
{
    public class BenefitCustomer1 : Customer
    {
        /// <summary>
        /// Льготники - 1.
        /// </summary>
        /// <param name="energyConsumed">Количество потребленной энергии.</param>
        /// <param name="rateCoefficient">Коэффициент тарифа.</param>
        public BenefitCustomer1(double energyConsumed, double rateCoefficient = 2/3f) : base(energyConsumed)
        {
            this.rateCoefficient = rateCoefficient;
            totalCostEnergy = TotalCostRate(energyConsumed, costEnergy, rateCoefficient, limitCount: 0);
        }
    }
}
