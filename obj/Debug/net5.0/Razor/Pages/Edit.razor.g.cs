#pragma checksum "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca2936fcf8cd7459d92b3057100007d12901f69"
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
#nullable restore
#line 12 "Z:\Swango\Desktop\GitHub Repositories\Library-App\_Imports.razor"
using LibraryApp.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/book/manage")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align:center\">Book Manager</h3>\r\n            <br>\r\n\r\n            ");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                              changeSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                             userSort

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.LibraryApp.Pages.Edit.TypeInference.CreateInputRadioGroup_0(__builder2, 9, 10, 
#nullable restore
#line 10 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                               userSort.filterField

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userSort.filterField = __value, userSort.filterField)), 12, () => userSort.filterField, 13, (__builder3) => {
                    __builder3.OpenElement(14, "table");
                    __builder3.AddAttribute(15, "class", "table");
                    __builder3.OpenElement(16, "tr");
#nullable restore
#line 13 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                             foreach (var bookSort in Enum.GetValues(typeof(BookSearch)))
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(17, "td");
                    __Blazor.LibraryApp.Pages.Edit.TypeInference.CreateInputRadio_1(__builder3, 18, 19, 
#nullable restore
#line 16 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                       bookSort

#line default
#line hidden
#nullable disable
                    , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                             e => changeFilter(bookSort)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(21, "\r\n                                    ");
                    __builder3.AddContent(22, 
#nullable restore
#line 17 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                     bookSort

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 19 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
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
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n            ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.OpenElement(26, "thead");
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "th");
            __builder.AddAttribute(29, "scope", "col");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                    e => changeSort("Title")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, 
#nullable restore
#line 29 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                                columnNames[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "scope", "col");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                    e => changeSort("Author")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 30 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                                 columnNames[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "th");
            __builder.AddAttribute(39, "scope", "col");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                    e => changeSort("ISBN")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, 
#nullable restore
#line 31 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                               columnNames[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "th");
            __builder.AddAttribute(44, "scope", "col");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                    e => changeSort("Status")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, 
#nullable restore
#line 32 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                                 columnNames[3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "th");
            __builder.AddAttribute(49, "scope", "col");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                    e => changeSort("Number of Copies")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, 
#nullable restore
#line 33 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                                           columnNames[4]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n                        <th scope=\"col\"></th>\r\n                        <th scope=\"col\"></th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n                ");
            __builder.OpenElement(54, "tbody");
#nullable restore
#line 41 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                     foreach (var book in bookResult)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "tr");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 44 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                 book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 45 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                 book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 46 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                 book.ISBN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 47 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                 book.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 48 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                 book.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "td");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-secondary");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                                            e => editBook(@book)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "EDIT");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "td");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "class", "btn btn-danger");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                                         e => deleteBook(@book)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "DELETE");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n            ");
            __builder.OpenComponent<LibraryApp.Components.EditBookDisplay>(85);
            __builder.AddAttribute(86, "CloseEventCallback", new System.Action(
#nullable restore
#line 56 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                   search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(87, (__value) => {
#nullable restore
#line 56 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                   editModal = (LibraryApp.Components.EditBookDisplay)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenComponent<LibraryApp.Components.DeleteBookDisplay>(89);
            __builder.AddAttribute(90, "CloseEventCallback", new System.Action(
#nullable restore
#line 57 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                                                       search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(91, (__value) => {
#nullable restore
#line 57 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
                                     deleteModal = (LibraryApp.Components.DeleteBookDisplay)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "Z:\Swango\Desktop\GitHub Repositories\Library-App\Pages\Edit.razor"
 
        List<string> columnNames = new List<string> { "Title", "Author", "ISBN", "Status", "Number of Copies" };
        List<BookCount> bookResult = new List<BookCount>();
        BookSort userSort = new BookSort();

        public EditBookDisplay editModal { get; set; }
        public DeleteBookDisplay deleteModal { get; set; }

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

        void editBook(BookCount book)
        {
            editModal.setBook(book);
            editModal.Show();
        }

        void deleteBook(BookCount book)
        {
            deleteModal.setBook(book);
            deleteModal.Show();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibraryDBContext connection { get; set; }
    }
}
namespace __Blazor.LibraryApp.Pages.Edit
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
