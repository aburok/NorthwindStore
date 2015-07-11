using System;
using System.Web.Optimization;

namespace NorthwindStore.WebUI.Areas.Administration.Config
{
    public sealed class OrderedBundle : ScriptBundle
    {
        private Lazy<ScriptsOrder> Order = new Lazy<ScriptsOrder>();

        public override IBundleOrderer Orderer
        {
            get { return Order.Value; }
        }

        public OrderedBundle(string virtualPath) : base(virtualPath) { }

        public OrderedBundle(string virtualPath, string cdnPath) : base(virtualPath, cdnPath) { }
    }
}