#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3f4d0ad49d09212b8f8595d1c2fb8395241d849"
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
#line 1 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    public partial class ViewTeamWorkingOnTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "b-s4vsrm1c2i");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "result");
            __builder.AddAttribute(5, "b-s4vsrm1c2i");
#nullable restore
#line 8 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
         if (team == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p b-s4vsrm1c2i><em b-s4vsrm1c2i>team is not exist</em></p>");
#nullable restore
#line 13 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
        }
        else if (!team.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p b-s4vsrm1c2i><em b-s4vsrm1c2i>no team been assigned to taks</em></p>");
#nullable restore
#line 19 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-hover");
            __builder.AddAttribute(10, "b-s4vsrm1c2i");
            __builder.AddMarkupContent(11, @"<thead style=""position: sticky;top:0; z-index: 100"" class=""thead-dark"" b-s4vsrm1c2i><tr b-s4vsrm1c2i><th b-s4vsrm1c2i>Name</th>
                    <th b-s4vsrm1c2i>Specialties</th>
                    <th b-s4vsrm1c2i>Age</th></tr></thead>
                ");
            __builder.OpenElement(12, "tbody");
            __builder.AddAttribute(13, "b-s4vsrm1c2i");
#nullable restore
#line 32 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
                 foreach (var t in team)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.AddAttribute(15, "b-s4vsrm1c2i");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "b-s4vsrm1c2i");
            __builder.AddContent(18, 
#nullable restore
#line 36 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
                             t.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " + ");
            __builder.AddContent(20, 
#nullable restore
#line 36 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
                                            t.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "b-s4vsrm1c2i");
            __builder.AddContent(24, 
#nullable restore
#line 39 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
                             splitOnCapitalLitter(t.Specialities)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "b-s4vsrm1c2i");
            __builder.AddContent(28, 
#nullable restore
#line 42 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
                             CalculateAge(t.Birthday)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "modal_foter");
            __builder.AddAttribute(32, "b-s4vsrm1c2i");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
                      ModalInstance.CancelAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn btn-secondary");
            __builder.AddAttribute(36, "b-s4vsrm1c2i");
            __builder.AddContent(37, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ViewTeamWorkingOnTask.razor"
       

    [CascadingParameter]
    BlazoredModalInstance ModalInstance { get; set; }

    [Parameter]
    public int Id { get; set; }

    IList<Profile> team = new List<Profile>();


    protected override async Task OnInitializedAsync()
    {
        team = await taskServices.GetTeamWorkingOnTask(Id);
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

    private int CalculateAge(DateTime birthda)
    {
        return DateTime.Now.Year - birthda.Year;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskServices taskServices { get; set; }
    }
}
#pragma warning restore 1591