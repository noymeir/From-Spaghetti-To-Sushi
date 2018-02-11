using System;
using System.IO;
using System.Threading.Tasks;
using ImageProviderContract;

namespace WatermarkProvider
{
    public class WaterMark : IImgProvider
    {
        public Task ChangeImg(Stream photoStream)
        {
            throw new NotImplementedException();
        }
    }
}
