#pragma checksum "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4708061032a51ad2e3db649135676fa22800c34"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Tareas
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
#line 2 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tareas/Editar/{id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                  Modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.AddMarkupContent(8, "<h3 class=\"my-4\">Tarea</h3>\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "container");
                __builder2.OpenElement(11, "div");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "mb-3");
                __builder2.AddMarkupContent(14, "\r\n                Título:\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                                        Modelo.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Titulo = __value, Modelo.Titulo))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Modelo.Titulo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "mb-3");
                __builder2.AddMarkupContent(22, "\r\n                Vencimiento:\r\n                ");
                __Blazor.BlazorApp1.Pages.Tareas.Editar.TypeInference.CreateInputDate_0(__builder2, 23, 24, 
#nullable restore
#line 18 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                                        Modelo.Vencimiento

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Vencimiento = __value, Modelo.Vencimiento)), 26, () => Modelo.Vencimiento);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "mb-3");
                __builder2.AddMarkupContent(30, "\r\n                Estimación:\r\n                ");
                __Blazor.BlazorApp1.Pages.Tareas.Editar.TypeInference.CreateInputNumber_1(__builder2, 31, 32, 
#nullable restore
#line 22 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                                          Modelo.Estimacion

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Estimacion = __value, Modelo.Estimacion)), 34, () => Modelo.Estimacion);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "mb-3");
                __builder2.AddMarkupContent(38, "\r\n                Recurso:\r\n                ");
                __Blazor.BlazorApp1.Pages.Tareas.Editar.TypeInference.CreateInputSelect_2(__builder2, 39, 40, "p-1", 41, 
#nullable restore
#line 26 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                                                      RecursoId

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RecursoId = __value, RecursoId)), 43, () => RecursoId, 44, (__builder3) => {
                    __builder3.AddMarkupContent(45, "<option value=\"0\">Elija un Recurso</option>");
#nullable restore
#line 28 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                     foreach (var item in Recursos)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(46, "option");
                    __builder3.AddAttribute(47, "value", 
#nullable restore
#line 30 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                                        item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(48, 
#nullable restore
#line 30 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                                                  item.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 31 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "mb-3");
                __builder2.AddMarkupContent(52, "\r\n                Estado:\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
                                        Modelo.Estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Estado = __value, Modelo.Estado))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Modelo.Estado));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.AddMarkupContent(58, "<button class=\"btn btn-primary my-3\" type=\"submit\">Guardar</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Roberto Rossa\source\repos\BlazorApp1\BlazorApp1\Pages\Tareas\Editar.razor"
       
    [Parameter]
    public int Id { get; set; }

    public Tarea Modelo { get; set; } = new Tarea();

    public string RecursoId { get; set; }

    private List<Recurso> Recursos;

    protected override async Task OnInitializedAsync()
    {
        if (Id > 0)
        {
            Modelo = await TareaService.SelectTask(Id);
            RecursoId = Modelo.RecursoId.ToString();
        }
        else
        {
            Modelo = new Tarea();
        }
        Recursos = await TareaService.GetResource();
    }


    private async void Guardar()
    {
        Modelo.RecursoId = int.Parse(RecursoId);
        await TareaService.SaveTask(Modelo);
        navigation.NavigateTo("Tareas/ListadoTareas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TareaService TareaService { get; set; }
    }
}
namespace __Blazor.BlazorApp1.Pages.Tareas.Editar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
