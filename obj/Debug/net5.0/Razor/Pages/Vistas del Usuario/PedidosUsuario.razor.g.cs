#pragma checksum "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1b19a38a58c3d048222d311f54ed1077a1e1c2f"
// <auto-generated/>
#pragma warning disable 1591
namespace Avocado_Market.Pages.Vistas_del_Usuario
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Avocado_Market;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Avocado_Market.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Avocado_Market.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Avocado_Market.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Avocado_Market.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuario/pedidos")]
    public partial class PedidosUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Mis pedidos</h3>\r\n\r\n        ");
            __builder.AddMarkupContent(1, "<h3>\r\n            Mapa con tus pedidos...\r\n        </h3>\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(2);
            __builder.AddAttribute(3, "style", "height: 400px; width: 90%");
            __builder.AddAttribute(4, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                                                 zoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                                                               new GoogleMapPosition() { Lat = 42.6977, Lng = 23.3219 }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                                                                                                                                   OnMapClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "MarkerClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenGoogleMapMarker>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenGoogleMapMarker>(this, 
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                                                                                                                                                           OnMarkerClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                 foreach (var item in Ordenes)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(9);
                __builder2.AddAttribute(10, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                                   item.Estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                                                           new GoogleMapPosition() { Lat = @item.Latitud, Lng = @item.Longitud }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __Blazor.Avocado_Market.Pages.Vistas_del_Usuario.PedidosUsuario.TypeInference.CreateMudTable_0(__builder, 13, 14, 
#nullable restore
#line 18 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                 Ordenes

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 18 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                 true

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 18 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                                   Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 17, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(20, "Id");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, "Estado");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(26);
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, "Latitud");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, "Longitud");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(34);
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(36, "Coste Total");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(40, "Comentario");
                }
                ));
                __builder2.CloseComponent();
            }
            , 41, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(42);
                __builder2.AddAttribute(43, "DataLabel", "Nr");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, 
#nullable restore
#line 29 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                               context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(47);
                __builder2.AddAttribute(48, "DataLabel", "Sign");
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(50, 
#nullable restore
#line 30 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                 context.Estado

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(52);
                __builder2.AddAttribute(53, "DataLabel", "Sign");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(55, 
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                 context.Latitud

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(57);
                __builder2.AddAttribute(58, "DataLabel", "Sign");
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(60, 
#nullable restore
#line 32 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                 context.Longitud

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(62);
                __builder2.AddAttribute(63, "DataLabel", "Sign");
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(65, 
#nullable restore
#line 33 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                 context.CosteTotal

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(67);
                __builder2.AddAttribute(68, "DataLabel", "Sign");
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(70, 
#nullable restore
#line 34 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
                                 context.Comentario

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, ">\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Vistas del Usuario\PedidosUsuario.razor"
       
    List<Orden> Ordenes;
    [CascadingParameter]
    private Task<AuthenticationState> EstadoLogin { get; set; }
    List<CarritoItems> Items;
    private AuthenticationState UsuarioLogueado;
    protected override async Task OnInitializedAsync()
    {
        UsuarioLogueado = await EstadoLogin;
        Ordenes = await AccesoOrdenes.Get(UsuarioLogueado.User.Identity.Name);
    }
    int zoom = 3;
    bool showMadridMarker;

    void OnMapClick(GoogleMapClickEventArgs args)
    {
       
    }

    void OnMarkerClick(RadzenGoogleMapMarker marker)
    {
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarritoServices AccesoCarrito { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrdenServices AccesoOrdenes { get; set; }
    }
}
namespace __Blazor.Avocado_Market.Pages.Vistas_del_Usuario.PedidosUsuario
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
