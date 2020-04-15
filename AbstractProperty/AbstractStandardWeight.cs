namespace lab4.AbstractProperty
{
    /// <summary>
    /// Параметр Единицы измерения массы
    /// </summary>
    public interface StandardWeightProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает единицы измерения массы страны
        /// </summary>
        /// <returns>строка - единицы измерения массы</returns>
        string getStandardWeight();
    }
}