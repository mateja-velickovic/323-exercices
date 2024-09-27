using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _323_matvelickov_filter1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Movie> frenchMovies = new List<Movie>() {
new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }
};

            var cin3 = frenchMovies.Where(x => x.Year < 2000).ToList();
            var cin4 = frenchMovies.Where(x => !x.LanguageOptions.Contains("Français")).ToList();
            var cin5 = frenchMovies.Where(x => !x.StreamingPlatforms.Contains("Netflix")).ToList();


            Console.Write("Quel genre voulez-vous exclure des films ?");
            string first = Console.ReadLine();
            Console.Write("Quel note minimale voulez-vous ?");
            string second = Console.ReadLine();
            Console.Write("ASD");
            string third = Console.ReadLine();
            Console.Write("Quel genre voulez-vous exclure des films ?");
            string fourth = Console.ReadLine();

            var filteredMovies = frenchMovies.Where(x => x.Genre != first).Where(x => x.Rating < Convert.ToInt32(second)).Where(x => x.Year < Convert.ToInt32(third)).ToList();

            Console.ReadLine();
        }
    }
}
