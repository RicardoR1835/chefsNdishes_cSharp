#pragma checksum "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7759f5f032ba037336fc2ace1622d174458fc55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/_ViewImports.cshtml"
using chefsNdishes;

#line default
#line hidden
#line 1 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml"
using chefsNdishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7759f5f032ba037336fc2ace1622d174458fc55", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38461abede48f599bb6939ca0b11ee1f71f5db0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 526, true);
            WriteLiteral(@"
<br>
<br>
<div class=""container table mx-auto"">
    <h1 class=""text-center sp""><a href=""/"">Chefs</a> <b style=""color: aliceblue; padding-left:20px; padding-right:20px"">|</b> <a href=""dishes"">Dishes</a></h1>
    <a href=""new"">Add a Chef</a>
    <br>
    <br>
    <table class=""table"">
    <thead class=""thead-light"">
        <tr>
        <th scope=""col"">#</th>
        <th scope=""col"">Name</th>
        <th scope=""col"">Age</th>
        <th scope=""col""># Of Dishes</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml"
         foreach(var chef in @Model)
        {

#line default
#line hidden
            BeginContext(622, 46, true);
            WriteLiteral("            <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(669, 11, false);
#line 24 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml"
                       Write(chef.ChefId);

#line default
#line hidden
            EndContext();
            BeginContext(680, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(704, 10, false);
#line 25 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml"
           Write(chef.FName);

#line default
#line hidden
            EndContext();
            BeginContext(714, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(716, 10, false);
#line 25 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml"
                       Write(chef.LName);

#line default
#line hidden
            EndContext();
            BeginContext(726, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(750, 8, false);
#line 26 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml"
           Write(chef.Age);

#line default
#line hidden
            EndContext();
            BeginContext(758, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(782, 26, false);
#line 27 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml"
           Write(chef.DishesCreated.Count());

#line default
#line hidden
            EndContext();
            BeginContext(808, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(845, 35, true);
            WriteLiteral("    </tbody>\r\n    </table> \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591