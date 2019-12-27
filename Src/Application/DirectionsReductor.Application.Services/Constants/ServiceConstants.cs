namespace DirectionsReductor.Application.Services.Constants
{
    using System.Collections.Generic;

    public static class ServiceConstants
    {
        public static readonly string East = "EAST";

        public static readonly string North = "NORTH";

        public static readonly string South = "SOUTH";

        public static readonly string West = "WEST";

        public static Dictionary<string, string> ReducibleDirections { get; } = new Dictionary<string, string> {
            { North, South },
            { South, North },
            { East, West },
            { West, East }
        };
    }
}