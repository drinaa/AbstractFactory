using System;
using lab4.AbstractProperty;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите страну: (ru-Россия, ch-Китай, ge-Германия)\n");
            bool check = Enum.TryParse(Console.ReadLine(), out Countries.listOfCountries country);

            if (!check)
            {
                Console.WriteLine("Данная страна не поддерживается");
            }
            else
            {
                RegionProperty prop;
                switch (country.ToString())
                {

                    case "ch":
                        prop = new ChinaProperty();
                        break;
                    case "ge":
                        prop = new GermanyProperty();
                        break;
                    default:
                        prop = new RussiaProperty();
                        break;
                }
                App app = new App(
                    prop.CurrencyCreate(),
                    prop.DateFormatCreate(),
                    prop.FirstDayOfWeekCreate(),
                    prop.DomainCreate(),
                    prop.LanguageCreate(),
                    prop.PhoneCodeCreate(),
                    prop.StandardLengthCreate(),
                    prop.StandardVolumeCreate(),
                    prop.StandardWeightCreator(),
                    prop.TimeZoneCreate());

                Console.WriteLine("Валюта: {0}\n" +
                                  "Формат даты: {1}\n" +
                                  "Первый день недели: {2}\n" +
                                  "Домен: {3}\n" +
                                  "Язык: {4}\n" +
                                  "Телефонный код: {5}\n" +
                                  "Стандартная единица длины: {6}\n" +
                                  "Стандартная единица объём: {7}\n" +
                                  "Стандартная единица массы: {8}\n" +
                                  "Часовой пояс: {9}\n",
                    app.currency.getCurrency(),
                    app.dateFormat.getDateFormat(),
                    app.firstDayOfWeek.getFirstDayOfWeek(),
                    app.domain.getDomain(),
                    app.language.getLanguage(),
                    app.phoneCode.getPhoneCode(),
                    app.standardLength.getStandardLength(),
                    app.standardVolume.getStandardVolume(),
                    app.standardWeight.getStandardWeight(),
                    app.timeZone.getTimeZone());
            }
        }
        /// <summary>
        /// создание класса App
        /// </summary>
        class App
        {
            public CurrencyProp currency;
            public DateFormatProp dateFormat;
            public FirstDayOfWeekProp firstDayOfWeek;
            public DomainProp domain;
            public LanguageProp language;
            public PhoneCodeProp phoneCode;
            public StandardLengthProp standardLength;
            public StandardVolumeProp standardVolume;
            public StandardWeightProp standardWeight;
            public TimeZoneProp timeZone;

            /// <summary>
            /// Конструктор класса App
            /// </summary>
            public App(CurrencyProp currency, DateFormatProp dateFormat, FirstDayOfWeekProp firstDayOfWeek, DomainProp domain, LanguageProp language,
                PhoneCodeProp phoneCode, StandardLengthProp standardLength, StandardVolumeProp standardVolume, StandardWeightProp standardWeight,
                TimeZoneProp timeZone)
            {
                this.currency = currency;
                this.dateFormat = dateFormat;
                this.firstDayOfWeek = firstDayOfWeek;
                this.domain = domain;
                this.language = language;
                this.phoneCode = phoneCode;
                this.standardLength = standardLength;
                this.standardVolume = standardVolume;
                this.standardWeight = standardWeight;
                this.timeZone = timeZone;
            }
        }
    }

        public class Countries
        {
            public enum listOfCountries { ru, ge, ch };
        }
    
}
