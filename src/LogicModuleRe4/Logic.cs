using System;
using LogicContract;
using ImageProcessContract;
using SaveContract;
using LoadContract;
using CommandLineParserNuget;
using System.IO;
using Model;

namespace LogicModuleRe4
{
    public class Logic : ILogic
    {
        private IImageProcessor imageProcessor;
        private ILoader loader;
        private ISaveable saver;

        public Logic(IImageProcessor imgProc, ILoader load, ISaveable save)
        {
            imageProcessor = imgProc;
            loader = load;
            saver = save;
        }

        public async void StartIoProcess(Args args)
        {
            var dest = Path.Combine(AppContext.BaseDirectory,
                                  args.Dest,
                                  DateTime.Now.ToString("HH-mm-ss"));
            if (!Directory.Exists(dest))
                Directory.CreateDirectory(dest);

            var paths = Directory.GetFiles(args.Src);
            foreach (var path in paths)
            {
                var stream = await loader.Load(path);
                string name = Path.GetFileName(path);
                string target = $@"{args.Dest}\{name}.jpg";
 
                using (var outStream = new FileStream(target, FileMode.Create))
                   await imageProcessor.ProcessImg(stream).ContinueWith(async (res) => await saver.Save(stream, args.Dest));
            }

               

        }
    }
}
