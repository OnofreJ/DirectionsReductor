namespace DirectionsReductor.Presentation
{
    using DirectionsReductor.Application.Services.DependencyInjection;
    using DirectionsReductor.Application.Services.Reducer;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    [ExcludeFromCodeCoverage]
    internal class Program
    {
        private static IServiceProvider ConfigureApplication()
        {
            return new ServiceCollection()
                .AddServices()
                .BuildServiceProvider();
        }

        private static void Main()
        {
            var serviceProvider = ConfigureApplication();

            StartApplication(serviceProvider);
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("* Welcome to the ROUTE REDUCTION SYSTEM! *");
            Console.WriteLine("******************************************");
            Console.WriteLine("Please enter the route to see if it can be shortened.");
            Console.WriteLine("Values entered must be delimited by commas(,).Example: North, East, South");
        }

        private static void StartApplication(IServiceProvider serviceProvider)
        {
            var exit = false;
            var errorMessage = string.Empty;
            var reducerService = serviceProvider.GetService<IReducerService>();

            while (!exit)
            {
                try
                {
                    PrintWelcomeMessage();

                    if (!string.IsNullOrEmpty(errorMessage))
                    {
                        Console.WriteLine(errorMessage);
                    }

                    Console.Write("Enter your route: ");

                    var directions = Console.ReadLine().Split(',');
                    var reducedDirections = reducerService.Reduce(directions.ToList());

                    Console.Write("Your direction has been reduced to: ");

                    reducedDirections.ForEach(direction => Console.Write($"{ direction } "));

                    Console.WriteLine(string.Empty);
                    Console.WriteLine("Exit? (Y/N)");

                    exit = Console.ReadLine().ToUpper().Trim() == "Y";
                    errorMessage = string.Empty;

                    Console.Clear();
                }
                catch (Exception exception)
                {
                    errorMessage = $"Oops! Something went wrong - {exception.Message}";
                    Console.Clear();
                }
            }

            Console.WriteLine("Thank you!");
        }
    }
}