using System;
using System.IO;
using ImageProcessContracts;
using ImageSharp;

namespace ImageProvider
{
    public class ImageProvider : IImageProvider
    {
        public void ProcessImgInGreyScale(string dest, string path)
        {
            byte[] photoBytes = File.ReadAllBytes(path);
            string name = Path.GetFileName(path);
            string target = $@"{dest}\{name}.jpg";

            using (var outStream = new FileStream(target, FileMode.Create))
            {
                var img = new Image(photoBytes);
                img.Resize(new Size(600, 600)).Grayscale().Save(outStream);
            }
        }
    }
}
