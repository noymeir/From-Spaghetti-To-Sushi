﻿using Autofac;
using System;
using System.Diagnostics;
using LogicContracts;
using LogicModule;
using ImageProcessContracts;
using ImageModule;
using ImageProvider;
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
            builder.RegisterModule<ImageProcessorRegistration>();
            builder.RegisterModule<LogicRegistration>();
            builder.RegisterModule<ImageProviderRegistration>();

            var container = builder.Build();
            return container;
        }

    }
}