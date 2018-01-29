using System;
using System.IO;
using LogicContracts;
using ImageProcessContracts;


namespace LogicModule
{
    public class Logic : Ilogic
    {
        private IImageProcess imageProcessor;
        public Logic(IImageProcess imgProcess)
        {
            this.imageProcessor = imgProcess;
        }
        public void GetSrcAndDestDirectory(string[] args)
        {
            var argsParser = new CommandLineParserNuget.CommandLineParserNuget(args);
            string src = argsParser["src"];
            string dest = argsParser["dest"];
            dest = Path.Combine(AppContext.BaseDirectory,
                                dest,
                                DateTime.Now.ToString("HH-mm-ss"));
            if (!Directory.Exists(dest))
                Directory.CreateDirectory(dest);

            var paths = Directory.GetFiles(src);
            foreach (var path in paths)
            {
               imageProcessor.ProcessImg(dest, path);
            }
        }
    }
}
