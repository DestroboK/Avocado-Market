#pragma checksum "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d85742502be8fade7b8fc8365e6e0af0ee11cc1"
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
            __builder.AddMarkupContent(5, "\r\n<link href=\"https://use.fontawesome.com/releases/v5.14.0/css/all.css\" rel=\"stylesheet\" b-sz3zfpgn5z>\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(8);
                __builder2.AddAttribute(9, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                      Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                            false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(13);
                    __builder3.AddAttribute(14, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIcon>(19);
                    __builder3.AddAttribute(20, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                        Icons.Material.Rounded.Shop2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Style", "font-size: large");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n        Avocado Market\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(23);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(25);
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(27, 
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                  UsuarioLogueado.User.Identity.Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(29);
                    __builder3.AddAttribute(30, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Material.Filled.AccountCircle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                                          Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Title", "Usuario");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(34);
                    __builder3.AddAttribute(35, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Material.Filled.Logout

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                                   Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Title", "Cerrar sesion");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(39);
                    __builder3.AddAttribute(40, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Material.Filled.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Title", "Acerca De");
                    __builder3.AddAttribute(43, "Link", "/about");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(45);
                    __builder3.AddAttribute(46, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                              Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "Link", "https://github.com/DestroboK/Avocado-Market");
                    __builder3.AddAttribute(49, "Title", "Repositorio del proyecto");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(51);
                    __builder3.AddAttribute(52, "Icon", "fas fa-fighter-jet");
                    __builder3.AddAttribute(53, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                        Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                                                                  (e) => DarkMode()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(56);
                __builder2.AddAttribute(57, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                            _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Avocado_Market.Shared.NavMenu>(60);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(62);
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(64);
                    __builder3.AddAttribute(65, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 26 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                                MaxWidth.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(67, 
#nullable restore
#line 27 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
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
            __builder.AddMarkupContent(68, "\r\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(69);
            __builder.AddAttribute(70, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
                         currentTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\MainLayout.razor"
       
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

    protected override void OnInitialized()
    {
        currentTheme = defaultTheme;
    }

    void DarkMode()
    {
        if (currentTheme == defaultTheme)
        {
            currentTheme = darkTheme;
        }
        else
        {
            currentTheme = defaultTheme;
        }
    }

    MudTheme currentTheme = new MudTheme();
    MudTheme defaultTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#272c34"
        }
    };

    MudTheme darkTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#27272f",
            Background = "#32333d",
            BackgroundGrey = "#27272f",
            Surface = "#373740",
            DrawerBackground = "#27272f",
            DrawerText = "rgba(255,255,255, 0.50)",
            DrawerIcon = "rgba(255,255,255, 0.50)",
            AppbarBackground = "#27272f",
            AppbarText = "rgba(255,255,255, 0.70)",
            TextPrimary = "rgba(255,255,255, 0.70)",
            TextSecondary = "rgba(255,255,255, 0.50)",
            ActionDefault = "#adadb1",
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",
            Divider = "rgba(255,255,255, 0.12)",
            DividerLight = "rgba(255,255,255, 0.06)",
            TableLines = "rgba(255,255,255, 0.12)",
            LinesDefault = "rgba(255,255,255, 0.12)",
            LinesInputs = "rgba(255,255,255, 0.3)",
            TextDisabled = "rgba(255,255,255, 0.2)"
        }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
