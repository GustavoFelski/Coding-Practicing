using System;
using System.Collections.Generic;
using System.Text;

namespace WorldNamespace
{
    abstract class World
    {
        private string planetName;
        private Continents continents;

        public string PlanetName { get; set; }
        public Continents ContinentsName { get {return continents ;} set {this.continents = value;} }
    }
    
    class Country : World
    {
        private string countryNames;
        private string capitals;
        private Currencies currency;
        private CountryLanguages countryLanguages;

        public string CountryNames { get { return countryNames; } set { this.countryNames = value; } }
        public string Capitals { get { return capitals; } set { this.capitals = value; } }
        public string Currency { get; set; }
        public CountryLanguages CountryLanguages { get { return countryLanguages; } set { this.countryLanguages = value; } }

        public Country()
        {
            capitals = "unknown";
            countryNames = "unknown";
        }

        public void sayHi(string planetName)
        {
            Console.WriteLine($"Welcome there from {planetName}");

        }
        public void sayHi(string Country, string County, string languageOne, string languageTwo)
        {
            Console.WriteLine($"Hello pal from {Country}, your county is: {County} \nyour Country has two Languages,\nOne is: {languageOne}\nand second is: {languageTwo}.");

        }
    }

    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage { get { return firstLanguage; } set { this.firstLanguage = value; } }
        public string SecondLanguage { get { return secondLanguage; } set { this.secondLanguage = value; } }
    }

    enum Continents
    {
        ASIA,
        AFRICA,
        NORTH_AMERICA,
        SOUTH_AMERICA,
        ANTARCTICA,
        EUROPE,
        AUSTRALIA
    }

    enum Currencies
    {
        USD,
        EUR,
        JPY,
        GBP,
        AUD,
        CAD,
        CHF,
        CNY,
        SEK,
        NZD,
        MXN,
        SGD,
        HKD,
        NOK,
        KRW,
        TRY,
        RUB,
        INR,
        EGP,
        BRL,
        ZAR,
        AED,
        TND,
        SAR,
        RON,
        PLN
    }

    enum languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
}
