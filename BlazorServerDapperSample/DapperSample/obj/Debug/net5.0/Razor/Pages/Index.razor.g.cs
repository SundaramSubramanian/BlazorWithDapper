#pragma checksum "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a763af5acecba475efb6697b60a6b0f174855872"
// <auto-generated/>
#pragma warning disable 1591
namespace DapperSample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using DapperSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\Projects\BlazorServerDapperSample\DapperSample\_Imports.razor"
using DapperSample.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Sales Entries</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"ProductName\" class=\"control-label\">Product Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "for", "ProductName");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                                                                      sales.ProductName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sales.ProductName = __value, sales.ProductName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Quantity\" class=\"control-label\">Quantity</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "for", "Quantity");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                                                                   sales.Quantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sales.Quantity = __value, sales.Quantity));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
     if (sales.IsUpdate)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-md-4");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                                                                            UpdateSales

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "value", "Update");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-md-4");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "btn btn-primary");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                                                                            CreateSales

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "value", "Save");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
     if (salesEntries == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<h3>Please wait, Loading the data.</h3>");
#nullable restore
#line 46 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "table");
            __builder.AddAttribute(47, "class", "table");
            __builder.AddMarkupContent(48, "<thead><tr><th>Product Name</th>\r\n                    <th>Quantity</th>\r\n                    <th>Options</th></tr></thead>\r\n            ");
            __builder.OpenElement(49, "tbody");
#nullable restore
#line 58 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                 foreach (var sales in salesEntries)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "tr");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 61 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                             sales.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 62 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                             sales.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.OpenElement(57, "td");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "value", "Edit");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                                                                        () => GetSalesById(sales.SalesId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "class", "btn btn-primary");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "value", "Delete");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
                                                                          () => DeleteSales(sales.SalesId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "class", "btn btn-danger");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"



                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "H:\Projects\BlazorServerDapperSample\DapperSample\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
