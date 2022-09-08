using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldNameSpace;

namespace NameSpace
{

    class MainProgram {

        public static void Main(string[] args)
        {
            
            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();
            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = Languages.Italian.ToString();
            countryLanguages.SecondLanguage = Languages.English.ToString();

            countryOneInstance.countryLanguages = countryLanguages;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName = "Italy";
            countryOneInstance.Currency = Currencies.Euro;
            countryOneInstance.Continents = Continents.Europa;

            countryOneInstance.Welcome(countryOneInstance.CountryName);

            Console.WriteLine(countryOneInstance.PlanetName, countryOneInstance.Continents.ToString(), 
                              countryOneInstance.countryLanguages.FirstLanguage.ToString(), 
                              countryOneInstance.countryLanguages.SecondLanguage.ToString(), 
                              countryOneInstance.Continents.ToString(), 
                              countryOneInstance.Currency.ToString());
        }
    }    
}