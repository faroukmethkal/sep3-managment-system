#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bed8481e53e83f7e3bcae8a894f9fccd2165127"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Pages.Admin.ManageShift
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
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllShifts")]
    public partial class AllShifts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddAttribute(2, "b-xhwi1krbk2");
            __builder.OpenComponent<BlazorSep3.Pages.Admin.ManageShift.ShiftNavSide>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "main");
            __builder.AddAttribute(6, "class", "content-view");
            __builder.AddAttribute(7, "b-xhwi1krbk2");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "filter_option");
            __builder.AddAttribute(10, "b-xhwi1krbk2");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form__group");
            __builder.AddAttribute(13, "b-xhwi1krbk2");
            __builder.AddMarkupContent(14, "<div class=\"form__group-title\" b-xhwi1krbk2><span class=\"icon oi oi-calendar\" b-xhwi1krbk2></span>\r\n                    <label class=\"form__label\" b-xhwi1krbk2>Date</label></div>\r\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "date");
            __builder.AddAttribute(17, "class", "form__input");
            __builder.AddAttribute(18, "placeholder", "Date");
            __builder.AddAttribute(19, "min", 
#nullable restore
#line 19 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                          DateTime.Today

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                               date

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date = __value, date, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(22, "b-xhwi1krbk2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form__group");
            __builder.AddAttribute(26, "b-xhwi1krbk2");
            __builder.AddMarkupContent(27, "<div class=\"form__group-title\" b-xhwi1krbk2><span class=\"icon oi oi-clock\" b-xhwi1krbk2></span>\r\n                    <label class=\"form__label\" b-xhwi1krbk2>Start Time</label></div>\r\n                ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "time");
            __builder.AddAttribute(30, "class", "form__input");
            __builder.AddAttribute(31, "placeholder", "StartTime");
            __builder.AddAttribute(32, "min", 
#nullable restore
#line 27 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                               DateTime.Today.TimeOfDay

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                               startTime

#line default
#line hidden
#nullable disable
            , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => startTime = __value, startTime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(35, "b-xhwi1krbk2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form__group");
            __builder.AddAttribute(39, "b-xhwi1krbk2");
            __builder.AddMarkupContent(40, "<div class=\"form__group-title\" b-xhwi1krbk2><span class=\"icon oi oi-clock\" b-xhwi1krbk2></span>\r\n                    <label class=\"form__label\" b-xhwi1krbk2>Start Time</label></div>\r\n                ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "time");
            __builder.AddAttribute(43, "class", "form__input");
            __builder.AddAttribute(44, "placeholder", "EndTime");
            __builder.AddAttribute(45, "min", (
#nullable restore
#line 35 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                             DateTime.Today.TimeOfDay

#line default
#line hidden
#nullable disable
            ) + "+1");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                               endTime

#line default
#line hidden
#nullable disable
            , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => endTime = __value, endTime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(48, "b-xhwi1krbk2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form__group");
            __builder.AddAttribute(52, "b-xhwi1krbk2");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "button-spec");
            __builder.AddAttribute(55, "type", "submit");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                                                    Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "b-xhwi1krbk2");
            __builder.AddContent(58, "Filter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n            ");
            __builder.OpenElement(60, "form");
            __builder.AddAttribute(61, "action", "#");
            __builder.AddAttribute(62, "class", "form__group_search");
            __builder.AddAttribute(63, "b-xhwi1krbk2");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "class", "search_input");
            __builder.AddAttribute(67, "placeholder", "Search shifts");
            __builder.AddAttribute(68, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                                                                                (arg)=>FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "b-xhwi1krbk2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "search_result");
            __builder.AddAttribute(73, "b-xhwi1krbk2");
#nullable restore
#line 52 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
             if (shiftsToShow == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "<p b-xhwi1krbk2><em b-xhwi1krbk2>Loading...</em></p>");
#nullable restore
#line 57 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
            }
            else if (!shiftsToShow.Any())
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<p b-xhwi1krbk2><em b-xhwi1krbk2>No Tasks to show. </em></p>");
#nullable restore
#line 63 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(76, "table");
            __builder.AddAttribute(77, "class", "table");
            __builder.AddAttribute(78, "b-xhwi1krbk2");
            __builder.AddMarkupContent(79, @"<thead b-xhwi1krbk2><tr b-xhwi1krbk2><th b-xhwi1krbk2>Name</th>
                        <th b-xhwi1krbk2>Date</th>
                        <th b-xhwi1krbk2>Start Time</th>
                        <th b-xhwi1krbk2>End Time</th>
                        <th b-xhwi1krbk2>Edit</th>
                        <th b-xhwi1krbk2>Remove</th></tr></thead>
                    ");
            __builder.OpenElement(80, "tbody");
            __builder.AddAttribute(81, "b-xhwi1krbk2");
#nullable restore
#line 78 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                     foreach (var item in shiftsToShow)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "tr");
            __builder.AddAttribute(83, "b-xhwi1krbk2");
            __builder.OpenElement(84, "td");
            __builder.AddAttribute(85, "b-xhwi1krbk2");
            __builder.AddContent(86, 
#nullable restore
#line 81 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                 item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.OpenElement(88, "td");
            __builder.AddAttribute(89, "b-xhwi1krbk2");
            __builder.AddContent(90, 
#nullable restore
#line 82 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                 item.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                            ");
            __builder.OpenElement(92, "td");
            __builder.AddAttribute(93, "b-xhwi1krbk2");
            __builder.AddContent(94, 
#nullable restore
#line 83 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                 item.StartTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                            ");
            __builder.OpenElement(96, "td");
            __builder.AddAttribute(97, "b-xhwi1krbk2");
            __builder.AddContent(98, 
#nullable restore
#line 84 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                 item.EndTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                            ");
            __builder.OpenElement(100, "td");
            __builder.AddAttribute(101, "b-xhwi1krbk2");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                                    () => Edit(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "b-xhwi1krbk2");
            __builder.AddMarkupContent(105, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\" b-xhwi1krbk2></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "b-xhwi1krbk2");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                                                    () => Remove(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "b-xhwi1krbk2");
            __builder.AddMarkupContent(112, "<i class=\"oi oi-delete\" style=\"color:red\" b-xhwi1krbk2></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 99 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
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
#line 104 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageShift\AllShifts.razor"
       
    private IList<Shift> shiftsToShow;
    private IList<Shift> shifts;
    private string? filterByName;

    private DateTime? date { get; set; }
    private DateTime? startTime { get; set; }
    private DateTime? endTime { get; set; }


    private async Task Filter()
    {
        shifts = await shiftService.getShifts(date, startTime, endTime);
        shiftsToShow = shifts;
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
        shifts = shifts.Where(t => filterByName != null && (t.Name.ToLower().Contains(filterByName.ToLower()) || t.Description.ToLower().Contains(filterByName.ToLower())) || filterByName == null).ToList();
    }

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"/EditShift/{id}");
    }
    
    private void Remove(int id)
    {
        shiftService.RemoveShift(id);
    }

    protected override async Task OnInitializedAsync()
    {
    //
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShiftService shiftService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
