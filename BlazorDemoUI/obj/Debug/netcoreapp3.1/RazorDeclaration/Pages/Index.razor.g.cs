#pragma checksum "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6e2f94090dc6b90d5b86c43301996bb25526302"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 3 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\Index.razor"
using BlazorDemoUI.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\Index.razor"
using BlazorDemoUI.PageClass;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\greyg\source\repos\BlazorDemoApp\BlazorDemoUI\Pages\Index.razor"
      
    /*
    string imgSrc = "";
    string Message = "";
    IFileListEntry file = null;
    byte[] _fileBytes = null;
    Refer refer = new Refer();

    public async Task HandleFileSelection(IFileListEntry[] files)
    {
        if (files.Count() > 0)
        {
            file = files.FirstOrDefault();
            using (var ms = new MemoryStream())
            {
                await file.Data.CopyToAsync(ms);
                _fileBytes = ms.ToArray();

                ReferPage referPage = new ReferPage(referService);
                var photo = referPage.GetImage(Convert.ToBase64String(_fileBytes));
                imgSrc = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(photo));
            }
        }
    }

    public void SaveRefer()
    {
        ReferPage referPage = new ReferPage(referService);
        Message = referPage.SaveInformation(_fileBytes, refer);

        refer = new Refer();
        imgSrc = "";
    }

    public void ReadRefer()
    {
        ReferPage referPage = new ReferPage(referService);
        refer = referPage.GetSavedRefer();
        imgSrc = refer.ImageUrl;
        Message = "";
    }
    */

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
