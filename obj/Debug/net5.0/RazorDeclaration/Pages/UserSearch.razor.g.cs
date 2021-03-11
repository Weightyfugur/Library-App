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
    [Microsoft.AspNetCore.Components.RouteAttribute("/usersearch")]
    public partial class UserSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\UserSearch.razor"
 
    List<string> columnNames = new List<string> { "Title", "Author", "ISBN", "Status", "Number of Copies" };
    List<BookCount> bookResult = new List<BookCount>();
    BookSort userSort = new BookSort();

    // On webpage load
    protected override async Task OnInitializedAsync()
    {
        search();
    }

    // When something is typed into the search box update the search class
    void changeSearch(ChangeEventArgs s)
    {
        userSort.searchField = s.Value.ToString();
        search();
    }

    // When radio button changes, update the search class
    void changeFilter(object s)
    {
        userSort.filterField = (BookSearch)(int)s;
        search();
    }

    // When sort changes, update the search class
    void changeSort(string s)
    {
        // reset all column names
        columnNames[0] = "Title";
        columnNames[1] = "Author";
        columnNames[2] = "ISBN";
        columnNames[3] = "Status";
        columnNames[4] = "Number of Copies";
        columnNames[columnNames.IndexOf(s)] = s + " ↓";

        userSort.sortField = s;
        search();
    }

    // search function
    void search()
    {
        var tempBookResult = from b in connection.Books
                             select b;

        // get the results that only contain X in the field X
        switch (userSort.filterField)
        {
            case BookSearch.Title:
                tempBookResult = tempBookResult.Where(b => b.Title.Contains(userSort.searchField));
                break;

            case BookSearch.Author:
                tempBookResult = tempBookResult.Where(b => b.Author.Contains(userSort.searchField));
                break;

            case BookSearch.ISBN:
                tempBookResult = tempBookResult.Where(b => b.ISBN.Contains(userSort.searchField));
                break;

            case BookSearch.Status:
                tempBookResult = tempBookResult.Where(b => b.Status.Contains(userSort.searchField));
                break;

            default:
                break;
        }

        // if search field empty, 
        if (userSort.searchField == "" || userSort.searchField == null)
        {
            tempBookResult = from b in connection.Books
                             select b;
        }

        // get number of books

        var countTable = connection.Books.GroupBy(b => new { Title = b.Title, Author = b.Author, ISBN = b.ISBN, Status = b.Status }).Select(b => new { b.Key, count = b.Count() });

        var result = from b in tempBookResult
                     join c in countTable on new { b.Title, b.Author, b.ISBN, b.Status } equals c.Key
                     select new
                     {
                         Book = b,
                         Count = c.count
                     };
        var resultTable = result.Select(b => new {Title = b.Book.Title, Author = b.Book.Author, ISBN = b.Book.ISBN, Status = b.Book.Status, Count = b.Count }).Distinct();

        // sort results based on the field selected
        switch (userSort.sortField)
        {
            case "Title":
                resultTable = resultTable.OrderBy(b => b.Title);
                break;

            case "Author":
                resultTable = resultTable.OrderBy(b => b.Author);
                break;

            case "ISBN":
                resultTable = resultTable.OrderBy(b => b.ISBN);
                break;

            case "Number of Copies":
                resultTable = resultTable.OrderBy(b => b.Count);
                break;

            case "Status":
                resultTable = resultTable.OrderBy(b => b.Status);
                break;

            default:
                break;
        }
        var tempList = resultTable.ToList();
        bookResult.Clear();
        foreach (var i in tempList)
        {
            bookResult.Add(new BookCount(i.Title, i.Author, i.ISBN, i.Status, i.Count));
        }
        StateHasChanged();
    }

    class BookSort
    {
        public BookSearch filterField = BookSearch.Title;
        public string searchField;
        public string sortField = "Title";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibraryDBContext connection { get; set; }
    }
}
#pragma warning restore 1591
