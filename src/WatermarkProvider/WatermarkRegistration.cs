using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ImageProviderContract;

namespace WatermarkProvider
{
    class WatermarkRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<WaterMark>()
           .As<IImgProvider>()
           .SingleInstance();
        }
    }
}
