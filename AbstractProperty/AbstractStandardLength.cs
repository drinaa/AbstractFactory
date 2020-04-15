namespace lab4.AbstractProperty
{
    /// <summary>
    /// Параметр Единицы измерения длины
    /// </summary>
    public interface StandardLengthProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает единицы измерения длины страны
        /// </summary>
        /// <returns>строка - единицы измерения длины</returns>
        string getStandardLength();
    }
}