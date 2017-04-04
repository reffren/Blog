using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wexplorer.Data.Abstract;
using Wexplorer.Data.Concrete;

namespace Wexplorer.Web.Infrastructure
{
    public class NinjectFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            ninjectKernel.Bind<IBlogRepository>().To<BlogRepository>();
        }
    }
}