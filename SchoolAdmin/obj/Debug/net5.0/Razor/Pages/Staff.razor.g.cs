#pragma checksum "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a394ce8753ec330e964c53faeee49a3189356b3"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/staff")]
    public partial class Staff : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align: center;\">Staff Details</h1>");
#nullable restore
#line 6 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
 if (todoItems == null )
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>No Todo Items found.</p>");
#nullable restore
#line 9 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead><tr><th>ID</th>
            <th>Name</th>
            <th>Department</th>
            <th>Work</th>
            <th>Experience</th>
            <th>Shift</th>
            <th>DOB</th>
            <th>ContactNo</th>
            <th>JoiningDate</th></tr></thead>
    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 27 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
         foreach (var item in todoItems)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 30 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 31 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 32 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffDepartment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffWork

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffExperience

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffShift

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffDOB

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffContactNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 38 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
                     item.StaffJoiningDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Staff.razor"
       
    private const string ServiceEndpoint = "https://localhost:5001/api/Staff";
    private TodoItem[] todoItems;

    protected override async Task OnInitializedAsync() => await GetTodoItems();

    private async Task GetTodoItems() =>
        todoItems = await Http.GetFromJsonAsync<TodoItem[]>(ServiceEndpoint);

    
    private class TodoItem
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffDepartment { get; set; }
        public string StaffWork { get; set; }
        public string StaffExperience { get; set; }
        public string StaffShift { get; set; }
        public string StaffDOB { get; set; }
        public string StaffContactNo { get; set; }
        public string StaffJoiningDate { get; set; }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
