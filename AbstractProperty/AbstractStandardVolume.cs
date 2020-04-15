namespace lab4.AbstractProperty
{
    /// <summary>
    /// Параметр Единицы измерения объёма
    /// </summary>
    public interface StandardVolumeProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает единицы измерения объёма страны
        /// </summary>
        /// <returns>строка - единицы измерения объёма</returns>
        string getStandardVolume();
    }
}