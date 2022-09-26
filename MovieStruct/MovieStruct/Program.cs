using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieInfo inceptionInfo = new MovieInfo();
            inceptionInfo.Genre = new Genres[4];
            inceptionInfo.Genre[0] = Genres.Drama;
            inceptionInfo.Genre[1] = Genres.Mistery;
            inceptionInfo.Genre[2] = Genres.Horror;
            inceptionInfo.Genre[3] = Genres.Suspence;

            inceptionInfo.Language = new Languages[1];
            inceptionInfo.Language[0] = Languages.English;

            inceptionInfo.Country = new Countries[2];
            inceptionInfo.Country[0] = Countries.UnitedKindom;
            inceptionInfo.Country[1] = Countries.UnitedStates;

            try { 
            MovieInfo movieInfo1 = new MovieInfo();
            MovieInfo movieInfo2 = new MovieInfo();

            #region Movie 1
            movieInfo1.MovieName = "The Father";
            movieInfo1.Rate = "8,2";
            //    movieInfo1.RealeaseDate = DateOnly(01,01,2019);
            movieInfo1.Genre = new Genres[2];
            movieInfo1.Genre[0] = Genres.Drama;
            movieInfo1.Genre[1] = Genres.Mistery;
            movieInfo1.Language[0] = Languages.English;
            movieInfo1.Country[0] = Countries.UnitedKindom;
            #endregion

            #region Movie 2
            movieInfo2.MovieName = "The Annabelle Story";
            movieInfo2.Rate = "5,4";
            //movieInfo2.RealeaseDate = 09/10/2014
            movieInfo2.Genre[0] = Genres.Horror;
            movieInfo2.Genre[1] = Genres.Mistery;
            movieInfo2.Genre[2] = Genres.Suspence;
            movieInfo2.Language[0] = Languages.English;
            movieInfo2.Country[0] = Countries.UnitedStates;
                #endregion


            movieInfo1.DisplayInfo();
            movieInfo2.DisplayInfo();

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }

    struct MovieInfo
    {
        private string movieName;
        private string rate;
        private DateTime realeaseDate;
        private Genres[] genre;
        private Languages[] language;
        private Countries[] country;


        #region Properties Struct Movie
        public string MovieName { get; set; }
        public string Rate { get; set; }
        public DateTime RealeaseDate { get; set; }
        public Genres[] Genre { get; set; }
        public Languages[] Language { get; set; }
        public Countries[] Country { get; set; }
        #endregion

        public void DisplayInfo()
        {
            Console.WriteLine($"Movie name: {movieName}" +
                            $"\nRate: {rate}" +
                            $"\nRealeaseDate:{realeaseDate}\n");
            foreach (Genres genres in genre)
            {
                Console.WriteLine($"Genre: {genres}\n");
            }
            foreach (Languages languages in language)
            {
                Console.WriteLine($"Langueges: {languages}\n");
            }
            foreach (Countries countries in country)
            {
                Console.WriteLine($"Genre: {countries}\n");
            }
        }
    }

    enum Genres
    {
        Drama,
        Mistery,
        Horror,
        Suspence
    }
    enum Languages
    {
        English
    }

    enum Countries
    {
        UnitedKindom,
        UnitedStates
    }
}


