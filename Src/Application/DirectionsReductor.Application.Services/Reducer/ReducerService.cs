namespace DirectionsReductor.Application.Services.Reducer
{
    using DirectionsReductor.Application.Services.Constants;
    using DirectionsReductor.Application.Services.DependencyInjection;
    using DirectionsReductor.Application.Services.Validation;
    using System.Collections.Generic;

    internal sealed class ReducerService : IReducerService
    {
        private readonly IValidationService validationService;

        public ReducerService(IValidationService validationService)
        {
            this.validationService = validationService;
        }

        public List<string> Reduce(List<string> directions)
        {
            var counter = 0;

            while ((counter < directions.Count - 1) && (directions.Count > 1))
            {
                if (ServiceConstants.ReducibleDirections[directions[counter]] == directions[counter + 1])
                {
                    directions = directions.Splice(counter, 2);
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