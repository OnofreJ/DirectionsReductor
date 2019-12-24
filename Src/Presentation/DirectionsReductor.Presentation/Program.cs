namespace DirectionsReductor.Presentation
{
    using DirectionsReductor.Application.Services;
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write your direction:");
            var directions = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };

            var reducerService = new ReducerService();

            foreach (var item in reducerService.Reduce(directions))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            directions = new string[] { "NORTH", "SOUTH", "EAST", "WEST" };
            foreach (var item in reducerService.Reduce(directions))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            directions = new string[] { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST" };
            foreach (var item in reducerService.Reduce(directions))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            directions = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            foreach (var item in reducerService.Reduce(directions))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            directions = new string[] { "NORTH", "WEST" };
            foreach (var item in reducerService.Reduce(directions))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }
    }
}