#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad750e8f1a25ea01448ed56989c7806e966f2a13"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Shared
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
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
#nullable restore
#line 1 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Shared\NavMenu.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Shared\NavMenu.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Shared\NavMenu.razor"
using BlazorSep3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddAttribute(2, "b-9bjcoxi6rp");
            __builder.OpenElement(3, "header");
            __builder.AddAttribute(4, "class", "header");
            __builder.AddAttribute(5, "b-9bjcoxi6rp");
            __builder.AddMarkupContent(6, "<a href=\"/\" b-9bjcoxi6rp><img class=\"logo\" alt=\"project management system\" src=\"images/logo.png\" b-9bjcoxi6rp></a>\r\n\r\n        ");
            __builder.OpenElement(7, "nav");
            __builder.AddAttribute(8, "class", "main-nav");
            __builder.AddAttribute(9, "b-9bjcoxi6rp");
            __builder.OpenElement(10, "ul");
            __builder.AddAttribute(11, "class", "main-nav-list");
            __builder.AddAttribute(12, "b-9bjcoxi6rp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(13);
            __builder.AddAttribute(14, "Policy", "MustBeAdmin");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "<li b-9bjcoxi6rp><a class=\"main-nav-link\" href=\"ManageShift\" b-9bjcoxi6rp>Manage Shift</a></li>\r\n\r\n                    ");
                __builder2.AddMarkupContent(17, "<li b-9bjcoxi6rp><a class=\"main-nav-link\" href=\"ManageEmployee\" b-9bjcoxi6rp>Manage Employee</a></li>\r\n                    ");
                __builder2.AddMarkupContent(18, "<li b-9bjcoxi6rp><a class=\"main-nav-link\" href=\"ViewAllTasks\" b-9bjcoxi6rp>Manage Task</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(20);
            __builder.AddAttribute(21, "Policy", "MustBePartTimeEmp");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "<li b-9bjcoxi6rp><a class=\"main-nav-link\" href=\"AllAvailableShifts\" b-9bjcoxi6rp>Shifts</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(25);
            __builder.AddAttribute(26, "Policy", "MustBeFullTimeEmp");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(28, "<li b-9bjcoxi6rp><a class=\"main-nav-link\" href=\"AllAvailableTasks\" b-9bjcoxi6rp>Tasks</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(30);
            __builder.AddAttribute(31, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(32, "li");
                __builder2.AddAttribute(33, "b-9bjcoxi6rp");
                __builder2.OpenElement(34, "a");
                __builder2.AddAttribute(35, "herf", "#");
                __builder2.AddAttribute(36, "class", "main-nav-link nav-cta");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Shared\NavMenu.razor"
                                                                                PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "b-9bjcoxi6rp");
                __builder2.AddContent(39, "Logout");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(40, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(41, "<li b-9bjcoxi6rp><a href=\"Login\" class=\"main-nav-link nav-cta\" b-9bjcoxi6rp>Login</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Shared\NavMenu.razor"
 
    private async Task PerformLogout()
    {
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
