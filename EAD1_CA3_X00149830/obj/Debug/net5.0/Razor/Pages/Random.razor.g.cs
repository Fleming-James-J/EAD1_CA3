#pragma checksum "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\Pages\Random.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3d6a6ba9e836c7bf7d6bfed0111e3013bdd09a"
// <auto-generated/>
#pragma warning disable 1591
namespace EAD1_CA3_X00149830.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using EAD1_CA3_X00149830;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\_Imports.razor"
using EAD1_CA3_X00149830.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/randomDog")]
    public partial class Random : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Random Dog</h1>\r\n\r\n");
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "src", 
#nullable restore
#line 5 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\Pages\Random.razor"
           randomDogImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "alt", "Dog");
            __builder.AddAttribute(4, "width", "500");
            __builder.AddAttribute(5, "height", "600");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\Pages\Random.razor"
                                          FetchRandomDogImage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Random Dog");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\James_2\source\repos\EAD1_CA3_X00149830\EAD1_CA3_X00149830\Pages\Random.razor"
       
    private string randomDogImageURL;

    private void FetchRandomDogImage()
    {

        Console.WriteLine("https://www.101dogbreeds.com/wp-content/uploads/2019/09/Docker.jpg");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
