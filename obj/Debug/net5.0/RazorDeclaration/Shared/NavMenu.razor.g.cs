// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
                   
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
#line 58 "C:\Users\Administrador\Desktop\Avocado-Market\Shared\NavMenu.razor"
      
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
