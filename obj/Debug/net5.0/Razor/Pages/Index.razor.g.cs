#pragma checksum "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05aa2ef0b7e6dcc690d15c0a183dcc1c7ce6370b"
// <auto-generated/>
#pragma warning disable 1591
namespace Avocado_Market.Pages
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
#line 15 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\_Imports.razor"
using Avocado_Market.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
using Avocado_Market.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCarousel<object>>(0);
            __builder.AddAttribute(1, "Style", "height:200px;");
            __builder.AddAttribute(2, "ShowArrows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                                arrows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ShowDelimiters", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                                                         delimiters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "AutoCycle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                                                                                 autocycle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(6);
                __builder2.AddAttribute(7, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                 transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 5 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                                     Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCard>(10);
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardMedia>(12);
                        __builder4.AddAttribute(13, "Image", "https://images.unsplash.com/photo-1601004890684-d8cbf643f5f2?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8M3x8fGVufDB8fHx8&w=1000&q=80");
                        __builder4.AddAttribute(14, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
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
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(16);
                __builder2.AddAttribute(17, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                 transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                                     Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardMedia>(20);
                    __builder3.AddAttribute(21, "Image", "https://c.tenor.com/zrO4syNz96IAAAAC/kristen-bell-eleanor-shellstrop.gif");
                    __builder3.AddAttribute(22, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                                                                                               250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(24);
                __builder2.AddAttribute(25, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 14 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                 transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardMedia>(27);
                    __builder3.AddAttribute(28, "Image", "https://itla.edu.do/wp-content/uploads/2021/02/logo-full.png");
                    __builder3.AddAttribute(29, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                                                                                   250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n");
            __Blazor.Avocado_Market.Pages.Index.TypeInference.CreateMudSelect_0(__builder, 31, 32, "Transition", 33, "ma-2", 34, 
#nullable restore
#line 18 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                        transition

#line default
#line hidden
#nullable disable
            , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => transition = __value, transition)), 36, (__builder2) => {
                __Blazor.Avocado_Market.Pages.Index.TypeInference.CreateMudSelectItem_1(__builder2, 37, 38, 
#nullable restore
#line 19 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                           Transition.Fade

#line default
#line hidden
#nullable disable
                , 39, (__builder3) => {
                    __builder3.AddContent(40, "Fade");
                }
                );
                __builder2.AddMarkupContent(41, "\r\n    ");
                __Blazor.Avocado_Market.Pages.Index.TypeInference.CreateMudSelectItem_2(__builder2, 42, 43, 
#nullable restore
#line 20 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                           Transition.Slide

#line default
#line hidden
#nullable disable
                , 44, (__builder3) => {
                    __builder3.AddContent(45, "Slide");
                }
                );
                __builder2.AddMarkupContent(46, "\r\n    ");
                __Blazor.Avocado_Market.Pages.Index.TypeInference.CreateMudSelectItem_3(__builder2, 47, 48, 
#nullable restore
#line 21 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                           Transition.None

#line default
#line hidden
#nullable disable
                , 49, (__builder3) => {
                    __builder3.AddContent(50, "None");
                }
                );
            }
            );
            __builder.AddMarkupContent(51, "\r\n");
            __Blazor.Avocado_Market.Pages.Index.TypeInference.CreateMudSwitch_4(__builder, 52, 53, 
#nullable restore
#line 23 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                          Color.Primary

#line default
#line hidden
#nullable disable
            , 54, 
#nullable restore
#line 23 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                           arrows

#line default
#line hidden
#nullable disable
            , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => arrows = __value, arrows)), 56, (__builder2) => {
                __builder2.AddContent(57, "Show Arrows");
            }
            );
            __builder.AddMarkupContent(58, "\r\n");
            __Blazor.Avocado_Market.Pages.Index.TypeInference.CreateMudSwitch_5(__builder, 59, 60, 
#nullable restore
#line 24 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                              Color.Primary

#line default
#line hidden
#nullable disable
            , 61, 
#nullable restore
#line 24 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                           delimiters

#line default
#line hidden
#nullable disable
            , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => delimiters = __value, delimiters)), 63, (__builder2) => {
                __builder2.AddContent(64, "Show Delimiters");
            }
            );
            __builder.AddMarkupContent(65, "\r\n");
            __Blazor.Avocado_Market.Pages.Index.TypeInference.CreateMudSwitch_6(__builder, 66, 67, 
#nullable restore
#line 25 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                             Color.Primary

#line default
#line hidden
#nullable disable
            , 68, 
#nullable restore
#line 25 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                           autocycle

#line default
#line hidden
#nullable disable
            , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => autocycle = __value, autocycle)), 70, (__builder2) => {
                __builder2.AddContent(71, "Auto Cycle (Default: 5 secs)");
            }
            );
            __builder.AddMarkupContent(72, "\r\n\r\n\r\n\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Maps.SfMaps>(73);
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Maps.MapsTitleSettings>(75);
                __builder2.AddAttribute(76, "Text", "Team aguacate esta trabajando...");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Maps.MapsLayers>(78);
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Maps.MapsLayer<string>>(80);
                    __builder3.AddAttribute(81, "ShapeData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 34 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
                                  new {dataOptions= "https://cdn.syncfusion.com/maps/map-data/world-map.json"}

#line default
#line hidden
#nullable disable
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
#line 39 "C:\Users\Kelvin\Desktop\Polsia\hola\Avocado-Market\Pages\Index.razor"
      
    //CODIGO PARA HACER QUE ESTA PAGINA SOLO SEA VISIBLE PARA ADMINS. COLOCAR AL INICIO DE PAGINA
    //@attribute [Authorize(Roles = "Administrador")]//
    private bool arrows = true;
    private bool delimiters = true;
    private bool autocycle = true;
    private Transition transition = Transition.Slide;

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Avocado_Market.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSelect_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Checked", __arg1);
        __builder.AddAttribute(__seq2, "CheckedChanged", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Checked", __arg1);
        __builder.AddAttribute(__seq2, "CheckedChanged", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Checked", __arg1);
        __builder.AddAttribute(__seq2, "CheckedChanged", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
