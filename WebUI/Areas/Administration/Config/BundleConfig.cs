using System.Web.Optimization;

namespace NorthwindStore.WebUI.Areas.Administration.Config
{
    public class BundleConfig
    {

        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/product").Include(
                        "~/Areas/Administration/Product/Scripts/*.js"));
        }
    }
}