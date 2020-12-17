// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EAD1_CA_3_X00149830
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using EAD1_CA_3_X00149830;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\_Imports.razor"
using EAD1_CA_3_X00149830.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dogs")]
    public partial class Dogs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\Dogs.razor"
       



    private Root data;

    private string errorImageURL = "images/DogNotFound.jpg";
    private string dogType = "";
    private string dogImageURL;
    private string imageURL = "https://dog.ceo/api/breeds/image/random";
    private string errormessage;

    private List<string> seenDogbreeds = new List<string>();

    private string dogBreed;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            // CORS needs to be enabled for Web API endpoint
            data = await Http.GetFromJsonAsync<Root>(imageURL);
            dogImageURL = data.Message;

            dogType = data.ExtractDogType(dogImageURL);

            dogType = data.FormatDogType(dogType);

            AddDogBreedToList();

        }
        catch (Exception e)
        {

            errormessage = e.StackTrace;
        }

    }

    protected async void GetDogData()
    {
        try
        {
            // CORS needs to be enabled for Web API endpoint
            data = await Http.GetFromJsonAsync<Root>(imageURL);

            dogImageURL = data.Message;

            dogType = data.ExtractDogType(dogImageURL);

            dogType = data.FormatDogType(dogType);

            AddDogBreedToList();

        }
        catch (Exception e)
        {
            errormessage = e.StackTrace;
        }

        StateHasChanged();

    }

    private void FetchRandomDogImg()
    {
        imageURL = "https://dog.ceo/api/breeds/image/random";
        GetDogData();

        dogImageURL = data.Message;

        dogType = data.ExtractDogType(dogImageURL);

        dogType = data.FormatDogType(dogType);

        AddDogBreedToList();

    }

    private void Search()
    {
        dogBreed = dogBreed.ToLower();

        if (!System.String.IsNullOrWhiteSpace(dogBreed))
        {
            imageURL = string.Format("https://dog.ceo/api/breed/{0}/images/random", dogBreed);
            GetDogData();
            dogImageURL = data.Message;

            dogType = data.ExtractDogType(dogImageURL);

            dogType = data.FormatDogType(dogType);

            AddDogBreedToList();
        }


        else
        {
            dogImageURL = errorImageURL;
            dogType = "Dog Not Found";
        }

    }

    private void AddDogBreedToList()
    {
        if (!seenDogbreeds.Contains(dogType))
        {
            //adds it to front of list so last dog seen is at top of list
            seenDogbreeds.Insert(0, dogType);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
