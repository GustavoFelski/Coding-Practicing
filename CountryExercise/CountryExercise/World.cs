using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNameSpace
{
    abstract class World
    {

        private string planetName;
        private Continents continents;

        #region Properties World
        public string PlanetName { get { return planetName; } set { planetName = value; } }
        
        public Continents Continents { get { return continents; } set { continents = value; } }
        #endregion
    }

    class Country : World
    {
        //Country()
        //{
          //  countryName = "";
            //capital = "";
        //}

        private string countryName;
        private string capital;
        private CountryLanguages languages;
        private Currencies currency;

        #region properties Country
        public string CountryName { get { return countryName; } set { countryName = value; } }
        public string Capital { get { return capital; } set { capital = value; } }
        public Currencies Currency { get { return currency; } set { currency = value; } }
        public CountryLanguages countryLanguages { get { return languages; } set { languages = value; } }
        #endregion
        public void Welcome()
        {
            Console.WriteLine($"Welcome");
        }

        public void Welcome(string CName)
        {
            Console.WriteLine($"Welcome you who came from {CName}");
        }

    }
    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        #region properties Languages
        public string FirstLanguage { get { return firstLanguage; } set { firstLanguage = value; } }
        public string SecondLanguage { get { return secondLanguage; } set { secondLanguage = value; } }
        #endregion

    }


    enum Continents
    {
        America,
        Africa,
        Europa,
        Oceania,
        Asia,
        antarctica
    }
    enum Currencies
    {
        #region America Currencies
        Dolar,
        Peso,
        Real,
        Sol,
        Boliviano,
        RicamColon,
        Quetzal,
        Gourde,
        Krone,
        Lempira,
        AntilleanGuilder,
        Cordoba,
        Balboa,
        Guarani,
        Bolivar,
        #endregion

        #region Europe Currencies
        Euro,
        Lek,
        Dram,
        Manat,
        Rouble,
        Mark,
        Lev,
        Kuna,
        Koruna,
        Lari,
        Florin,
        Forint,
        Krona,
        Franc,
        Leu,
        Denar,
        Zloty,
        Dinar,
        Lira,
        Hryvnia,
        Sterling,
        #endregion

        #region Africa Currencies
        AlgerianDinar,
        AngolanKwanza,
        BotswanaPula,
        BurundianFranc,
        CapeVerdeanEscudo,
        ComorianFranc,
        CongoleseFranc,
        Dalasi,
        DjiboutianFranc,
        EgyptianPound,
        EritreanNakfa,
        EthiopianBirr,
        GhanaianCedi,
        GuineanFranc,
        KenyanShilling,
        LesothoLoti,
        LiberianDollar,
        LibyanDinar,
        Lilangeni,
        MalagasyAriary,
        MalawianKwacha,
        MauritianRupee,
        MoroccanDirham,
        MozambicanMetical,
        NamibianDollar,
        NigerianNaira,
        Ouguiya,
        RTGSDollar,
        RwandanFranc,
        SãoToméandPríncipeDobra,
        SeychelloisRupee,
        SierraLeoneanLeone,
        SomaliShilling,
        SouthAfricanRand,
        SouthSudanesePound,
        SudanesePound,
        TanzanianShilling,
        TunisianDinar,
        UgandanShilling,
        ZambianKwacha,

        #endregion

        #region Oceania Currencies
        AustralianDollar,
        CfpFranc,
        CookIslandsDollar,
        FijianDollar,
        NewZealandDollar,
        PapuaNewGuineanKina,
        SamoanTala,
        SolomonIslandsDollar,
        TonganPaAnga,
        UnitedStatesDollar,
        VanuatuVatu,
        #endregion

        #region Asia Currencies
        AfghanAfghani,
        ArmenianDram,
        //ArmenianDram,
        //AustralianDollar,
        AzerbaijaniManat,
        BahrainiDinar,
        Baht,
        BhutaneseNgultrum,
        BruneiDollar,
        CambodianRiel,
        ChineseRenminbi,
        Đồng,
        //Euro,
        HongKongDollar,
        IndianRupee,
        IranianRial,
        IraqiDinar,
        IsraeliNewShekel,
        //IsraeliNewShekel,
        JordanianDinar,
        KazakhstaniTenge,
        KuwaitiDinar,
        Kyat,
        KyrgyzstaniSom,
        LaoKip,
        //Lari,
        LebanesePound,
        MacanesePataca,
        MaldivianRufiyaa,
        MongolianTögrög,
        NepaleseRupee,
        NewTaiwanDollar,
        NorthKoreanWon,
        OmaniRial,
        PakistaniRupee,
        PhilippinePeso,
        PoundSterling,
        QatariRiyal,
        Ringgit,
        Rupiah,
        RussianRuble,
        SaudiRiyal,
        SingaporeDollar,
        Somoni,
        SouthKoreanWon,
        SriLankanRupee,
        SyrianPound,
        Taka,
        TurkishLira,
        TurkmenNewManat,
        UaeDirham,
        UsDollar,
        UzbekistanSom,
        YemeniRial,
        Yen,
        #endregion

        #region Antarctica Currencies
        AntarcticDollar
        #endregion

    }
    enum Languages
    {
        #region America Languages
        English,
        Spanish,
        French,
        Chinese,
        Tagalog,
        Vietnamese,
        German,
        Arabic,
        Guarani,
        Aymara,
        Mapudungun,
        Wayuunaiki,
        Kuna,
        Embera,
        Paez,
        Ashaninka,
        Portuguese,
        #endregion

        #region Europe Languages
        Albanian,
        Belarusian,
        Bosnian,
        Bulgarian,
        Castilian,
        Catalan,
        Croatian,
        Czech,
        Danish,
        Dutch,
        //English,
        Estonian,
        Finnish,
        //French,
        //German,
        Greek,
        Hungarian,
        Icelandic,
        Irish,
        Italian,
        Latin,
        Latvian,
        Lithuanian,
        Luxembourgish,
        Macedonian,
        Maltese,
        Montenegrin,
        Norwegian,
        Polish,
        //Portuguese
        Romanian,
        Russian,
        Sami,
        Serbian,
        Slovak,
        Slovenian,
        Swedish,
        Turkish,
        Ukrainian,
        #endregion

        #region Africa Languages
        #endregion

        #region Asia Languages
        //Chinese,
        Japanese,
        Korean,
        Thai,
        //Vietnamese,
        Indonesian,
        Burmese,
        Filipino,
        Lao,
        Khmer,
        Hindi,
        //Arabic,
        #endregion

        #region Oceania Languages
        //English,
        //French,
        Marshallese,
        //Japanese,
        Maori,
        Nauruan,
        Palauan,
        Tobi,
        Angaur,
        HiriMotu,
        TokPisin,
        Samoan,
        Tongan,
        Bislama
        #endregion

        #region antarctica Languages
        //English, German, Spanish, French, Japanese, Chinese, Italian
        #endregion

    }
}
