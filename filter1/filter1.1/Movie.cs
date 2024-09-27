namespace _323_matvelickov_filter1
{
    internal class Movie
    {
        public Movie()
        {
        }

        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }
        public string[] LanguageOptions { get; set; }
        public string[] StreamingPlatforms { get; set; }
    }
}