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
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WorkExperience/_WorkExperienceItem.cshtml")]
    public partial class _Views_WorkExperience__WorkExperienceItem_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.WorkExperience.WorkExperienceViewModel>
    {
        public _Views_WorkExperience__WorkExperienceItem_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-12 \"");

WriteAttribute("id", Tuple.Create(" id=\"", 89), Tuple.Create("\"", 118)
, Tuple.Create(Tuple.Create("", 94), Tuple.Create("workExperience-", 94), true)
            
            #line 2 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
, Tuple.Create(Tuple.Create("", 109), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 109), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n      \r\n        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-calendar-o\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">آغاز کار:</label>\r\n                    <small>");

            
            #line 10 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.TenureBeginDate.ToPersianString(PersianDateTimeFormat.Date));

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-calendar\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">پایان کار :</label>\r\n                    <small>");

            
            #line 15 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.TenureEndDate.ToPersianString(PersianDateTimeFormat.Date));

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-folder\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        تعداد طرحهای متوقف‌شده:\r\n                    </label>\r" +
"\n                    <small>");

            
            #line 22 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.ReferentialProjectCount.GetPersianNumber());

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-folder-o\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        تعداد طرحهای انجام‌شده:\r\n                    </label>\r" +
"\n                    <small>");

            
            #line 29 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.ClosedProjectCount.GetPersianNumber());

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-folder-open-o\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        تعداد طرحهای جاری:\r\n                    </label>\r\n    " +
"                <small>");

            
            #line 38 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.OpenProjectCount);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-check-square-o\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        نوع مشارکت:\r\n                    </label>\r\n           " +
"         <small>");

            
            #line 45 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Html.DisplayFor(a=>a.CooperationType));

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-location-arrow\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        استان محل خدمت:\r\n                    </label>\r\n       " +
"             <small>");

            
            #line 52 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.State);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-map-marker\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                         شهر محل خدمت:\r\n                    </label>\r\n        " +
"            <small>");

            
            #line 59 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.City);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-building\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                          پست سازمانی :\r\n                    </label>\r\n       " +
"             <small>");

            
            #line 68 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.TitleName);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-building-o\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        اداره محل خدمت:\r\n                    </label>\r\n       " +
"             <small>");

            
            #line 75 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                      Write(Model.OfficeName);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n");

            
            #line 78 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
            
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
              Html.RenderPartial(MVC.Shared.Views._AuditLog, Model);
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"panel-footer \"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"btn btn-primary btn-sm\"");

WriteLiteral(" data-ajax-oncomplete=\"editGetOnComplete(xhr,status)\"");

WriteLiteral("\r\n                   data-ajax=\"true\"");

WriteLiteral(" data-ajax-method=\"GET\"");

WriteLiteral("\r\n                   data-ajax-begin=\"onBegin(xhr,this)\"");

WriteLiteral("\r\n                   data-ajax-mode=\"REPLACE-WITH\"");

WriteLiteral(" data-ajax-success=\"inlineEditGetOnSuccess(data, status, xhr,\'");

            
            #line 85 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                                                                                                         Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\')\"");

WriteLiteral("\r\n                   data-ajax-update=\"#workExperience-");

            
            #line 86 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                                                Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("href", Tuple.Create("\r\n                   href=\"", 3913), Tuple.Create("\"", 3986)
            
            #line 87 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
, Tuple.Create(Tuple.Create("", 3940), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.WorkExperience.Edit(Model.Id))
            
            #line default
            #line hidden
, 3940), false)
);

WriteLiteral(" role=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-edit\"");

WriteLiteral("></i>ویرایش</a>\r\n\r\n                <button");

WriteLiteral(" class=\"btn-sm btn btn-danger\"");

WriteLiteral("\r\n                        type=\"button\"");

WriteLiteral(" data-delete-url=\"");

            
            #line 90 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                                                  Write(Url.Action(MVC.WorkExperience.Delete()));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-Teacher=\"");

            
            #line 90 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                                                                                                          Write(Model.TeacherId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-removal-element=\"#workExperience-");

            
            #line 90 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                                                                                                                                                                  Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("id", Tuple.Create(" id=\"", 4274), Tuple.Create("\"", 4295)
, Tuple.Create(Tuple.Create("", 4279), Tuple.Create("remove-", 4279), true)
            
            #line 90 "..\..\Views\WorkExperience\_WorkExperienceItem.cshtml"
                                                                                                             , Tuple.Create(Tuple.Create("", 4286), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 4286), false)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral("></i>\r\n                    حذف\r\n                </button>\r\n            </div>\r\n  " +
"          <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
