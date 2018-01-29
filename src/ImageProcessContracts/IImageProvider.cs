using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessContracts
{
    public interface IImageProvider
    {
        void ProcessImgInGreyScale(string dest, string path);
    }
}
