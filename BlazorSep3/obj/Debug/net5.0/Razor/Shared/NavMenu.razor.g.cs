#pragma checksum "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41309176382a7ce0af24ef48f2ac99733fafb41e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Shared
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
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
#nullable restore
#line 1 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Shared\NavMenu.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Shared\NavMenu.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Shared\NavMenu.razor"
using BlazorSep3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Shared\NavMenu.razor"
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
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.AddMarkupContent(16, "<li b-9bjcoxi6rp><a class=\"main-nav-link\" href=\"ManageShift\" b-9bjcoxi6rp>Manage Shift</a></li>\r\n\r\n                ");
            __builder.AddMarkupContent(17, "<li b-9bjcoxi6rp><a class=\"main-nav-link\" href=\"ManageEmployee\" b-9bjcoxi6rp>Manage Employee</a></li>\r\n                ");
            __builder.AddMarkupContent(18, "<li b-9bjcoxi6rp><a class=\"main-nav-link\" href=\"ManageTask\" b-9bjcoxi6rp>Manage Task</a></li>\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(19);
            __builder.AddAttribute(20, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "b-9bjcoxi6rp");
                __builder2.OpenElement(23, "a");
                __builder2.AddAttribute(24, "herf", "#");
                __builder2.AddAttribute(25, "class", "main-nav-link nav-cta");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Shared\NavMenu.razor"
                                                                                PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "b-9bjcoxi6rp");
                __builder2.AddContent(28, "Logout");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(29, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(30, "<li b-9bjcoxi6rp><a href=\"Login\" class=\"main-nav-link nav-cta\" b-9bjcoxi6rp>Login</a></li>");
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
#line 55 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Shared\NavMenu.razor"
 
    public async Task PerformLogout()
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
