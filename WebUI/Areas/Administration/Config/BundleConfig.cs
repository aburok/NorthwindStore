using System.Web.Optimization;

namespace NorthwindStore.WebUI.Areas.Administration.Config
{
    public class BundleConfig
    {

        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // NOTE : Names need to be in separate file to be loaded first
            bundles.Add(new ScriptBundle("~/bundles/admin/common")
                .Include("~/Areas/Administration/Common/Scripts/*.js"));

            bundles.Add(new NameConventionOrderedBundle("~/bundles/product")
                .Include("~/Areas/Administration/Product/Scripts/*.js"));

            bundles.Add(new NameConventionOrderedBundle("~/bundles/company")
                .Include("~/Areas/Administration/Company/Scripts/*.js"));

            bundles.Add(new NameConventionOrderedBundle("~/bundles/order")
                .Include("~/Areas/Administration/Order/Scripts/*.js"));
        }
    }
}