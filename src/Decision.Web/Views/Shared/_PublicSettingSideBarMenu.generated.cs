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
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Decision.Common.MVC;
    
    #line 1 "..\..\Views\Shared\_PublicSettingSideBarMenu.cshtml"
    using Decision.ServiceLayer.Security;
    
    #line default
    #line hidden
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_PublicSettingSideBarMenu.cshtml")]
    public partial class _Views_Shared__PublicSettingSideBarMenu_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__PublicSettingSideBarMenu_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\Shared\_PublicSettingSideBarMenu.cshtml"
Write(Html.SideBarSecureActionLink("مدیریت مراکز کارآموزی", Url.Action(MVC.TrainingCenter.List()), "list-group-item second-split", "fa fa-graduation-cap", AssignableToRolePermissions.CanManageTrainingCenter));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 5 "..\..\Views\Shared\_PublicSettingSideBarMenu.cshtml"
Write(Html.SideBarSecureActionLink("مدیریت عنوان ها", Url.Action(MVC.Title.List()), "list-group-item second-split", "fa fa-list-ul", AssignableToRolePermissions.CanManageTitle));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Shared\_PublicSettingSideBarMenu.cshtml"
Write(Html.SideBarSecureActionLink("مدیریت ارزش گذارن", Url.Action(MVC.Appraiser.List()), "list-group-item second-split", "fa fa-certificate", AssignableToRolePermissions.CanManageAppraiser));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Shared\_PublicSettingSideBarMenu.cshtml"
Write(Html.SideBarSecureActionLink("مدیریت مراکز آموزش عالی", Url.Action(MVC.Institution.List()), "list-group-item second-split", "fa fa-university", AssignableToRolePermissions.CanManageInstitution));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Shared\_PublicSettingSideBarMenu.cshtml"
Write(Html.SideBarSecureActionLink("مدیریت سوالات", Url.Action(MVC.Question.List()), "list-group-item second-split", "fa fa-list-ol", AssignableToRolePermissions.CanManageQuestion));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
