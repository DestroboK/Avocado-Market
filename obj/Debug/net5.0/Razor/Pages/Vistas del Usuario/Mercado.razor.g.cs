#pragma checksum "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dde7c73239a7d4125073ef01b0f5850c42f0988e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/mercado")]
    public partial class Mercado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.OpenComponent<MudBlazor.MudText>(1);
            __builder.AddAttribute(2, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                   Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Mercado");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudSelect<string>>(6);
            __builder.AddAttribute(7, "Label", "Categoria");
            __builder.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                         Categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Categoria = __value, Categoria))));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
         foreach (Categoria cat in Categorias)
        {

#line default
#line hidden
#nullable disable
                __Blazor.Avocado_Market.Pages.Vistas_del_Usuario.Mercado.TypeInference.CreateMudSelectItem_0(__builder2, 11, 12, 
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                   cat.Nombre

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 13 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n     ");
            __builder.OpenComponent<MudBlazor.MudIconButton>(14);
            __builder.AddAttribute(15, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                           Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                Color.Inherit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                        PorCategoria

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "Refrescar");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudIconButton>(21);
            __builder.AddAttribute(22, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                          Icons.Material.Filled.Refresh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                Color.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                     Actualizarr

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(26, "Buscar");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudText>(28);
            __builder.AddAttribute(29, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                   Typo.h6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(31, "Se han cargado ");
                __builder2.AddContent(32, 
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                            ListaProductos.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(33, " items.");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudGrid>(35);
            __builder.AddAttribute(36, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                      2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 21 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
         foreach (Producto Prod in ListaProductos)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudItem>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCard>(40);
                    __builder3.AddAttribute(41, "Style", "max-width:100%");
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardHeader>(43);
                        __builder4.AddAttribute(44, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(45);
                            __builder5.AddAttribute(46, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 27 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                           Typo.body1

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(48, 
#nullable restore
#line 27 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                        Prod.Nombre

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(49, "\r\n                            ");
                            __builder5.OpenComponent<MudBlazor.MudText>(50);
                            __builder5.AddAttribute(51, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 28 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                           Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(53, 
#nullable restore
#line 28 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                        Prod.Categoria

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(54, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudCardMedia>(55);
                        __builder4.AddAttribute(56, "Image", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                          Prod.UrlImagen

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(57, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                  250

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudCardContent>(59);
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(61);
                            __builder5.AddAttribute(62, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 34 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                       Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(64, "Quedan ");
                                __builder6.AddContent(65, 
#nullable restore
#line 34 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                           Prod.UnidadesDisponibles

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudCardActions>(67);
                        __builder4.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 37 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                         if(Prod.UnidadesDisponibles != 0){

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<MudBlazor.MudFab>(69);
                            __builder5.AddAttribute(70, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(71, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                 Icons.Material.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(72, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                                           Size.Large

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(73, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                                                                 Size.Large

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(74, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                                                                                     Prod.PrecioUnidad.ToString()

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(75, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                                                                                                                            (() => Seleccionar(Prod))

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(76, "Class", "ma-2");
                            __builder5.CloseComponent();
#nullable restore
#line 39 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                        }
                        else{

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<MudBlazor.MudFab>(77);
                            __builder5.AddAttribute(78, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(79, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                 Icons.Material.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(80, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(81, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                                                           Size.Large

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(82, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                                                                                 Size.Large

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(83, "Label", "Agotado");
                            __builder5.AddAttribute(84, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                                                                                                                                      (() => Seleccionar(Prod))

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(85, "Class", "ma-2");
                            __builder5.CloseComponent();
#nullable restore
#line 42 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                        }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 46 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudButton>(87);
            __builder.AddAttribute(88, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 49 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                        Variant.Text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                 () => OpenDrawer(Anchor.Bottom)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(91, "Bottom");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(92, "\r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudDrawer>(93);
            __builder.AddAttribute(94, "Anchor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Anchor>(
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                           anchor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                              1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerVariant>(
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                           DrawerVariant.Temporary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                            open

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => open = __value, open))));
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudDrawerHeader>(100);
                __builder2.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(102);
                    __builder3.AddAttribute(103, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                  Icons.Material.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 53 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                                                                             Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(105, "Title", "Ir a mi carrito");
                    __builder3.AddAttribute(106, "Link", "/carrito");
                    __builder3.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(108, "Mi Carrito");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudText>(110);
                    __builder3.AddAttribute(111, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 54 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(113, "Mi Carrito");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudNavMenu>(115);
                __builder2.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 57 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
             foreach (Producto p in ListaProductos)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(117);
                    __builder3.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(119, 
#nullable restore
#line 59 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
                          p.Nombre

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 60 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Usuario\Mercado.razor"
           
        [CascadingParameter]
        private Task<AuthenticationState> EstadoLogin { get; set; }

        private AuthenticationState UsuarioLogueado;

        Producto Produ = new Producto();
        List<Producto> ListaProductos;
        Avocado_Market.Data.Carrito MiCarrito;
        List<Categoria> Categorias;
        string Categoria;
        protected override async Task OnInitializedAsync()
        {
            UsuarioLogueado = await EstadoLogin;
            MiCarrito = await AccesoCarrito.Get(UsuarioLogueado.User.Identity.Name);
            ListaProductos = await AccesoDatos.Get(); ;
            Categorias = await AccesoCategorias.Get();
        }
        public async void Seleccionar(Producto temp)
        {
            temp.UnidadesDisponibles --;
            await AccesoDatos.Update(temp);
            await AccesoCarrito.AgregarItem(temp, MiCarrito);
            MiCarrito = await AccesoCarrito.Get(UsuarioLogueado.User.Identity.Name);
            ListaProductos = await AccesoDatos.Get();
        }
        public async void Actualizar()
        {
            await AccesoDatos.Update(Produ);
            ListaProductos = await AccesoDatos.Get();
        }
        public async void Actualizarr()
        {
            ListaProductos = await AccesoDatos.Get();
        }

        public async void PorCategoria()
        {

            ListaProductos = await AccesoDatos.PorCategoria(Categoria);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriaService AccesoCategorias { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarritoServices AccesoCarrito { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoServices AccesoDatos { get; set; }
    }
}
namespace __Blazor.Avocado_Market.Pages.Vistas_del_Usuario.Mercado
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSelectItem_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
