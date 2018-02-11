using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using LoadContract;

namespace LoadProvider
{
    class LoadRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Loader>()
           .As<ILoader>()
           .SingleInstance();
        }
    }
}
