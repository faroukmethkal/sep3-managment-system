#pragma checksum "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Part-time\ShiftEmployeeNavSide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cadca7e8c13c1082345ce9458a45828b9be45f0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Pages.Part_time
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using BlazorSep3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using BlazorSep3.Shared;

#line default
#line hidden
#nullable disable
    public partial class ShiftEmployeeNavSide : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddAttribute(2, "b-x61mjnei9v");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "side-nav");
            __builder.AddAttribute(5, "b-x61mjnei9v");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "nav-item");
            __builder.AddAttribute(8, "b-x61mjnei9v");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "href", "MyShifts");
            __builder.AddAttribute(11, "class", "side-nav__link");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "<svg class=\"side-nav__icon\" b-x61mjnei9v><use xlink:href=\"images/sprite.svg#icon-home\" b-x61mjnei9v></use></svg>\r\n                ");
                __builder2.AddMarkupContent(14, "<span b-x61mjnei9v>Dashboard</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "nav-item");
            __builder.AddAttribute(18, "b-x61mjnei9v");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "href", "AllAvailableShifts");
            __builder.AddAttribute(21, "class", "side-nav__link");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "<svg class=\"side-nav__icon\" b-x61mjnei9v><use xlink:href=\"images/sprite.svg#icon-home\" b-x61mjnei9v></use></svg>\r\n                ");
                __builder2.AddMarkupContent(24, "<span b-x61mjnei9v>Shifts</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item");
            __builder.AddAttribute(28, "b-x61mjnei9v");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "href", "#");
            __builder.AddAttribute(31, "class", "side-nav__link");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "<svg class=\"side-nav__icon\" b-x61mjnei9v><use xlink:href=\"images/sprite.svg#icon-bookmark\" b-x61mjnei9v></use></svg>\r\n                ");
                __builder2.AddMarkupContent(34, "<span b-x61mjnei9v>My shifts</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
