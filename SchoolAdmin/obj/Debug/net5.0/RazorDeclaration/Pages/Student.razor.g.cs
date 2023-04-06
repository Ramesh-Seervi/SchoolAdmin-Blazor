// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SchoolAdmin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using SchoolAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using SchoolAdmin.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/student")]
    public partial class Student : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Student.razor"
       
    private const string ServiceEndpoint = "https://localhost:5001/api/Student";
    private TodoItem[] todoItems;

    protected override async Task OnInitializedAsync() => await GetTodoItems();

    private async Task GetTodoItems() =>
        todoItems = await Http.GetFromJsonAsync<TodoItem[]>(ServiceEndpoint);



    private class TodoItem
    {
        public int StudentRollno { get; set; }
        public string StudentName { get; set; }
        public string StudentDOB { get; set; }
        public string StudentClass { get; set; }
        public string StudentContactNo { get; set; }
        public string StudentGender { get; set; }
        public string StudentJoiningDate { get; set; }
        public string StudentParentName { get; set; }
        public string StudentParentNumber { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
