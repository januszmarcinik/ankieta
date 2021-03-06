﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly AccountClass s_Account = new AccountClass();
    public static AccountClass Account { get { return s_Account; } }
    static readonly AdminClass s_Admin = new AdminClass();
    public static AdminClass Admin { get { return s_Admin; } }
    static readonly ApplicationClass s_Application = new ApplicationClass();
    public static ApplicationClass Application { get { return s_Application; } }
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class AccountClass
    {
        public readonly string Name = "Account";
        public JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.AccountController Account = new JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.T4MVC_AccountController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.ImageController Image = new JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.T4MVC_ImageController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.ManageController Manage = new JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.T4MVC_ManageController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.RolesController Roles = new JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.T4MVC_RolesController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.UsersController Users = new JanuszMarcinik.Mvc.WebUI.Areas.Account.Controllers.T4MVC_UsersController();
        public T4MVC.Account.SharedController Shared = new T4MVC.Account.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class AdminClass
    {
        public readonly string Name = "Admin";
        public JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.AnswersController Answers = new JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.T4MVC_AnswersController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.CategoriesController Categories = new JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.T4MVC_CategoriesController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.ConfigurationController Configuration = new JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.T4MVC_ConfigurationController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.DictionariesController Dictionaries = new JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.T4MVC_DictionariesController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.IntervieweesController Interviewees = new JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.T4MVC_IntervieweesController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.QuestionnairesController Questionnaires = new JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.T4MVC_QuestionnairesController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.QuestionsController Questions = new JanuszMarcinik.Mvc.WebUI.Areas.Admin.Controllers.T4MVC_QuestionsController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class ApplicationClass
    {
        public readonly string Name = "Application";
        public JanuszMarcinik.Mvc.WebUI.Areas.Application.Controllers.HomeController Home = new JanuszMarcinik.Mvc.WebUI.Areas.Application.Controllers.T4MVC_HomeController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Application.Controllers.ResultsController Results = new JanuszMarcinik.Mvc.WebUI.Areas.Application.Controllers.T4MVC_ResultsController();
        public JanuszMarcinik.Mvc.WebUI.Areas.Application.Controllers.SurveyController Survey = new JanuszMarcinik.Mvc.WebUI.Areas.Application.Controllers.T4MVC_SurveyController();
        public T4MVC.Application.SharedController Shared = new T4MVC.Application.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_PartialViewResult : System.Web.Mvc.PartialViewResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_PartialViewResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        public const string UrlPath = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string application_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/application.min.js") ? Url("application.min.js") : Url("application.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string highcharts_exporting_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/highcharts.exporting.min.js") ? Url("highcharts.exporting.min.js") : Url("highcharts.exporting.js");
        public static readonly string highcharts_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/highcharts.src.min.js") ? Url("highcharts.src.min.js") : Url("highcharts.src.js");
        public static readonly string jquery_3_1_1_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.1.1.intellisense.min.js") ? Url("jquery-3.1.1.intellisense.min.js") : Url("jquery-3.1.1.intellisense.js");
        public static readonly string jquery_3_1_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.1.1.min.js") ? Url("jquery-3.1.1.min.js") : Url("jquery-3.1.1.js");
        public static readonly string jquery_3_1_1_min_js = Url("jquery-3.1.1.min.js");
        public static readonly string jquery_3_1_1_min_map = Url("jquery-3.1.1.min.map");
        public static readonly string jquery_3_1_1_slim_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.1.1.slim.min.js") ? Url("jquery-3.1.1.slim.min.js") : Url("jquery-3.1.1.slim.js");
        public static readonly string jquery_3_1_1_slim_min_js = Url("jquery-3.1.1.slim.min.js");
        public static readonly string jquery_3_1_1_slim_min_map = Url("jquery-3.1.1.slim.min.map");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string modernizr_2_8_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/modernizr-2.8.3.min.js") ? Url("modernizr-2.8.3.min.js") : Url("modernizr-2.8.3.js");
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_min_js = Url("respond.min.js");
        public static readonly string TwitterBootstrapMvcJs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/TwitterBootstrapMvcJs.min.js") ? Url("TwitterBootstrapMvcJs.min.js") : Url("TwitterBootstrapMvcJs.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        public const string UrlPath = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
        public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
        public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        public static readonly string font_awesome_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/font-awesome.min.css") ? Url("font-awesome.min.css") : Url("font-awesome.css");
        public static readonly string font_awesome_min_css = Url("font-awesome.min.css");
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static class Assets
            {
                public const string _references_js = "~/Scripts/_references.js"; 
                public const string application_js = "~/Scripts/application.js"; 
                public const string bootstrap_js = "~/Scripts/bootstrap.js"; 
                public const string bootstrap_min_js = "~/Scripts/bootstrap.min.js"; 
                public const string highcharts_exporting_js = "~/Scripts/highcharts.exporting.js"; 
                public const string highcharts_src_js = "~/Scripts/highcharts.src.js"; 
                public const string jquery_3_1_1_intellisense_js = "~/Scripts/jquery-3.1.1.intellisense.js"; 
                public const string jquery_3_1_1_js = "~/Scripts/jquery-3.1.1.js"; 
                public const string jquery_3_1_1_min_js = "~/Scripts/jquery-3.1.1.min.js"; 
                public const string jquery_3_1_1_slim_js = "~/Scripts/jquery-3.1.1.slim.js"; 
                public const string jquery_3_1_1_slim_min_js = "~/Scripts/jquery-3.1.1.slim.min.js"; 
                public const string jquery_validate_js = "~/Scripts/jquery.validate.js"; 
                public const string jquery_validate_min_js = "~/Scripts/jquery.validate.min.js"; 
                public const string jquery_validate_unobtrusive_js = "~/Scripts/jquery.validate.unobtrusive.js"; 
                public const string jquery_validate_unobtrusive_min_js = "~/Scripts/jquery.validate.unobtrusive.min.js"; 
                public const string modernizr_2_8_3_js = "~/Scripts/modernizr-2.8.3.js"; 
                public const string respond_js = "~/Scripts/respond.js"; 
                public const string respond_min_js = "~/Scripts/respond.min.js"; 
                public const string TwitterBootstrapMvcJs_js = "~/Scripts/TwitterBootstrapMvcJs.js"; 
            }
        }
        public static partial class Content 
        {
            public static class Assets
            {
                public const string bootstrap_theme_css = "~/Content/bootstrap-theme.css";
                public const string bootstrap_theme_min_css = "~/Content/bootstrap-theme.min.css";
                public const string bootstrap_css = "~/Content/bootstrap.css";
                public const string bootstrap_min_css = "~/Content/bootstrap.min.css";
                public const string font_awesome_css = "~/Content/font-awesome.css";
                public const string font_awesome_min_css = "~/Content/font-awesome.min.css";
                public const string Site_css = "~/Content/Site.css";
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


