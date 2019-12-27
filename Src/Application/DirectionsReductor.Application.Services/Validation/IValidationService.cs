namespace DirectionsReductor.Application.Services.Validation
{
    using System.Collections.Generic;

    public interface IValidationService
    {
        void Validate(List<string> directions);
    }
}