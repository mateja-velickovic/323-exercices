using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matvelickov_filter1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> frenchWords = new List<string>() { "aba", "hello", "monde", "vert", "rouge", "bleu", "jaune" };


            /* 1. Filtrage simple
            var charAvg = list.Average(w => w.Length);

            List<string> filteredList = list.Where(a => !a.Contains('x') && a.Length >= 4 && a.Length > charAvg).ToList();

            Console.Write("\n Non-filtrée\n");
            list.ForEach(a => { Console.WriteLine($" {a}"); });

            Console.Write("\n Filtrée\n");
            filteredList.ForEach(a => { Console.WriteLine($" {a}"); });*/

            Dictionary<char, double> charsProb = new Dictionary<char, double>();
            charsProb.Add('e', 17.39);
            charsProb.Add('a', 8.15);
            charsProb.Add('i', 6.59);
            charsProb.Add('s', 6.51);
            charsProb.Add('n', 6.39);
            charsProb.Add('r', 6.64);
            charsProb.Add('t', 7.22);
            charsProb.Add('o', 5.02);
            charsProb.Add('l', 4.96);
            charsProb.Add('u', 4.49);
            charsProb.Add('d', 3.67);
            charsProb.Add('c', 3.18);
            charsProb.Add('m', 2.62);
            charsProb.Add('p', 2.49);
            charsProb.Add('é', 1.94);
            charsProb.Add('g', 1.23);
            charsProb.Add('b', 0.97);
            charsProb.Add('v', 1.64);
            charsProb.Add('h', 1.11);
            charsProb.Add('f', 1.11);
            charsProb.Add('q', 0.65);
            charsProb.Add('y', 0.46);
            charsProb.Add('x', 0.38);
            charsProb.Add('j', 0.34);
            charsProb.Add('è', 0.31);
            charsProb.Add('à', 0.31);
            charsProb.Add('k', 0.29);
            charsProb.Add('w', 0.17);
            charsProb.Add('z', 0.15);
            charsProb.Add('ê', 0.08);
            charsProb.Add('ç', 0.06);
            charsProb.Add('ô', 0.04);
            charsProb.Add('â', 0.03);
            charsProb.Add('î', 0.03);
            charsProb.Add('û', 0.02);
            charsProb.Add('ù', 0.02);
            charsProb.Add('ï', 0.01);
            charsProb.Add('á', 0.01);
            charsProb.Add('ü', 0.01);
            charsProb.Add('ë', 0.01);
            charsProb.Add('ö', 0.01);
            charsProb.Add('í', 0.01);

            Dictionary<char, double> charsInc = new Dictionary<char, double>();
            charsInc.Add('e', 0);
            charsInc.Add('a', 0);
            charsInc.Add('i', 0);
            charsInc.Add('s', 0);
            charsInc.Add('n', 0);
            charsInc.Add('r', 0);
            charsInc.Add('t', 0);
            charsInc.Add('o', 0);
            charsInc.Add('l', 0);
            charsInc.Add('u', 0);
            charsInc.Add('d', 0);
            charsInc.Add('c', 0);
            charsInc.Add('m', 0);
            charsInc.Add('p', 0);
            charsInc.Add('é', 0);
            charsInc.Add('g', 0);
            charsInc.Add('b', 0);
            charsInc.Add('v', 0);
            charsInc.Add('h', 0);
            charsInc.Add('f', 0);
            charsInc.Add('q', 0);
            charsInc.Add('y', 0);
            charsInc.Add('x', 0);
            charsInc.Add('j', 0);
            charsInc.Add('è', 0);
            charsInc.Add('à', 0);
            charsInc.Add('k', 0);
            charsInc.Add('w', 0);
            charsInc.Add('z', 0);
            charsInc.Add('ê', 0);
            charsInc.Add('ç', 0);
            charsInc.Add('ô', 0);
            charsInc.Add('â', 0);
            charsInc.Add('î', 0);
            charsInc.Add('û', 0);
            charsInc.Add('ù', 0);
            charsInc.Add('ï', 0);
            charsInc.Add('á', 0);
            charsInc.Add('ü', 0);
            charsInc.Add('ë', 0);
            charsInc.Add('ö', 0);
            charsInc.Add('í', 0);

            double Epsilon(string word)
            {
                double value = 0;

                foreach (var c in word)
                {
                    charsInc[c]++;
                }
                foreach (var b in word)
                {
                    if (charsInc.TryGetValue(b, out double inc))
                    {
                        if (charsProb.TryGetValue(b, out double probability))
                        {
                            if (inc >= 2)
                            {
                                value = value + (probability / 100) / inc;
                                charsInc[b] = 0;
                            }
                            else if (inc <= 1)
                            {
                                value = value + (probability / 100);
                                charsInc[b] = 0;
                            }
                            Console.WriteLine($"{b} {inc}");
                        }
                    }

                }
                return value;
            }

            frenchWords.ForEach(a => Console.WriteLine($"{a} > {Epsilon(a)}"));

            Console.ReadLine();

        }
    }
}
