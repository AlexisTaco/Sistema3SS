#pragma checksum "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f501702232e363160faf5f4c4711cb8d4cc7e2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProyectos_ListaDePresupuestos), @"mvc.1.0.view", @"/Views/AdminProyectos/ListaDePresupuestos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f501702232e363160faf5f4c4711cb8d4cc7e2f", @"/Views/AdminProyectos/ListaDePresupuestos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045da2a7240690618b9a4d49852771807ef3a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminProyectos_ListaDePresupuestos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sistema3SS_2020.Models.Proyecto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/NavBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f501702232e363160faf5f4c4711cb8d4cc7e2f3951", async() => {
                WriteLiteral("\r\n  \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f501702232e363160faf5f4c4711cb8d4cc7e2f4923", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f501702232e363160faf5f4c4711cb8d4cc7e2f5185", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <br />
    <br />
    <br />
    <div class=""container-xl"">
        <div class=""table-responsive"">
            <div class=""table-wrapper"">
                <div class=""table-title"">
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <h2>Administrar <b>Presupuestos</b> de proyecto</h2>
                        </div>
                        <div class=""col-sm-6"">
                            <a class=""btn btn-danger"" data-toggle=""tooltip"" title=""Regresar a lista de proyectos""");
                BeginWriteAttribute("href", " href=\"", 683, "\"", 727, 1);
#nullable restore
#line 20 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
WriteAttributeValue("", 690, Url.Action("Index","AdminProyectos"), 690, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""material-icons"">&#xe408;</i> <span>Atras</span></a>
                        </div>
                    </div>
                </div>
                <table class=""table"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Economico</th>
                            <th scope=""col"">Gasto</th>
                            <th scope=""col"">Concepto</th>
                            <th scope=""col"">$</th>

                        </tr>
                    </thead>
                    <tbody>
                    

");
                WriteLiteral("                        <tr>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th>Total ");
                WriteLiteral(@" </th>
                        </tr>
                    </tbody>
                </table>
                <table class=""table"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Producción</th>
                            <th scope=""col"">Gasto</th>
                            <th scope=""col"">Concepto</th>
                            <th scope=""col"">$</th>

                        </tr>
                    </thead>
                    <tbody>
");
                WriteLiteral("\r\n");
                WriteLiteral("                        <tr>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th></th>\r\n");
                WriteLiteral("                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sistema3SS_2020.Models.Proyecto> Html { get; private set; }
    }
}
#pragma warning restore 1591
