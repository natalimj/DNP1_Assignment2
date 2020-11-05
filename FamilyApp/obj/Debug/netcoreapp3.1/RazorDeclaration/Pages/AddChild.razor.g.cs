#pragma checksum "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddChild.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0918a82fd70460d59c5c292df56cbb7b108574a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddChild.razor"
using FamilyApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddChild.razor"
using FamilyApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddChild")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddChild/{StreetNameF}/{HouseNumberF:int}")]
    public partial class AddChild : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "C:\Users\natal\Desktop\dnp2-3\Assignment1_Approach2-30,10 - Copy\FamilyApp\Pages\AddChild.razor"
       
    
    [Parameter]
    public string StreetNameF { get; set; }
    [Parameter]
    public int HouseNumberF { get; set; }

    public Family Family { get; set; }
    Child newChild=new Child();
     IList<Family> Families=new List<Family>();
     List<Pet> newChildPets=new List<Pet>();
     List<ChildInterest> ChildInterests=new List<ChildInterest>();

    String showPet = "d-none";
    String petName;
     int petAge;
     String petSpecies;
    
  
    
    protected override async Task OnInitializedAsync()
    {
        Families = await FamilyService.GetFamiliesAsync();
        Family = await FamilyService.GetFamilyAsync(StreetNameF, HouseNumberF);
        showPet = "d-none";
    }
    
    private  void AddNewChild()
    {
        foreach (var intrst in ChildInterests)
        {
            newChild.ChildInterests.Add(intrst);
        }
        foreach (var pet in newChildPets)
        {
            newChild.Pets.Add(pet);
        }
            
        MemberService.AddChildAsync(newChild);

        FamilyService.AddChildToFamily(Family,newChild);
        
        NavigationManager.NavigateTo("/");
    }

  
    private void AddNewPet()
    {
        Pet newPet=new Pet();
        newPet.Name = petName;
        newPet.Age = petAge;
        newPet.Species = petSpecies;
        newChildPets.Add(newPet);
        petName = null;
        petAge = 0;
        petSpecies = null;
        showPet = "d-none";
    }
    
    private void AddedChange(ChangeEventArgs evt, string interest)
    {
       
        ChildInterest newCInterest=new ChildInterest();
        newCInterest.ChildId = newChild.Id;
        newCInterest.InterestId = interest;
        if ((bool)evt.Value)
        {
            ChildInterests.Add(newCInterest);
          
        }
        else
        {
            ChildInterests.Remove(newCInterest);
        }
    }

    public void ShowPetForm()
    {
        showPet = "";
    }
    
    List<String> validHairs= new[] {"Blond", "Red", "Brown", "Black",
        "White", "Grey", "Blue", "Green", "Leverpostej"}.ToList();
    List<string> validEyes = new[] {"Brown", "Grey", "Green", "Blue",
        "Amber", "Hazel"}.ToList();
    List<string> genders = new[] {"M", "F"}.ToList();
    List<string> interests = new[] {"Soccer", "Drawing", "Kite Flying", "Roller Blades","Board Games", "Ballet", "Hockey", "Gaming", "Lego",
        "Scout","Gymnastics", "Harry Potter", "Frozen"}.ToList();
    List<string> species = new[] {"Hamster", "Bunny", "Frog", "Budgerigar","Owl", "Snake", "Cat", "Dog", "None"}.ToList();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
    }
}
#pragma warning restore 1591
