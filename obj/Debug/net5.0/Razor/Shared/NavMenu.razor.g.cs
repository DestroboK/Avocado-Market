#pragma checksum "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be5879686fda1ff0cf618830a169e518668d150"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
                __builder2.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(4);
                    __builder3.AddAttribute(5, "Href", "/Counter");
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(7, "Counter");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudMenu>(9);
                    __builder3.AddAttribute(10, "Label", "Vistas de usuarios por articulos");
                    __builder3.AddAttribute(11, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                       Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                              Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                     Direction.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Expanded", "false");
                    __builder3.AddAttribute(16, "Style", "padding: 2px");
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(18);
                        __builder4.AddAttribute(19, "Href", "/mercado");
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(21, "Mercado");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(23);
                        __builder4.AddAttribute(24, "Href", "/carrito");
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(26, "Mi carrito");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(28);
                        __builder4.AddAttribute(29, "Href", "/usuario/pedidos");
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(31, "Mis pedidos");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudMenu>(33);
                    __builder3.AddAttribute(34, "Label", "Vistas de administradores");
                    __builder3.AddAttribute(35, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                       Color.Tertiary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                  Direction.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Expanded", "false");
                    __builder3.AddAttribute(40, "Style", "padding: 2px");
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(42);
                        __builder4.AddAttribute(43, "Href", "/admin/clientes");
                        __builder4.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(45, "Clientes");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(47);
                        __builder4.AddAttribute(48, "Href", "/admin/slider");
                        __builder4.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(50, "Administrar slider");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(52);
                        __builder4.AddAttribute(53, "Href", "/admin/categorias");
                        __builder4.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(55, "Administrar categorías");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(57);
                        __builder4.AddAttribute(58, "Href", "/admin/productos");
                        __builder4.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(60, "Administrar productos");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(62);
                        __builder4.AddAttribute(63, "Href", "/admin/pedidos");
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(65, "Administrar pedidos");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(67);
                        __builder4.AddAttribute(68, "Href", "/admin/mapapedidos");
                        __builder4.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(70, "Mapa de pedidos");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(71, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(72);
                        __builder4.AddAttribute(73, "Href", "/admin/cumples");
                        __builder4.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(75, "Cumpleaños por mes");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(77);
                    __builder3.AddAttribute(78, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 24 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                            Icons.Material.Filled.Favorite

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 24 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                                    Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(83);
                        __builder4.AddAttribute(84, "Class", "ms-2");
                        __builder4.AddAttribute(85, "Href", "/about");
                        __builder4.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(87, "About");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(89);
                    __builder3.AddAttribute(90, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                  _processing

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                        ProcessSomething

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(92, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 28 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                   Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 28 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                                          Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 29 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                 if (_processing)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudProgressCircular>(96);
                        __builder4.AddAttribute(97, "Class", "ms-n1");
                        __builder4.AddAttribute(98, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                             Size.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(99, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(100, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudText>(101);
                        __builder4.AddAttribute(102, "Class", "ms-2");
                        __builder4.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(104, "Procesando");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 33 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"

                }
                else
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(105);
                        __builder4.AddAttribute(106, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                       Icons.Material.Filled.ThumbUp

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(107, "Href", "/identity/account/logout");
                        __builder4.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(109, "Cerrar Sesion");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 38 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(110, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(111);
                    __builder3.AddAttribute(112, "Href", "/identity/account/login");
                    __builder3.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(114, "Iniciar Sesion");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(116);
                    __builder3.AddAttribute(117, "Href", "/about");
                    __builder3.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(119, "About");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                   
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
#nullable restore
#line 58 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> EstadoLogin { get; set; }

    private AuthenticationState UsuarioLogueado;
    protected override async Task OnInitializedAsync()
    {
        UsuarioLogueado = await EstadoLogin;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
