#pragma checksum "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce86c6458248de08ec42742ab603465203c57f7e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3.Pages.Full_time
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 3 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 2 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllAvailableTasks")]
    public partial class AllAvailableTasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddAttribute(2, "b-c3k7vppjaw");
            __builder.OpenComponent<BlazorSep3.Pages.Full_time.TaskEmployeeNavSide>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "main");
            __builder.AddAttribute(6, "class", "content-view");
            __builder.AddAttribute(7, "b-c3k7vppjaw");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "filter_option");
            __builder.AddAttribute(10, "b-c3k7vppjaw");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form__group");
            __builder.AddAttribute(13, "b-c3k7vppjaw");
            __builder.AddMarkupContent(14, "<div class=\"form__group-title\" b-c3k7vppjaw><span class=\"icon oi oi-calendar\" b-c3k7vppjaw></span>\r\n                    <label class=\"form__label\" b-c3k7vppjaw>StartDate</label></div>\r\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "date");
            __builder.AddAttribute(17, "class", "form__input");
            __builder.AddAttribute(18, "placeholder", "StartDate");
            __builder.AddAttribute(19, "min", 
#nullable restore
#line 19 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                               DateTime.Today

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                               startTime

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => startTime = __value, startTime, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(22, "b-c3k7vppjaw");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form__group");
            __builder.AddAttribute(26, "b-c3k7vppjaw");
            __builder.AddMarkupContent(27, "<div class=\"form__group-title\" b-c3k7vppjaw><span class=\"icon oi oi-calendar\" b-c3k7vppjaw></span>\r\n                    <label class=\"form__label\" b-c3k7vppjaw>Deadline</label></div>\r\n                ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "date");
            __builder.AddAttribute(30, "class", "form__input");
            __builder.AddAttribute(31, "placeholder", "Deadline");
            __builder.AddAttribute(32, "min", 
#nullable restore
#line 27 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                              DateTime.Today.AddDays(1)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                               deadline

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => deadline = __value, deadline, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(35, "b-c3k7vppjaw");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form__group");
            __builder.AddAttribute(39, "b-c3k7vppjaw");
            __builder.AddMarkupContent(40, "<div class=\"form__group-title\" b-c3k7vppjaw><span class=\"icon oi oi-person\" b-c3k7vppjaw></span>\r\n                    <label class=\"form__label\" b-c3k7vppjaw>Status</label></div>\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "b-c3k7vppjaw");
            __builder.OpenElement(43, "select");
            __builder.AddAttribute(44, "name", "specialties");
            __builder.AddAttribute(45, "class", "form__input_select");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                                                                 status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => status = __value, status));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(48, "b-c3k7vppjaw");
#nullable restore
#line 36 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                         foreach (var status in Enum.GetValues(typeof(Status)))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", 
#nullable restore
#line 38 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                            status

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "b-c3k7vppjaw");
            __builder.AddContent(52, 
#nullable restore
#line 38 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                                     status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form__group");
            __builder.AddAttribute(56, "b-c3k7vppjaw");
            __builder.AddMarkupContent(57, "<div class=\"form__group-title\" b-c3k7vppjaw><span class=\"icon oi oi-pencil\" b-c3k7vppjaw></span>\r\n                    <label class=\"form__label\" b-c3k7vppjaw>Is important</label></div>\r\n                ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "checkbox");
            __builder.AddAttribute(60, "class", "form__radio-input");
            __builder.AddAttribute(61, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                                                         isImportant

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => isImportant = __value, isImportant));
            __builder.SetUpdatesAttributeName("checked");
            __builder.AddAttribute(63, "b-c3k7vppjaw");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form__group");
            __builder.AddAttribute(67, "b-c3k7vppjaw");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "class", "button-spec");
            __builder.AddAttribute(70, "type", "submit");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                                                    Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "b-c3k7vppjaw");
            __builder.AddContent(73, "Filter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n            ");
            __builder.OpenElement(75, "form");
            __builder.AddAttribute(76, "action", "#");
            __builder.AddAttribute(77, "class", "form__group_search");
            __builder.AddAttribute(78, "b-c3k7vppjaw");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "text");
            __builder.AddAttribute(81, "class", "search_input");
            __builder.AddAttribute(82, "placeholder", "Search tasks");
            __builder.AddAttribute(83, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 56 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                                                                               (arg)=>FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "b-c3k7vppjaw");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "search_result");
            __builder.AddAttribute(88, "b-c3k7vppjaw");
