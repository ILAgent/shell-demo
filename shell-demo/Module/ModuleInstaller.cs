using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Contracts;
using Module.ViewModels;

namespace Module
{
    public class ModuleInstaller:IWindsorInstaller 
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
                .Register(Component.For<FirstViewModel>())
                .Register(Component.For<SecondViewModel>())
                .Register(Component.For<IModule>().ImplementedBy<ModuleImpl>());
        }
    }
}
