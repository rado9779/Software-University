using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesCount = int.Parse(Console.ReadLine());

            double highestRating = 0;
            string highestRatingMovie = "";

            double lowestRating = double.MaxValue;
            string lowestRatingMovie = "";

            double totalRating = 0;

            for (int i = 0; i < moviesCount; i++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                if (movieRating > highestRating)
                {
                    highestRating = movieRating;
                    highestRatingMovie = movieName;
                }
                if (movieRating < lowestRating)
                {
                    lowestRating = movieRating;
                    lowestRatingMovie = movieName;
                }

                totalRating += movieRating;
            }
            Console.WriteLine($"{highestRatingMovie} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{lowestRatingMovie} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {totalRating / moviesCount:f1}");


        }
    }
}
