#pragma checksum "C:\Users\igor\Documents\ExtremeDemo\Pages\CostumerClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fefe9863cd83761bea2e8cddafc1738faa59e12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExtremeDemo.Pages.Pages_CostumerClass), @"mvc.1.0.razor-page", @"/Pages/CostumerClass.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CostumerClass.cshtml", typeof(ExtremeDemo.Pages.Pages_CostumerClass), null)]
namespace ExtremeDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\igor\Documents\ExtremeDemo\Pages\_ViewImports.cshtml"
using ExtremeDemo;

#line default
#line hidden
#line 2 "C:\Users\igor\Documents\ExtremeDemo\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fefe9863cd83761bea2e8cddafc1738faa59e12", @"/Pages/CostumerClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2754a4a933a87c29c3ae17a7ff3866654e5e64f3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CostumerClass : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\igor\Documents\ExtremeDemo\Pages\CostumerClass.cshtml"
  
    ViewData["Title"] = "Costumer Classification";

#line default
#line hidden
            BeginContext(93, 1373, true);
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
  <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
    <ul class=""navbar-nav mr-auto"">
      <li class=""nav-item active"">
        <a class=""nav-link"" href=""#"">Save <span class=""sr-only"">(current)</span></a>
      </li>
      <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">Copy</a>
      </li>
      <li class=""nav-item dropdown"">
        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
          Dropdown
        </a>
        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
          <a class=""dropdown-item"" href=""#"">Action</a>
          <a ");
            WriteLiteral(@"class=""dropdown-item"" href=""#"">Another action</a>
          <div class=""dropdown-divider""></div>
          <a class=""dropdown-item"" href=""#"">Something else here</a>
        </div>
      </li>
      <li class=""nav-item"">
        <a class=""nav-link disabled"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Disabled</a>
      </li>
    </ul>
    ");
            EndContext();
            BeginContext(1466, 241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fefe9863cd83761bea2e8cddafc1738faa59e125335", async() => {
                BeginContext(1505, 195, true);
                WriteLiteral("\r\n      <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n      <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1707, 43, true);
            WriteLiteral("\r\n  </div>\r\n</nav>\r\n<div class=\"row\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(1752, 506, false);
#line 44 "C:\Users\igor\Documents\ExtremeDemo\Pages\CostumerClass.cshtml"
Write(Html.DevExtreme().DataGrid()
    .ID("gridContainer")
    .ShowBorders(true)
    .Editing(editing => {
            editing.Mode(GridEditMode.Cell);
            editing.AllowUpdating(true);
    })
    .DataSource(d => d.RemoteController().LoadUrl(Url.Page("CostumerClass", "Costumers")).Key("AppointmentId"))
    .Columns(c => {
        c.Add().DataField("AppointmentId");
        c.Add().DataField("Text");
        c.Add().DataField("StartDate");
        c.Add().DataField("EndDate");
    })
);

#line default
#line hidden
            EndContext();
            BeginContext(2259, 10, true);
            WriteLiteral("\r\n\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CostumerClassModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CostumerClassModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CostumerClassModel>)PageContext?.ViewData;
        public CostumerClassModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
