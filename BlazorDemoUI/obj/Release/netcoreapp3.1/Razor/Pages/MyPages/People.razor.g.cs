#pragma checksum "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4422a138ec01dd2bef1a2923b1eaee800d3082"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoUI.Pages.MyPages
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
#line 3 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
using BlazorDemoUI.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/People")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>People</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Insert New Person</h4>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
                  newPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
                                             InsertPerson

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n    First Name: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "firstName");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
                                                       newPerson.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.FirstName = __value, newPerson.FirstName))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "<br><br>\r\n    Last Name: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "lastName");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
                                                     newPerson.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.LastName = __value, newPerson.LastName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "<br><br>\r\n    Email Address: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "emailAddress");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
                                                             newPerson.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.EmailAddress = __value, newPerson.EmailAddress))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "<br><br>\r\n    ");
                __builder2.AddMarkupContent(29, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button><br><br>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.AddMarkupContent(31, "<h4>Current People</h4>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
 if (people is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.AddMarkupContent(33, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 27 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "class", "table table-striped");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.AddMarkupContent(38, "<thead>\r\n            <tr>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>Email Address</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(39, "tbody");
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 39 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
             foreach (var person in people)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 42 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
                     person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 43 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
                     person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 44 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
                     person.EmailAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 46 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 49 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\MyPages\People.razor"
       
    private List<PersonModel> people;

    private DisplayPersonModel newPerson = new DisplayPersonModel();

    protected override async Task OnInitializedAsync()
    {
        people = await dbPeople.GetPeople();
    }

    private async void InsertPerson()
    {
        PersonModel p = new PersonModel
        {
            FirstName = newPerson.FirstName,
            LastName = newPerson.LastName,
            EmailAddress = newPerson.EmailAddress
        };

        await dbPeople.InsertPerson(p);

        people.Add(p);

        newPerson = new DisplayPersonModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData dbPeople { get; set; }
    }
}
#pragma warning restore 1591
