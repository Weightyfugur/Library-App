#pragma checksum "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d22c2cc05a78fef081492074193342beed64a66"
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
#line 1 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using LibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using LibraryApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using LibraryApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Wren\Documents\GitHub\Library-App\_Imports.razor"
using LibraryApp.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/comingsoon")]
    public partial class ComingSoon : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align:center\">Coming soon to the Library!</h3>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                                  changeSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                 userSort

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.LibraryApp.Pages.ComingSoon.TypeInference.CreateInputRadioGroup_0(__builder2, 9, 10, 
#nullable restore
#line 10 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                   userSort.filterField

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userSort.filterField = __value, userSort.filterField)), 12, () => userSort.filterField, 13, (__builder3) => {
                    __builder3.OpenElement(14, "table");
                    __builder3.AddAttribute(15, "class", "table");
                    __builder3.OpenElement(16, "tr");
#nullable restore
#line 13 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                 foreach (var bookSort in Enum.GetValues(typeof(newBookSearch)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(17, "td");
                    __Blazor.LibraryApp.Pages.ComingSoon.TypeInference.CreateInputRadio_1(__builder3, 18, 19, 
#nullable restore
#line 16 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                           bookSort

#line default
#line hidden
#nullable disable
                    , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                                                 e => changeFilter(bookSort)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(21, "\r\n                        ");
                    __builder3.AddContent(22, 
#nullable restore
#line 17 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                         bookSort

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 19 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.OpenElement(26, "thead");
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "th");
            __builder.AddAttribute(29, "scope", "col");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                        e => changeSort("Title")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, 
#nullable restore
#line 29 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                                                    columnNames[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "scope", "col");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                        e => changeSort("Author")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 30 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                                                     columnNames[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "th");
            __builder.AddAttribute(39, "scope", "col");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                        e => changeSort("ISBN")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, 
#nullable restore
#line 31 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                                                   columnNames[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "th");
            __builder.AddAttribute(44, "scope", "col");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                        e => changeSort("Status")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, 
#nullable restore
#line 32 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                                                     columnNames[3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "th");
            __builder.AddAttribute(49, "scope", "col");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                        e => changeSort("Number of Copies")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, 
#nullable restore
#line 33 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                                                                               columnNames[4]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n    ");
            __builder.OpenElement(53, "tbody");
#nullable restore
#line 38 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
         foreach (var book in bookResult)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "tr");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 41 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                 book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 42 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                 book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 43 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                 book.ISBN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 44 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                 book.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 45 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
                 book.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Wren\Documents\GitHub\Library-App\Pages\ComingSoon.razor"
 
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
        userSort.filterField = (newBookSearch)(int)s;
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
            case newBookSearch.Title:
                tempBookResult = tempBookResult.Where(b => b.Title.Contains(userSort.searchField));
                break;

            case newBookSearch.Author:
                tempBookResult = tempBookResult.Where(b => b.Author.Contains(userSort.searchField));
                break;

            case newBookSearch.ISBN:
                tempBookResult = tempBookResult.Where(b => b.ISBN.Contains(userSort.searchField));
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
        var resultTable = result.Select(b => new { Title = b.Book.Title, Author = b.Book.Author, ISBN = b.Book.ISBN, Status = b.Book.Status, Count = b.Count }).Distinct();

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

        resultTable = resultTable.Where(b => b.Status.Contains("Coming Soon"));

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
        public newBookSearch filterField = newBookSearch.Title;
        public string searchField;
        public string sortField = "Title";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibraryDBContext connection { get; set; }
    }
}
namespace __Blazor.LibraryApp.Pages.ComingSoon
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputRadioGroup_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "onclick", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
