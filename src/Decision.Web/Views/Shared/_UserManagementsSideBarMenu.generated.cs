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
    
    
    #line 1 "..\..\Views\Shared\_UserManagementsSideBarMenu.cshtml"
    using Decision.ServiceLayer.Security;
    
    #line default
    #line hidden
    using Decision.Utility;
    
    #line 2 "..\..\Views\Shared\_UserManagementsSideBarMenu.cshtml"
    using Decision.Web.HtmlHelpers;
    
    #line default
    #line hidden
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_UserManagementsSideBarMenu.cshtml")]
    public partial class _Views_Shared__UserManagementsSideBarMenu_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__UserManagementsSideBarMenu_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 5 "..\..\Views\Shared\_UserManagementsSideBarMenu.cshtml"
Write(Html.SideBarSecureActionLink("لیست کاربران", Url.Action(MVC.User.List()), "list-group-item second-split", "fa fa-user", AssignableToRolePermissions.CanManageUser));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Shared\_UserManagementsSideBarMenu.cshtml"
Write(Html.SideBarSecureActionLink("لیست گروه های کاربری", Url.Action(MVC.Role.List()), "list-group-item second-split", "fa fa-group", AssignableToRolePermissions.CanManageUser));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
