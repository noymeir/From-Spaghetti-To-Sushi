using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using SaveContract;

namespace SaveProvider
{
    class SaveRegistration:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Saver>()
           .As<ISaveable>()
           .SingleInstance();
        }
    }
}
