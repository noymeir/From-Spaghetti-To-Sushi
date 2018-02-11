using System;
using Autofac;
using LogicContract;
using ImageProcessorRe4;
using LogicModuleRe4;
using BlurProvider;
using Model;
using System.Diagnostics;

namespace Host_Re4
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Register();
            ILogic logic = container.Resolve<ILogic>();
            Args param = new Args(@"Images\Src", @"Images\dest");
            var sw = Stopwatch.StartNew();
            logic.StartIoProcess(param);
            sw.Stop();
            Console.WriteLine($"Done: {sw.Elapsed}");
            Console.ReadKey();
        }
        private static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<>();
            var container = builder.Build();
            return container;
        }
    }
}