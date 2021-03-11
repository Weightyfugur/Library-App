// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 11 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using LibraryApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using LibraryApp.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/book/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Create.razor"
       
    public Book newBook = new Book();
    public List<Book> newBooks = new List<Book>();
    public int newBookAmount { get; set; } = 1;
    public int ISBN;

    void FormSubmitted()
    {
        // Makes a connection to the database and adds a new book, saves changes
        // Optional usage instead of States -> connection.Books.Add(newBook);

        for (int i = 0; i < newBookAmount; i++)
        {
            newBooks.Add(newBook);
        }

        foreach (Book b in newBooks)
        {
            connection.Add(addBook(b));
            connection.SaveChanges();
        }

        nav.NavigateTo(nav.Uri, forceLoad: true);

    }

    public Book addBook(Book b)
    {
        connection.Entry(b).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        b.GetType().GetProperty("Id").SetValue(b, 0);

        return b;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibraryDBContext connection { get; set; }
    }
}
#pragma warning restore 1591
