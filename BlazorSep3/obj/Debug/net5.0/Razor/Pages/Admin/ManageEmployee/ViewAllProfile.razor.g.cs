#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb6066e6b575cd28359b848fcf8969ab545f3d0d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Pages.Admin.ManageEmployee
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
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAllProfile")]
    public partial class ViewAllProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddAttribute(2, "b-dpmqsdio88");
            __builder.OpenComponent<BlazorSep3.Pages.Admin.ManageEmployee.EmployeeSideNav>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "main");
            __builder.AddAttribute(6, "class", "content-view");
            __builder.AddAttribute(7, "b-dpmqsdio88");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "filter_option");
            __builder.AddAttribute(10, "b-dpmqsdio88");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form__group");
            __builder.AddAttribute(13, "b-dpmqsdio88");
            __builder.AddMarkupContent(14, "<div class=\"form__group-title\" b-dpmqsdio88><span class=\"icon oi oi-briefcase\" b-dpmqsdio88></span>\r\n                    <label class=\"form__label\" b-dpmqsdio88>Role</label></div>\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "b-dpmqsdio88");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "name", "specialties");
            __builder.AddAttribute(19, "class", "form__input_select");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                                                                 role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => role = __value, role));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(22, "b-dpmqsdio88");
#nullable restore
#line 18 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                         foreach (var role in Enum.GetValues(typeof(Role)))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 20 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                            role

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "b-dpmqsdio88");
            __builder.AddContent(26, 
#nullable restore
#line 20 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                                   role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form__group");
            __builder.AddAttribute(30, "b-dpmqsdio88");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "button-spec");
            __builder.AddAttribute(33, "type", "submit");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                                                    Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "b-dpmqsdio88");
            __builder.AddContent(36, "Filter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n            ");
            __builder.OpenElement(38, "form");
            __builder.AddAttribute(39, "action", "#");
            __builder.AddAttribute(40, "class", "form__group_search");
            __builder.AddAttribute(41, "b-dpmqsdio88");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "class", "search_input");
            __builder.AddAttribute(45, "placeholder", "Search name");
            __builder.AddAttribute(46, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                                                                              (arg)=>FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "b-dpmqsdio88");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "search_result");
            __builder.AddAttribute(51, "b-dpmqsdio88");
#nullable restore
#line 37 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
             if (profilesToShow == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<p b-dpmqsdio88><em b-dpmqsdio88>Loading...</em></p>");
#nullable restore
#line 42 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
            }
            else if (!profilesToShow.Any())
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<p b-dpmqsdio88><em b-dpmqsdio88>No Profile to show. </em></p>");
#nullable restore
#line 48 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "class", "table");
            __builder.AddAttribute(56, "b-dpmqsdio88");
            __builder.AddMarkupContent(57, @"<thead b-dpmqsdio88><tr b-dpmqsdio88><th b-dpmqsdio88>Username</th>
                        <th b-dpmqsdio88>First Name</th>
                        <th b-dpmqsdio88>Last Name</th>
                        <th b-dpmqsdio88>Specialty</th>
                        <th b-dpmqsdio88>Birthday</th>
                        <th b-dpmqsdio88>Role</th></tr></thead>
                    ");
            __builder.OpenElement(58, "tbody");
            __builder.AddAttribute(59, "b-dpmqsdio88");
#nullable restore
#line 63 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                     foreach (var item in profilesToShow)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "tr");
            __builder.AddAttribute(61, "b-dpmqsdio88");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "b-dpmqsdio88");
            __builder.AddContent(64, 
#nullable restore
#line 66 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                 item.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "td");
            __builder.AddAttribute(67, "b-dpmqsdio88");
            __builder.AddContent(68, 
#nullable restore
#line 67 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                 item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "b-dpmqsdio88");
            __builder.AddContent(72, 
#nullable restore
#line 68 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                 item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "td");
            __builder.AddAttribute(75, "b-dpmqsdio88");
            __builder.AddContent(76, 
#nullable restore
#line 69 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                 item.Specialities

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "b-dpmqsdio88");
            __builder.AddContent(80, 
#nullable restore
#line 70 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                 item.Birthday

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                            ");
            __builder.OpenElement(82, "td");
            __builder.AddAttribute(83, "b-dpmqsdio88");
            __builder.AddContent(84, 
#nullable restore
#line 71 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                                 item.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllProfile.razor"
       
    private IList<Profile> profilesToShow;
    private IList<Profile> profiles;
    private string? filterByName;

    private Role? role { get; set; }

    private async Task Filter()
    {
        profiles = await serviceUser.GetAllProfiles(role);
        profilesToShow = profiles;
    }


    private void FilterByName(ChangeEventArgs changeEventArgs)
    {
        filterByName = null;
        try
        {
            filterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        profilesToShow = profiles.Where(t => filterByName != null && (t.FirstName.ToLower().Contains(filterByName.ToLower()) || t.LastName.ToLower().Contains(filterByName.ToLower())) || filterByName == null).ToList();
    }
    

    /*protected override async Task OnInitializedAsync()
    {
        Console.WriteLine(isImportant);
    }*/




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceUser serviceUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
