#pragma checksum "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97d3112d7f96cd167671299264df1f5a4a38f07"
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
#line 1 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Avocado_Market;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Avocado_Market.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Avocado_Market.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Avocado_Market.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Avocado_Market.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/carrito")]
    public partial class Carrito : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Carrito de ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                MiCarrito.Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ", Id: ");
            __builder.AddContent(4, 
#nullable restore
#line 4 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                      MiCarrito.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __Blazor.Avocado_Market.Pages.Vistas_del_Usuario.Carrito.TypeInference.CreateMudTable_0(__builder, 6, 7, 
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                  Items

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                true

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                  Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 10, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "Id");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(15);
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(17, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(19);
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Categoria");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(23);
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, "Precio por unidad");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(27);
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(29, "Unidades");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(31);
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(33, "Imagen");
                }
                ));
                __builder2.CloseComponent();
            }
            , 34, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(35);
                __builder2.AddAttribute(36, "DataLabel", "Nr");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(38, 
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                               context.Id

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
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                 context.Nombre

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
#line 18 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                 context.Categoria

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
#line 19 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                 context.PrecioUnidad

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
#line 20 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                 context.Unidades

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(60);
                __builder2.AddAttribute(61, "DataLabel", "Sign");
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCard>(63);
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardMedia>(65);
                        __builder4.AddAttribute(66, "Image", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                               context.UrlImagen

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                                          30

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(68, "\r\n");
            __builder.OpenComponent<MudBlazor.MudButton>(69);
            __builder.AddAttribute(70, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                    Variant.Text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                             () => OpenDrawer(Anchor.Bottom)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(73, "Comprar");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDrawer>(75);
            __builder.AddAttribute(76, "Anchor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Anchor>(
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                       anchor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                          1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerVariant>(
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                       DrawerVariant.Temporary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                        open

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => open = __value, open))));
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(82, "center");
                __builder2.OpenComponent<MudBlazor.MudDrawerHeader>(83);
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(85);
                    __builder3.AddAttribute(86, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 28 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(88, "Pasarela de compra...");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudText>(90);
                __builder2.AddAttribute(91, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 30 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(93, "¿A donde te lo llevamos?");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(95);
                __builder2.AddAttribute(96, "style", "height: 200px; width: 90%");
                __builder2.AddAttribute(97, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                           new GoogleMapPosition() { Lat = 0, Lng = 0 }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                                                                                   OnMapClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(100, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(101);
                    __builder3.AddAttribute(102, "Label", "Aqui llegara");
                    __builder3.AddAttribute(103, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 33 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                           new GoogleMapPosition() { Lat = latitud, Lng = longitud }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n        ");
                __builder2.OpenElement(105, "p");
                __builder2.AddContent(106, 
#nullable restore
#line 37 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
            latitud

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(107, " , ");
                __builder2.AddContent(108, 
#nullable restore
#line 37 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                       longitud

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudNavMenu>(110);
                __builder2.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 39 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
             foreach (CarritoItems p in Items)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(112);
                    __builder3.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(114, 
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                          p.Nombre

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 42 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudText>(116);
                __builder2.AddAttribute(117, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 45 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(119, "Total: ");
                    __builder3.AddContent(120, 
#nullable restore
#line 45 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                        costetotal

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(121, " RD$");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\r\n        ");
                __Blazor.Avocado_Market.Pages.Vistas_del_Usuario.Carrito.TypeInference.CreateMudTextField_1(__builder2, 123, 124, "Escribe aqui a detalle tu direccion y un comentario para localizarte.", 125, 
#nullable restore
#line 46 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                                                                                      Variant.Outlined

#line default
#line hidden
#nullable disable
                , 126, 
#nullable restore
#line 46 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                   Comentario

#line default
#line hidden
#nullable disable
                , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Comentario = __value, Comentario)));
                __builder2.AddMarkupContent(128, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudFab>(129);
                __builder2.AddAttribute(130, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                       Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                             Icons.Material.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(132, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                                       Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(133, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                                                             Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(134, "Label", "Comprar");
                __builder2.AddAttribute(135, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
                                                                                                                                                  AgregarPedido

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(136, "Class", "ma-2");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Carrito.razor"
       
    string Comentario;
    Avocado_Market.Data.Carrito MiCarrito;
    [CascadingParameter]
    private Task<AuthenticationState> EstadoLogin { get; set; }
    List<CarritoItems> Items;
    private AuthenticationState UsuarioLogueado;
    double latitud, longitud, costetotal;
    protected override async Task OnInitializedAsync()
    {
        UsuarioLogueado = await EstadoLogin;
        MiCarrito = await AccesoCarrito.Get(UsuarioLogueado.User.Identity.Name);
        Items = await AccesoCarrito.GetItems(MiCarrito.Id);
        foreach (CarritoItems item in Items)
        {
            costetotal = costetotal + item.PrecioUnidad;
        }
    }

    public async void AgregarPedido()
    {
        await AccesoOrdenes.Add(MiCarrito, Items, latitud, longitud, costetotal, Comentario);
    }

    void OnMapClick(GoogleMapClickEventArgs args)
    {
        latitud = args.Position.Lat;
        longitud = args.Position.Lng;
    }


    bool open;
    Anchor anchor;

    void OpenDrawer(Anchor anchor)
    {
        open = true;
        this.anchor = anchor;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrdenServices AccesoOrdenes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarritoServices AccesoCarrito { get; set; }
    }
}
namespace __Blazor.Avocado_Market.Pages.Vistas_del_Usuario.Carrito
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
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
