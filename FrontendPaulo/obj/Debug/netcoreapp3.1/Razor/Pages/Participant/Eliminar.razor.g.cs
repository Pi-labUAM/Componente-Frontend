#pragma checksum "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Participant\Eliminar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "176e45f6393f250256fccf052648000e9b666680"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontendPaulo.Pages.Participant
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using FrontendPaulo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Paulo\FrontendPaulo\FrontendPaulo\_Imports.razor"
using FrontendPaulo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Participant\Eliminar.razor"
using FrontendPaulo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Participant\Eliminar.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Participant\Eliminar.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/participant/eliminar/{Document}")]
    public partial class Eliminar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<h3>Delete Confirmation</h3>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group row mb-1");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "alert alert-danger");
            __builder.AddAttribute(9, "role", "alert");
            __builder.AddMarkupContent(10, "\r\n            Participant => \' ");
            __builder.AddContent(11, 
#nullable restore
#line 17 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Participant\Eliminar.razor"
                              Document

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, " \'\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-danger");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Participant\Eliminar.razor"
                                                 Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n        ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-secondary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Participant\Eliminar.razor"
                                                    Cancelar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Participant\Eliminar.razor"
       

    [Parameter]
    public string Document { get; set; }

    public Response<object> oResponse = new Response<object>();

    public string Url = "/api/Participant";

    private void Cancelar()
    {
        NavigationManager.NavigateTo("/participant/listar");
    }

    private async Task Delete()
    {
        var response = await Http.DeleteAsync(Url + "/" + Document);

        oResponse = response.Content.ReadFromJsonAsync<Response<object>>().Result;

        NavigationManager.NavigateTo("/participant/listar");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
