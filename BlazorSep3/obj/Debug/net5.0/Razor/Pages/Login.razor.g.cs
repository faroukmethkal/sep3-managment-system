#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf2b56a9a9d6dbab96876a42bbf92e70107e755"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Pages
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
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
using BlazorSep3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
using BlazorSep3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
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
            __builder.AddAttribute(1, "class", "form");
            __builder.AddAttribute(2, "b-nu0ng3xqlj");
            __builder.AddMarkupContent(3, "<div class=\"form-header\" b-nu0ng3xqlj><h2 b-nu0ng3xqlj>\r\n               Login\r\n           </h2></div>\r\n       ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "b-nu0ng3xqlj");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "class", "error-message");
            __builder.AddAttribute(8, "b-nu0ng3xqlj");
            __builder.AddContent(9, 
#nullable restore
#line 20 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
                                        errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n   \r\n       ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form__group");
            __builder.AddAttribute(13, "b-nu0ng3xqlj");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "class", "form__input");
            __builder.AddAttribute(17, "placeholder", "Username");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
                                                                                 username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(20, "b-nu0ng3xqlj");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n           ");
            __builder.AddMarkupContent(22, "<label for=\"name\" class=\"form__label\" b-nu0ng3xqlj>Username</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n   \r\n       ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form__group");
            __builder.AddAttribute(26, "b-nu0ng3xqlj");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "password");
            __builder.AddAttribute(29, "class", "form__input");
            __builder.AddAttribute(30, "placeholder", "Password");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
                                                                                      password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(33, "b-nu0ng3xqlj");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n           ");
            __builder.AddMarkupContent(35, "<label class=\"form__label\" b-nu0ng3xqlj>Password</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n   \r\n       ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form__group");
            __builder.AddAttribute(39, "b-nu0ng3xqlj");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "button-white");
            __builder.AddAttribute(42, "type", "submit");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
                                                                 PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "b-nu0ng3xqlj");
            __builder.AddContent(45, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Login.razor"
       

    [CascadingParameter]
    public MainLayout Layout { get; set; }

    private string username;
    private string password;
    private string errorMessage;

    private async Task PerformLogin()
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
