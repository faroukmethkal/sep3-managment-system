#pragma checksum "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5eb7f13f18d2feabed13bbf0a3f3d47b529935a"
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
#line 12 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyTasks")]
    public partial class MyTasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddAttribute(2, "b-zjodemoi42");
            __builder.OpenComponent<BlazorSep3.Pages.Full_time.TaskEmployeeNavSide>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "main");
            __builder.AddAttribute(6, "class", "content-view");
            __builder.AddAttribute(7, "b-zjodemoi42");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "filter_option");
            __builder.AddAttribute(10, "b-zjodemoi42");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form__group");
            __builder.AddAttribute(13, "b-zjodemoi42");
            __builder.AddMarkupContent(14, "<div class=\"form__group-title\" b-zjodemoi42><span class=\"icon oi oi-person\" b-zjodemoi42></span>\r\n                    <label class=\"form__label\" b-zjodemoi42>Status</label></div>\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "b-zjodemoi42");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "name", "specialties");
            __builder.AddAttribute(19, "class", "form__input_select");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                                                 status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => status = __value, status));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(22, "b-zjodemoi42");
#nullable restore
#line 20 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                         foreach (var status in Enum.GetValues(typeof(Status)))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 22 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                            status

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "b-zjodemoi42");
            __builder.AddContent(26, 
#nullable restore
#line 22 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                     status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
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
            __builder.AddAttribute(30, "b-zjodemoi42");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "button-spec");
            __builder.AddAttribute(33, "type", "submit");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                                    Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "b-zjodemoi42");
            __builder.AddContent(36, "Filter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n            ");
            __builder.OpenElement(38, "form");
            __builder.AddAttribute(39, "action", "#");
            __builder.AddAttribute(40, "class", "form__group_search");
            __builder.AddAttribute(41, "b-zjodemoi42");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "class", "search_input");
            __builder.AddAttribute(45, "placeholder", "Search tasks");
            __builder.AddAttribute(46, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                                                               (arg) => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "b-zjodemoi42");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "search_result");
            __builder.AddAttribute(51, "b-zjodemoi42");
#nullable restore
#line 40 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
             if (tasksToShow == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<p b-zjodemoi42><em b-zjodemoi42>Loading...</em></p>");
#nullable restore
#line 45 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
            }
            else if (!tasksToShow.Any())
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<p b-zjodemoi42><em b-zjodemoi42>No Tasks to show. </em></p>");
#nullable restore
#line 51 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "class", "table");
            __builder.AddAttribute(56, "b-zjodemoi42");
            __builder.AddMarkupContent(57, @"<thead b-zjodemoi42><tr b-zjodemoi42><th b-zjodemoi42>Title</th>
                        <th b-zjodemoi42>Start Date</th>
                        <th b-zjodemoi42>Estimate</th>
                        <th b-zjodemoi42>Progress</th>
                        <th b-zjodemoi42>Add Hours</th>
                        <th b-zjodemoi42>Deadline</th>
                        <th b-zjodemoi42>Status</th></tr></thead>
                    ");
            __builder.OpenElement(58, "tbody");
            __builder.AddAttribute(59, "b-zjodemoi42");
#nullable restore
#line 67 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                     foreach (var item in tasksToShow)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "tr");
            __builder.AddAttribute(61, "b-zjodemoi42");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "b-zjodemoi42");
            __builder.AddContent(64, 
#nullable restore
#line 70 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                 item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "td");
            __builder.AddAttribute(67, "b-zjodemoi42");
            __builder.AddContent(68, 
#nullable restore
#line 71 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                 item.StartDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "b-zjodemoi42");
            __builder.AddContent(72, 
#nullable restore
#line 72 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                 item.Estimate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "td");
            __builder.AddAttribute(75, "b-zjodemoi42");
            __builder.OpenElement(76, "p");
            __builder.AddAttribute(77, "b-zjodemoi42");
            __builder.AddContent(78, 
#nullable restore
#line 75 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                     item.SpentHours

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(79, "/");
            __builder.AddContent(80, 
#nullable restore
#line 75 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                      item.Estimate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(81, "\r\n                                    ");
            __builder.OpenElement(82, "progress");
            __builder.AddAttribute(83, "value", 
#nullable restore
#line 76 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                      item.SpentHours

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(84, "max", 
#nullable restore
#line 76 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                                             item.Estimate

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(85, "b-zjodemoi42");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                    ");
            __builder.AddContent(87, 
#nullable restore
#line 77 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                     CalculatePercentage(item.SpentHours, item.Estimate)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                            ");
            __builder.OpenElement(89, "td");
            __builder.AddAttribute(90, "b-zjodemoi42");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                    () => AddHoursSpent(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "class", "oi oi-plus");
            __builder.AddAttribute(94, "style", "color:green");
            __builder.AddAttribute(95, "b-zjodemoi42");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                            ");
            __builder.OpenElement(97, "td");
            __builder.AddAttribute(98, "b-zjodemoi42");
            __builder.AddContent(99, 
#nullable restore
#line 83 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                 item.Deadline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                            ");
            __builder.OpenElement(101, "td");
            __builder.AddAttribute(102, "b-zjodemoi42");
            __builder.OpenElement(103, "button");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                                    () => ChangeStatus(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "class", "btn btn-secondary");
            __builder.AddAttribute(106, "b-zjodemoi42");
            __builder.AddContent(107, 
#nullable restore
#line 86 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                                     item.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 90 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 93 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
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
#line 98 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Full-time\MyTasks.razor"
       
    [CascadingParameter]
    public IModalService Modal { get; set; }

    private IList<Taskk> tasksToShow;
    private IList<Taskk> tasks;
    private string? filterByName;
    private double hours;
    private int idToChange;

    private Status? status { get; set; }

    private async Task Filter()
    {
        tasks = await taskServices.GetAllMyTasks(status);
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

    private double CalculatePercentage(double hours, double estimate)
    {
        return hours / estimate * 100;
    }

    private async Task AddHoursSpent(Taskk task)
    {
        var parameters = new ModalParameters();
        parameters.Add("taskId", task.id);
        var modelResult = Modal.Show<AddHoursToTask>("Add time spent on task: "+ task.id, parameters);
    }
    private async void ChangeStatus(Taskk task)
    {
        var parameters = new ModalParameters();
        parameters.Add("Task", task);
        var modelResult =Modal.Show<ChangeStatus>("Change Status of task: "+task.Title, parameters);
        var result = await modelResult.Result;
        Taskk taskResult = (Taskk) result.Data;
        
        foreach (var t in tasksToShow)
        {
            if (t.id == taskResult.id) t.Status = taskResult.Status;
        }

        tasks = tasksToShow;
    }

    private void ExecuteFilter()
    {
        tasksToShow = tasks.Where(t => filterByName != null && (t.Title.ToLower().Contains(filterByName.ToLower()) || t.Description.ToLower().Contains(filterByName.ToLower())) || filterByName == null).ToList();
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
