#pragma checksum "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb89f1f45aae933461df3fe40c3b7b8d08c90b51"
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
#nullable restore
#line 11 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using LibraryApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4 style=\"text-align:center\">Looking for a specific book? Use the search!</h4><br>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
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
#line 8 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                 userSort

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.LibraryApp.Pages.Search.TypeInference.CreateInputRadioGroup_0(__builder2, 9, 10, 
#nullable restore
#line 9 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                                   userSort.filterField

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userSort.filterField = __value, userSort.filterField)), 12, () => userSort.filterField, 13, (__builder3) => {
                    __builder3.OpenElement(14, "table");
                    __builder3.AddAttribute(15, "class", "table");
                    __builder3.OpenElement(16, "tr");
#nullable restore
#line 12 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                 foreach (var bookSort in BookSearch)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(17, "td");
                    __Blazor.LibraryApp.Pages.Search.TypeInference.CreateInputRadio_1(__builder3, 18, 19, 
#nullable restore
#line 15 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                                       bookSort

#line default
#line hidden
#nullable disable
                    , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                                                             e => changeFilter(bookSort)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(21, "\r\n                    ");
                    __builder3.AddContent(22, 
#nullable restore
#line 16 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                     bookSort

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 18 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
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
#line 28 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                                        e => changeSort("Title")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, 
#nullable restore
#line 28 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
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
#line 29 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                                        e => changeSort("Author")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 29 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
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
#line 30 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                                        e => changeSort("ISBN")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, 
#nullable restore
#line 30 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
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
#line 31 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                                        e => changeSort("Number of Copies")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, 
#nullable restore
#line 31 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
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
#line 32 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                                        e => changeSort("Status")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, 
#nullable restore
#line 32 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
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
#line 37 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
         foreach (var book in bookResult)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "tr");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 40 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                     book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 41 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                     book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 42 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                     book.ISBN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 43 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                     book.NumCopies

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 44 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
                     book.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Search.razor"
 
    List<string> columnNames = new List<string> { "Title", "Author", "ISBN", "Number of Copies", "Status" };
    List<string> BookSearch = new List<string> { "Title", "Author", "ISBN", "Status" };
    List<Book> bookResult = new List<Book>();
    BookSort userSort = new BookSort();


    // On webpage load
    protected override async Task OnInitializedAsync()
    {
        bookResult = connection.Books.ToList();
    }

    // When something is typed into the search box update the search class
    void changeSearch(ChangeEventArgs s)
    {
        userSort.searchField = s.Value.ToString();
        search();
    }

    // When radio button changes, update the search class
    void changeFilter(string s)
    {
        userSort.filterField = s;
        search();
    }

    // When sort changes, update the search class
    void changeSort(string s)
    {
        // reset all column names
        columnNames[0] = "Title";
        columnNames[1] = "Author";
        columnNames[2] = "ISBN";
        columnNames[3] = "Number of Copies";
        columnNames[4] = "Status";
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
            case "Title":
                tempBookResult = tempBookResult.Where(b => b.Title.Contains(userSort.searchField));
                break;

            case "Author":
                tempBookResult = tempBookResult.Where(b => b.Author.Contains(userSort.searchField));
                break;

            case "ISBN":
                tempBookResult = tempBookResult.Where(b => b.ISBN.Contains(userSort.searchField));
                break;

            case "Status":
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

        // sort results based on the field selected
        switch (userSort.sortField)
        {
            case "Title":
                tempBookResult = tempBookResult.OrderBy(b => b.Title);
                break;

            case "Author":
                tempBookResult = tempBookResult.OrderBy(b => b.Author);
                break;

            case "ISBN":
                tempBookResult = tempBookResult.OrderBy(b => b.ISBN);
                break;

            case "Number of Copies":
                tempBookResult = tempBookResult.OrderBy(b => b.NumCopies);
                break;

            case "Status":
                tempBookResult = tempBookResult.OrderBy(b => b.Status);
                break;

            default:
                break;
        }


        bookResult = tempBookResult.ToList();
        StateHasChanged();
    }

    class BookSort
    {
        public string filterField = "Title";
        public string searchField;
        public string sortField = "Title";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibraryDBContext connection { get; set; }
    }
}
namespace __Blazor.LibraryApp.Pages.Search
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
