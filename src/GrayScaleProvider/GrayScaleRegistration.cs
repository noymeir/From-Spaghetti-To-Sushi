using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ImageProviderContract;

namespace GrayScaleProvider
{
    class GrayScaleRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GrayScale>()
           .As<IImgProvider>()
           .SingleInstance();
        }
    }
}
