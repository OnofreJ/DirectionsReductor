namespace DirectionsReductor.Application.Services
{
    using System.Collections.Generic;

    internal static class ServiceExtensions
    {
        public static string[] Splice(this List<string> source, int index, int count)
        {
            source.RemoveRange(index, count);
            return source.ToArray();
        }
    }
}