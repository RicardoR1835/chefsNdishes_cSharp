#pragma checksum "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d743593fe33213f1ff2b054f862a9e02d6379b4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
using chefsNdishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d743593fe33213f1ff2b054f862a9e02d6379b4f", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38461abede48f599bb6939ca0b11ee1f71f5db0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 564, true);
            WriteLiteral(@"
<br>
<br>
<div class=""container table mx-auto"">
    <h1 class=""text-center sp""><a href=""/"">Chefs</a> <b style=""color: aliceblue; padding-left:20px; padding-right:20px"">|</b> <a href=""dishes"">Dishes</a></h1>
    <a href=""dishes/new"">Add a Dish</a>
    <br>
    <br>
    <table class=""table"">
    <thead class=""thead-light text-center"">
        <tr>
        <th scope=""col"">#</th>
        <th scope=""col"">Name</th>
        <th scope=""col"">Chef</th>
        <th scope=""col"">Tastiness</th>
        <th scope=""col"">Calories</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
          
            int i = 1;
        

#line default
#line hidden
#line 24 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
         foreach(var dish in @Model)
        {

#line default
#line hidden
            BeginContext(690, 45, true);
            WriteLiteral("            <tr>\n            <th scope=\"row\">");
            EndContext();
            BeginContext(736, 1, false);
#line 27 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(737, 22, true);
            WriteLiteral("</th>\n            <td>");
            EndContext();
            BeginContext(760, 9, false);
#line 28 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
           Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(769, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(792, 18, false);
#line 29 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
           Write(dish.Creator.FName);

#line default
#line hidden
            EndContext();
            BeginContext(810, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(812, 18, false);
#line 29 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
                               Write(dish.Creator.LName);

#line default
#line hidden
            EndContext();
            BeginContext(830, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(853, 14, false);
#line 30 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
           Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(867, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(890, 13, false);
#line 31 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
           Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(903, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 33 "/Users/ricardorivera/cSharp/ORM/chefsNdishes/Views/Home/Dishes.cshtml"
            i++;
        }

#line default
#line hidden
            BeginContext(964, 33, true);
            WriteLiteral("    </tbody>\n    </table> \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
