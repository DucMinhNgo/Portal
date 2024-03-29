#pragma checksum "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6894a399eb0c048241d73ca5695a48ccb267d471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Subjects_Index), @"mvc.1.0.view", @"/Views/Students_Subjects/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students_Subjects/Index.cshtml", typeof(AspNetCore.Views_Students_Subjects_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6894a399eb0c048241d73ca5695a48ccb267d471", @"/Views/Students_Subjects/Index.cshtml")]
    public class Views_Students_Subjects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FourApplication.Models.Students_Subjects>>
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
            BeginContext(61, 880, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
    Students_Subjects
    </h1>
    <ol class=""breadcrumb"">
    <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
    <li class=""active"">Students_Subjects</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box"">
        <div class=""box-header"">
            <h3 class=""box-title"">Manage Students_Subjects</h3>
        </div>
        <!-- /.box-header -->
        <div class=""box-body"">
            <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
            <tr>
                <th>Id</th>
                <th>StudentID</th>
                <th>SubjectID</th>
                <th>Unchoose</th>
            </tr>
            </thead>
            <tbody>
                 <form action=""/Subjects"">
");
            EndContext();
#line 32 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1004, 49, true);
            WriteLiteral("                    <tr>\n                    <td>");
            EndContext();
            BeginContext(1054, 37, false);
#line 35 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1122, 44, false);
#line 36 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StudentID));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1197, 44, false);
#line 37 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SubjectID));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 65, true);
            WriteLiteral("</td>\n                   <td><input type=\"checkbox\" name=\"MonHoc\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1306, "\"", 1322, 1);
#line 38 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
WriteAttributeValue("", 1314, item.Id, 1314, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1323, 37, true);
            WriteLiteral("><br></td>\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1400, 2);
            WriteAttributeValue("", 1367, "Students_Subjects/Update/", 1367, 25, true);
#line 39 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
WriteAttributeValue("", 1392, item.Id, 1392, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1401, 24, true);
            WriteLiteral(">Update</a> | <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1425, "\"", 1453, 3);
            WriteAttributeValue("", 1435, "Delete(\'", 1435, 8, true);
#line 39 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
WriteAttributeValue("", 1443, item.Id, 1443, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1451, "\')", 1451, 2, true);
            EndWriteAttribute();
            BeginContext(1454, 43, true);
            WriteLiteral(">Delete</a></td>\n                    </tr>\n");
            EndContext();
#line 41 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1515, 280, true);
            WriteLiteral(@"                 <input type=""submit"" value=""Unsubscribe"">
                </form>
            </table>
        </div>
        <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->
    </div>
    <!-- /.row -->
</section>
   
<!-- DataTables -->
");
            EndContext();
            BeginContext(1795, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6894a399eb0c048241d73ca5695a48ccb267d4717936", async() => {
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
            BeginContext(1880, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1881, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6894a399eb0c048241d73ca5695a48ccb267d4719113", async() => {
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
            BeginContext(1972, 322, true);
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
            BeginContext(2295, 41, false);
#line 71 "f:\Demo\Portal\Views\Students_Subjects\Index.cshtml"
                 Write(Url.Action("Delete", "Students_Subjects"));

#line default
#line hidden
            EndContext();
            BeginContext(2336, 562, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl=""/Students_Subjects"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FourApplication.Models.Students_Subjects>> Html { get; private set; }
    }
}
#pragma warning restore 1591
