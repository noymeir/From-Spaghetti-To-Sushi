using System;
using System.IO;
using System.Threading.Tasks;

namespace ImageProviderContract
{
    public interface IImgProvider
    {
        Task ChangeImg(Stream photoStream);
    }
}
