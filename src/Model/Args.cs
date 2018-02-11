using System;

namespace Model
{
    public class Args
    {
        private string src;
        private string dest;
        public string Src { get; private set; }
        public string Dest { get; private set; }
        
        public Args(string source, string destination)
        {
            src = source;
            dest = destination;
        }
    }
}
