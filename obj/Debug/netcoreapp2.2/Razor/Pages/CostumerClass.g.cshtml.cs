#pragma checksum "/home/igor/Projects/ExtremeDemo/Pages/CostumerClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f914ce6ddc362b3a2187b1cb2ec4f43680ba312b"
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
#line 1 "/home/igor/Projects/ExtremeDemo/Pages/_ViewImports.cshtml"
using ExtremeDemo;

#line default
#line hidden
#line 2 "/home/igor/Projects/ExtremeDemo/Pages/_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f914ce6ddc362b3a2187b1cb2ec4f43680ba312b", @"/Pages/CostumerClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2754a4a933a87c29c3ae17a7ff3866654e5e64f3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CostumerClass : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/igor/Projects/ExtremeDemo/Pages/CostumerClass.cshtml"
  
    ViewData["Title"] = "Costumer Classification";

#line default
#line hidden
            BeginContext(93, 27, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    ");
            EndContext();
            BeginContext(122, 1325, false);
#line 9 "/home/igor/Projects/ExtremeDemo/Pages/CostumerClass.cshtml"
Write(Html.DevExtreme().DataGrid()
        .ID("gridContainer")
        .ShowBorders(true)
        .Editing(editing => {
                editing.Mode(GridEditMode.Batch);
                editing.AllowUpdating(true);
        })
        .ColumnChooser(c => c.Enabled(true))
        .DataSource(d => d.RemoteController()
        .LoadUrl(Url.Page("CostumerClass", "Costumers")).Key("cCodTerceiro")
        .UpdateUrl(Url.Page("CostumerClass", "UpdateClassTypes")).Key("cCodTerceiro")) // haven't tried implementing a PUT until I can get the POST to work)
        .Columns(c => {
            c.Add().DataField("cCodTerceiro");
            c.Add().DataField("vcNome");
            c.Add().DataField("vcMorada");
            c.Add().DataField("mSaldo")
            .Alignment(HorizontalAlignment.Right)
                .Format(Format.Currency);
            c.Add().DataField("cClassificacaoFact")
            .Width(125)
                    .Lookup(lookup => lookup
                        .DataSource(d => d.RemoteController().LoadUrl(Url.Page("CostumerClass", "ClassTypes")).Key("vcClassType"))
                        .DisplayExpr("vcClassType")
                        .ValueExpr("vcClassType")
                    );
        }).OnToolbarPreparing("toolbar_preparing")
        .OnContentReady("ready")
    );

#line default
#line hidden
            EndContext();
            BeginContext(1448, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(1459, 23, false);
#line 38 "/home/igor/Projects/ExtremeDemo/Pages/CostumerClass.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1482, 2502, true);
            WriteLiteral(@"

<script>

$.ajaxSetup({
    data: {
        __RequestVerificationToken: document.getElementsByName(""__RequestVerificationToken"")[0].value
    }
});

function ready(e)
{

}
function toolbar_preparing(e) {
        var dataGrid = e.component;
        
        e.toolbarOptions.items.unshift({
            location: ""before"",
            template: function() {
                return $(""<div/>"")
                    .addClass(""informer"")
                    .append(
                       $(""<h2 />"")
                         .addClass(""count"")
                         .text(getTotalCount()),
                       $(""<span />"")
                         .addClass(""name"")
                         .text(""Total Count"")
                    );
            }
        }, {
            location: ""before"",
            widget: ""dxSelectBox"",
            options: {
                width: 200,
                items: [{
                    value: ""CustomerStoreState"",
                    text");
            WriteLiteral(@": ""Show All""
                }, {
                    value: ""Employee"",
                    text: ""Show only Unclassified""
                }],
                displayExpr: ""text"",
                valueExpr: ""value"",
                value: ""CustomerStoreState"",
                onValueChanged: function(e) {
                   // dataGrid.clearGrouping();
                   // dataGrid.columnOption(e.value, ""groupIndex"", 0);
                    $("".informer .count"").text(getTotalCount());
                }
            }
        }, {
            location: ""before"",
            widget: ""dxButton"",
            options: {
                text: ""Collapse All"",
                width: 136,
                onClick: function(e) {
                    var expanding = e.component.option(""text"") === ""Expand All"";
                    dataGrid.option(""grouping.autoExpandAll"", expanding);
                    e.component.option(""text"", expanding ? ""Collapse All"" : ""Expand All"");
                }
      ");
            WriteLiteral(@"      }
        }, {
            location: ""after"",
            widget: ""dxButton"",
            options: {
                icon: ""refresh"",
                onClick: function() {
                    dataGrid.refresh();
                }
            }
        });
    }

    function getTotalCount() {
       
        var coiso = $(""#gridContainer"").dxDataGrid(""instance"");

        
        return coiso.totalCount();
    }
</script>
");
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
