#pragma checksum "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99ff20fb410317fb8cc8f9a65e478ea9799abcc"
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
#line 3 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
using FamilyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
using FamilyApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPet")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPet/{StreetNameF}/{HouseNumberF:int}")]
    public partial class AddPet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Pet</h3>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Family address:");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                    StreetNameF

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " +");
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                                  HouseNumberF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                  newPet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                                          AddNewPet

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\r\n    Name<br>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                            newPet.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPet.Name = __value, newPet.Name))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPet.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n                    Age<br>\r\n                    ");
                __Blazor.FamilyApp.Pages.AddPet.TypeInference.CreateInputNumber_0(__builder2, 28, 29, 
#nullable restore
#line 20 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                                              newPet.Age

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPet.Age = __value, newPet.Age)), 31, () => newPet.Age);
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "\r\n                   ");
                __Blazor.FamilyApp.Pages.AddPet.TypeInference.CreateInputSelect_1(__builder2, 37, 38, "form-control", 39, "species", 40, "width:200px", 41, 
#nullable restore
#line 23 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                                                                                newPet.Species

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPet.Species = __value, newPet.Species)), 43, () => newPet.Species, 44, (__builder3) => {
                    __builder3.AddMarkupContent(45, "\r\n                       ");
                    __builder3.AddMarkupContent(46, "<option value=\"species\" selected disabled>Species</option>  \r\n");
#nullable restore
#line 25 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                        foreach (var sp in species)
                       {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(47, "                           ");
                    __builder3.OpenElement(48, "option");
                    __builder3.AddAttribute(49, "value", 
#nullable restore
#line 27 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                                           sp

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(50, 
#nullable restore
#line 27 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                                                sp

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n");
#nullable restore
#line 28 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
                       }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(52, "        \r\n                   ");
                }
                );
                __builder2.AddMarkupContent(53, "\r\n                   \r\n                                      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.AddMarkupContent(55, "<p class=\"actions\">\r\n                <button class=\"btn btn-outline-dark\" type=\"submit\">Add</button>\r\n            </p>\r\n        ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddPet.razor"
       
        
    [Parameter]
    public string StreetNameF { get; set; }
    [Parameter]
    public int HouseNumberF { get; set; }
    
    public Family Family { get; set; }
    Pet newPet=new Pet();
    
        
    protected override async Task OnInitializedAsync() {
        Family = await FamilyService.GetFamilyAsync(StreetNameF, HouseNumberF);
    }
    
    public void AddNewPet()
    {
        FamilyService.AddPetToFamily(Family,newPet);
        MemberService.AddPetAsync(newPet);
        NavigationManager.NavigateTo("/");
    }
    
    List<string> species = new[] {"Hamster", "Bunny", "Frog", "Budgerigar","Owl", "Snake", "Cat", "Dog", "None"}.ToList();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
    }
}
namespace __Blazor.FamilyApp.Pages.AddPet
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
