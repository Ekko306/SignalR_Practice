#pragma checksum "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541164fde5a7b691edf043dd28fe88e7831ecf91"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerSignalRApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using BlazorServerSignalRApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/_Imports.razor"
using BlazorServerSignalRApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddMarkupContent(4, "\n        User:\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
                      userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "label");
            __builder.AddMarkupContent(15, "\n        Message:\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "size", "50");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
                      messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "disabled", 
#nullable restore
#line 18 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n\n<hr>\n\n");
            __builder.OpenElement(28, "ul");
            __builder.AddAttribute(29, "id", "messagesList");
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 23 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.OpenElement(32, "li");
            __builder.AddContent(33, 
#nullable restore
#line 25 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 26 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/Index.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    async Task Send() =>
        await hubConnection.SendAsync("SendMessage", userInput, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection?.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
