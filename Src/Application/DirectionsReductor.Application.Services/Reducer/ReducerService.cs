namespace DirectionsReductor.Application.Services.Reducer
{
    using DirectionsReductor.Application.Services.Constants;
    using DirectionsReductor.Application.Services.DependencyInjection;
    using DirectionsReductor.Application.Services.Validation;
    using DirectionsReductor.Infrastructure.CrossCutting;
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
            Guard.ArgumentNotNull(directions, nameof(directions));

            validationService.Validate(directions);

            var counter = 0;

            while ((counter < directions.Count - 1) && (directions.Count > 1))
            {
                var key = directions[counter].ToUpper().Trim();
                var value = directions[counter + 1].ToUpper().Trim();

                if (ServiceConstants.ReducibleDirections[key] == value)
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