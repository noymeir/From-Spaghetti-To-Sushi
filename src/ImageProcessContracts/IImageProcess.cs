using System;

namespace ImageProcessContracts
{
    public interface IImageProcess
    {
        void ProcessImg(string dest, string path);
    }
}
