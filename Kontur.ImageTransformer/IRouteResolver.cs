using System.Net;

namespace Kontur.ImageTransformer
{
    public interface IRouteResolver
    {
        byte[] Resolve(HttpListenerRequest request);
    }
}
