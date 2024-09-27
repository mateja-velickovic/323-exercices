using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _323_matvelickov_pir1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 players
            var players = ImmutableList.Create(
                new Player("Joe", 32),
                new Player("Jack", 30),
                new Player("William", 37),
                new Player("Averell", 25)
            );

            Player x = FindOlder(players);

            Player FindOlder(IEnumerable<Player> pl)
            {
                Player elder = pl.First();

                for(int i = 0; i < 4; ++i)
                {
                    Player p = pl.ElementAt(i);
                    if(p.Age > elder.Age)
                    {
                        elder = new Player(p.Name, p.Age);
                    }
                }

                return elder;
            }
            
            Console.WriteLine($"Le plus agé est {x.Name} qui a {x.Age} ans");

            Console.ReadKey();
        }

    }
}
