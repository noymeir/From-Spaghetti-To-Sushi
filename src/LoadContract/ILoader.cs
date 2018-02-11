using System;
using System.IO;
using System.Threading.Tasks;

namespace LoadContract
{
    public interface ILoader
    {
       Task<Stream> Load(string path);
    }
}
