#pragma checksum "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d4728d59b0b581aa51e473e7ea295bffb94545"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerApp.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\App.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\App.razor"
using PlannerApp.Client.Pages.Auth;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 4 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 6 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n                ");
                    __builder3.OpenComponent<PlannerApp.Client.Pages.Auth.RedirectToLogin>(9);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
            }
            ));
            __builder.AddAttribute(12, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(17);
                    __builder3.AddAttribute(18, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 14 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\02_PlannerApp\PlannerApp.Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(20, "\r\n                ");
                        __builder4.AddMarkupContent(21, "<p>Sorry, there\'s nothing at this address.</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
