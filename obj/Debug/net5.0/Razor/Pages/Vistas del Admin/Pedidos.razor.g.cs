#pragma checksum "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40aa8ab21d64ca548acfa4790a3e77853111a619"
// <auto-generated/>
#pragma warning disable 1591
namespace Avocado_Market.Pages.Vistas_del_Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Avocado_Market;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Avocado_Market.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Avocado_Market.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Avocado_Market.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Avocado_Market.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
           [Authorize(Roles = "Administrador")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/pedidos")]
    public partial class Pedidos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Todos los pedidos emitidos..</h3>\r\n");
            __Blazor.Avocado_Market.Pages.Vistas_del_Admin.Pedidos.TypeInference.CreateMudTable_0(__builder, 1, 2, 
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                 Ordenes

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                 true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                                   Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 5, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, "Id");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, "Estado");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "Latitud");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(20, "Longitud");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, "Coste Total");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(26);
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, "Comentario");
                }
                ));
                __builder2.CloseComponent();
            }
            , 29, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(30);
                __builder2.AddAttribute(31, "DataLabel", "Nr");
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(33, 
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                               context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(35);
                __builder2.AddAttribute(36, "DataLabel", "Sign");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(38, 
#nullable restore
#line 17 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                 context.Estado

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(40);
                __builder2.AddAttribute(41, "DataLabel", "Sign");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(43, 
#nullable restore
#line 18 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                 context.Latitud

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(45);
                __builder2.AddAttribute(46, "DataLabel", "Sign");
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(48, 
#nullable restore
#line 19 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                 context.Longitud

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(50);
                __builder2.AddAttribute(51, "DataLabel", "Sign");
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, 
#nullable restore
#line 20 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                 context.CosteTotal

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(55);
                __builder2.AddAttribute(56, "DataLabel", "Sign");
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(58, 
#nullable restore
#line 21 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                 context.Comentario

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudFab>(60);
                __builder2.AddAttribute(61, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                       Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                             Icons.Material.Filled.Update

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                                                                 Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                                                                                       Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "Label", "Promover estado");
                __builder2.AddAttribute(66, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
                                                                                                                                                    (() => ActualizarPedido(context))

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(67, "Class", "ma-2");
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Pages\Vistas del Admin\Pedidos.razor"
       
    List<Orden> Ordenes;
    [CascadingParameter]
    private Task<AuthenticationState> EstadoLogin { get; set; }
    private AuthenticationState UsuarioLogueado;
    protected override async Task OnInitializedAsync()
    {
        UsuarioLogueado = await EstadoLogin;
        Ordenes = await AccesoOrdenes.Get();
    }

    public async void ActualizarPedido(Orden orden)
    {
        if (orden.Estado == "En proceso")
        {
            orden.Estado = "Enviandose";
            await AccesoOrdenes.Update(orden);
        }
        else if (orden.Estado == "Enviandose")
        {
            orden.Estado = "Completado";
            await AccesoOrdenes.Update(orden);
        }
        else if (orden.Estado == "Completado")
        {
            orden.Estado = "Ya no se puede promover mas";
        }
        Ordenes = await AccesoOrdenes.Get();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrdenServices AccesoOrdenes { get; set; }
    }
}
namespace __Blazor.Avocado_Market.Pages.Vistas_del_Admin.Pedidos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "HeaderContent", __arg3);
        __builder.AddAttribute(__seq4, "RowTemplate", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
