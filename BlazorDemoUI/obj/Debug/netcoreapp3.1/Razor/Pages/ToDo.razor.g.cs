#pragma checksum "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8065c59f75d40f8230fbf157902381c1decc077d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ToDo</h3>\r\n");
            __builder.AddContent(1, 
#nullable restore
#line 4 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
 toDoItems.Count(todo => todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, " / ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
                                         toDoItems.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "ul");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 7 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
     foreach (var item in toDoItems)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "li");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "checkbox");
            __builder.AddAttribute(12, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
                                          item.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.IsDone = __value, item.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddContent(15, 
#nullable restore
#line 11 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
             item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 13 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
                          item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item = __value, item));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
                  AddToDo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Add Item");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\ToDo.razor"
       

    private List<ToDoItem> toDoItems = new List<ToDoItem>();
    private string item;

    private void AddToDo()
    {
        toDoItems.Add(new ToDoItem(item, false));
        item = "";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
