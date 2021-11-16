// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSep3.Pages.Admin.ManageEmployee
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using BlazorSep3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using BlazorSep3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageEmployee\AddEmployee.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageEmployee\AddEmployee.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageEmployee\AddEmployee.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageEmployee\AddEmployee.razor"
using Task = System.Threading.Tasks.Task;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageEmployee\AddEmployee.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEmployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "F:\VIA\Third Semester\SEP3\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageEmployee\AddEmployee.razor"
       

    [CascadingParameter]
    public MainLayout Layout { get; set; }

    private string errorMessage;
    private Profile profile = new Profile();

    public async Task PerformRegister()
    {
        try
        {
            await _serviceUser.RegisterUser(profile);
            errorMessage = "";
            NavigationManager.NavigateTo("/ManageEmployee");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            errorMessage = e.Message;
        }
    }

    protected override void OnInitialized()
    {
        profile.Birthday = new DateTime(1980, 1, 1);
    }

    private string splitOnCapitalLitter(string s)
    {
        StringBuilder builder = new StringBuilder();
        s.First().ToString().ToUpper();
        foreach (char c in s)
        {
            if (Char.IsUpper(c) && builder.Length > 0) builder.Append(' ');
            builder.Append(c);
        }
        string newString = builder.ToString();
        string newsCapitalizeFirstLetter = char.ToUpper(newString[0]) + newString.Substring(1);
        return newsCapitalizeFirstLetter;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceUser _serviceUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
