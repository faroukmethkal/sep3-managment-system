#pragma checksum "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2fd14d963c6dc5160ccf17ab272ce0bef6e8819"
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
#line 2 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
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
#line 21 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
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
#line 32 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
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
#line 43 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
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
            __builder.AddMarkupContent(59, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-person\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "b-f5ypzovfwh");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "b-f5ypzovfwh");
            __builder.AddMarkupContent(64, "<label class=\"form__label\" b-f5ypzovfwh>Speciality</label>\r\n                                ");
            __builder.OpenElement(65, "select");
            __builder.AddAttribute(66, "name", "specialties");
            __builder.AddAttribute(67, "class", "form__input_select");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                             currentSpec

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentSpec = __value, currentSpec));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(70, "b-f5ypzovfwh");
#nullable restore
#line 55 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                     foreach (var speciality in Enum.GetValues(typeof(Specialities)))
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", 
#nullable restore
#line 57 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                        speciality

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(73, "b-f5ypzovfwh");
            __builder.AddContent(74, 
#nullable restore
#line 57 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                     splitOnCapitalLitter(speciality.ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "b-f5ypzovfwh");
            __builder.AddMarkupContent(78, "<label class=\"form__label\" b-f5ypzovfwh>Number of people</label>\r\n                                ");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "number");
            __builder.AddAttribute(81, "class", "form__input");
            __builder.AddAttribute(82, "placeholder", "NumberOfPeople");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                                             currentPeople

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentPeople = __value, currentPeople, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(85, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "b-f5ypzovfwh");
            __builder.OpenElement(89, "span");
            __builder.AddAttribute(90, "class", "specialty-message");
            __builder.AddAttribute(91, "b-f5ypzovfwh");
            __builder.AddContent(92, 
#nullable restore
#line 66 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                 textSpecialty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "form__group");
            __builder.AddAttribute(96, "b-f5ypzovfwh");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "class", "button-spec");
            __builder.AddAttribute(99, "type", "submit");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                    AddToSpecialties

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "b-f5ypzovfwh");
            __builder.AddContent(102, "Add Speciality");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n\r\n                ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "form_part2");
            __builder.AddAttribute(106, "b-f5ypzovfwh");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "form__group");
            __builder.AddAttribute(109, "b-f5ypzovfwh");
            __builder.AddMarkupContent(110, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-calendar\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "b-f5ypzovfwh");
            __builder.AddMarkupContent(113, "<label class=\"form__label\" b-f5ypzovfwh>StartDate</label>\r\n                            ");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "date");
            __builder.AddAttribute(116, "class", "form__input");
            __builder.AddAttribute(117, "placeholder", "StartDate");
            __builder.AddAttribute(118, "min", 
#nullable restore
#line 84 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                        DateTime.Today

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                                  task.StartDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.StartDate = __value, task.StartDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(121, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\r\n                    ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "form__group");
            __builder.AddAttribute(125, "b-f5ypzovfwh");
            __builder.AddMarkupContent(126, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-calculator\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "b-f5ypzovfwh");
            __builder.AddMarkupContent(129, "<label class=\"form__label\" b-f5ypzovfwh>Estimate</label>\r\n                            ");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "type", "number");
            __builder.AddAttribute(132, "class", "form__input");
            __builder.AddAttribute(133, "placeholder", "Estimate");
            __builder.AddAttribute(134, "min", "1");
            __builder.AddAttribute(135, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 94 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                                   task.Estimate

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(136, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.Estimate = __value, task.Estimate, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(137, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n\r\n                    ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "form__group");
            __builder.AddAttribute(141, "b-f5ypzovfwh");
            __builder.AddMarkupContent(142, "<div class=\"icon\" b-f5ypzovfwh><span class=\"oi oi-calendar\" b-f5ypzovfwh></span></div>\r\n                        ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "b-f5ypzovfwh");
            __builder.AddMarkupContent(145, "<label class=\"form__label\" b-f5ypzovfwh>Deadline</label>\r\n                            ");
            __builder.OpenElement(146, "input");
            __builder.AddAttribute(147, "type", "date");
            __builder.AddAttribute(148, "class", "form__input");
            __builder.AddAttribute(149, "placeholder", "Deadline");
            __builder.AddAttribute(150, "min", 
#nullable restore
#line 106 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                        DateTime.Today.AddDays(1)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(151, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                                                 task.Deadline

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(152, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.Deadline = __value, task.Deadline, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(153, "b-f5ypzovfwh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n            ");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "class", "form__group");
            __builder.AddAttribute(157, "b-f5ypzovfwh");
            __builder.OpenElement(158, "button");
            __builder.AddAttribute(159, "class", "button-white");
            __builder.AddAttribute(160, "type", "submit");
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
                                                                     AddTaskk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(162, "b-f5ypzovfwh");
            __builder.AddContent(163, "Add Task");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\terez\RiderProjects\sep3-managment-system\BlazorSep3\Pages\Admin\ManageTask\AddTask.razor"
       

    [CascadingParameter]
    public MainLayout Layout { get; set; }

    private string errorMessage;
    private Taskk task = new Taskk();
    private string currentSpec = Specialities.videoGameDesigner.ToString();

    [Range(1, int.MaxValue)] private int currentPeople = 1;

    private string textSpecialty;

    private async Task AddTaskk()
    {
        try
        {
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

    private void AddToSpecialties()
    {
        task.Specialities.Add(currentSpec, currentPeople);
        textSpecialty = "Speciality " + splitOnCapitalLitter(currentSpec) + " for " + currentPeople +
                        " has been added to this task";
        currentSpec = Specialities.videoGameDesigner.ToString();
        currentPeople = 1;
    }

    protected override void OnInitialized()
    {
        task.StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        task.Deadline = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 7);
        task.Estimate = 1;
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskServices taskServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
