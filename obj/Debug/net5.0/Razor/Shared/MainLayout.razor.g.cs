#pragma checksum "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33659b334c80723fc68eea12575c929b28f7c1a5"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(8);
                __builder2.AddAttribute(9, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 8 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                      Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                            false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(13);
                    __builder3.AddAttribute(14, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        My Application\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(19);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(21);
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(23, 
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                  UsuarioLogueado.User.Identity.Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(25);
                    __builder3.AddAttribute(26, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Material.Filled.AccountCircle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                                                          Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Title", "Usuario");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(30);
                    __builder3.AddAttribute(31, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Material.Filled.Logout

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                                                   Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Title", "Cerrar sesion");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(35);
                    __builder3.AddAttribute(36, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Material.Filled.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Title", "Acerca De");
                    __builder3.AddAttribute(39, "Link", "/about");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(41);
                    __builder3.AddAttribute(42, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Link", "https://github.com/DestroboK/Avocado-Market");
                    __builder3.AddAttribute(45, "Title", "Repositorio del proyecto");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(47);
                __builder2.AddAttribute(48, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                            _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Avocado_Market.Shared.NavMenu>(51);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(53);
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(55);
                    __builder3.AddAttribute(56, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
                            MaxWidth.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(58, 
#nullable restore
#line 23 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
                        );
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
#line 28 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\MainLayout.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> EstadoLogin { get; set; }

    private AuthenticationState UsuarioLogueado;
    protected override async Task OnInitializedAsync()
    {
        UsuarioLogueado = await EstadoLogin;
    }
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
