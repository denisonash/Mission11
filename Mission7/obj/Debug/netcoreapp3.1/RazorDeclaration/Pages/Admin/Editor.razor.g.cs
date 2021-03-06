// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Mission7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Admin/_Imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/create")]
    public partial class Editor : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Admin/Editor.razor"
       
    [Parameter]
    public long Id { get; set; } = 0;

    public string ThemeColor => Id == 0 ? "success" : "warning";

    public string TitleText => Id == 0 ? "Add" : "Edit";

    public Mission7.Models.Books b { get; set; } = new Mission7.Models.Books();

    public IBookstoreRepository repo => Service;

    protected override void OnParametersSet()
    {
        if (Id != 0) //Existing Book
        {
            b = repo.Books.FirstOrDefault(x => x.BookID == Id);
        }
    }

    public void SaveBook()
    {
        if (Id == 0) // New Book
        {
            repo.CreateBook(b);
        }
        else
        {
            repo.SaveBook(b);
        }

        NavManager.NavigateTo("/admin/books");
    }

    [Inject]
    public NavigationManager NavManager { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
