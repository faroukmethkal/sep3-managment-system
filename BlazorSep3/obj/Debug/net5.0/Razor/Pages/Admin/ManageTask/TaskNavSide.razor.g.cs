#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\TaskNavSide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da256f50bb30a43eff61e8938d98c14bdbfa1b8e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Pages.Admin.ManageTask
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using BlazorSep3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using BlazorSep3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class TaskNavSide : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddAttribute(2, "b-nn8520mob5");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "side-nav");
            __builder.AddAttribute(5, "b-nn8520mob5");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "nav-item");
            __builder.AddAttribute(8, "b-nn8520mob5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "href", "ManageTask");
            __builder.AddAttribute(11, "class", "side-nav__link");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "<svg class=\"side-nav__icon\" b-nn8520mob5><use xlink:href=\"images/sprite.svg#icon-home\" b-nn8520mob5></use></svg>\r\n                ");
                __builder2.AddMarkupContent(14, "<span b-nn8520mob5>Dashboard</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "nav-item");
            __builder.AddAttribute(18, "b-nn8520mob5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "href", "AddTask");
            __builder.AddAttribute(21, "class", "side-nav__link");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "<svg class=\"side-nav__icon\" b-nn8520mob5><use xlink:href=\"images/sprite.svg#icon-star\" b-nn8520mob5></use></svg>\r\n                ");
                __builder2.AddMarkupContent(24, "<span b-nn8520mob5>Add Task</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item");
            __builder.AddAttribute(28, "b-nn8520mob5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "href", "ViewAllTasks");
            __builder.AddAttribute(31, "class", "side-nav__link");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "<svg class=\"side-nav__icon\" b-nn8520mob5><use xlink:href=\"images/sprite.svg#icon-bookmark\" b-nn8520mob5></use></svg>\r\n                ");
                __builder2.AddMarkupContent(34, "<span b-nn8520mob5>All Tasks</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item");
            __builder.AddAttribute(38, "b-nn8520mob5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "href", "#");
            __builder.AddAttribute(41, "class", "side-nav__link");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<svg class=\"side-nav__icon\" b-nn8520mob5><use xlink:href=\"images/sprite.svg#icon-bookmark\" b-nn8520mob5></use></svg>\r\n                ");
                __builder2.AddMarkupContent(44, "<span b-nn8520mob5>Current Task</span>");
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