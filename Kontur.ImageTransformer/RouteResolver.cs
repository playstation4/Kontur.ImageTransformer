using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Reflection;
using Kontur.ImageTransformer.Infrastucture.Attributes;
using Kontur.ImageTransformer.Infrastucture.Helpers;

namespace Kontur.ImageTransformer
{
    internal class RouteResolver : IRouteResolver
    {
        public byte[] Resolve(HttpListenerRequest request)
        {
            var route = request.Url.Segments[2].Replace("/", "");
            string[] strParams = request.Url
                .Segments[3]
                .Replace("/", "")
                .Split(',')
                .ToArray();

            var method = typeof(ImageController).GetMethods().First(x => x.GetCustomAttribute<RouteAttribute>().Route == route);
            var image = Image.FromStream(request.InputStream);
            var parameters = method.GetParameters()
                .Take(strParams.Length)
                .Select((p, i) => Convert.ChangeType(strParams[i], p.ParameterType))
                .Concat(new [] { image })
                .ToArray();

            var result = method.Invoke(new ImageController(), parameters) as Image;
            return result.ToBytes(ImageFormat.Png);
        }
    }
}
