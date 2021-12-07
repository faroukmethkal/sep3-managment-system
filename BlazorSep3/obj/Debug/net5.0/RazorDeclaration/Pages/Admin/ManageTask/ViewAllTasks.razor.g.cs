// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSep3.Pages.Admin.ManageTask
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
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\ViewAllTasks.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\ViewAllTasks.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAllTasks")]
    public partial class ViewAllTasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\ViewAllTasks.razor"
       

    [CascadingParameter]
    public IModalService Modal { get; set; }

    private IList<Taskk> tasksToShow;
    private IList<Taskk> tasks;
    private string? filterByName;

    private DateTime? startTime { get; set; }
    private DateTime? deadline { get; set; }
    private bool? isImportant { get; set; }
    private Status? status { get; set; }

    private async Task Filter()
    {
        tasks = await taskServices.GetTasks(startTime, deadline, isImportant, status);
        tasksToShow = tasks;
    }

    async Task ShowEditSpecialities(Taskk task1)
    {
        var parameters = new ModalParameters();
        parameters.Add("Specialities", task1.Specialities);
        Modal.Show<ViewTaskSpecialties>("Task's Specialties", parameters);
    }
    async Task ShowTeamWorkingOnTask(int id)
    {
        var parameters = new ModalParameters();
        parameters.Add("Id", id);
        Modal.Show<ViewTeam>("Team Working on Task", parameters);
    }
    
    async Task ApproveOrDecline(Taskk task1)
    {
        var parameters = new ModalParameters();
        parameters.Add("Task", task1);
        Modal.Show<ApproveDecline>("Approve or decline task: "+task1.Title, parameters);
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

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"/EditTask/{id}");
    }

    private async Task Remove(int id)
    {
        bool confirmed = await _jsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to remove this task?"); // Confirm
        if (confirmed)
        {
            await taskServices.RemoveTask(id);
        }
    }
    

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine(isImportant);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskServices taskServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
