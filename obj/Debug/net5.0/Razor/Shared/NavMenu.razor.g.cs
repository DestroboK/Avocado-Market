#pragma checksum "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5f14db50f05f69e9742af7e486721b6bbb84dc"
// <auto-generated/>
#pragma warning disable 1591
namespace Avocado_Market.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Avocado_Market;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Avocado_Market.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Avocado_Market.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Avocado_Market.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Avocado_Market.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
                __builder2.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudMenu>(4);
                    __builder3.AddAttribute(5, "Label", "Vistas de usuarios por articulos");
                    __builder3.AddAttribute(6, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                       Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                              Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                     Direction.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Expanded", "false");
                    __builder3.AddAttribute(11, "Style", "padding: 2px");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(13);
                        __builder4.AddAttribute(14, "Href", "/mercado");
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(16, "Mercado");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(18);
                        __builder4.AddAttribute(19, "Href", "/carrito");
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(21, "Mi carrito");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(23);
                        __builder4.AddAttribute(24, "Href", "/usuario/pedidos");
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(26, "Mis pedidos");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(28);
                    __builder3.AddAttribute(29, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                            Icons.Material.Filled.Favorite

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                                   Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(34);
                        __builder4.AddAttribute(35, "Class", "ms-2");
                        __builder4.AddAttribute(36, "Href", "/about");
                        __builder4.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(38, "About");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(40);
                    __builder3.AddAttribute(41, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                  _processing

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                        ProcessSomething

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(43, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                   Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                                          Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 17 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                 if (_processing)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudProgressCircular>(47);
                        __builder4.AddAttribute(48, "Class", "ms-n1");
                        __builder4.AddAttribute(49, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 19 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                             Size.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudText>(52);
                        __builder4.AddAttribute(53, "Class", "ms-2");
                        __builder4.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(55, "Procesando");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 21 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"

                }
                else
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(56);
                        __builder4.AddAttribute(57, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                       Icons.Material.Filled.ThumbUp

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "Href", "/identity/account/logout");
                        __builder4.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(60, "Cerrar Sesion");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 26 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(61, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(62);
                    __builder3.AddAttribute(63, "Href", "/identity/account/login");
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(65, "Iniciar Sesion");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(67);
                    __builder3.AddAttribute(68, "Href", "/about");
                    __builder3.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(70, "About");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(72);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(74);
                __builder2.AddAttribute(75, "Roles", "Administrador");
                __builder2.AddAttribute(76, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudMenu>(77);
                    __builder3.AddAttribute(78, "Label", "Configuración");
                    __builder3.AddAttribute(79, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 38 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                    Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 38 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                           Color.Tertiary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 38 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                                      Direction.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                                true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "Expanded", "false");
                    __builder3.AddAttribute(84, "Style", "padding: 2px");
                    __builder3.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(86);
                        __builder4.AddAttribute(87, "Href", "/admin/clientes");
                        __builder4.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(89, "Clientes");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(90, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(91);
                        __builder4.AddAttribute(92, "Href", "/admin/slider");
                        __builder4.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(94, "Administrar slider");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(95, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(96);
                        __builder4.AddAttribute(97, "Href", "/admin/categorias");
                        __builder4.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(99, "Administrar categorías");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(100, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(101);
                        __builder4.AddAttribute(102, "Href", "/admin/productos");
                        __builder4.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(104, "Administrar productos");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(105, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(106);
                        __builder4.AddAttribute(107, "Href", "/admin/pedidos");
                        __builder4.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(109, "Administrar pedidos");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(110, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(111);
                        __builder4.AddAttribute(112, "Href", "/admin/mapapedidos");
                        __builder4.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(114, "Mapa de pedidos");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(115, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(116);
                        __builder4.AddAttribute(117, "Href", "/admin/cumples");
                        __builder4.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(119, "Cumpleaños por mes");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(120, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Shared\NavMenu.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> EstadoLogin { get; set; }

    private AuthenticationState UsuarioLogueado;
    protected override async Task OnInitializedAsync()
    {
        UsuarioLogueado = await EstadoLogin;
    }
    private bool _processing = false;

    async Task ProcessSomething()
    {
        _processing = true;
        await Task.Delay(2000);
        _processing = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
