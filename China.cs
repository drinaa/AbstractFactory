using lab4.AbstractProperty;

namespace lab4.China
{
    /// <summary>
    /// Параметр Часовой пояс для Китая
    /// </summary>
    public class TimeZonePropChin : TimeZoneProp
    {
        private static int timeZone = 8;
        /// <summary>
        /// Метод, который возвращает часовой пояс по столице
        /// </summary>
        /// <returns>число - часовой пояс</returns>
        public int getTimeZone()
        {
            return timeZone;
        }
    }
    public class PhoneCodePropChin : PhoneCodeProp
    {
        private static int phoneCode = 86;
        /// <summary>
        /// Метод, который возвращает телефонный код
        /// </summary>
        /// <returns>число - телефонный код</returns>
        public int getPhoneCode()
        {
            return phoneCode;
        }
    }
    public class CurrencyPropChin : CurrencyProp
    {
        private static string currency = "CNY";
        /// <summary>
        /// Метод, который возвращает валюту
        /// </summary>
        /// <returns>строка - валюта</returns>
        public string getCurrency()
        {
            return currency;
        }
    }
    public class DateFormatPropChin : DateFormatProp
    {
        private static string dateFormat = "YYYY-MM-DD";
        /// <summary>
        /// Метод, который возвращает формат даты
        /// </summary>
        /// <returns>строка - формат даты</returns>
        public string getDateFormat()
        {
            return dateFormat;
        }
    }
    public class FirstDayOfWeekPropChin : FirstDayOfWeekProp
    {
        private static string firstDayOfWeek = "su";
        /// <summary>
        /// Метод, который возвращает первый день недели
        /// </summary>
        /// <returns>строка - первый день недели</returns>
        public string getFirstDayOfWeek()
        {
            return firstDayOfWeek;
        }
    }
    public class DomainPropChin : DomainProp
    {
        private static string domain = "cn";
        /// <summary>
        /// Метод, который возвращает Домен
        /// </summary>
        /// <returns>строка - домен</returns>
        public string getDomain()
        {
            return domain;
        }
    }
    public class LanguagePropChin :LanguageProp
    {
        private static string lang = "chinese";
        /// <summary>
        /// Метод, который возвращает язык
        /// </summary>
        /// <returns>строка - язык</returns>
        public string getLanguage()
        {
            return lang;
        }
    }
    public class StandardLengthPropChin : StandardLengthProp
    {
        private static string standardLength = "chǐ";
        /// <summary>
        /// Метод, который возвращает стандартную единицу длины
        /// </summary>
        /// <returns>строка - стандартную единицу длины</returns>
        public string getStandardLength()
        {
            return standardLength;
        }
    }
    public class StandardVolumePropChin : StandardVolumeProp
    {
        private static string standardVolume = "shēng";
        /// <summary>
        /// Метод, который возвращает стандартную единицу объёма
        /// </summary>
        /// <returns>строка - стандартную единицу объёма</returns>
        public string getStandardVolume()
        {
            return standardVolume;
        }
    }
    public class StandardWeightPropChin : StandardWeightProp
    {
        private static string standardWeight = "jīn";
        /// <summary>
        /// Метод, который возвращает стандартную единицу массы
        /// </summary>
        /// <returns>строка - стандартную единицу массы</returns>
        public string getStandardWeight()
        {
            return standardWeight;
        }
    }

}