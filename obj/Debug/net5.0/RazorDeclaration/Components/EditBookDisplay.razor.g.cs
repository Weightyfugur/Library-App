// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LibraryApp.Components
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
    public partial class EditBookDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Components\EditBookDisplay.razor"
       
    public Book bookSearch { get; set; } = new Book();

    public List<Book> bookList;

    public bool ShowDialog {get; set;}

    [Parameter]
    public Action CloseEventCallback {get; set;}

    public void Show()
    {
        ShowDialog = true;
        StateHasChanged();
    }

    public void Close()
    {
        ShowDialog = false;
        StateHasChanged();
    }

    // Submit button
    void HandleValidSubmit()
    {
        editBook();
        ShowDialog = false;
        CloseEventCallback.Invoke();
        StateHasChanged();
    }

    // changes the data for the book
    void editBook()
    {
        foreach(var b in bookList)
        {
            b.Title = bookSearch.Title;
            b.Author = bookSearch.Author;
            b.ISBN = bookSearch.ISBN;
            b.Status = bookSearch.Status;
            connection.Entry(b).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        connection.SaveChanges();
    }

    public void setBook(BookCount _book)
    {
        bookSearch.Title = _book.Title;
        bookSearch.Author = _book.Author;
        bookSearch.ISBN = _book.ISBN;
        bookSearch.Status = _book.Status;
        setBookList();
        StateHasChanged();
    }

    private void setBookList()
    {
        var result = from b in connection.Books
                     select b;

        result = result.Where(b => b.Title.Contains(bookSearch.Title));
        result = result.Where(b => b.Author.Contains(bookSearch.Author));
        result = result.Where(b => b.ISBN.Contains(bookSearch.ISBN));
        result = result.Where(b => b.Status.Contains(bookSearch.Status));

        bookList = result.ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibraryDBContext connection { get; set; }
    }
}
#pragma warning restore 1591
