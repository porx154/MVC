using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SANGUINARIOS
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
                //usando bundles para las hojas de estilo
                bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                "~/Content/node_modules/font-awesome/css/font-awesome.min.css",
                "~/Content/node_modules/perfect-scrollbar/dist/css/perfect-scrollbar.min.css",
                "~/Content/node_modules/flag-icon-css/css/flag-icon.min.css",
                "~/Content/css/style.css",
                "~/Content/css/style-menu.css"));


 

                bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
                "~/Content/node_modules/jquery/dist/jquery.min.js",
                "~/Content/node_modules/popper.js/dist/umd/popper.min.js",
                "~/Content/node_modules/bootstrap/dist/js/bootstrap.min.js",
                "~/Content/node_modules/chart.js/dist/Chart.min.js",
                "~/Content/node_modules/perfect-scrollbar/dist/js/perfect-scrollbar.jquery.min.js",
                "~/Content/js/off-canvas.js",
                "~/Content/js/hoverable-collapse.js",
                "~/Content/js/misc.js",
                "~/Content/js/chart.js",
                "~/Content/js/maps.js"));
        }

    }
}