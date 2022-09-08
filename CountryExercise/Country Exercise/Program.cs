using System;
using WorldNamespace;

namespace Country_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Country countryOne = new Country();
            Country countryTwo = new Country();
            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = languages.English.ToString();
            countryLanguages.SecondLanguage = languages.French.ToString();

            countryOne.CountryLanguages = countryLanguages;
            countryOne.PlanetName = "earth";
            countryOne.CountryNames = "Canada";
            countryOne.Currency = Currencies.CAD.ToString();
            countryOne.ContinentsName = Continents.NORTH_AMERICA;

           countryOne.sayHi(countryOne.PlanetName);
            countryOne.sayHi(
                countryOne.CountryNames,
                countryOne.Currency, 
                countryLanguages.FirstLanguage, 
                countryLanguages.SecondLanguage);


        }
    }
}

