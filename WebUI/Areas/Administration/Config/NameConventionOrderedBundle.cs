using System;
using System.Web.Optimization;

namespace NorthwindStore.WebUI.Areas.Administration.Config
{
    public sealed class NameConventionOrderedBundle : ScriptBundle
    {
        private Lazy<NameConventionScriptsOrderer> Order = new Lazy<NameConventionScriptsOrderer>();

        public override IBundleOrderer Orderer
        {
            get { return Order.Value; }
        }

        public NameConventionOrderedBundle(string virtualPath) : base(virtualPath) { }

        public NameConventionOrderedBundle(string virtualPath, string cdnPath) : base(virtualPath, cdnPath) { }
    }
}