namespace EnergyEnterprise.BL
{
    public class RegularCustomer : Customer
    {
        /// <summary>
        /// Обычные потребители.
        /// </summary>
        /// <param name="energyConsumed">Количество потребленной энергии.</param>
        public RegularCustomer(double energyConsumed) : base(energyConsumed)
        {
            totalCostEnergy = TotalCostRate(energyConsumed, costEnergy, rateCoefficient: 1, limitCount: 0);
        }
    }
}
