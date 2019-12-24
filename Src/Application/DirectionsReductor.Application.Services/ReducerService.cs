namespace DirectionsReductor.Application.Services
{
    using DirectionsReductor.Infrastructure.CrossCutting;
    using System.Linq;

    public class ReducerService : IReducerService
    {
        public string[] Reduce(string[] directions)
        {
            var counter = 0;

            while ((counter < directions.Length - 1) && (directions.Length > 1))
            {
                if (Constants.ReducibleDirections[directions[counter]] == directions[counter + 1])
                {
                    directions = directions.ToList().Splice(counter, 2);
                    counter = counter == 0 ? counter : counter - 1;
                }
                else
                {
                    counter++;
                }
            }

            return directions;
        }
    }
}