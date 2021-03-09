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
#nullable restore
#line 1 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Components\DeleteBookDisplay.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class DeleteBookDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Components\DeleteBookDisplay.razor"
       
    public numInput input = new numInput();
    public List<Book> bookList;
    public bool ShowDialog { get; set; }
    private int maxBooks { get; set; }

    [Parameter]
    public Action CloseEventCallback { get; set; }

    public class numInput
    {
        public int amount { get; set; } = 1;

        public Book bookSearch = new Book();
    }

    public void Show()
    {
        ShowDialog = true;
        StateHasChanged();
    }

    public void Close()
    {
        ShowDialog = false;
        input.amount = 1;
        StateHasChanged();
    }

    // Submit button
    void HandleValidSubmit()
    {
        deleteBook();
        ShowDialog = false;
        CloseEventCallback.Invoke();
        StateHasChanged();
    }

    // deletes the book
    void deleteBook()
    {
        setBookList();
        foreach (var b in bookList)
        {
            b.Title = input.bookSearch.Title;
            b.Author = input.bookSearch.Author;
            b.ISBN = input.bookSearch.ISBN;
            b.Status = input.bookSearch.Status;
            connection.Entry(b).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        connection.SaveChanges();
    }

    // save book info to form and save max amount of books
    public void setBook(BookCount _book)
    {
        input.bookSearch.Title = _book.Title;
        input.bookSearch.Author = _book.Author;
        input.bookSearch.ISBN = _book.ISBN;
        input.bookSearch.Status = _book.Status;
        setBookList();
        maxBooks = _book.Count;
        StateHasChanged();
    }

    // grab books to be deleted
    private void setBookList()
    {
        var result = from b in connection.Books
                     select b;

        result = result.Where(b => b.Title.Contains(input.bookSearch.Title));
        result = result.Where(b => b.Author.Contains(input.bookSearch.Author));
        result = result.Where(b => b.ISBN.Contains(input.bookSearch.ISBN));
        result = result.Where(b => b.Status.Contains(input.bookSearch.Status));

        result = result.Take(input.amount);

        bookList = result.ToList();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibraryDBContext connection { get; set; }
    }
}
#pragma warning restore 1591
