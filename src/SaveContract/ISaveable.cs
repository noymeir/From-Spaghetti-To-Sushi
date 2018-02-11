using System;
using System.IO;
using System.Threading.Tasks;

namespace SaveContract
{
    public interface ISaveable
    {
        Task<bool> Save(Stream streamArray, string dest);
    }
}
