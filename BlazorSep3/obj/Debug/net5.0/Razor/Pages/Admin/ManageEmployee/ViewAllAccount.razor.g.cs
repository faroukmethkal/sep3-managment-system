#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b30d0bdcdb8cedcdc9a7fc02e1e342efc263fc"
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
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAllAccount")]
    public partial class ViewAllAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddAttribute(2, "b-i1oonn7s1f");
            __builder.OpenComponent<BlazorSep3.Pages.Admin.ManageEmployee.EmployeeSideNav>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n ");
            __builder.OpenElement(5, "main");
            __builder.AddAttribute(6, "class", "content-view");
            __builder.AddAttribute(7, "b-i1oonn7s1f");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form");
            __builder.AddAttribute(10, "b-i1oonn7s1f");
            __builder.AddMarkupContent(11, "<div class=\"form-header\" b-i1oonn7s1f><h2 b-i1oonn7s1f>\r\n                    Look for account\r\n                </h2></div>\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "b-i1oonn7s1f");
            __builder.AddMarkupContent(14, "<div class=\"form__group-title\" b-i1oonn7s1f><span class=\"icon oi oi-person\" b-i1oonn7s1f></span>\r\n                    <label class=\"form__label\" b-i1oonn7s1f>Search by username</label></div>\r\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "search_input");
            __builder.AddAttribute(18, "placeholder", "Username");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
                                                                                      searchUsername

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchUsername = __value, searchUsername));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(21, "b-i1oonn7s1f");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "search_button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
                                                        SearchByUsername

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "b-i1oonn7s1f");
            __builder.AddMarkupContent(27, "<span class=\"icon oi oi-magnifying-glass\" b-i1oonn7s1f>Search</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "b-i1oonn7s1f");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "class", "error-message");
            __builder.AddAttribute(33, "b-i1oonn7s1f");
            __builder.AddContent(34, 
#nullable restore
#line 27 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
                                             errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
             if (account == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<p b-i1oonn7s1f><em b-i1oonn7s1f>Search by username...</em></p>");
#nullable restore
#line 34 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form_parts");
            __builder.AddAttribute(38, "b-i1oonn7s1f");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "b-i1oonn7s1f");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form__group");
            __builder.AddAttribute(43, "b-i1oonn7s1f");
            __builder.AddMarkupContent(44, "<div class=\"icon\" b-i1oonn7s1f><span class=\"oi oi-person\" b-i1oonn7s1f></span></div>\r\n                            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "b-i1oonn7s1f");
            __builder.AddMarkupContent(47, "<label for=\"name\" class=\"form__label\" b-i1oonn7s1f>Username</label>\r\n                                ");
            __builder.OpenElement(48, "label");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "class", "form__account");
            __builder.AddAttribute(51, "b-i1oonn7s1f");
            __builder.AddContent(52, 
#nullable restore
#line 45 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
                                                                          account.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n                        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form__group");
            __builder.AddAttribute(56, "b-i1oonn7s1f");
            __builder.AddMarkupContent(57, "<div class=\"icon\" b-i1oonn7s1f><span class=\"oi oi-key\" b-i1oonn7s1f></span></div>\r\n                            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "b-i1oonn7s1f");
            __builder.AddMarkupContent(60, "<label class=\"form__label\" b-i1oonn7s1f>Password</label>\r\n                                ");
            __builder.OpenElement(61, "label");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "class", "form__account");
            __builder.AddAttribute(64, "b-i1oonn7s1f");
            __builder.AddContent(65, 
#nullable restore
#line 56 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
                                                                          account.password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n                        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form__group");
            __builder.AddAttribute(69, "b-i1oonn7s1f");
            __builder.AddMarkupContent(70, "<div class=\"icon\" b-i1oonn7s1f><span class=\"oi oi-briefcase\" b-i1oonn7s1f></span></div>\r\n                            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "b-i1oonn7s1f");
            __builder.AddMarkupContent(73, "<label class=\"form__label\" b-i1oonn7s1f>Role</label>\r\n                                ");
            __builder.OpenElement(74, "label");
            __builder.AddAttribute(75, "type", "text");
            __builder.AddAttribute(76, "class", "form__account");
            __builder.AddAttribute(77, "b-i1oonn7s1f");
            __builder.AddContent(78, 
#nullable restore
#line 67 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
                                                                          account.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            }\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageEmployee\ViewAllAccount.razor"
       

    [CascadingParameter]
    public MainLayout Layout { get; set; }

    private Account account;
    private string errorMessage;
    private string? searchUsername;

    private async Task SearchByUsername()
    {
        try
        {
            account = await serviceUser.GetAccountByUsername(searchUsername);
            errorMessage = "";
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceUser serviceUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
