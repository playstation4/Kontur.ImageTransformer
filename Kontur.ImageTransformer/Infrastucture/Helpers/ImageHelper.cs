using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Kontur.ImageTransformer.Infrastucture.Helpers
{
    internal static class ImageHelper
    {
        public static byte[] ToBytes(this Image image, ImageFormat format)
        {
            using (var stream = new MemoryStream())
            {
                image.Save(stream, format);
                stream.Position = 0;
                return stream.ToArray();
            }
        }
    }
}
