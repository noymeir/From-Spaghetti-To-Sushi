using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ImageProcessContracts;

namespace ImageModule
{
    public class ImageProcessorRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ImageProcessor>()
           .As<IImageProcess>()
           .SingleInstance();
        }
    }
}
