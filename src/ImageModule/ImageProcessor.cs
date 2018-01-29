using System;
using ImageProcessContracts;

namespace ImageModule
{
    public class ImageProcessor : IImageProcess
    {
        private IImageProvider imageProvider;
        public ImageProcessor(IImageProvider provider)
        {
            this.imageProvider = provider;
        }
        public void ProcessImg(string dest, string path)
        {
            imageProvider.ProcessImgInGreyScale(dest, path);
        }
    }
}
