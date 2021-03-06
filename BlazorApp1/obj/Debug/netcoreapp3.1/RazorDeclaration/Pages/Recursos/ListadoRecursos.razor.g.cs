// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.Recursos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\Pages\Recursos\ListadoRecursos.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Recursos/ListadoRecursos")]
    public partial class ListadoRecursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Roberto Rossa\Desktop\escuela2020\Davinci\Plataformas-de-desarrollo\ejecicios\BlazorApp2\BlazorApp1\Pages\Recursos\ListadoRecursos.razor"
       
    private List<BlazorApp1.Data.Recurso> recursos;

    protected override async Task OnInitializedAsync()
    {
        recursos = await RecursoService.ListResource();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("Recursos/Editar/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el Recurso?");
        if (confirmed)
        {
            await RecursoService.DeleteResource(id);
            recursos = await RecursoService.ListResource();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecursoService RecursoService { get; set; }
    }
}
#pragma warning restore 1591
