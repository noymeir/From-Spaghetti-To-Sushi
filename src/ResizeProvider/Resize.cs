using System;
using System.IO;
using System.Threading.Tasks;
using ImageProviderContract;
using ImageSharp;
namespace ResizeProvider
{
    public class Resize : IImgProvider
    {
        public async Task ChangeImg(Stream photoStream)
        {
            Image img = new Image(photoStream);
            img.Resize(new Size(600, 600));
        }
    }
}
