namespace DirectionsReductor.Application.Services
{
    using System.Collections.Generic;
    using System.Linq;

    public class ReducerService : IReducerService
    {
        private readonly Dictionary<string, string> dirs = new Dictionary<string, string> {
            { "NORTH", "SOUTH" },
            { "SOUTH", "NORTH" },
            { "EAST", "WEST" },
            { "WEST", "EAST" }
        };

        public string[] Reduce(string[] directions)
        {
            var counter = 0;

            while ((counter < directions.Length - 1) && directions.Length > 1)
            {
                if (dirs[directions[counter]] == directions[counter + 1])
                {
                    directions = Splice(directions.ToList(), counter, 2);
                    counter = counter == 0 ? counter : counter - 1;
                }
                else
                {
                    counter++;
                }
            }

            return directions;
        }

        private string[] Splice(List<string> source, int index, int count)
        {
            source.RemoveRange(index, count);
            return source.ToArray();
        }
    }
}