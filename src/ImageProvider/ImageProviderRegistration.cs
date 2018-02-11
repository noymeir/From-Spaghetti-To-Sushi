using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ImageProcessContracts;

namespace ImageProvider
{
    public class ImageProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ImageProvider>()
    .As<IImageProvider>()
    .SingleInstance();
        }
    }
}
