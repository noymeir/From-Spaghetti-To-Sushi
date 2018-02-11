using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using SaveContract;

namespace SaveProvider
{
    class Saver : ISaveable
    {
        public Task<bool> Save(Stream streamArray, string dest)
        {
            throw new NotImplementedException();
        }
    }
}
