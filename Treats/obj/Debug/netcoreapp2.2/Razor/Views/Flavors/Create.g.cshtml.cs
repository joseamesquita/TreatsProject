#pragma checksum "/Users/JoseAmesquita/Desktop/TreatsProject/Treats/Views/Flavors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f64877e0a756ee984729fec494854edf9ace0dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Create), @"mvc.1.0.view", @"/Views/Flavors/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Create.cshtml", typeof(AspNetCore.Views_Flavors_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f64877e0a756ee984729fec494854edf9ace0dc", @"/Views/Flavors/Create.cshtml")]
    public class Views_Flavors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Treats.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/JoseAmesquita/Desktop/TreatsProject/Treats/Views/Flavors/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 28, true);
            WriteLiteral("\n<h3>Add a new Flavor</h3>\n\n");
            EndContext();
#line 9 "/Users/JoseAmesquita/Desktop/TreatsProject/Treats/Views/Flavors/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(117, 41, false);
#line 11 "/Users/JoseAmesquita/Desktop/TreatsProject/Treats/Views/Flavors/Create.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(164, 43, false);
#line 12 "/Users/JoseAmesquita/Desktop/TreatsProject/Treats/Views/Flavors/Create.cshtml"
Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(213, 51, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new Flavor\" />\n");
            EndContext();
#line 15 "/Users/JoseAmesquita/Desktop/TreatsProject/Treats/Views/Flavors/Create.cshtml"
}

#line default
#line hidden
            BeginContext(266, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(270, 44, false);
#line 16 "/Users/JoseAmesquita/Desktop/TreatsProject/Treats/Views/Flavors/Create.cshtml"
Write(Html.ActionLink("View all Flavors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(314, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Treats.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
