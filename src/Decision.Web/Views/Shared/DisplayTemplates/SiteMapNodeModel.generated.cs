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
    
    #line 2 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
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
    
    #line 3 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
    using MvcSiteMapProvider.Web.Html.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/SiteMapNodeModel.cshtml")]
    public partial class _Views_Shared_DisplayTemplates_SiteMapNodeModel_cshtml_ : System.Web.Mvc.WebViewPage<MvcSiteMapProvider.Web.Html.Models.SiteMapNodeModel>
    {
        public _Views_Shared_DisplayTemplates_SiteMapNodeModel_cshtml_()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
 if (Model.IsCurrentNode && Model.SourceMetadata["HtmlHelper"].ToString() != "MvcSiteMapProvider.Web.Html.MenuHelper")  { 

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 6 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
     Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
} else if (Model.IsClickable) { 
    if (string.IsNullOrEmpty(Model.Description))
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 389), Tuple.Create("\"", 406)
            
            #line 10 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
, Tuple.Create(Tuple.Create("", 396), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 396), false)
);

WriteLiteral(">");

            
            #line 10 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
                        Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 11 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 460), Tuple.Create("\"", 477)
            
            #line 14 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
, Tuple.Create(Tuple.Create("", 467), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 467), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 478), Tuple.Create("\"", 504)
            
            #line 14 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
, Tuple.Create(Tuple.Create("", 486), Tuple.Create<System.Object, System.Int32>(Model.Description
            
            #line default
            #line hidden
, 486), false)
);

WriteLiteral(">");

            
            #line 14 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
                                                   Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 15 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
    }
} else { 

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 17 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
     Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 18 "..\..\Views\Shared\DisplayTemplates\SiteMapNodeModel.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
