namespace EnergyEnterprise.BL
{
    public interface IBasicLevel
    {
        /// <summary>
        /// Сортировка массив по количеству потребленной энергии по убыванию
        /// </summary>
        /// <returns></returns>
        Customer[] SortDescByEnergyConsumed();
        /// <summary>
        /// Сортировка массива по величине оплаты по возрастанию
        /// </summary>
        /// <returns></returns>
        Customer[] SortByTotalCost();
        /// <summary>
        /// Упорядочить по типу клиентов (обычные - с лимитом - льготники 1 - льготники 2)
        /// </summary>
        /// <returns></returns>
        Customer[] SortByTypeCustomer();
        /// <summary>
        /// Вычислить общую сумму SUM за потребленную энергию
        /// </summary>
        /// <returns></returns>
        double TotalCostFromAllCustomers();
        /// <summary>
        /// Вычислить размер льготы LG = SUM0 - SUM
        /// </summary>
        /// <returns></returns>
        double TotalBenefitsCots();
    }
}
