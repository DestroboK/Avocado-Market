#pragma checksum "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29a9685d8c9947bdacda323ba487ff5c8c90507e"
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
#line 6 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
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
#line 8 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(14, "Class", "px-4");
                            __builder5.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(16, "Avocado Market");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(17, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudText>(18);
                            __builder5.AddAttribute(19, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
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
                            __builder5.AddMarkupContent(26, "\r\n                 \r\n\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudNavGroup>(27);
                            __builder5.AddAttribute(28, "Title", "Vistas de usuarios");
                            __builder5.AddAttribute(29, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                   Icons.Filled.ManageAccounts

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(30, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                          false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(32);
                                __builder6.AddAttribute(33, "Href", "/mercado");
                                __builder6.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                           Icons.Filled.AddBusiness

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(35, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(37, "Mercado");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(38, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(39);
                                __builder6.AddAttribute(40, "Href", "/carrito");
                                __builder6.AddAttribute(41, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                           Icons.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(42, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                 Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(44, "Mi carrito");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(45, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(46);
                                __builder6.AddAttribute(47, "Href", "/usuario/pedidos");
                                __builder6.AddAttribute(48, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                   Icons.Filled.PersonAdd

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(49, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                      Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(51, "Mis pedidos");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(52, "\r\n\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(53);
                            __builder5.AddAttribute(54, "Href", "/identity/account/logout");
                            __builder5.AddAttribute(55, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                       Icons.Filled.Logout

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(57, "Cerrar Sesion");
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
                __builder2.AddAttribute(58, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudPaper>(59);
                    __builder3.AddAttribute(60, "Width", "250px");
                    __builder3.AddAttribute(61, "Class", "py-3");
                    __builder3.AddAttribute(62, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavMenu>(64);
                        __builder4.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(66);
                            __builder5.AddAttribute(67, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 28 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(68, "Class", "px-4");
                            __builder5.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(70, "Avocado Market");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(71, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudDivider>(72);
                            __builder5.AddAttribute(73, "Class", "my-2");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(74, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudNavGroup>(75);
                            __builder5.AddAttribute(76, "Title", "Opciones");
                            __builder5.AddAttribute(77, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                         Icons.Filled.AutoStories

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(78, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                  _isExpanded

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(79, "ExpandedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _isExpanded = __value, _isExpanded))));
                            __builder5.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(81);
                                __builder6.AddAttribute(82, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                            Icons.Filled.AccountBalance

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(83, "Href", "/identity/account/login");
                                __builder6.AddAttribute(84, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                                    Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(86, "Iniciar Sesion");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(87, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(88);
                                __builder6.AddAttribute(89, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                            Icons.Filled.Add

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(90, "Href", "/identity/account/register");
                                __builder6.AddAttribute(91, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 32 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                            Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(93, "Registrarme");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(94, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudNavLink>(95);
                                __builder6.AddAttribute(96, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                           Icons.Filled.AccountCircle

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(97, "Href", "/about");
                                __builder6.AddAttribute(98, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 33 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                Color.Info

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(100, "About");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\r\n            <br b-r5i9y9wz54>\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudText>(102);
                    __builder3.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 39 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                 if (_isExpanded)
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(104, "<b class=\"mud-theme-tertiary rounded pa-2 ml-2\" b-r5i9y9wz54>Expandido</b>");
#nullable restore
#line 42 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(105, "<b class=\"mud-theme-error rounded pa-2 ml-2\" b-r5i9y9wz54>Colapsado</b>");
#nullable restore
#line 46 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n\r\n");
                __builder2.OpenComponent<MudBlazor.MudDivider>(107);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "    \r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(109);
                __builder2.AddAttribute(110, "Roles", "Administrador");
                __builder2.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudPaper>(112);
                    __builder3.AddAttribute(113, "Width", "250px");
                    __builder3.AddAttribute(114, "Class", "d-inline-flex py-3");
                    __builder3.AddAttribute(115, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavGroup>(117);
                        __builder4.AddAttribute(118, "Title", "Configuración");
                        __builder4.AddAttribute(119, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                              Icons.Filled.Handyman

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(120, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                               false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(122);
                            __builder5.AddAttribute(123, "Href", "/admin/clientes");
                            __builder5.AddAttribute(124, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                  Icons.Filled.PeopleAlt

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(125, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 58 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                     Color.Success

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(127, "Clientes");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(128, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(129);
                            __builder5.AddAttribute(130, "Href", "/admin/slider");
                            __builder5.AddAttribute(131, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                Icons.Filled.AppRegistration

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(132, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 59 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                         Color.Info

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(134, "Administrar slider");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(135, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(136);
                            __builder5.AddAttribute(137, "Href", "/admin/categorias");
                            __builder5.AddAttribute(138, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                    Icons.Filled.CreateNewFolder

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(139, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 60 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                             Color.Info

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(141, "Administrar categorías");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(142, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(143);
                            __builder5.AddAttribute(144, "Href", "/admin/productos");
                            __builder5.AddAttribute(145, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                   Icons.Filled.AddShoppingCart

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(146, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 61 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                            Color.Info

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(147, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(148, "Administrar productos");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(149, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(150);
                            __builder5.AddAttribute(151, "Href", "/admin/pedidos");
                            __builder5.AddAttribute(152, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                 Icons.Filled.AdminPanelSettings

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(153, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 62 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                             Color.Info

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(154, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(155, "Administrar pedidos");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(156, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(157);
                            __builder5.AddAttribute(158, "Href", "/admin/mapapedidos");
                            __builder5.AddAttribute(159, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                     Icons.Filled.AddLocationAlt

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(160, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 63 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                                             Color.Info

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(161, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(162, "Mapa de pedidos");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(163, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudNavLink>(164);
                            __builder5.AddAttribute(165, "Href", "/admin/cumples");
                            __builder5.AddAttribute(166, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                 Icons.Filled.Cake

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(167, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 64 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
                                                                                               Color.Info

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(168, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(169, "Cumpleaños por mes");
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
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(170, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(171);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Kelvin\Desktop\PracticaFinal\Avocado-Market\Shared\NavMenu.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> EstadoLogin { get; set; }

    private AuthenticationState UsuarioLogueado;
    protected override async Task OnInitializedAsync()
    {
        UsuarioLogueado = await EstadoLogin;
    }

    bool _isExpanded = true;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
