#pragma checksum "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d040dad5e9d72ed7392be0a45b195e28c286acf9"
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
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(9);
                    __builder3.AddAttribute(10, "Href", "/servers");
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(12, "Servers");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(14);
                    __builder3.AddAttribute(15, "Href", "/identity/account/logout");
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(17, "Cerrar Sesion");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavGroup>(19);
                    __builder3.AddAttribute(20, "Title", "Settings");
                    __builder3.AddAttribute(21, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Shared\NavMenu.razor"
                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(23);
                        __builder4.AddAttribute(24, "Href", "/users");
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(26, "Users");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(28);
                        __builder4.AddAttribute(29, "Href", "/security");
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(31, "Security");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(33);
                    __builder3.AddAttribute(34, "Href", "/about");
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(36, "About");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(37, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(38);
                    __builder3.AddAttribute(39, "Href", "/identity/account/login");
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(41, "Iniciar Sesion");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(43);
                    __builder3.AddAttribute(44, "Href", "/about");
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(46, "About");
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
    }
}
#pragma warning restore 1591
