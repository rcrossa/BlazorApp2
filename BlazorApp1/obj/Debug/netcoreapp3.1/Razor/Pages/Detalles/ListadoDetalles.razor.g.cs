#pragma checksum "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44fae9f8fa8b74a25b0da6f3b7ef3c9eb7ab79b9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Detalles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Detalles/ListadoDetalles")]
    public partial class ListadoDetalles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado Detalles</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary mb-2 pt-2");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                                                    ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "<span class=\"oi oi-plus mr-1\"></span>Nuevo");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<p>Visualizador de los DEtalles</p>");
#nullable restore
#line 13 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
 if (detalles == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Id</th>\r\n                <th>Fecha</th>\r\n                <th>Tiempo</th>\r\n                <th>Recurso</th>\r\n                <th>Tarea</th>\r\n                <th>Acciones</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 31 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
             foreach (var detail in detalles)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 34 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 35 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 36 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Tiempo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 37 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Recurso.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 38 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Tarea.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-info");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                                                           ()=>Editar(detail.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                                                             ()=>Borrar(detail.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
       
    private List<BlazorApp1.Data.Detalle> detalles;

    protected override async Task OnInitializedAsync()
    {
        detalles = await DetalleService.ListDetail();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("Detalles/Editar/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar la Detalle?");
        if (confirmed)
        {
            await DetalleService.DeleteDetail(id);
            detalles = await DetalleService.ListDetail();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DetalleService DetalleService { get; set; }
    }
}
#pragma warning restore 1591
