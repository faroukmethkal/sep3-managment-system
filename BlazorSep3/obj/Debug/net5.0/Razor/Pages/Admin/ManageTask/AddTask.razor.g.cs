#pragma checksum "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc66570b8179de6544b98e6fb095bf8bd1d47264"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddTask")]
    public partial class AddTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<header b-f5ypzovfwh></header>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "content");
            __builder.AddAttribute(3, "b-f5ypzovfwh");
            __builder.OpenComponent<BlazorSep3.Pages.Admin.ManageTask.TaskNavSide>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "main");
            __builder.AddAttribute(7, "class", "content-view");
            __builder.AddAttribute(8, "b-f5ypzovfwh");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form");
            __builder.AddAttribute(11, "b-f5ypzovfwh");
            __builder.AddMarkupContent(12, "<div class=\"form-header\" b-f5ypzovfwh><h2 b-f5ypzovfwh>\r\n                    Add new task\r\n                </h2></div>\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "b-f5ypzovfwh");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "error-message");
            __builder.AddAttribute(17, "b-f5ypzovfwh");
            __builder.AddContent(18, 
#nullable restore
#line 21 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                             errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form_parts");
            __builder.AddAttribute(22, "b-f5ypzovfwh");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form_part1");
            __builder.AddAttribute(25, "b-f5ypzovfwh");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form__group");
            __builder.AddAttribute(28, "b-f5ypzovfwh");
            __builder.AddMarkupContent(29, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-pencil\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "b-f5ypzovfwh");
            __builder.AddMarkupContent(32, "<label class=\"form__label\" b-f5ypzovfwh>Title</label>\r\n                            ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "text");
            __builder.AddAttribute(35, "class", "form__input");
            __builder.AddAttribute(36, "placeholder", "Title");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                               task.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.Title = __value, task.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(39, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form__group");
            __builder.AddAttribute(43, "b-f5ypzovfwh");
            __builder.AddMarkupContent(44, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-briefcase\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "b-f5ypzovfwh");
            __builder.AddMarkupContent(47, "<label class=\"form__label\" b-f5ypzovfwh>Description</label>\r\n                            ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "class", "form__input");
            __builder.AddAttribute(51, "placeholder", "Description");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                                    task.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.Description = __value, task.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(54, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form__group");
            __builder.AddAttribute(58, "b-f5ypzovfwh");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form__group");
            __builder.AddAttribute(61, "b-f5ypzovfwh");
            __builder.AddMarkupContent(62, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-person\" b-f5ypzovfwh></span></div>\r\n                            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "b-f5ypzovfwh");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "b-f5ypzovfwh");
            __builder.AddMarkupContent(67, "<label class=\"form__label\" b-f5ypzovfwh>Speciality</label>\r\n                                    ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                        () => ShowEditSpecialities()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "b-f5ypzovfwh");
            __builder.AddContent(72, "Add Specialities");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n\r\n                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "form_part2");
            __builder.AddAttribute(76, "b-f5ypzovfwh");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "form__group");
            __builder.AddAttribute(79, "b-f5ypzovfwh");
            __builder.AddMarkupContent(80, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-calendar\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "b-f5ypzovfwh");
            __builder.AddMarkupContent(83, "<label class=\"form__label\" b-f5ypzovfwh>StartDate</label>\r\n                            ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "date");
            __builder.AddAttribute(86, "class", "form__input");
            __builder.AddAttribute(87, "placeholder", "StartDate");
            __builder.AddAttribute(88, "min", 
#nullable restore
#line 72 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                        DateTime.Today

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                                  task.StartDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.StartDate = __value, task.StartDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(91, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n                    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form__group");
            __builder.AddAttribute(95, "b-f5ypzovfwh");
            __builder.AddMarkupContent(96, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-calculator\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "b-f5ypzovfwh");
            __builder.AddMarkupContent(99, "<label class=\"form__label\" b-f5ypzovfwh>Estimate</label>\r\n                            ");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "type", "number");
            __builder.AddAttribute(102, "class", "form__input");
            __builder.AddAttribute(103, "placeholder", "Estimate");
            __builder.AddAttribute(104, "min", "1");
            __builder.AddAttribute(105, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                                   task.Estimate

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.Estimate = __value, task.Estimate, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(107, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n                    ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "form__group");
            __builder.AddAttribute(111, "b-f5ypzovfwh");
            __builder.AddMarkupContent(112, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-calendar\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "b-f5ypzovfwh");
            __builder.AddMarkupContent(115, "<label class=\"form__label\" b-f5ypzovfwh>Deadline</label>\r\n                            ");
            __builder.OpenElement(116, "input");
            __builder.AddAttribute(117, "type", "date");
            __builder.AddAttribute(118, "class", "form__input");
            __builder.AddAttribute(119, "placeholder", "Deadline");
            __builder.AddAttribute(120, "min", 
#nullable restore
#line 94 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                        DateTime.Today.AddDays(1)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(121, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                                 task.Deadline

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(122, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.Deadline = __value, task.Deadline, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(123, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\r\n                    ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "form__group");
            __builder.AddAttribute(127, "b-f5ypzovfwh");
            __builder.AddMarkupContent(128, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-pencil\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "b-f5ypzovfwh");
            __builder.AddMarkupContent(131, "<label class=\"form__label\" b-f5ypzovfwh>Status</label>\r\n\r\n                            ");
            __builder.OpenElement(132, "select");
            __builder.AddAttribute(133, "name", "specialties");
            __builder.AddAttribute(134, "class", "form__input_select");
            __builder.AddAttribute(135, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                         task.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.Status = __value, task.Status));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(137, "b-f5ypzovfwh");
#nullable restore
#line 106 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                 foreach (var status in Enum.GetValues(typeof(Status)))
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(138, "option");
            __builder.AddAttribute(139, "value", 
#nullable restore
#line 108 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                    status

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(140, "b-f5ypzovfwh");
            __builder.AddContent(141, 
#nullable restore
#line 108 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                             status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 109 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n            ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "form__group");
            __builder.AddAttribute(145, "b-f5ypzovfwh");
            __builder.OpenElement(146, "button");
            __builder.AddAttribute(147, "class", "button-white");
            __builder.AddAttribute(148, "type", "submit");
            __builder.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                     AddTaskk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(150, "b-f5ypzovfwh");
            __builder.AddContent(151, "Add Task");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
       
    [CascadingParameter]
    public IModalService Modal { get; set; }

    [CascadingParameter]
    public MainLayout Layout { get; set; }

    public List<Speciality> specList ;
  

    private string errorMessage;
    
    private Taskk task = new Taskk();

   // [Range(1, int.MaxValue)] private int currentPeople = 1;


    private async Task AddTaskk()
    {
        try
        {
            await AddToSpecialties();
            Console.WriteLine(task);
            await taskServices.AddTask(task);
            errorMessage = "";
            NavigationManager.NavigateTo("/ManageTask");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            errorMessage = e.Message;
        }
    }
    
    async Task ShowEditSpecialities()
    {
        var parameters = new ModalParameters();
        parameters.Add("Specialities", task.Specialities);
        
        var modelResult = Modal.Show<EditTaskSpecialties>("Add Task's Specialties", parameters);
        var result = await modelResult.Result;
        specList = (List<Speciality>) result.Data;
        
    }
    
    private async Task AddToSpecialties()
    {
        foreach (var s in specList)
        {
            if (!task.Specialities.ContainsKey(s.name))
            {
                task.Specialities.Add(s.name, s.requirednumber);
            } 
        }
        
    }



    protected override void OnInitialized()
    {
        task.StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        task.Deadline = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(7);
        task.Estimate = 1;
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskServices taskServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
