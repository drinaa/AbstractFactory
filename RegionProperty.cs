using lab4.AbstractProperty;

namespace lab4
{
    public interface RegionProperty
    {
        /// <summary>
        /// метод создаёт параметр "язык"
        /// </summary>
        LanguageProp LanguageCreate();
        /// <summary>
        /// метод создаёт параметр "первый день недели"
        /// </summary>
        FirstDayOfWeekProp FirstDayOfWeekCreate();
        /// <summary>
        ///  метод создаёт параметр "валюта"
        /// </summary>
        CurrencyProp CurrencyCreate();
        /// <summary>
        ///  метод создаёт  параметр "формат даты"
        /// </summary>
        DateFormatProp DateFormatCreate();
        /// <summary>
        ///  метод создаёт параметр "стандартная единица измерения длины"
        /// </summary>
        StandardLengthProp StandardLengthCreate();
        /// <summary>
        ///  метод создаёт параметр "стандартная ед.измерения объёма"
        /// </summary>
        StandardVolumeProp StandardVolumeCreate();
        /// <summary>
        ///  метод создаёт параметр "стандартная ед.измерения массы"
        /// </summary>
        StandardWeightProp StandardWeightCreator();
        /// <summary>
        ///  метод создаёт параметр "телефонный код"
        /// </summary>
        PhoneCodeProp PhoneCodeCreate();
        /// <summary>
        /// метод создаёт параметр "домен"
        /// </summary>
        DomainProp DomainCreate();
        /// <summary>
        ///  метод создаёт параметр "часовой пояс"
        /// </summary>
        TimeZoneProp TimeZoneCreate();
    }
}
