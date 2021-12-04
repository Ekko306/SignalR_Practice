#pragma checksum "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5ac5aee3d1478d7981a4fe5d98c2932eb83ac7f"
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
#line 3 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
using BlazorServerSignalRApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\n\n");
#nullable restore
#line 10 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 13 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 26 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 34 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 37 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/suyapeng/Projects/Private/signalIR/BlazorServerSignalRApp/BlazorServerSignalRApp/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
