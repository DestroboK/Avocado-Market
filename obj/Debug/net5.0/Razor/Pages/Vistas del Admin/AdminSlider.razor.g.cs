#pragma checksum "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9859a45adba042c78dd30ddf47fe99bcd75d3340"
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
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
           [Authorize(Roles = "Administrador")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/slider")]
    public partial class AdminSlider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Administrar slider</h3>\r\n");
            __builder.OpenElement(1, "center");
            __builder.OpenComponent<MudBlazor.MudCarousel<object>>(2);
            __builder.AddAttribute(3, "Style", "height:200px;");
            __builder.AddAttribute(4, "ShowArrows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                                    arrows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ShowDelimiters", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                                                             delimiters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AutoCycle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                                                                                     autocycle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 7 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
         foreach (PaginasSlider item in Paginas)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(8);
                __builder2.AddAttribute(9, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                     transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                                         Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCard>(12);
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardMedia>(14);
                        __builder4.AddAttribute(15, "Image", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                     item.UrlImagen

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                                            250

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 19 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
     foreach (PaginasSlider item in Paginas)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudCard>(17);
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.Avocado_Market.Pages.Vistas_del_Admin.AdminSlider.TypeInference.CreateMudTextField_0(__builder2, 19, 20, "URL de la imagen en internet", 21, "mt-3", 22, 
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                               item.UrlImagen

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.UrlImagen = __value, item.UrlImagen)));
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudButton>(25);
                __builder2.AddAttribute(26, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                        Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                                    Icons.Material.Filled.Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                                                                       Color.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
                                                                                                            (()=> Actualizar(item))

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(31, "Actualizar");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Vistas del Admin\AdminSlider.razor"
      
    PaginasSlider Sli = new PaginasSlider();
    List<PaginasSlider> Paginas;
    private bool arrows = true;
    private bool delimiters = true;
    private bool autocycle = true;
    private Transition transition = Transition.Slide;

    protected override async Task OnInitializedAsync()
    {
        Paginas = await Slider.Get();
    }

    public async Task Actualizar(PaginasSlider slider)
    {
        await Slider.Update(slider);
        Paginas = await Slider.Get();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioSlider Slider { get; set; }
    }
}
namespace __Blazor.Avocado_Market.Pages.Vistas_del_Admin.AdminSlider
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
