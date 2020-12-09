#pragma checksum "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\SearchDogs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51d1bd2ef98de4d5ecda6c84d74880fa0ad810ee"
// <auto-generated/>
#pragma warning disable 1591
namespace EAD1_CA_3_X00149830.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/searchDogs")]
    public partial class SearchDogs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "img");
            __builder.AddAttribute(3, "src", 
#nullable restore
#line 6 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\SearchDogs.razor"
               dogImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "alt", "Dog");
            __builder.AddAttribute(5, "width", "500");
            __builder.AddAttribute(6, "height", "600");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "placeholder", "Dog Breed");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\SearchDogs.razor"
                                      dogBreed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dogBreed = __value, dogBreed));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "div");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\SearchDogs.razor"
                                              Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\SearchDogs.razor"
           

        private string dogImageURL = "images/DogSearch.jpg";
        private string searchUrl;
        private string dogBreed;

        public class Root
        {
            public string Message { get; set; }
            public string Status { get; set; }
        }

        private Root data;
        

        protected override async Task OnInitializedAsync()
        {

            // CORS needs to be enabled for Web API endpoint
            data = await Http.GetFromJsonAsync<Root>(searchUrl);
        }

        private void Search()
        {
            searchUrl = string.Format("https://dog.ceo/api/{0}/image/random",dogBreed);
            dogImageURL = data.Message;
            OnInitializedAsync();
        }




    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591