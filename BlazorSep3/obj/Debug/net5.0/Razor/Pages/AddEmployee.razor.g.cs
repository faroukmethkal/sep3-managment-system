#pragma checksum "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "876cf4df57ec5363f29106c799050996834e02b7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 3 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 10 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\_Imports.razor"
using BlazorSep3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
using BlazorSep3.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEmployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-swyd6ass2n>AddEmployee</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main");
            __builder.AddAttribute(3, "b-swyd6ass2n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-Contanier");
            __builder.AddAttribute(6, "b-swyd6ass2n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "header");
            __builder.AddAttribute(9, "b-swyd6ass2n");
            __builder.AddMarkupContent(10, "<span b-swyd6ass2n> Add Employee </span>\r\n                <br b-swyd6ass2n> ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "error");
            __builder.AddAttribute(13, "b-swyd6ass2n");
            __builder.AddContent(14, 
#nullable restore
#line 16 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                           errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-field");
            __builder.AddAttribute(18, "b-swyd6ass2n");
            __builder.AddMarkupContent(19, "<div b-swyd6ass2n><label class=\"FirstName\" b-swyd6ass2n><span class=\"oi oi-person\" b-swyd6ass2n></span> First Name\r\n                    </label></div>\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "b-swyd6ass2n");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "placeholder", "First Name");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                                            profile.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => profile.FirstName = __value, profile.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(26, "b-swyd6ass2n");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-field");
            __builder.AddAttribute(30, "b-swyd6ass2n");
            __builder.AddMarkupContent(31, "<div b-swyd6ass2n><label class=\"LastName\" b-swyd6ass2n><span class=\"oi oi-pencil\" b-swyd6ass2n></span> Last Name\r\n                    </label></div>\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "b-swyd6ass2n");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "placeholder", "Last Name");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                                          profile.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => profile.LastName = __value, profile.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(38, "b-swyd6ass2n");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-field");
            __builder.AddAttribute(42, "b-swyd6ass2n");
            __builder.AddMarkupContent(43, "<div b-swyd6ass2n><label class=\"Birthday\" b-swyd6ass2n><span class=\"oi oi-calendar\" b-swyd6ass2n></span> Birthday\r\n                    </label></div>\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "b-swyd6ass2n");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "date");
            __builder.AddAttribute(48, "placeholder", "Birthday");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                                                     profile.Birthday

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => profile.Birthday = __value, profile.Birthday, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(51, "b-swyd6ass2n");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-field");
            __builder.AddAttribute(55, "b-swyd6ass2n");
            __builder.AddMarkupContent(56, "<div b-swyd6ass2n><label class=\"Specialities\" b-swyd6ass2n><span class=\"oi-magnifying-glass\" b-swyd6ass2n></span> Specialities \r\n                    </label></div>\r\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "b-swyd6ass2n");
            __builder.OpenElement(59, "select");
            __builder.AddAttribute(60, "placeholder", "Specialities");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                                              profile.Specialities

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => profile.Specialities = __value, profile.Specialities));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(63, "b-swyd6ass2n");
#nullable restore
#line 56 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                     foreach (var speciality in Enum.GetValues(typeof(Specialities)))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", 
#nullable restore
#line 58 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                            speciality

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "b-swyd6ass2n");
            __builder.AddContent(67, 
#nullable restore
#line 58 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                                         speciality

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-field");
            __builder.AddAttribute(71, "b-swyd6ass2n");
            __builder.AddMarkupContent(72, "<div b-swyd6ass2n><label class=\"Role\" b-swyd6ass2n><span class=\"oi oi-person\" b-swyd6ass2n></span> Role\r\n                    </label></div>\r\n                ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "b-swyd6ass2n");
            __builder.OpenElement(75, "select");
            __builder.AddAttribute(76, "rows", "1");
            __builder.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                            profile.Role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => profile.Role = __value, profile.Role));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(79, "b-swyd6ass2n");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "FullTimeEmployee");
            __builder.AddAttribute(82, "b-swyd6ass2n");
            __builder.AddContent(83, "Full-Time Employee");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                        ");
            __builder.OpenElement(85, "option");
            __builder.AddAttribute(86, "value", "PartTimeEmployee");
            __builder.AddAttribute(87, "b-swyd6ass2n");
            __builder.AddContent(88, "Part-time Employee");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "form-field footer");
            __builder.AddAttribute(92, "b-swyd6ass2n");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "b-swyd6ass2n");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "class", "btn btn-success");
            __builder.AddAttribute(97, "type", "submit");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
                                                                            PerformRegister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "b-swyd6ass2n");
            __builder.AddContent(100, "Register");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\terez\RiderProjects\BlazorSep3LoginExample\BlazorSep3\Pages\AddEmployee.razor"
       

    [CascadingParameter]
    public MainLayout Layout { get; set; }
    private string errorMessage;
    private Profile profile = new Profile();

    public async Task PerformRegister()
    {
        try
        {
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Register(profile);
            errorMessage = "Employee has been registered";
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
