using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ImageProcessContract;

namespace ImageProcessorRe4
{
    class ImgProcessorRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ImgProcessor>()
           .As<IImageProcessor>()
           .SingleInstance();
        }
    }
}
