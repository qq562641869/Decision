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
    
    #line 1 "..\..\Views\Role\_Edit.cshtml"
    using Decision.Common.Helpers;
    
    #line default
    #line hidden
    using Decision.Common.MVC;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Role/_Edit.cshtml")]
    public partial class _Views_Role__Edit_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.Role.EditRoleViewModel>
    {
        public _Views_Role__Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-12\"");

WriteAttribute("id", Tuple.Create(" id=\"", 106), Tuple.Create("\"", 125)
, Tuple.Create(Tuple.Create("", 111), Tuple.Create("role-", 111), true)
            
            #line 4 "..\..\Views\Role\_Edit.cshtml"
, Tuple.Create(Tuple.Create("", 116), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 116), false)
);

WriteLiteral(">\r\n");

            
            #line 5 "..\..\Views\Role\_Edit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\Role\_Edit.cshtml"
     using (Ajax.BeginForm(MVC.Role.Edit(), new AjaxOptions { HttpMethod = "POST", OnComplete = "editOnComplete(xhr, status, '" + Model.Id + "','#editButton" + Model.Id + "')" }, new { @class = "form-horizontal", id = Model.Id, autocomplete = "off", data_ajax_update = "role-" + Model.Id }))
    {
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Role\_Edit.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Role\_Edit.cshtml"
                                
        
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Role\_Edit.cshtml"
   Write(Html.HiddenFor(a => a.Id));

            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Role\_Edit.cshtml"
                                  


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-5\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 14 "..\..\Views\Role\_Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control", autocomplete = "off", placeholder = "نام گروه" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 15 "..\..\Views\Role\_Edit.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n                <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                            <ul");

WriteLiteral(" class=\"list-group row margin-bottom-0\"");

WriteLiteral(">\r\n");

            
            #line 23 "..\..\Views\Role\_Edit.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Role\_Edit.cshtml"
                                 foreach (var p in Model.Permissions)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li");

WriteLiteral(" class=\"list-group-item non-border col-xs-6 text-primary\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ");

            
            #line 27 "..\..\Views\Role\_Edit.cshtml"
                                                                        if (p.Selected) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" checked=\"checked\" ");

WriteLiteral("     ");

            
            #line 27 "..\..\Views\Role\_Edit.cshtml"
                                                                                                                               }

            
            #line default
            #line hidden
WriteLiteral("                                                       id=\"");

            
            #line 28 "..\..\Views\Role\_Edit.cshtml"
                                                      Write(p.Value);

            
            #line default
            #line hidden
WriteLiteral("\" name=\"PermissionNames\" value=\"");

            
            #line 28 "..\..\Views\Role\_Edit.cshtml"
                                                                                              Write(p.Value);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"checkbox-inline\" />\r\n                                            <label");

WriteLiteral(" class=\"control-label\"");

WriteAttribute("for", Tuple.Create(" for=\"", 1801), Tuple.Create("\"", 1815)
            
            #line 29 "..\..\Views\Role\_Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1807), Tuple.Create<System.Object, System.Int32>(p.Value
            
            #line default
            #line hidden
, 1807), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\Views\Role\_Edit.cshtml"
                                                                                   Write(p.Text);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                        </div>\r\n                       " +
"             </li>\r\n");

            
            #line 32 "..\..\Views\Role\_Edit.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n              " +
"      </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"panel-footer block\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" type=\"button\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2219), Tuple.Create("\"", 2250)
            
            #line 39 "..\..\Views\Role\_Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2224), Tuple.Create<System.Object, System.Int32>($"editButton{Model.Id}"
            
            #line default
            #line hidden
, 2224), false)
);

WriteLiteral(" autocomplete=\"off\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 2270), Tuple.Create("\"", 2320)
, Tuple.Create(Tuple.Create("", 2280), Tuple.Create("AjaxForm.CustomSubmit(this,", 2280), true)
, Tuple.Create(Tuple.Create(" ", 2307), Tuple.Create("\'", 2308), true)
            
            #line 39 "..\..\Views\Role\_Edit.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 2309), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 2309), false)
, Tuple.Create(Tuple.Create("", 2318), Tuple.Create("\')", 2318), true)
);

WriteLiteral(" data-loading-text=\"در حال ارسال اطلاعات\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-check-square-o\"");

WriteLiteral("></i>\r\n                            ذخیره تغییرات\r\n                        </butto" +
"n>\r\n\r\n                        <a");

WriteLiteral(" class=\"btn btn-default btn-sm\"");

WriteLiteral(" data-ajax=\"true\"");

WriteLiteral("\r\n                           data-ajax-mode=\"REPLACE-WITH\"");

WriteLiteral(" data-ajax-complete=\"cancelEditOnComplete(xhr, status)\"");

WriteLiteral("\r\n                           data-ajax-update=\"#role-");

            
            #line 46 "..\..\Views\Role\_Edit.cshtml"
                                              Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-ajax-method=\"POST\"");

WriteAttribute("href", Tuple.Create("\r\n                           href=\"", 2816), Tuple.Create("\"", 2893)
            
            #line 47 "..\..\Views\Role\_Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2851), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Role.CancelEdit(Model.Id))
            
            #line default
            #line hidden
, 2851), false)
);

WriteLiteral(" role=\"button\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-arrow-right\"");

WriteLiteral("></i>\r\n                            انصراف\r\n                        </a>\r\n        " +
"            </div>\r\n                    <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 55 "..\..\Views\Role\_Edit.cshtml"

    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
