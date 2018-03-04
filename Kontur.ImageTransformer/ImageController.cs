
using System.Drawing;
using Kontur.ImageTransformer.Infrastucture.Attributes;
using Kontur.ImageTransformer.Infrastucture.Exceptions;

namespace Kontur.ImageTransformer
{
    internal class ImageController
    {
        private const int MaxImageSize = 1000;

        [Route("rotate-cw")]
        public Image RotateClockwise(int x, int y, int weight, int height, Image image)
        {
            ValidateImage(image);
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);  
            return image;
        }

        [Route("rotate-ccw")]
        public Image RotateCounterClockwise(int x, int y, int weight, int height, Image image)
        {
            ValidateImage(image);
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return image;
        }

        [Route("flip-v")]
        public Image FlipVertical(int x, int y, int weight, int height, Image image)
        {
            ValidateImage(image);
            image.RotateFlip(RotateFlipType.Rotate180FlipY);
            return image;
        }

        [Route("flip-h")]
        public Image FlipHorizontal(int x, int y, int weight, int height, Image image)
        {
            ValidateImage(image);
            image.RotateFlip(RotateFlipType.Rotate180FlipX);
            return image;
        }

        private static void ValidateImage(Image image)
        {
            if (image.Width > MaxImageSize || image.Height > MaxImageSize)
            {
                throw new ValidationServiceException("Размер изображения превышает максимальный");
            }
        }
    }
}
