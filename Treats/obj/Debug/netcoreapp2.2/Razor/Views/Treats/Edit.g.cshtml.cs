#pragma checksum "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68915969fc09d723e4404f08ed67b5fc63bee95f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Edit), @"mvc.1.0.view", @"/Views/Treats/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Edit.cshtml", typeof(AspNetCore.Views_Treats_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68915969fc09d723e4404f08ed67b5fc63bee95f", @"/Views/Treats/Edit.cshtml")]
    public class Views_Treats_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Treats.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 37, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this treat: ");
            EndContext();
            BeginContext(94, 36, false);
#line 10 "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml"
                Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(130, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 12 "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(170, 38, false);
#line 14 "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(215, 34, false);
#line 16 "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(255, 35, false);
#line 17 "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(292, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 20 "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(335, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(339, 42, false);
#line 21 "/Users/JoseAmesquita/Desktop/Treats.Solution/Treats/Views/Treats/Edit.cshtml"
Write(Html.ActionLink("Back to treats", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(381, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Treats.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
