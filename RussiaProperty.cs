using lab4.AbstractProperty;
using lab4.Russia;

namespace lab4
{
    public class RussiaProperty : RegionProperty
    {
        /// <summary>
        /// метод создаёт параметр "язык" для России
        /// </summary>
        public LanguageProp LanguageCreate()
        {
            return new LanguagePropRus();
        }
        /// <summary>
        /// метод создаёт параметр "первый день недели" для России
        /// </summary>
        public FirstDayOfWeekProp FirstDayOfWeekCreate()
        {
            return new FirstDayOfWeekPropRus();
        }
        /// <summary>
        ///  метод создаёт параметр "валюта" для России
        /// </summary>
        public CurrencyProp CurrencyCreate()
        {
            return new CurrencyPropRus();
        }
        /// <summary>
        ///  метод создаёт  параметр "формат даты" для России
        /// </summary>
        public DateFormatProp DateFormatCreate()
        {
            return new DateFormatPropRus();
        }
        /// <summary>
        ///  метод создаёт параметр "стандартная единица измерения длины" для России
        /// </summary>
        public StandardLengthProp StandardLengthCreate()
        {
            return new StandardLengthPropRus();
        }
        /// <summary>
        ///  метод создаёт параметр "стандартная ед.измерения объёма" для России
        /// </summary>
        public StandardVolumeProp StandardVolumeCreate()
        {
            return new StandardVolumePropRus();
        }
        /// <summary>
        ///  метод создаёт параметр "стандартная ед.измерения массы" для России
        /// </summary>
        public StandardWeightProp StandardWeightCreator()
        {
            return new StandardWeightPropRus();
        }
        /// <summary>
        ///  метод создаёт параметр "телефонный код" для России
        /// </summary>
        public PhoneCodeProp PhoneCodeCreate()
        {
            return new PhoneCodePropRus();
        }
        /// <summary>
        /// метод создаёт параметр "домен" для России
        /// </summary>
        public DomainProp DomainCreate()
        {
            return new DomainPropRus();
        }
        /// <summary>
        ///  метод создаёт параметр "часовой пояс" для России
        /// </summary>
        public TimeZoneProp TimeZoneCreate()
        {
            return new TimeZonePropRus();
        }
    }
}
