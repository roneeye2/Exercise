using GloboMart.Framwork.Interface;
using GloboMart.Framwork.Interface.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Business
{
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IModuleRegistrar registrar)
        {
            registrar.RegisterType<IProductDomain, ProductDomain>();
        }
    }
}
