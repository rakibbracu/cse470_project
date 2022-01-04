#pragma checksum "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Department\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7442a7a29e51f325bd66d2219c607abf9dd6637e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Department_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Department/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7442a7a29e51f325bd66d2219c607abf9dd6637e", @"/Areas/Admin/Views/Department/Edit.cshtml")]
    public class Areas_Admin_Views_Department_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorAppointmentSystem.Web.Areas.Admin.Models.DepartmentUpdateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Department/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Department\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("notification", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Department\Edit.cshtml"
Write(await Html.PartialAsync("_Notification", Model.Notification));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-6"">
            <!-- general form elements -->
            <div class=""card card-info"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Edit Department</h3>
                </div>
                <!-- /.card-header -->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7442a7a29e51f325bd66d2219c607abf9dd6637e5236", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Department\Edit.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <input hidden name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 775, "\"", 792, 1);
#nullable restore
#line 23 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Department\Edit.cshtml"
WriteAttributeValue("", 783, Model.Id, 783, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""card-body"">

                        <div class=""form-group"">
                            <label asp-for=""Name"" class=""control-label"">Name </label>
                            <input type=""text"" class=""form-control"" name=""Name""");
                BeginWriteAttribute("value", " value=", 1061, "", 1079, 1);
#nullable restore
#line 28 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Department\Edit.cshtml"
WriteAttributeValue("", 1068, Model.Name, 1068, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Department Name....."">
                        </div>

                        <div class=""form-group"">
                            <label for=""Description"">Description </label>
                            <textarea class=""form-control"" rows=""5"" cols=""33"" name=""Description"" ");
                WriteLiteral(" placeholder=\"Enter Description Name.....\">");
#nullable restore
#line 33 "D:\DoctorAppointmentSystem\DoctorAppointmentSystem\DoctorAppointmentSystem.Web\Areas\Admin\Views\Department\Edit.cshtml"
                                                                                                                                                                     Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"card-footer\">\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorAppointmentSystem.Web.Areas.Admin.Models.DepartmentUpdateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591