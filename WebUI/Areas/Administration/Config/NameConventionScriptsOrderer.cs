using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace NorthwindStore.WebUI.Areas.Administration.Config
{
    public class NameConventionScriptsOrderer : IBundleOrderer
    {
        private class OrderedBundleFile
        {
            public OrderedBundleFile(int order, BundleFile file)
            {
                Order = order;
                File = file;
            }

            public int Order { get; private set; }
            public BundleFile File { get; private set; }
        }

        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            var repositories = files
                .Select(f =>
                {
                    var name = f.VirtualFile.Name;
                    var order = 1000;

                    if (name.EndsWith("Repository.js"))
                    {
                        order = 100;
                    }
                    else if (name.EndsWith("Controller.js"))
                    {
                        order = 200;
                    }
                    else if (name.EndsWith("Module.js"))
                    {
                        order = 300;
                    }

                    return new OrderedBundleFile(order, f);
                })
                .OrderBy(o => o.Order)
                .ThenBy(o => o.File.VirtualFile.Name)
                .Select(o => o.File);

            return repositories;
        }
    }
}