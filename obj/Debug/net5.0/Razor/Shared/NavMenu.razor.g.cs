#pragma checksum "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b787c348d78240256c0b0d9d51d1e26e56def0"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
                __builder2.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudPaper>(4);
                    __builder3.AddAttribute(5, "Width", "250px");
                    __builder3.AddAttribute(6, "Class", "d-inline-flex py-3");
                    __builder3.AddAttribute(7, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavMenu>(9);
                        __builder4.AddAttribute(10, "Class", "mud-width-full");
                        __builder4.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(12);
                            __builder5.AddAttribute(13, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(14, "Class", "px-4");
                            __builder5.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(16, "Menu");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(17, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudText>(18);
                            __builder5.AddAttribute(19, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                   Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "Class", "px-4 mud-text-secondary");
                            __builder5.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(22, "Elija su opcion");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(23, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudDivider>(24);
                            __builder5.AddAttribute(25, "Class", "my-2");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(26, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(27);
                            __builder5.AddAttribute(28, "Href", "/dashboard");
                            __builder5.AddAttribute(29, "Icon", "fas fa-chart-line");
                            __builder5.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(31, "Dashboard");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(32, "\r\n                 \r\n\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudNavGroup>(33);
                            __builder5.AddAttribute(34, "Title", "Vistas de usuarios");
                            __builder5.AddAttribute(35, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                   Icons.Filled.ManageAccounts

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                          false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(38);
                                __builder6.AddAttribute(39, "Href", "/mercado");
                                __builder6.AddAttribute(40, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                           Icons.Filled.AddBusiness

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(41, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(43, "Mercado");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(44, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(45);
                                __builder6.AddAttribute(46, "Href", "/carrito");
                                __builder6.AddAttribute(47, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                           Icons.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(48, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                 Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(50, "Mi carrito");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(51, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(52);
                                __builder6.AddAttribute(53, "Href", "/usuario/pedidos");
                                __builder6.AddAttribute(54, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                   Icons.Filled.PersonAdd

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(55, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                      Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(57, "Mis pedidos");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(58, "\r\n\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudNavGroup>(59);
                            __builder5.AddAttribute(60, "Title", "Administrador");
                            __builder5.AddAttribute(61, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                              Icons.Filled.Handyman

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(62, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                               false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(64);
                                __builder6.AddAttribute(65, "Href", "/admin/clientes");
                                __builder6.AddAttribute(66, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                  Icons.Filled.PeopleAlt

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(67, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 21 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                     Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(69, "Clientes");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(70, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(71);
                                __builder6.AddAttribute(72, "Href", "/admin/slider");
                                __builder6.AddAttribute(73, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                Icons.Filled.AppRegistration

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(74, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                         Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(76, "Administrar slider");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(77, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(78);
                                __builder6.AddAttribute(79, "Href", "/admin/categorias");
                                __builder6.AddAttribute(80, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                    Icons.Filled.CreateNewFolder

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(81, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                             Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(83, "Administrar categorías");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(84, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(85);
                                __builder6.AddAttribute(86, "Href", "/admin/productos");
                                __builder6.AddAttribute(87, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                   Icons.Filled.AddShoppingCart

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(88, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                            Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(90, "Administrar productos");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(91, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(92);
                                __builder6.AddAttribute(93, "Href", "/admin/pedidos");
                                __builder6.AddAttribute(94, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                 Icons.Filled.AdminPanelSettings

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(95, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                             Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(97, "Administrar pedidos");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(98, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(99);
                                __builder6.AddAttribute(100, "Href", "/admin/mapapedidos");
                                __builder6.AddAttribute(101, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                     Icons.Filled.AddLocationAlt

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(102, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                             Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(104, "Mapa de pedidos");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(105, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(106);
                                __builder6.AddAttribute(107, "Href", "/admin/cumples");
                                __builder6.AddAttribute(108, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                 Icons.Filled.AutoAwesome

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(109, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 27 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                                                      Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(111, "Cumpleaños por mes");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(112, "\r\n\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(113);
                            __builder5.AddAttribute(114, "Href", "/identity/account/logout");
                            __builder5.AddAttribute(115, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                                                                       Icons.Filled.Logout

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(117, "Cerrar Sesion");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(118, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(119);
                    __builder3.AddAttribute(120, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                               Icons.Filled.Label

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(121, "Href", "/identity/account/login");
                    __builder3.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(123, "Iniciar Sesion");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(124, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(125);
                    __builder3.AddAttribute(126, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                               Icons.Filled.Label

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(127, "Href", "/about");
                    __builder3.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(129, "About");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(131);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
      
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