#nullable restore
#line 65 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
             if (tasksToShow == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "<p b-c3k7vppjaw><em b-c3k7vppjaw>Loading...</em></p>");
#nullable restore
#line 70 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
            }
            else if (!tasksToShow.Any())
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "<p b-c3k7vppjaw><em b-c3k7vppjaw>No Tasks to show. </em></p>");
#nullable restore
#line 76 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "table");
            __builder.AddAttribute(92, "class", "table");
            __builder.AddAttribute(93, "b-c3k7vppjaw");
            __builder.AddMarkupContent(94, @"<thead b-c3k7vppjaw><tr b-c3k7vppjaw><th b-c3k7vppjaw>Title</th>
                        <th b-c3k7vppjaw>Start Date</th>
                        <th b-c3k7vppjaw>Estimate</th>
                        <th b-c3k7vppjaw>Deadline</th>
                        <th b-c3k7vppjaw>Number of employees</th></tr></thead>
                    ");
            __builder.OpenElement(95, "tbody");
            __builder.AddAttribute(96, "b-c3k7vppjaw");
#nullable restore
#line 90 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                     foreach (var item in tasksToShow)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(97, "tr");
            __builder.AddAttribute(98, "b-c3k7vppjaw");
            __builder.OpenElement(99, "td");
            __builder.AddAttribute(100, "b-c3k7vppjaw");
            __builder.AddContent(101, 
#nullable restore
#line 93 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                 item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.OpenElement(103, "td");
            __builder.AddAttribute(104, "b-c3k7vppjaw");
            __builder.AddContent(105, 
#nullable restore
#line 94 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                 item.StartDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "b-c3k7vppjaw");
            __builder.AddContent(109, 
#nullable restore
#line 95 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                 item.Estimate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                            ");
            __builder.OpenElement(111, "td");
            __builder.AddAttribute(112, "b-c3k7vppjaw");
            __builder.AddContent(113, 
#nullable restore
#line 96 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                 item.Deadline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                            ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "b-c3k7vppjaw");
            __builder.AddContent(117, 
#nullable restore
#line 97 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                 item.GetFinalNumberOfPeople()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "b-c3k7vppjaw");
            __builder.OpenElement(121, "button");
            __builder.AddAttribute(122, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                                                    () => TakeTask(item.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "b-c3k7vppjaw");
            __builder.AddMarkupContent(124, "<i class=\"oi oi-arrow-thick-right\" style=\"color:green\" b-c3k7vppjaw></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 104 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 107 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
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
#line 112 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\AllAvailableTasks.razor"
       
    private IList<Taskk> tasksToShow;
    private IList<Taskk> tasks;
    private string? filterByName;

    private DateTime? startTime { get; set; }
    private DateTime? deadline { get; set; }
    private bool? isImportant { get; set; }
    private Status? status { get; set; }

    private async Task Filter()
    {
        tasks = await taskServices.GetAllRelativeTasks(startTime, deadline, isImportant,status);
        tasksToShow = tasks;
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
        tasksToShow = tasks.Where(t => filterByName != null && (t.Title.ToLower().Contains(filterByName.ToLower()) || t.Description.ToLower().Contains(filterByName.ToLower())) || filterByName == null).ToList();
    }

    private void TakeTask(int id)
    {
        NavigationManager.NavigateTo($"/TakeTask{id}");
    }

    /*protected override async Task OnInitializedAsync()
    {
        Console.WriteLine(isImportant);
    }*/


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskServices taskServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
