using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace XRM.Core.Utlities.Infrastructure.Ninject
{
    public class NinjectControllerFactory :DefaultControllerFactory
    {
        IKernel kernel;

        public NinjectControllerFactory (params INinjectModule[] modules)
        {
            kernel = new StandardKernel (modules);

        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }
    }
}
