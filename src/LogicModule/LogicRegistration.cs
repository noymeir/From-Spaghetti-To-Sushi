using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using LogicContracts;

namespace LogicModule
{
    public class LogicRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Logic>()
        .As<Ilogic>()
        .SingleInstance();
        }
    }
}
