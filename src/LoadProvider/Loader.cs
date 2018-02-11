using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LoadContract;
using System.Threading.Tasks;

namespace LoadProvider
{
    class Loader : ILoader
    {
        public async Task<Stream> Load(string path)
        {
            using (Stream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                var bytes = File.ReadAllBytes(path);
                await fs.WriteAsync(bytes, 0, (int)fs.Length);
                return fs;
            }
        }
    }
}
