#pragma checksum "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b22ffdd403c429982a4f4465f7080c27d0161200"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontendPaulo.Pages.Research
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
#line 4 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
using FrontendPaulo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/research/listar")]
    public partial class Listar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<h3 style=\"text-align:center\">My Research</h3>\r\n\r\n    <br>\r\n\r\n");
#nullable restore
#line 16 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
     if (oResponse != null && oResponse.Data != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group row mb-1");
            __builder.AddMarkupContent(7, "\r\n\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-8");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "style", "text-align:center; border:groove");
            __builder.AddAttribute(14, "placeholder", "Enter Title");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                                                                                                   searchTxt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTxt = __value, searchTxt));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-sm-2");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-info btn-lg btn-block");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                                        Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, " Search ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-sm-2");
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-danger btn-lg btn-block");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                                          GetAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, " Cancel ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.AddMarkupContent(39, "        <br>\r\n");
            __builder.AddContent(40, "        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group row mb-1");
            __builder.AddMarkupContent(43, "\r\n\r\n");
#nullable restore
#line 37 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
             foreach (var oElement in oResponse.Data)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col col-md-6");
            __builder.AddMarkupContent(47, "\r\n\r\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card img-fluid");
            __builder.AddAttribute(50, "alt", "Responsive image");
            __builder.AddMarkupContent(51, "\r\n\r\n                        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-header");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 44 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                             if (oElement.State.Equals("t"))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                                ");
            __builder.AddMarkupContent(56, @"<div class=""form-group row mb-1"">
                                    <div class=""col col-md-12"">
                                        <div class=""alert alert-success"" role=""alert"">
                                            Active
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 53 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 55 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                             if (oElement.State.Equals("f"))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                                ");
            __builder.AddMarkupContent(59, @"<div class=""form-group row mb-1"">
                                    <div class=""col col-md-12"">
                                        <div class=""alert alert-danger"" role=""alert"">
                                            Inactive
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 64 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n                        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "card-body");
            __builder.AddMarkupContent(64, "\r\n\r\n                            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group row mb-1");
            __builder.AddMarkupContent(67, "\r\n\r\n                                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-sm-6");
            __builder.AddMarkupContent(70, "\r\n                                    ");
            __builder.OpenElement(71, "img");
            __builder.AddAttribute(72, "class", "card-img-top img-fluid");
            __builder.AddAttribute(73, "src", "/Images/Research/" + (
#nullable restore
#line 72 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                                                               oElement.Picture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "alt", "Card image cap Responsive image");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n                                ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "col-sm-6");
            __builder.AddMarkupContent(79, "\r\n                                    ");
            __builder.OpenElement(80, "ul");
            __builder.AddAttribute(81, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(82, "\r\n                                        ");
            __builder.OpenElement(83, "li");
            __builder.AddAttribute(84, "class", "list-group-item");
            __builder.AddContent(85, 
#nullable restore
#line 77 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                                     oElement.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n                        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "card-footer text-muted");
            __builder.AddMarkupContent(93, "\r\n\r\n                            ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "form-group row mb-1");
            __builder.AddMarkupContent(96, "\r\n\r\n                                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "col-sm-4");
            __builder.AddMarkupContent(99, "\r\n                                    ");
            __builder.OpenElement(100, "a");
            __builder.AddAttribute(101, "href", "/research/get/" + (
#nullable restore
#line 89 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                            oElement.CreateDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "class", "btn btn-info btn-lg btn-block");
            __builder.AddContent(103, " View ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, " <br>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n                                ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "col-sm-4");
            __builder.AddMarkupContent(108, "\r\n                                    ");
            __builder.OpenElement(109, "a");
            __builder.AddAttribute(110, "href", "/research/editar/" + (
#nullable restore
#line 93 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                               oElement.CreateDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "class", "btn btn-warning btn-lg btn-block");
            __builder.AddContent(112, " Edit ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, " <br>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n                                ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-sm-4");
            __builder.AddMarkupContent(117, "\r\n                                    ");
            __builder.OpenElement(118, "a");
            __builder.AddAttribute(119, "href", "/research/eliminar/" + (
#nullable restore
#line 97 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                                 oElement.Title

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 97 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
                                                                                 oElement.CreateDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "class", "btn btn-danger btn-lg btn-block");
            __builder.AddContent(121, " Delete ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n\r\n                    <br>\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 107 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
#nullable restore
#line 110 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(130, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Research\Listar.razor"
       

    String searchTxt = "";

    public string Url = "/api/Research";

    public Response<List<Research>> oResponse = new Response<List<Research>>();

    protected override async Task OnInitializedAsync() => oResponse = await Http.GetFromJsonAsync<Response<List<Research>>>(Url);

    private async Task GetAll()
    {
        oResponse = await Http.GetFromJsonAsync<Response<List<Research>>>(Url);

        searchTxt = "";
    }

    private async Task Search()
    {
        searchTxt = searchTxt.Trim();

        if (!searchTxt.Equals("")) oResponse = await Http.GetFromJsonAsync<Response<List<Research>>>(Url + "/search/" + searchTxt);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
