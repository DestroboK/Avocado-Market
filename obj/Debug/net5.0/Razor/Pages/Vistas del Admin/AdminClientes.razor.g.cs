#pragma checksum "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a47b8125426b7a3d5592e4ef64dd263587c126"
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
#nullable restore
#line 4 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
           [Authorize(Roles = "Administrador")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/clientes")]
    public partial class AdminClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Administrar privilegios de las cuentas</h3>\r\n");
            __Blazor.Avocado_Market.Pages.Vistas_del_Admin.AdminClientes.TypeInference.CreateMudTable_0(__builder, 1, 2, 
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                  Usuarios

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                   true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                     Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                          Color.Info

#line default
#line hidden
#nullable disable
            , 6, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(7);
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(9, "Id");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "Nombre");
                }
                ));
                __builder2.CloseComponent();
            }
            , 14, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(15);
                __builder2.AddAttribute(16, "DataLabel", "Nr");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, 
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                               context.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(20);
                __builder2.AddAttribute(21, "DataLabel", "Sign");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, 
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                 context.Email

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(25);
                __builder2.AddAttribute(26, "DataLabel", "Sign");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 18 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
             if (UsuarioEsAdmin(context) == true)
            {
                if (context.Email == UsuarioLogueado.User.Identity.Name)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudButton>(28);
                    __builder3.AddAttribute(29, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                    Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                                         Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                                                              (() => QuitarAdmin(context.Id))

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(35, "Usted ya es admin");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 23 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudButton>(36);
                    __builder3.AddAttribute(37, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 26 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                    Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                         Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                                               (() => QuitarAdmin(context.Id))

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(42, "Quitar privilegio");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 27 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                }
            }
            else if (UsuarioEsAdmin(context) == false)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudButton>(43);
                    __builder3.AddAttribute(44, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                       MudBlazor.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                             Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                    Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "Class", "ml-auto");
                    __builder3.AddAttribute(48, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                                                            (() => DarAdmin(context.Id))

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(50, "Promover a Admin");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 32 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(52);
                __builder2.AddAttribute(53, "DataLabel", "Sign");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(55);
                    __builder3.AddAttribute(56, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                  Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 35 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                         Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "StartIcon", 
#nullable restore
#line 35 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                     Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(59, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                                                          Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                                                                                                                 () => OpenDrawer(Anchor.Bottom, context)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(61, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDrawer>(62);
            __builder.AddAttribute(63, "Anchor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Anchor>(
#nullable restore
#line 39 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                       anchor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                          1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerVariant>(
#nullable restore
#line 39 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                       DrawerVariant.Temporary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                        open

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => open = __value, open))));
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudDrawerHeader>(69);
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(71);
                    __builder3.AddAttribute(72, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 41 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(74, "Ordenes de este usuario");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavMenu>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 44 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
         if (OrdenesEspecificas.Count == 0)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(78);
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(80, "Este usuario no ha comprado nada");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 47 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(81);
                    __builder3.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(83, "Este usuario ha hecho ");
                        __builder4.AddContent(84, 
#nullable restore
#line 50 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                            OrdenesEspecificas.Count

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(85, " pedido(s)");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\r\n            ");
                    __Blazor.Avocado_Market.Pages.Vistas_del_Admin.AdminClientes.TypeInference.CreateMudTable_1(__builder3, 87, 88, 
#nullable restore
#line 51 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                             OrdenesEspecificas

#line default
#line hidden
#nullable disable
                    , 89, 
#nullable restore
#line 51 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    , 90, 
#nullable restore
#line 51 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                                                          Breakpoint.Sm

#line default
#line hidden
#nullable disable
                    , 91, (__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTh>(92);
                        __builder4.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(94, "Id");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(95, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(96);
                        __builder4.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(98, "Estado");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(99, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(100);
                        __builder4.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(102, "Latitud");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(103, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(104);
                        __builder4.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(106, "Longitud");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(107, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(108);
                        __builder4.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(110, "Coste Total");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(111, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(112);
                        __builder4.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(114, "Comentario");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    , 115, (context) => (__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTd>(116);
                        __builder4.AddAttribute(117, "DataLabel", "Nr");
                        __builder4.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(119, 
#nullable restore
#line 62 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                           context.Id

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(120, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(121);
                        __builder4.AddAttribute(122, "DataLabel", "Sign");
                        __builder4.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(124, 
#nullable restore
#line 63 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                             context.Estado

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(125, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(126);
                        __builder4.AddAttribute(127, "DataLabel", "Sign");
                        __builder4.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(129, 
#nullable restore
#line 64 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                             context.Latitud

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(130, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(131);
                        __builder4.AddAttribute(132, "DataLabel", "Sign");
                        __builder4.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(134, 
#nullable restore
#line 65 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                             context.Longitud

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(135, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(136);
                        __builder4.AddAttribute(137, "DataLabel", "Sign");
                        __builder4.AddAttribute(138, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(139, 
#nullable restore
#line 66 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                             context.CosteTotal

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(140, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(141);
                        __builder4.AddAttribute(142, "DataLabel", "Sign");
                        __builder4.AddAttribute(143, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(144, 
#nullable restore
#line 67 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                                             context.Comentario

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(145, ">\r\n                ");
                    }
                    );
#nullable restore
#line 70 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(146, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(147);
                __builder2.AddAttribute(148, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
                         (() => open = false)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(149, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(150, "Cerrar");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\Kelvin\Desktop\Polsia\hola\hola2\Avocado-Market\Pages\Vistas del Admin\AdminClientes.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> EstadoLogin { get; set; }
    private readonly UserManager<IdentityUser> userManager;
    List<IdentityUser> Usuarios;
    List<Orden> OrdenesEspecificas = new List<Orden>();
    IdentityUser UsuarioBuscado;
    private AuthenticationState UsuarioLogueado;
    protected override async Task OnInitializedAsync()
    {
        UsuarioLogueado = await EstadoLogin;
        Usuarios = AccesoUsuarios.Get();
    }
    public bool UsuarioEsAdmin(IdentityUser usuario)
    {

        bool EsAdmin = AccesoUsuarios.EsAdmin(usuario).Result;

        return EsAdmin;
    }


    public async Task DarAdmin(string usuario)
    {
        await AccesoUsuarios.DarAdmin(usuario);
        Usuarios = AccesoUsuarios.Get();
    }

    public async Task QuitarAdmin(string usuario)
    {
        await AccesoUsuarios.QuitarAdmin(usuario);
        Usuarios = AccesoUsuarios.Get();
    }

    bool open;
    Anchor anchor;

    public async Task OpenDrawer(Anchor anchor, IdentityUser usuario)
    {
        OrdenesEspecificas = await AccesoOrdenes.Get(usuario.Email);
        open = true;
        this.anchor = anchor;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrdenServices AccesoOrdenes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUsuarioService AccesoUsuarios { get; set; }
    }
}
namespace __Blazor.Avocado_Market.Pages.Vistas_del_Admin.AdminClientes
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::MudBlazor.Color __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "LoadingProgressColor", __arg3);
        __builder.AddAttribute(__seq4, "HeaderContent", __arg4);
        __builder.AddAttribute(__seq5, "RowTemplate", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg4)
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
