#pragma checksum "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\RentPages\GetAllRents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53497002fd4ab4e3eee066cee3caed075335642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DatabaseAssingment.Pages.RentPages.Pages_RentPages_GetAllRents), @"mvc.1.0.razor-page", @"/Pages/RentPages/GetAllRents.cshtml")]
namespace DatabaseAssingment.Pages.RentPages
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
#line 1 "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\_ViewImports.cshtml"
using DatabaseAssingment;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53497002fd4ab4e3eee066cee3caed075335642", @"/Pages/RentPages/GetAllRents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee893942560210863229b93ba290355e5fe2a03a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RentPages_GetAllRents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>  Leasing Number   </th>
            <th>    Student Number  </th>
            <th>  Place Number </th>
            <th>  Leasing From </th>
            <th>  Leasing To </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\RentPages\GetAllRents.cshtml"
         foreach (var item in Model.Leasings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\RentPages\GetAllRents.cshtml"
           Write(item.Leasing_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\RentPages\GetAllRents.cshtml"
           Write(item.Student_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\RentPages\GetAllRents.cshtml"
           Write(item.Place_No);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\RentPages\GetAllRents.cshtml"
           Write(item.DateFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\RentPages\GetAllRents.cshtml"
           Write(item.DateTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Acer\source\repos\DatabaseAssingment\DatabaseAssingment\Pages\RentPages\GetAllRents.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DatabaseAssingment.Pages.RentPages.GetAllRentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DatabaseAssingment.Pages.RentPages.GetAllRentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DatabaseAssingment.Pages.RentPages.GetAllRentsModel>)PageContext?.ViewData;
        public DatabaseAssingment.Pages.RentPages.GetAllRentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
