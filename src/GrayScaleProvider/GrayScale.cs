using System;
using System.IO;
using System.Threading.Tasks;
using ImageProviderContract;
using ImageSharp;

namespace GrayScaleProvider
{
    public class GrayScale : IImgProvider
    {
        public async Task ChangeImg(Stream photoStream)
        {
            Image img = new Image(photoStream);
            img.Grayscale();
        }
    }
}
