#pragma checksum "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef23d72c9807a02b912335622848b6600d65a336"
// <auto-generated/>
#pragma warning disable 1591
namespace Basic.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using Basic.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using Basic.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using Basic.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\TAR\Desktop\Templates\Basic\Client\_Imports.razor"
using DotNetify.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/helloworld")]
    public partial class HelloWorld : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DotNetify.Blazor.VMContext<IHelloWorldState>>(0);
            __builder.AddAttribute(1, "VM", "HelloWorld");
            __builder.AddAttribute(2, "OnStateChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IHelloWorldState>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IHelloWorldState>(this, 
#nullable restore
#line 3 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
                                                                    UpdateState

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\n");
#nullable restore
#line 4 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
 if (state != null)
{

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, "    ");
                __builder2.OpenElement(6, "h1");
                __builder2.AddContent(7, 
#nullable restore
#line 6 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
         state.Greetings

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenElement(11, "p");
                __builder2.AddContent(12, "Server time is: ");
                __builder2.OpenElement(13, "strong");
                __builder2.AddContent(14, 
#nullable restore
#line 8 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
                                    state.ServerTime

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.AddMarkupContent(16, "<p>Enter your name:</p>\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "style", "display:flex");
                __builder2.AddMarkupContent(19, "\n            ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "placeholder", "First name");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
                                                                                    person.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => person.FirstName = __value, person.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n            ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "type", "text");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "placeholder", "Last name");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
                                                                                   person.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => person.LastName = __value, person.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n            ");
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "class", "btn btn-primary");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
                                                      () => state.Submit(person)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(37, "Submit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n        \n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n");
#nullable restore
#line 17 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
}

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\TAR\Desktop\Templates\Basic\Client\Pages\HelloWorld.razor"
       
   private IHelloWorldState state;
   private Person person = new Person();

   private void UpdateState(IHelloWorldState state)
   {
       this.state = state;
       StateHasChanged();
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
