using Autofac;
using System;
using System.Diagnostics;
using LogicContracts;
using LogicModule;
using ImageProcessContracts;
using ImageModule;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Register();
            Ilogic logic = container.Resolve<Ilogic>();
            var sw = Stopwatch.StartNew();
            logic.GetSrcAndDestDirectory(args);
            sw.Stop();
            Console.WriteLine($"Done: {sw.Elapsed}");
            Console.ReadKey();
        }
        private static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ImageProcessor>()
                    .As<IImageProcess>()
                    .SingleInstance();
            builder.RegisterType<Logic>()
                    .As<Ilogic>()
                    .SingleInstance();
            builder.RegisterType<ImageProvider.ImageProvider>()
                .As<IImageProvider>()
                .SingleInstance();
            var container = builder.Build();
            return container;
        }

    }
}