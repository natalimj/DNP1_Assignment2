#pragma checksum "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\Statistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab4200a9e0435a7a63613bc6a69eba46215b42c2"
// <auto-generated/>
#pragma warning disable 1591
namespace FamilyApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using FamilyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using FamilyApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\Statistics.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\Statistics.razor"
using FamilyApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\Statistics.razor"
using FamilyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\Statistics.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Statistics")]
    public partial class Statistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mx-auto rounded ");
            __builder.AddMarkupContent(2, "\r\n   \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "mw-100 p-3 text-center blue");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h3>Distribution of Ages</h3>\r\n        ");
            __builder.OpenComponent<FamilyApp.Pages.ChartAgeComponent>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    \r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "mw-100 p-3 my-3 p-3 text-center blue");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<h3>Distribution of Genders</h3>\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-6 d-flex justify-content-md-around");
            __builder.OpenComponent<FamilyApp.Pages.ChartGenderAdult>(19);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-md-6 d-flex justify-content-md-around");
            __builder.OpenComponent<FamilyApp.Pages.ChartGenderChild>(23);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\Statistics.razor"
      

    static int ChildMale;
    static int ChildFemale;
    static int AdultMale;
    static int AdultFemale;
     IList<Adult> Adults;
    IList<Child> Children;
 
    
    protected override async Task OnInitializedAsync()
    {
        Adults = await MemberService.GetAdultsAsync();
        Children = await MemberService.GetChildrenAsync();
        AdultFemale = Adults.Where(a => a.Sex.Equals("F")).ToList().Count;
        ChildFemale=Children.Where(c => c.Sex.Equals("F")).ToList().Count;
        AdultMale = Adults.Where(a => a.Sex.Equals("M")).ToList().Count;
        ChildMale=Children.Where(c => c.Sex.Equals("M")).ToList().Count;
        StateHasChanged();
    }
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
