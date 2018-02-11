using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ImageProviderContract;

namespace ResizeProvider
{
    class ResizeRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Resize>()
           .As<IImgProvider>()
           .SingleInstance();
        }
    }
}
