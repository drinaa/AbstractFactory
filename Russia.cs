﻿using lab4.AbstractProperty;

namespace lab4.Russia
{
    /// <summary>
    /// Параметр Часовой пояс для Китая
    /// </summary>
    public class TimeZonePropRus : TimeZoneProp
    {
        private static int timeZone = 3;
        /// <summary>
        /// Метод, который возвращает часовой пояс по столице
        /// </summary>
        /// <returns>число - часовой пояс</returns>
        public int getTimeZone()
        {
            return timeZone;
        }
    }
    public class PhoneCodePropRus : PhoneCodeProp
    {
        private static int phoneCode = 7;
        /// <summary>
        /// Метод, который возвращает телефонный код
        /// </summary>
        /// <returns>число - телефонный код</returns>
        public int getPhoneCode()
        {
            return phoneCode;
        }
    }
    public class CurrencyPropRus : CurrencyProp
    {
        private static string currency = "RUB";
        /// <summary>
        /// Метод, который возвращает валюту
        /// </summary>
        /// <returns>строка - валюта</returns>
        public string getCurrency()
        {
            return currency;
        }
    }
    public class DateFormatPropRus : DateFormatProp
    {
        private static string dateFormat = "DD-MM-YYYY";
        /// <summary>
        /// Метод, который возвращает формат даты
        /// </summary>
        /// <returns>строка - формат даты</returns>
        public string getDateFormat()
        {
            return dateFormat;
        }
    }
    public class FirstDayOfWeekPropRus : FirstDayOfWeekProp
    {
        private static string firstDayOfWeek = "mo";
        /// <summary>
        /// Метод, который возвращает первый день недели
        /// </summary>
        /// <returns>строка - первый день недели</returns>
        public string getFirstDayOfWeek()
        {
            return firstDayOfWeek;
        }
    }
    public class DomainPropRus : DomainProp
    {
        private static string domain = "ru";
        /// <summary>
        /// Метод, который возвращает Домен
        /// </summary>
        /// <returns>строка - домен</returns>
        public string getDomain()
        {
            return domain;
        }
    }
    public class LanguagePropRus : LanguageProp
    {
        private static string lang = "russian";
        /// <summary>
        /// Метод, который возвращает язык
        /// </summary>
        /// <returns>строка - язык</returns>
        public string getLanguage()
        {
            return lang;
        }
    }
    public class StandardLengthPropRus : StandardLengthProp
    {
        private static string standardLength = "m";
        /// <summary>
        /// Метод, который возвращает стандартную единицу длины
        /// </summary>
        /// <returns>строка - стандартную единицу длины</returns>
        public string getStandardLength()
        {
            return standardLength;
        }
    }
    public class StandardVolumePropRus : StandardVolumeProp
    {
        private static string standardVolume = "l";
        /// <summary>
        /// Метод, который возвращает стандартную единицу объёма
        /// </summary>
        /// <returns>строка - стандартную единицу объёма</returns>
        public string getStandardVolume()
        {
            return standardVolume;
        }
    }
    public class StandardWeightPropRus : StandardWeightProp
    {
        private static string standardWeight = "kg";
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