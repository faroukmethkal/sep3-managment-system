#pragma checksum "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "048dec0fb448f6018f168e98de862c28dc0fe247"
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
#line 1 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
using BlazorSep3.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
using BlazorSep3.Data;

#line default
#line hidden
#nullable disable
    public partial class EditTaskSpecialties : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "b-or3q62nlz1");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "result");
            __builder.AddAttribute(5, "b-or3q62nlz1");
#nullable restore
#line 8 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
         if (specList == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p b-or3q62nlz1><em b-or3q62nlz1>Specialties is not exist</em></p>");
#nullable restore
#line 11 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
        }else if (!specList.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p b-or3q62nlz1><em b-or3q62nlz1>No specialites been added</em></p>");
#nullable restore
#line 16 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-hover");
            __builder.AddAttribute(10, "b-or3q62nlz1");
            __builder.AddMarkupContent(11, @"<thead style=""position: sticky;top:0; z-index: 100"" class=""thead-dark"" b-or3q62nlz1><tr b-or3q62nlz1><th b-or3q62nlz1>Specialties</th>
                    <th b-or3q62nlz1>Number of Specialities required</th>
                    <th b-or3q62nlz1>Remove</th></tr></thead>
                ");
            __builder.OpenElement(12, "tbody");
            __builder.AddAttribute(13, "b-or3q62nlz1");
#nullable restore
#line 29 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                 foreach (var s in specList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.AddAttribute(15, "style", "text-align: center");
            __builder.AddAttribute(16, "b-or3q62nlz1");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "b-or3q62nlz1");
            __builder.OpenElement(19, "select");
            __builder.AddAttribute(20, "class", "form__input_select");
            __builder.AddAttribute(21, "placeholder", 
#nullable restore
#line 33 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                                             s.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "list", "Specialitties");
            __builder.AddAttribute(23, "id", "Specialitties");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                                                                                 s.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => s.name = __value, s.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(26, "b-or3q62nlz1");
#nullable restore
#line 35 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                 foreach (var item in Enum.GetValues(typeof(Specialities)))
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 37 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                    item

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "b-or3q62nlz1");
            __builder.AddContent(30, 
#nullable restore
#line 37 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                           splitOnCapitalLitter(item.ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "b-or3q62nlz1");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "placeholder", 
#nullable restore
#line 43 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                 s.requirednumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "class", "form__input_select_number");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                                                                            s.requirednumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => s.requirednumber = __value, s.requirednumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(39, "b-or3q62nlz1");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "b-or3q62nlz1");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                () => RemoveSpeciality(s)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "b-or3q62nlz1");
            __builder.AddMarkupContent(46, "<i class=\"oi oi-delete\" style=\"color:red\" b-or3q62nlz1></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form");
            __builder.AddAttribute(50, "b-or3q62nlz1");
            __builder.AddMarkupContent(51, "<div class=\"form__group_title\" b-or3q62nlz1><h3 b-or3q62nlz1> Add New Speciality</h3></div>\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form_content");
            __builder.AddAttribute(54, "b-or3q62nlz1");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form__group_part");
            __builder.AddAttribute(57, "b-or3q62nlz1");
            __builder.AddMarkupContent(58, "<label class=\"form__label\" b-or3q62nlz1>Speciality</label>\r\n                ");
            __builder.OpenElement(59, "select");
            __builder.AddAttribute(60, "name", "specialties");
            __builder.AddAttribute(61, "class", "form__input_select");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                                             Speciality.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Speciality.name = __value, Speciality.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(64, "b-or3q62nlz1");
#nullable restore
#line 70 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                     foreach (var speciality in Enum.GetValues(typeof(Specialities)))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", 
#nullable restore
#line 72 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                        speciality

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(67, "b-or3q62nlz1");
            __builder.AddContent(68, 
#nullable restore
#line 72 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                     splitOnCapitalLitter(speciality.ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 73 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "form__group_part");
            __builder.AddAttribute(72, "b-or3q62nlz1");
            __builder.AddMarkupContent(73, "<label class=\"form__label\" b-or3q62nlz1>Number of Specialities required</label>\r\n                ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "number");
            __builder.AddAttribute(76, "class", "form__input_select_number");
            __builder.AddAttribute(77, "placeholder", "NumberOfPeople");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                                                                           Speciality.requirednumber

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Speciality.requirednumber = __value, Speciality.requirednumber, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(80, "b-or3q62nlz1");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "b-or3q62nlz1");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "class", "button-spec");
            __builder.AddAttribute(86, "type", "submit");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                                                                    AddToSpecialties

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "b-or3q62nlz1");
            __builder.AddContent(89, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "modal_foter");
            __builder.AddAttribute(93, "b-or3q62nlz1");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                      SaveSpeciality

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "class", "btn btn-primary");
            __builder.AddAttribute(97, "b-or3q62nlz1");
            __builder.AddContent(98, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
                      ModalInstance.CancelAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "class", "btn btn-secondary");
            __builder.AddAttribute(103, "b-or3q62nlz1");
            __builder.AddContent(104, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "F:\VIA\Third Semester\SEP3\Backup\sep3-managment-system-blazor-server\BlazorSep3\Pages\Admin\ManageTask\EditTaskSpecialties.razor"
       

    [CascadingParameter]
    BlazoredModalInstance ModalInstance { get; set; }

    [Parameter]
    public Dictionary<string, int> Specialities { get; set; }

    List<Speciality> specList = new List<Speciality>();
    private Speciality Speciality = new Speciality();

    private void RemoveSpeciality(Speciality s)
    {
        specList.Remove(s);
    }

    protected override async Task OnInitializedAsync()
    {
        if (Specialities.Count != 0)
        {
            foreach (var speciality in Specialities)
            {
                Console.WriteLine(speciality.Key + " " + speciality.Value);
                specList.Add(new()
                {
                    name = speciality.Key,
                    requirednumber = speciality.Value
                });
            }
        }
        else
        {
            Specialities = new Dictionary<string, int>();
        }
    }

    private void AddToSpecialties()
    {
        specList.Add(Speciality);
        Speciality = new Speciality();
    }

    private void SaveSpeciality()
    {
        ModalInstance.CloseAsync(ModalResult.Ok<List<Speciality>>(specList));
        foreach (var item in specList)
        {
            Console.WriteLine($"Specialtiy: {item.name}, number: {item.requirednumber}");
        }
        Console.WriteLine("################");
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
    }
}
#pragma warning restore 1591
