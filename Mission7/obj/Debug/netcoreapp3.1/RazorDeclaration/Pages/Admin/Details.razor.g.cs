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
#line 1 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/Details.razor"
       
    [Inject]
    public IBookstoreRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Mission7.Models.Books b { get; set; }

    protected override void OnParametersSet()
    {
        b = repo.Books.FirstOrDefault(x => x.BookID == Id);
    }

    public string EditUrl => $"/admin/books/edit/{b.BookID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591