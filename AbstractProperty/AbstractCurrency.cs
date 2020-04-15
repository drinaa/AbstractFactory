namespace lab4.AbstractProperty
{
    /// <summary>
    /// Параметр Валюта
    /// </summary>
    public interface CurrencyProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает валюту страны
        /// </summary>
        /// <returns>строка - валюта</returns>
        string getCurrency();
    }
}