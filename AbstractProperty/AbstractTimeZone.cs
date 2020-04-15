namespace lab4.AbstractProperty
{
    /// <summary>
    /// Параметр Часовой пояс
    /// </summary>
    public interface TimeZoneProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает часовой пояс страны
        /// </summary>
        /// <returns>число - часовой пояс</returns>
        int getTimeZone();
    }
}