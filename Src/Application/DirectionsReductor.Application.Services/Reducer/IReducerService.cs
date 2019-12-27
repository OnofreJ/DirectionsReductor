namespace DirectionsReductor.Application.Services.Reducer
{
    using System.Collections.Generic;

    public interface IReducerService
    {
        List<string> Reduce(List<string> directions);
    }
}