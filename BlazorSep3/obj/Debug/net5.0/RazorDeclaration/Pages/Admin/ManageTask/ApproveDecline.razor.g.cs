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
#line 1 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\ApproveDecline.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\ApproveDecline.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\ApproveDecline.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    public partial class ApproveDecline : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\ApproveDecline.razor"
       

    [CascadingParameter]
    BlazoredModalInstance ModalInstance { get; set; }

    [Parameter]
    public Taskk Task { get; set; }

    private async Task Accept(int id)
    {
        await taskServices.ApproveTask(id);
        await ModalInstance.CancelAsync();
    }
    private async Task Decline(int id)
    {
        await taskServices.DeclineTask(id);
        await ModalInstance.CancelAsync();
    }
    
    
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskServices taskServices { get; set; }
    }
}
#pragma warning restore 1591
