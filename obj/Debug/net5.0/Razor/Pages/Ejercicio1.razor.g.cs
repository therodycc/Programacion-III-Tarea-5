#pragma checksum "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e0c1faf11498485401cee505c31198973427a9c"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_V.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Tarea_V;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Tarea_V.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio1.razor"
using Tarea_V.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio1")]
    public partial class Ejercicio1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"alert alert-info\" role=\"alert\">\r\nListado de los empleados, nombre, apellido y teléfono. \r\n</div>\r\n<br>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table ");
            __builder.AddMarkupContent(3, "<thead class=\"table-dark\"><tr><td>Nombre</td>\r\n            <td>Apellido</td>\r\n            <td>Telefono</td></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 18 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio1.razor"
         foreach (Employees Emp in GetEmployees())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 21 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio1.razor"
                     Emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 22 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio1.razor"
                      Emp.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 23 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio1.razor"
                      Emp.FaxNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio1.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio1.razor"
      
    List<Employees> GetEmployees() => new northwindContext().Employees.ToList();
  

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591