namespace DirectionsReductor.Presentation
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var exit = false;

            while (exit == false)
            {
                Console.WriteLine("Welcome to the ROUTE REDUCTION SYSTEM! Please enter the route to see if it can be shortened.");
                Console.WriteLine("Values entered must be delimited by commas(,).Example:");
                Console.WriteLine("North, East, South.");

                Console.WriteLine();

                exit = Convert.ToBoolean(Console.ReadLine());
                Console.Clear();
            }

            //Console.WriteLine("Write your direction:");
            //var directions = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };

            //var reducerService = new ReducerService();

            //foreach (var item in reducerService.Reduce(directions))
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("");

            //directions = new string[] { "NORTH", "SOUTH", "EAST", "WEST" };
            //foreach (var item in reducerService.Reduce(directions))
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("");

            //directions = new string[] { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST" };
            //foreach (var item in reducerService.Reduce(directions))
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("");

            //directions = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            //foreach (var item in reducerService.Reduce(directions))
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("");

            //directions = new string[] { "NORTH", "WEST" };
            //foreach (var item in reducerService.Reduce(directions))
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("");
        }
    }
}