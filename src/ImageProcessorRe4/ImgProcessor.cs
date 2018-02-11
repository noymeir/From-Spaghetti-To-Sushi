using System;
using ImageProviderContract;
using ImageProcessContract;
using System.IO;
using System.Threading.Tasks;

namespace ImageProcessorRe4
{
    public class ImgProcessor : IImageProcessor
    {
        private IImgProvider[] imgProviders;

        public ImgProcessor(IImgProvider[] providers)
        {
            imgProviders = providers;
        }

        public async Task ProcessImg(Stream imageStream)
        {
            foreach (var provider in imgProviders)
            {
              await provider.ChangeImg(imageStream);
            }
        }
    }
}
