﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace YRS.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Js").Include(
                      "~/Content/plugins/jQuery/jquery-2.2.3.min.js",
                      "~/Content/bootstrap/js/bootstrap.min.js",
                      "~/Content/plugins/slimScroll/jquery.slimscroll.min.js",
                      "~/Content/plugins/fastclick/fastclick.js",
                      "~/Content/dist/js/app.min.js",
                      "~/Content/dist/js/demo.js"
                      ));

            bundles.Add(new StyleBundle("~/Css").Include(
                      "~/Content/bootstrap/css/bootstrap.min.css",
                      "~/Content/dist/css/AdminLTE.min.css",
                      "~/Content/dist/css/skins/_all-skins.min.css",
                      "~/Content/dist/css/AdminLTE.min.css"
                      ));

            BundleTable.EnableOptimizations = true;
        }
    }
}







//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;

//// General Information about an assembly is controlled through the following 
//// set of attributes. Change these attribute values to modify the information
//// associated with an assembly.
//[assembly: AssemblyTitle("YRS.App_Start")]
//[assembly: AssemblyDescription("")]
//[assembly: AssemblyConfiguration("")]
//[assembly: AssemblyCompany("")]
//[assembly: AssemblyProduct("YRS.App_Start")]
//[assembly: AssemblyCopyright("Copyright ©  2018")]
//[assembly: AssemblyTrademark("")]
//[assembly: AssemblyCulture("")]

//// Setting ComVisible to false makes the types in this assembly not visible 
//// to COM components.  If you need to access a type in this assembly from 
//// COM, set the ComVisible attribute to true on that type.
//[assembly: ComVisible(false)]

//// The following GUID is for the ID of the typelib if this project is exposed to COM
//[assembly: Guid("7817ebda-f234-4947-a4b3-fa3226fc56ae")]

//// Version information for an assembly consists of the following four values:
////
////      Major Version
////      Minor Version 
////      Build Number
////      Revision
////
//[assembly: AssemblyVersion("1.0.0.0")]
//[assembly: AssemblyFileVersion("1.0.0.0")]
