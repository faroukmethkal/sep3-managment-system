#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823c04ad81d6ed503c673c617b0fe841af308ce2"
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
#line 1 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    public partial class ChangeStatus : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "b-v3xr8ptm6d");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "result");
            __builder.AddAttribute(5, "b-v3xr8ptm6d");
            __builder.OpenElement(6, "body");
            __builder.AddAttribute(7, "b-v3xr8ptm6d");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "name", "status");
            __builder.AddAttribute(10, "class", "form__input_select");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
                                                                NewStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewStatus = __value, NewStatus));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(13, "b-v3xr8ptm6d");
#nullable restore
#line 10 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
             foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                if (status != Status.Rejected && status!= Status.Approved)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 14 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
                                    status

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "b-v3xr8ptm6d");
            __builder.AddContent(17, 
#nullable restore
#line 14 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
                                             status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal_foter");
            __builder.AddAttribute(21, "b-v3xr8ptm6d");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
                      Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-success");
            __builder.AddAttribute(25, "b-v3xr8ptm6d");
            __builder.AddContent(26, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
                      ModalInstance.CancelAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-secondary");
            __builder.AddAttribute(31, "b-v3xr8ptm6d");
            __builder.AddContent(32, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Full-time\ChangeStatus.razor"
       

    [CascadingParameter]
    BlazoredModalInstance ModalInstance { get; set; }

    [Parameter]
    public Taskk Task { get; set; }

    private Status NewStatus { get; set; }

    private async Task Save()
    {
        await taskServices.ChangeStatus(Task.id,NewStatus);
        await ModalInstance.CancelAsync();
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskServices taskServices { get; set; }
    }
}
#pragma warning restore 1591
