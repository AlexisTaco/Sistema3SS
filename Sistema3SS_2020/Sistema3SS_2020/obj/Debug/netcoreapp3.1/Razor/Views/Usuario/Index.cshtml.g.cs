#pragma checksum "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ecd1999eb37b90b70e239ffa096746d88d66776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\_ViewImports.cshtml"
using Sistema3SS_2020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\_ViewImports.cshtml"
using Sistema3SS_2020.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ecd1999eb37b90b70e239ffa096746d88d66776", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045da2a7240690618b9a4d49852771807ef3a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sistema3SS_2020.Models.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<p>\r\n    <input class=\"alert-success\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 113, "\"", 171, 3);
            WriteAttributeValue("", 123, "location.href=\'", 123, 15, true);
#nullable restore
#line 5 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 138, Url.Action("Create", "Usuario"), 138, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 170, "\'", 170, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" value=""Agregar nuevo cuenta"" />
</p>
<table class=""table table-striped"">
    <thead class=""thead-light"">
        <tr>
            <th class=""text-center"">
                <a>Nombre</a>
            </th>
            <th class=""text-center"">
                <a>Apellido paterno</a>
            </th>
            <th class=""text-center"">
                <a>Apellido materno</a>
            </th>
            <th class=""text-center"">
                <a>Clave de tipo</a>
            </th>
            <th class=""text-center"">
                <a>Correo electronico</a>
            </th>
            <th class=""text-center"">
                <a>Numero de celular</a>
            </th>
            <th class=""text-center"">
                <a>Direccción</a>
            </th>
            <th class=""text-center"">
                <a>Fecha de nacimiento</a>
            </th>
            <th class=""text-center"">
                ");
#nullable restore
#line 35 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.apellido_paterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.apellido_materno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id_tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.correo_electronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.numero_celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.fecha_nacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input class=\"alert\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2585, "\"", 2657, 3);
            WriteAttributeValue("", 2595, "location.href=\'", 2595, 15, true);
#nullable restore
#line 71 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 2610, Url.Action("Edit", "Usuario",new { item.id }), 2610, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2656, "\'", 2656, 1, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Editar información\" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Usuario\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sistema3SS_2020.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
