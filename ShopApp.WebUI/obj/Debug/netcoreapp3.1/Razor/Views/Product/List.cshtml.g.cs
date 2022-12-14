#pragma checksum "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c0bf73467db62fb6797192504c8f4c92003f46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 2 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c0bf73467db62fb6797192504c8f4c92003f46", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc28b1b2bf3cee19407ee059a03f18d96df96d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
  
    var popularClass = Model.Products.Count == 2 ? "popular" : "";
    var products = Model.Products;

#line default
#line hidden
#nullable disable
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
 if (products.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_noproduct.cshtml"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                                                                

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
         foreach (var product in products)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 31 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
           Write(await Html.PartialAsync("~/Views/Shared/_product.cshtml", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"




        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 39 "C:\Users\nur.senkara\Desktop\Nur\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
