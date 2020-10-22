namespace EnergyEnterprise.BL
{
    public class Customer
    {
        /// <summary>
        /// Стоимость одной единицы энергии. (Задается только в Customer и действует на все наследуемые классы)
        /// </summary>
        protected const double costEnergy = 15;
        /// <summary>
        /// Потребленная энергия за 1 месяц.
        /// </summary>
        protected readonly double energyConsumed;
        /// <summary>
        /// Коэффициент тарифа.
        /// </summary>
        protected double rateCoefficient = 1;
        /// <summary>
        /// Общая стоимость энергии. (Вычисляется в каждом наследнике отдельно)
        /// </summary>
        protected double totalCostEnergy;
        /// <summary>
        /// Тип потребителя.
        /// </summary>

        public Customer(double energyConsumed)
        {
            this.energyConsumed = energyConsumed;
        }

        protected virtual double TotalCostRate(double energyConsumed, double costEnergy, double rateCoefficient, int limitCount)
        {
            return costEnergy * rateCoefficient * energyConsumed;
        }

        public double GetTotalCostEnergyValue()
        {
            return totalCostEnergy;
        }
        public double GetEnergyConsumed()
        {
            return energyConsumed;
        }
        public double GetCurrentCostEnergy()
        {
            return costEnergy;
        }
    }
}
