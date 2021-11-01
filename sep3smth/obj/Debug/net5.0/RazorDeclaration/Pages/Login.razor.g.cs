// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace sep3smth.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using sep3smth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\_Imports.razor"
using sep3smth.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\Pages\Login.razor"
using BlazorSep3LoginExample.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\Pages\Login.razor"
using BlazorSep3LoginExample.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\Pages\Login.razor"
using BlazorSep3LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\Pages\Login.razor"
using BlazorSep3LoginExample.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\Pages\Login.razor"
using BlazorSep3LoginExample.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\Pages\Login.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\Pages\Login.razor"
using Task = System.Threading.Tasks.Task;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\anzym\RiderProjects\sep3-managment-system\sep3smth\Pages\Login.razor"
       
    public LoginUser User { get; set; } = new LoginUser();
    private string password;
    private string token;
    private string username;
    private string role;
    async Task SubmitCredentials()
    {
        Dictionary<string, string> values = await ((ServiceUser) _serviceUser).ValidateUser(User);
        if (values != null)
        {
            if (values.TryGetValue("access_token", out token))
                if (values.TryGetValue("role", out role))
                    if (values.TryGetValue("username", out username))
                        ((CustomAuthenticationStateProvider) authenticationStateProvider).SetTokenAsync(token);
            NavigationManaget.NavigateTo("/counter");
        }
    }

    userDAL _userDAL = new userDAL();
    userBLL _userBLL = new userBLL();
    DataTable dt = new DataTable();

    async Task SubmitDBCredentials()
    {
        _userDAL.username = username;
        _userDAL.username = password;
        dt = _userBLL.login(_userDAL);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceUser _serviceUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManaget { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
