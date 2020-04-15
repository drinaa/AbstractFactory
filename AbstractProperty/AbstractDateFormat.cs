namespace lab4.AbstractProperty
{
    /// <summary>
    /// Параметр Формат даты
    /// </summary>
    public interface DateFormatProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает формат даты страны
        /// </summary>
        /// <returns>строка - формат даты</returns>
        string getDateFormat();
    }
}