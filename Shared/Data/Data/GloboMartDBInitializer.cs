using GloboMart.Framwork.Interface.Data;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Data
{
    internal class GloboMartDBInitializer : DropCreateDatabaseIfModelChanges<GloboMartContext>
    {
        protected override void Seed(GloboMartContext context)
        {
            new DatabaseDefaultEntries(context).Execute();

            base.Seed(context);
        }
    }
}
