#pragma checksum "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25f642378438aed531f02b68bc8709836109260c"
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
#line 3 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
using Avocado_Market.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "max-width: 400px;");
            __builder.OpenComponent<MudBlazor.MudCard>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardContent>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudForm>(6);
                    __builder3.AddAttribute(7, "OnValidSubmit", true);
                    __builder3.AddAttribute(8, "IsValid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                 success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "IsValidChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => success = __value, success))));
                    __builder3.AddAttribute(10, "Errors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                                         errors

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ErrorsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String[]>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => errors = __value, errors))));
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(13);
                        __builder4.AddAttribute(14, "Label", "Nombre");
                        __builder4.AddAttribute(15, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "RequiredError", "Por favor introduzca un usuario");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(18);
                        __builder4.AddAttribute(19, "Label", "Email");
                        __builder4.AddAttribute(20, "bind-Value", 
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                                    usuario.Email

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(21, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "RequiredError", "Por favor introduzca un correo");
                        __builder4.AddAttribute(23, "Validation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                            new EmailAddressAttribute() {ErrorMessage = "Esta direccion es invalida"}

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(25);
                        __builder4.AddAttribute(26, "Label", "Contraseña");
                        __builder4.AddAttribute(27, "HelperText", "Choose a strong password");
                        __builder4.AddAttribute(28, "InputType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.InputType>(
#nullable restore
#line 14 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                         InputType.Password

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Validation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                            new Func<string, IEnumerable<string>>(PasswordStrength)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "RequiredError", "Por favor introduzca una contraseña");
                        __builder4.AddComponentReferenceCapture(32, (__value) => {
#nullable restore
#line 13 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                                                                        pwField1 = (MudBlazor.MudTextField<string>)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(34);
                        __builder4.AddAttribute(35, "Label", "Password");
                        __builder4.AddAttribute(36, "HelperText", "Repeat the password");
                        __builder4.AddAttribute(37, "InputType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.InputType>(
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                                                           InputType.Password

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "Validation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                            new Func<string, string>(PasswordMatch)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(39, (__value) => {
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                           form = (MudBlazor.MudForm)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudCardActions>(41);
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(43);
                    __builder3.AddAttribute(44, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                       Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                                                                  !success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "Class", "ml-auto");
                    __builder3.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(49, "Register");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudExpansionPanels>(51);
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudExpansionPanel>(53);
                __builder2.AddAttribute(54, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                   $"Errores ({errors.Length})"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 29 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
             foreach (var error in errors)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(56);
                    __builder3.AddAttribute(57, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                 Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(59, 
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
                                               error

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 32 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
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
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "p");
            __builder.AddContent(62, 
#nullable restore
#line 37 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
    hola

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\Avocado-Market\Pages\Login.razor"
       
    bool success;
    string hola = "";
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;

        async Task ProcessSomething()
    {
        hola = "fafwafwaf";
        await Task.Delay(50);

    }



    private IEnumerable<string> PasswordStrength(string pw)
    {
        if (string.IsNullOrWhiteSpace(pw))
        {
            yield return "Es necesaria una contraseña!";
            yield break;
        }
        if (pw.Length < 8)
            yield return "La contraseña debe tener almenos 8 caracteres.";
        if (!Regex.IsMatch(pw, @"[A-Z]"))
            yield return "La contraseña debe tener almenos 1 letra mayúscula.";
        if (!Regex.IsMatch(pw, @"[a-z]"))
            yield return "La contraseña debe tener almenos 1 letra minúscula.";
        if (!Regex.IsMatch(pw, @"[0-9]"))
            yield return "La contraseña debe tener almenos 1 digito.";
    }

    private string PasswordMatch(string arg)
    {
        if (pwField1.Value != arg)
            return "Passwords don't match";
        return null;
    }
    
    public Usuario usuario = new Usuario();



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
