#pragma checksum "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdd8c628d4c288f24e51461f29410d6a4ae446e9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
#nullable restore
#line 1 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using BlazorSep3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
using BlazorSep3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
using BlazorSep3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddAttribute(2, "b-nu0ng3xqlj");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-Contanier");
            __builder.AddAttribute(5, "b-nu0ng3xqlj");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "header");
            __builder.AddAttribute(8, "b-nu0ng3xqlj");
            __builder.AddMarkupContent(9, "<span b-nu0ng3xqlj> Login </span>\r\n            <br b-nu0ng3xqlj> ");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "error");
            __builder.AddAttribute(12, "b-nu0ng3xqlj");
            __builder.AddContent(13, 
#nullable restore
#line 18 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
                                       errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-field");
            __builder.AddAttribute(17, "b-nu0ng3xqlj");
            __builder.AddMarkupContent(18, "<div b-nu0ng3xqlj><label class=\"username\" b-nu0ng3xqlj><span class=\"oi oi-person\" b-nu0ng3xqlj></span> Username\r\n                </label></div>\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "b-nu0ng3xqlj");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "placeholder", "User Name");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
                                                       username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(25, "b-nu0ng3xqlj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-field");
            __builder.AddAttribute(29, "b-nu0ng3xqlj");
            __builder.AddMarkupContent(30, "<div b-nu0ng3xqlj><label class=\"password\" b-nu0ng3xqlj><span class=\"oi oi-lock-locked\" b-nu0ng3xqlj></span> Password\r\n                </label></div>\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "b-nu0ng3xqlj");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "password");
            __builder.AddAttribute(35, "placeholder", "Password");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
                                                                     password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(38, "b-nu0ng3xqlj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-field footer");
            __builder.AddAttribute(42, "b-nu0ng3xqlj");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "b-nu0ng3xqlj");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn btn-success");
            __builder.AddAttribute(47, "type", "submit");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
                                                                        PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "b-nu0ng3xqlj");
            __builder.AddContent(50, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\Login.razor"
       
    [CascadingParameter]
    public MainLayout Layout { get; set; }

    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        try
        {
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            NavgMan.NavigateTo("/");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            errorMessage = e.Message;
        }
    }
          
        
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceUser _serviceUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavgMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
