#pragma checksum "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38dde00ed2056e5d48ff8d8bde640b794682afcb"
// <auto-generated/>
#pragma warning disable 1591
namespace LibraryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using LibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using LibraryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to the Library!</h1>\r\n\r\nFeel free to look at our selection of books available.\r\n\r\n");
            __builder.OpenComponent<LibraryApp.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is the Library working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<LibraryApp.Pages.FetchData>(4);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
