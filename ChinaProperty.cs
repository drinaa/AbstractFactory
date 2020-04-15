using lab4.AbstractProperty;
using lab4.China;

namespace lab4
{
    public class ChinaProperty : RegionProperty
    {
            /// <summary>
            /// метод создаёт параметр "язык" для Китая
            /// </summary>
            public LanguageProp LanguageCreate()
        {
            return new LanguagePropChin();
        }
            /// <summary>
            /// метод создаёт параметр "первый день недели" для Китая
            /// </summary>
            public FirstDayOfWeekProp FirstDayOfWeekCreate()
        {
            return new FirstDayOfWeekPropChin();
        }
            /// <summary>
            ///  метод создаёт параметр "валюта" для Китая
            /// </summary>
            public CurrencyProp CurrencyCreate()
        {
            return new CurrencyPropChin();
        }
            /// <summary>
            ///  метод создаёт  параметр "формат даты" для Китая
            /// </summary>
            public DateFormatProp DateFormatCreate()
        {
            return new DateFormatPropChin();
        }
            /// <summary>
            ///  метод создаёт параметр "стандартная единица измерения длины" для Китая
            /// </summary>
            public StandardLengthProp StandardLengthCreate()
        {
            return new StandardLengthPropChin();
        }
            /// <summary>
            ///  метод создаёт параметр "стандартная ед.измерения объёма" для Китая
            /// </summary>
            public StandardVolumeProp StandardVolumeCreate()
        {
            return new StandardVolumePropChin();
        }
        /// <summary>
        ///  метод создаёт параметр "стандартная ед.измерения массы" для Китая
        /// </summary>
        public StandardWeightProp StandardWeightCreator()
        {
            return new StandardWeightPropChin();
        }
        /// <summary>
        ///  метод создаёт параметр "телефонный код" для Китая
        /// </summary>
        public PhoneCodeProp PhoneCodeCreate()
        {
            return new PhoneCodePropChin();
        }
            /// <summary>
            /// метод создаёт параметр "домен" для Китая
            /// </summary>
            public DomainProp DomainCreate()
        {
            return new DomainPropChin();
        }
            /// <summary>
            ///  метод создаёт параметр "часовой пояс" для Китая
            /// </summary>
            public TimeZoneProp TimeZoneCreate()
        {
            return new TimeZonePropChin();
        }
        }
    }