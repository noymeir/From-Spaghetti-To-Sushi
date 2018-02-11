using System;
using System.IO;
using System.Threading.Tasks;

namespace ImageProcessContract
{
    public interface IImageProcessor
    {
        Task ProcessImg(Stream imageStream);
    }
}
