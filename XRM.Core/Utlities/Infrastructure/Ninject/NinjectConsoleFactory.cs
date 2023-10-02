using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRM.Core.Utlities.Infrastructure.Ninject
{
    public class NinjectConsoleFactory
    {
        IKernel kernel;
        public NinjectConsoleFactory(params INinjectModule[] modules)
        {
            kernel = new StandardKernel(modules);
        }
        public IKernel GetKernel()
        {
            return kernel?? throw new InvalidOperationException("No Kernel Is empty");
        }

    }
}
