using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using Castle.Core.Internal;
using Castle.Windsor;
using Shell.ViewModels;

namespace Shell
{
    public class ShellBootstrapper : BootstrapperBase
    {
        private readonly IWindsorContainer _container = new WindsorContainer();

        public ShellBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            var loader = _container.Resolve<ModuleLoader>();

            var exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var pattern = "*.dll";

            Directory
                .GetFiles(exeDir, pattern)
                .Select(Assembly.LoadFrom)
                .Select(loader.LoadModule)
                .Where(module => module != null)
                .ForEach(module => module.Init());

            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void Configure()
        {
            _container.Install(new ShellInstaller());
        }

        protected override object GetInstance(Type service, string key)
        {
            return string.IsNullOrWhiteSpace(key)

                ? _container.Kernel.HasComponent(service)
                    ? _container.Resolve(service)
                    : base.GetInstance(service, key)

                : _container.Kernel.HasComponent(key)
                    ? _container.Resolve(key, service)
                    : base.GetInstance(service, key);
        }
    }
}
