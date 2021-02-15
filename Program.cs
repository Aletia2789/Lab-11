using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<Movie>();
            string answer;

            list.Add(new Movie("Spirited Away", "animated"));
            list.Add(new Movie("Frozen", "animated"));
            list.Add(new Movie("Rambo", "drama"));
            list.Add(new Movie("Django Unchained", "drama"));
            list.Add(new Movie("Texas Chainsaw Massacre", "horror"));
            list.Add(new Movie("Saw", "horror"));
            list.Add(new Movie("Star Wars", "sci-fi"));
            list.Add(new Movie("Jurassic", "sci-fi"));
            list.Add(new Movie("Annabelle", "horror"));
            list.Add(new Movie("The Conjouring", "horror"));

            do
            {
                string response = GetUserInput();
                if (response == "horror")
                {
                    GetHorror(list);
                }
                else if (response == "drama")
                {
                    GetDrama(list);
                }
                else if (response == "animated")
                {
                    GetAnimated(list);
                }
                else if (response == "scifi")
                {
                    GetSciFi(list);
                }

                Console.WriteLine("Do you want to continue (y/n)?");
                answer = Console.ReadLine();

                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    answer = Console.ReadLine();
                }

            } while (answer == "y");

            Console.WriteLine("Thank for using the List application! Goodbye.");
        }
        public static void GetHorror(List<Movie> list)
        {
           
            foreach (var movie in list)
            {
                if (movie.GetCategory() == "horror")
                {
                    Console.WriteLine(movie.GetTitle());
                }
            }
        }
        public static void GetAnimated(List<Movie> list)
        {

            foreach (var movie in list)
            {
                if (movie.GetCategory() == "animated")
                {
                    Console.WriteLine(movie.GetTitle());
                }
            }
        }
        public static void GetSciFi(List<Movie> list)
        { 

            foreach (var movie in list)
            {
                if (movie.GetCategory() == "sci-fi")
                {
                    Console.WriteLine(movie.GetTitle());
                }
            }
        }
        public static void GetDrama(List<Movie> list)
        {

            foreach (var movie in list)
            {
                if (movie.GetCategory() == "drama")
                {
                    Console.WriteLine(movie.GetTitle());
                }
            }
        }

        private static string GetUserInput()
        {
            string response;
            Console.WriteLine("Welcome to the Movie List Application!" + "\r\n" + "There are 10 movies in this list." + "\r\n" +
              "The category choices are Animated, Horror, Scifi, or Drama. Please pick one of the 4 choices and enter it below:");
            response = Console.ReadLine().ToLower();
            
            while(!(response.ToLower() == "scifi" || response.ToLower() == "horror" || response.ToLower() == "animated" || response.ToLower() == "drama"))   
            {
                Console.WriteLine("Sorry the category you have chosen does not exist. Please enter either Scifi, Animated, Horror, or Drama as a category below:");
                response = Console.ReadLine().ToLower();

            }
            return response;
        }
        
    }
}


