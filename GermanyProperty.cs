using lab4.AbstractProperty;
using lab4.Germany;

namespace lab4
{
    public class GermanyProperty : RegionProperty
    {
        /// <summary>
        /// метод создаёт параметр "язык" для Германии
        /// </summary>
        public LanguageProp LanguageCreate()
        {
            return new LanguagePropGer();
        }
        /// <summary>
        /// метод создаёт параметр "первый день недели" для Германии
        /// </summary>
        public FirstDayOfWeekProp FirstDayOfWeekCreate()
        {
            return new FirstDayOfWeekPropGer();
        }
        /// <summary>
        ///  метод создаёт параметр "валюта" для Германии
        /// </summary>
        public CurrencyProp CurrencyCreate()
        {
            return new CurrencyPropGer();
        }
        /// <summary>
        ///  метод создаёт  параметр "формат даты" для Германии
        /// </summary>
        public DateFormatProp DateFormatCreate()
        {
            return new DateFormatPropGer();
        }
        /// <summary>
        ///  метод создаёт параметр "стандартная единица измерения длины" для Германии
        /// </summary>
        public StandardLengthProp StandardLengthCreate()
        {
            return new StandardLengthPropGer();
        }
        /// <summary>
        ///  метод создаёт параметр "стандартная ед.измерения объёма" для ГерманииC:\Users\Darina\Desktop\универ\programming\lab4\GermanyProperty.cs
        /// </summary>
        public StandardVolumeProp StandardVolumeCreate()
        {
            return new StandardVolumePropGer();
        }
        /// <summary>
        ///  метод создаёт параметр "стандартная ед.измерения массы" для Германии
        /// </summary>
        public StandardWeightProp StandardWeightCreator()
        {
            return new StandardWeightPropGer();
        }
        /// <summary>
        ///  метод создаёт параметр "телефонный код" для Германии
        /// </summary>
        public PhoneCodeProp PhoneCodeCreate()
        {
            return new PhoneCodePropGer();
        }
        /// <summary>
        /// метод создаёт параметр "домен" для Германии
        /// </summary>
        public DomainProp DomainCreate()
        {
            return new DomainPropGer();
        }
        /// <summary>
        ///  метод создаёт параметр "часовой пояс" для Германии
        /// </summary>
        public TimeZoneProp TimeZoneCreate()
        {
            return new TimeZonePropGer();
        }
    }
}
