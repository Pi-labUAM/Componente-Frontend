// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FrontendPaulo.Pages.Publication
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
#line 4 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Publication\Editar.razor"
using FrontendPaulo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Publication\Editar.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Publication\Editar.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/publication/editar/{CreateDate}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\Paulo\FrontendPaulo\FrontendPaulo\Pages\Publication\Editar.razor"
       

    [Parameter]
    public string CreateDate { get; set; }

    Publication oPublication = new Publication();

    Response<Publication> oResponse = new Response<Publication>();

    String Url = "/api/Publication";

    Alert oAlert = new Alert();

    String[] actualDate;

    protected override async Task OnInitializedAsync()
    {
        oResponse = await Http.GetFromJsonAsync<Response<Publication>>(Url + "/" + CreateDate);
        oPublication = oResponse.Data;
        oPublication.AuxDate = Convert.ToDateTime(oPublication.PublicationDate); //REVISAR
    }

    private async Task Save()
    {
        if (validateMaxDate())
        {
            var response = await Http.PutAsJsonAsync<Publication>(Url, oPublication);

            oResponse = response.Content.ReadFromJsonAsync<Response<Publication>>().Result;

            if (oResponse.Success == 0) oAlert.isBad(oResponse.Message);

            else NavigationManager.NavigateTo("/publication/listar");

        }
    }

    private Boolean validateMaxDate()
    {
        actualDate = DateTime.Now.ToString().Split("/");

        String actualDay = actualDate[0];

        String actualMonth = actualDate[1];

        String actualYear = actualDate[2].Substring(0, 4);

        if (actualYear.Equals(oPublication.AuxDate.Year.ToString()))
        {
            if (actualMonth.Equals(oPublication.AuxDate.Month.ToString()))
            {
                if (Convert.ToInt32((oPublication.AuxDate.Day)) > Convert.ToInt32(actualDay))
                    return oAlert.isBad("Publication Date is greater than the current date");
            }
        }

        oPublication.PublicationDate = DateTime.Now.ToString().Split(" ")[0];

        return validateTitle();
    }

    private Boolean validateTitle()
    {
        if (oPublication.Title.Equals("")) return oAlert.isBad("Field Title is required");

        oPublication.Title = oPublication.Title.Trim();

        return validateLink();
    }

    private Boolean validateLink()
    {
        if (oPublication.Link.Equals("")) return oAlert.isBad("Field Link is required");

        oPublication.Link = oPublication.Link.Trim();

        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
