using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using LogicContract;

namespace LogicModuleRe4
{
    class LogicRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Logic>()
           .As<ILogic>()
           .SingleInstance();
        }
    }
}
