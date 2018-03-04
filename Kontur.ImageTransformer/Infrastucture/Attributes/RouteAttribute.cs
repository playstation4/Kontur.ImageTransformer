using System;

namespace Kontur.ImageTransformer.Infrastucture.Attributes
{
    public class RouteAttribute : Attribute
    {
        public string Route { get; set; }

        public RouteAttribute(string route)
        {
            Route = route;
        }
    }
}
