#pragma checksum "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Shared\_Notification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee11ecc1d04c42219d2d5eae9fccbcfd6a7eeb55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Notification), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Notification.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee11ecc1d04c42219d2d5eae9fccbcfd6a7eeb55", @"/Areas/Admin/Views/Shared/_Notification.cshtml")]
    public class Areas_Admin_Views_Shared__Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorAppointmentSystem.Web.Areas.Admin.Models.NotificationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Shared\_Notification.cshtml"
  
    ViewData["Title"] = "_Notification";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Shared\_Notification.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 156, "\"", 213, 4);
            WriteAttributeValue("", 164, "alert", 164, 5, true);
            WriteAttributeValue(" ", 169, "alert-", 170, 7, true);
#nullable restore
#line 8 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Shared\_Notification.cshtml"
WriteAttributeValue("", 176, Model.TypeCssClass, 176, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 195, "alert-dismissible", 196, 18, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n        <h5><i");
            BeginWriteAttribute("class", " class=\"", 333, "\"", 372, 4);
            WriteAttributeValue("", 341, "icon", 341, 4, true);
            WriteAttributeValue(" ", 345, "fas", 346, 4, true);
            WriteAttributeValue(" ", 349, "fa-", 350, 4, true);
#nullable restore
#line 10 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Shared\_Notification.cshtml"
WriteAttributeValue("", 353, Model.SignCssClass, 353, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 10 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Shared\_Notification.cshtml"
                                                       Write(Model.HeaderText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        ");
#nullable restore
#line 11 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Shared\_Notification.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorAppointmentSystem.Web.Areas.Admin.Models.NotificationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
