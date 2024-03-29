#pragma checksum "f:\Demo\Portal\Views\Doctors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83aa246a1f1c9e3b0678d529c311e658429ddd59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Index), @"mvc.1.0.view", @"/Views/Doctors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Index.cshtml", typeof(AspNetCore.Views_Doctors_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83aa246a1f1c9e3b0678d529c311e658429ddd59", @"/Views/Doctors/Index.cshtml")]
    public class Views_Doctors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FourApplication.Models.Doctors>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 896, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
    Doctors
    </h1>
    <ol class=""breadcrumb"">
    <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
    <li class=""active"">Doctors</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box"">
        <div class=""box-header"">
            <h3 class=""box-title"">Manage Doctors</h3>
        </div>
        <!-- /.box-header -->
        <div class=""box-body"">
            <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Email</th>
                <th>Phone</th>
                <th>Created</th>
                <th>Specialist</th>
                <th>Action</th>
            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 34 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1010, 49, true);
            WriteLiteral("                    <tr>\n                    <td>");
            EndContext();
            BeginContext(1060, 37, false);
#line 37 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1128, 39, false);
#line 38 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1198, 40, false);
#line 39 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1269, 40, false);
#line 40 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1340, 42, false);
#line 41 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1413, 45, false);
#line 42 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Specialist));

#line default
#line hidden
            EndContext();
            BeginContext(1458, 32, true);
            WriteLiteral("</td>\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1490, "\"", 1520, 2);
            WriteAttributeValue("", 1497, "Doctors/Update/", 1497, 15, true);
#line 43 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
WriteAttributeValue("", 1512, item.Id, 1512, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1521, 24, true);
            WriteLiteral(">Update</a> | <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1545, "\"", 1573, 3);
            WriteAttributeValue("", 1555, "Delete(\'", 1555, 8, true);
#line 43 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
WriteAttributeValue("", 1563, item.Id, 1563, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1571, "\')", 1571, 2, true);
            EndWriteAttribute();
            BeginContext(1574, 43, true);
            WriteLiteral(">Delete</a></td>\n                    </tr>\n");
            EndContext();
#line 45 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1635, 197, true);
            WriteLiteral("            </table>\n        </div>\n        <!-- /.box-body -->\n        </div>\n        <!-- /.box -->\n    </div>\n    <!-- /.col -->\n    </div>\n    <!-- /.row -->\n</section>\n   \n<!-- DataTables -->\n");
            EndContext();
            BeginContext(1832, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83aa246a1f1c9e3b0678d529c311e658429ddd598344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1917, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1918, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83aa246a1f1c9e3b0678d529c311e658429ddd599521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2009, 322, true);
            WriteLiteral(@"
<!-- page script -->
<script>
    $(function () {
        $('#example1').DataTable();
    });
    function Delete(id){
        var txt;
        var r = confirm(""Are you sure you want to Delete?"");
        if (r == true) {
            
            $.ajax(
            {
                type: ""POST"",
                url: '");
            EndContext();
            BeginContext(2332, 31, false);
#line 73 "f:\Demo\Portal\Views\Doctors\Index.cshtml"
                 Write(Url.Action("Delete", "Doctors"));

#line default
#line hidden
            EndContext();
            BeginContext(2363, 552, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl=""/Doctors"";
                        window.location.reload();
                    }
                    else {
                        alert(""There is a problem, Try Later!"");
                    }
                }
            });
        } 
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FourApplication.Models.Doctors>> Html { get; private set; }
    }
}
#pragma warning restore 1591
