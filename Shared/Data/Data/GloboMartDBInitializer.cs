using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Data
{
    public class GloboMartDBInitializer : DropCreateDatabaseIfModelChanges<GloboMartContext>
    {
        protected override void Seed(GloboMartContext context)
        {
            DatabaseDefaultEntries.Execute();

            base.Seed(context);
        }
    }
}
