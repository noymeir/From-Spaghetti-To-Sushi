using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ImageProviderContract;

namespace BlurProvider
{
    class BlurRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Blur>()
           .As<IImgProvider>()
           .SingleInstance();
        }
    }
}
