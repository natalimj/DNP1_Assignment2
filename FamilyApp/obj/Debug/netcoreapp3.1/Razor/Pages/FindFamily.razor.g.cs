#pragma checksum "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\FindFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35598f2a3aa1d2f32cb6fdc4fdd967ea36c902b2"
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
#line 2 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\FindFamily.razor"
using FamilyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\FindFamily.razor"
using FamilyApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FindFamily")]
    public partial class FindFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Find Family</h3>\r\n<img src=\"/images/family4.jpg\" alt=\"family\" class=\"img-thumbnail\">\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "Enter Street Name\r\n    <br>\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\FindFamily.razor"
                  street

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => street = __value, street));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "Enter Number\r\n            <br>\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\FindFamily.razor"
                          number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => number = __value, number));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "actions");
            __builder.AddMarkupContent(17, "\r\n  \r\n     ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-outline-dark button-p");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\FindFamily.razor"
                                                                () => FilterByName(street,number)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "style", "color: #c82333");
            __builder.AddContent(26, 
#nullable restore
#line 20 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\FindFamily.razor"
                           errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\FindFamily.razor"
       
    Family filteredFamily;
    IList<Family> families;

    string street;
    int number;
    string errorMessage = "";
  
    protected override async Task OnInitializedAsync()
    {
        families = await FamilyService.GetFamiliesAsync();
    }

    private void FilterByName(string streetName,int houseNumber)
    {
        if (street==null||number == 0)
        {
            errorMessage = "please enter street name and number";
        }
        else
        {
            errorMessage = "";
            
            foreach (var f in families)
            {
                if (f.StreetName.Equals(streetName, StringComparison.OrdinalIgnoreCase) && f.HouseNumber ==houseNumber)
                {
                    filteredFamily = f;
                }
            }

            if (filteredFamily == null)
            {
                errorMessage = "No result";
            }
            else
            {
                NavigationManager.NavigateTo("FamilyPage/" +streetName+"/"+houseNumber);
            }
    
        }
    }

   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591