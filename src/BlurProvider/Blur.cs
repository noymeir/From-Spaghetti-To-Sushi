using System;
using System.IO;
using System.Threading.Tasks;
using ImageProviderContract;

namespace BlurProvider
{
    public class Blur : IImgProvider
    {
        public Task ChangeImg(Stream photoStream)
        {
            throw new NotImplementedException();
        }
    }
}
