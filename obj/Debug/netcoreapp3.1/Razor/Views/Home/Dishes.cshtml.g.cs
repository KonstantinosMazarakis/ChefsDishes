#pragma checksum "C:\CodingDojo\c#\assigments\ChefsDishes\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "259e5acb03294607010b0da724858f03961e5dd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
#nullable restore
#line 1 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\_ViewImports.cshtml"
using ChefsDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\_ViewImports.cshtml"
using ChefsDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259e5acb03294607010b0da724858f03961e5dd0", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4173e1c09328e4989c76d1431c897dfcd73c0666", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""text-center"">
    <a href=""/"">Chefs</a> | <span>Dishes</span>
     <a href=""/dishes/new"" class=""ms-5 add d-block"">Add a Dish</a>
    <p>Yum, take a look at our tasty dishes!</p>
    <hr>
        <table class=""table table-striped"">
  <thead>
    <tr>
        <th scope=""col"">Name</th>
        <th scope=""col"">Chef</th>
        <th scope=""col"">Tastiness</th>
        <th scope=""col"">Calories</th>
    </tr>
  </thead>
  <tbody>

");
#nullable restore
#line 18 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\Home\Dishes.cshtml"
  
    foreach(Dish i in ViewBag.AllDishes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n        <td>");
#nullable restore
#line 22 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\Home\Dishes.cshtml"
       Write(i.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\Home\Dishes.cshtml"
       Write(i.Chef.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\Home\Dishes.cshtml"
                         Write(i.Chef.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\Home\Dishes.cshtml"
       Write(i.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\Home\Dishes.cshtml"
       Write(i.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\CodingDojo\c#\assigments\ChefsDishes\Views\Home\Dishes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
