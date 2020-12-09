#pragma checksum "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\RandomDog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00fa09a9e638cfc54c9451d2237f7580184b3997"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/randomDog")]
    public partial class RandomDog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Random Dog</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 8 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\RandomDog.razor"
           randomDogImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "alt", "Dog");
            __builder.AddAttribute(6, "width", "500");
            __builder.AddAttribute(7, "height", "600");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\RandomDog.razor"
                                          FetchRandomDogImg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Random Dog");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA_3_X00149830\Pages\RandomDog.razor"
       


    public class Root
    {
        public string Message { get; set; }
        public string Status { get; set; }
    }

    private Root data;
    private string randomDogImageURL;

    protected override async Task OnInitializedAsync()
    {

        // CORS needs to be enabled for Web API endpoint
        data = await Http.GetFromJsonAsync<Root>("https://dog.ceo/api/breeds/image/random");
    }

    private void FetchRandomDogImg()
    {
        randomDogImageURL = data.Message;
        OnInitializedAsync();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
