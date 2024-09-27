using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWarsApiCSharp;

namespace _323_starwars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository<Film> filmsRepo = new Repository<Film>();
            IRepository<Planet> planetsRepo = new Repository<Planet>();
            IRepository<Person> personsRepo = new Repository<Person>();
            IRepository<Vehicle> starshipRepo = new Repository<Vehicle>();

            var films = filmsRepo.GetEntities(size: int.MaxValue);
            var planets = planetsRepo.GetEntities(size: int.MaxValue);
            var persons = personsRepo.GetEntities(size: int.MaxValue);
            var starships = starshipRepo.GetEntities(size: int.MaxValue);

            // 1 Quel est le film Star Wars dont le titre est le plus long ?
            string longestFilmName =
            films.Select(a => a.Title).
                  Aggregate((longest, next) =>
                            next.Length > longest.Length ? next : longest);
            DisplayAnswer("// 1 Quel est le film Star Wars dont le titre est le plus long ?", $"{longestFilmName} ({longestFilmName.Length} caractères)");

            // 2 Quel est le personnage qui est présent dans le plus de films ?
            var mostActed =
            persons.Select(a => new { a.Name, FilmsCount = a.Films.Count }).
                    Aggregate((current, next) =>
                    next.FilmsCount > current.FilmsCount ? next : current);
            DisplayAnswer("// 2 Quel est le personnage qui est présent dans le plus de films ?", $"{mostActed.Name} est le personnage le plus présent dans les films ({mostActed.FilmsCount} films)");

            // 3 Quelle est la planète la plus peuplée ?
            var mostResidents =
            planets.Select(a => new { a.Name, ResidentsCount = a.Residents.Count }).
                    Aggregate((current, next) =>
                              next.ResidentsCount > current.ResidentsCount ? next : current);
            DisplayAnswer("// 3 Quelle est la planète la plus peuplée ?", $"{mostResidents.Name} est la planète la plus peuplée ({mostResidents.ResidentsCount} habitants)");

            // 5 Est-ce qu'Obi-wan Kenobi peut piloter un Millennium Falcon ?
            DisplayAnswer("// 5 Est-ce qu'Obi-wan Kenobi peut piloter un Millennium Falcon ?", starshipRepo.GetById(10).Pilots.Contains("https://swapi.dev/api/people/10/") ? "Obi-Wan Kenobi peut piloter un Millenium Falcon" : "Obi-Wan Kenobi ne peut pas piloter un Millenium Falcon");
            Console.ReadLine();
        }

        /// <summary>
        /// Display the answer
        /// </summary>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void DisplayAnswer(string b, string c)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"  {b}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  {c}\n");
        }
    }
}
