﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    
    #line 2 "..\..\Views\Shared\DisplayTemplates\SiteMapPath.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Decision.Common.MVC;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/SiteMapPath.cshtml")]
    public partial class _Views_Shared_DisplayTemplates_SiteMapPath_cshtml_ : System.Web.Mvc.WebViewPage<SiteMapPathHelperModel>
    {
        public _Views_Shared_DisplayTemplates_SiteMapPath_cshtml_()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<ol");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n");

            
            #line 5 "..\..\Views\Shared\DisplayTemplates\SiteMapPath.cshtml"
    
            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\Shared\DisplayTemplates\SiteMapPath.cshtml"
     foreach (var node in Model)
    {
        if (node == Model.Last())
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Shared\DisplayTemplates\SiteMapPath.cshtml"
                          Write(Html.DisplayFor(m => node));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 10 "..\..\Views\Shared\DisplayTemplates\SiteMapPath.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n");

WriteLiteral("                ");

            
            #line 14 "..\..\Views\Shared\DisplayTemplates\SiteMapPath.cshtml"
           Write(Html.DisplayFor(m => node));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n");

            
            #line 16 "..\..\Views\Shared\DisplayTemplates\SiteMapPath.cshtml"
        }

    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</ol>");

        }
    }
}
#pragma warning restore 1591
