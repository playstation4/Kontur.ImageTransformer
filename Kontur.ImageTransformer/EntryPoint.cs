using System;

namespace Kontur.ImageTransformer
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            using (var server = new AsyncHttpServer(new RouteResolver()))
            {
                server.Start("http://+:8080/");

                Console.ReadKey(true);
            }
        }
    }
}
