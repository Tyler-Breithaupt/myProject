using System;

namespace myProject
{
    class Game
    {
        // Private Fields
        private string title;
        private int releaseYear;
        private double rating;

        // Default Constructor
        public Game()
        {
            title = "Untitled Game";
            releaseYear = 2024;
            rating = 0.0;
        }

        // Parameterized Constructor
        public Game(string title, int releaseYear, double rating)
        {
            this.title = title;
            this.releaseYear = releaseYear;
            this.rating = rating;
        }

        // Get and Set Methods
        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public int GetReleaseYear()
        {
            return releaseYear;
        }

        public void SetReleaseYear(int releaseYear)
        {
            this.releaseYear = releaseYear;
        }

        public double GetRating()
        {
            return rating;
        }

        public void SetRating(double rating)
        {
            this.rating = rating;
        }

        static void Main()
        {
            // Creating objects using the default constructor
            Game game1 = new Game();
            Game game2 = new Game();

            // Creating objects using the parameterized constructor
            Game game3 = new Game("Super Mario Galaxy", 2007, 4.8);
            Game game4 = new Game("Batman: Arkham Knight", 2015, 4.6);

            // Displaying information
            Console.WriteLine("Game 1: {0} ({1}), Rating: {2}", game1.GetTitle(), game1.GetReleaseYear(), game1.GetRating());
            Console.WriteLine("Game 2: {0} ({1}), Rating: {2}", game2.GetTitle(), game2.GetReleaseYear(), game2.GetRating());
            Console.WriteLine("Game 3: {0} ({1}), Rating: {2}", game3.GetTitle(), game3.GetReleaseYear(), game3.GetRating());
            Console.WriteLine("Game 4: {0} ({1}), Rating: {2}", game4.GetTitle(), game4.GetReleaseYear(), game4.GetRating());
        }
    }
}