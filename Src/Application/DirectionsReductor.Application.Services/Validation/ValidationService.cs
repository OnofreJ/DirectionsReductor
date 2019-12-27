namespace DirectionsReductor.Application.Services.Validation
{
    using DirectionsReductor.Application.Services.Constants;
    using DirectionsReductor.Infrastructure.CrossCutting;
    using System;
    using System.Collections.Generic;

    internal sealed class ValidationService : IValidationService
    {
        public void Validate(List<string> directions)
        {
            foreach (var direction in directions)
            {
                Guard.ArgumentNotNullOrWhiteSpace(direction, nameof(direction));

                if (!ServiceConstants.ReducibleDirections.TryGetValue(direction.ToUpper().Trim(), out var validatedDirection))
                {
                    throw new InvalidOperationException(string.Format(MessageConstants.InvalidDirectionMessage, direction));
                }
            }
        }
    }
}