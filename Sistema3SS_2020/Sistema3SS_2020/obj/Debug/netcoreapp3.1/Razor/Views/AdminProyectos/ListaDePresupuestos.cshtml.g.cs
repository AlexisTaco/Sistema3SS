#pragma checksum "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bcd6f065f519a8453da0d562ffb613c9c7121a6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bcd6f065f519a8453da0d562ffb613c9c7121a6", @"/Views/AdminProyectos/ListaDePresupuestos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045da2a7240690618b9a4d49852771807ef3a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminProyectos_ListaDePresupuestos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sistema3SS_2020.Models.Proyecto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcd6f065f519a8453da0d562ffb613c9c7121a64210", async() => {
                WriteLiteral("\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcd6f065f519a8453da0d562ffb613c9c7121a65180", async() => {
                WriteLiteral(@"
    <br />
    <br />
    <br />
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
#nullable restore
#line 22 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                  int count1 = 0; 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                 foreach (var presu in Model.presupuestos)
                {
                    int numeropresu = presu.id;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                     if (presu.TipoPrsupuesto.Nombre.Trim() == "Económico")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                           Write(count1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>Presupuesto de ");
#nullable restore
#line 31 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                          Write(presu.detalle.concepcion.nombres);

#line default
#line hidden
#nullable disable
                WriteLiteral(" en granja <spam>");
#nullable restore
#line 31 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                                                            Write(presu.detalle.granja.nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</spam> </td>\r\n                            <td>El gasto se debe a ");
#nullable restore
#line 32 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                              Write(presu.detalle.concepto_Gastos.ConceptoDes);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                            <td>se describe como: ");
#nullable restore
#line 33 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                             Write(presu.detalle.gastos.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                            <td>$ 0</td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#Taco-");
#nullable restore
#line 36 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                                                                                Write(presu.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" title=\"Agregar proyección\">\r\n                                  <i class=\"material-icons\">&#xE147;</i>\r\n                                </button>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcd6f065f519a8453da0d562ffb613c9c7121a69735", async() => {
                    WriteLiteral("\r\n                                    <div class=\"modal fade\"");
                    BeginWriteAttribute("id", " id=\"", 1644, "\"", 1663, 2);
                    WriteAttributeValue("", 1649, "Taco-", 1649, 5, true);
#nullable restore
#line 40 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
WriteAttributeValue("", 1654, presu.id, 1654, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title""");
                    BeginWriteAttribute("id", " id=\"", 2086, "\"", 2091, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">PREOYECCIONES</h5>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
                                                    <div class=""container"">
                                                        <label>Semanas</label>
                                                        <select");
                    BeginWriteAttribute("name", " name=\"", 2753, "\"", 2782, 2);
                    WriteAttributeValue("", 2760, "SelectSemana-", 2760, 13, true);
#nullable restore
#line 52 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
WriteAttributeValue("", 2773, presu.id, 2773, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("id", " id=\"", 2783, "\"", 2810, 2);
                    WriteAttributeValue("", 2788, "SelectSemana-", 2788, 13, true);
#nullable restore
#line 52 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
WriteAttributeValue("", 2801, presu.id, 2801, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n");
#nullable restore
#line 53 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                              int CountSem = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                             foreach (var semana in Model.semanasTemporada)
                                                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcd6f065f519a8453da0d562ffb613c9c7121a613701", async() => {
                        WriteLiteral("Semana ");
#nullable restore
#line 56 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                                                             Write(CountSem);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" del ");
#nullable restore
#line 56 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                                                                           Write(semana.fecha_inicial.ToShortDateString());

#line default
#line hidden
#nullable disable
                        WriteLiteral(" - ");
#nullable restore
#line 56 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                                                                                                                       Write(semana.fecha_final.ToShortDateString());

#line default
#line hidden
#nullable disable
                        WriteLiteral(" ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                                   WriteLiteral(semana.id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                                CountSem++;
                                                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                                        </select>
                                                        <br />
                                                        <label><spam class=""alert-dark"">$</spam> </label>
                                                        <input");
                    BeginWriteAttribute("id", " id=\"", 3716, "\"", 3749, 2);
                    WriteAttributeValue("", 3721, "CantidadProyeccion-", 3721, 19, true);
#nullable restore
#line 62 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
WriteAttributeValue("", 3740, presu.id, 3740, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" name=""CantidadProyeccion"" class=""text-body"" placeholder=""Agregar cantidad..."" title=""Agregar cantidad estimada"" />
                                                    </div>
                                                    <table class=""table"">
                                                        <thead class=""thead-dark"">
                                                            <tr>
                                                                <th scope=""col"">SEMANA</th>
                                                                <th scope=""col"">Cantidad proyectada</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
");
#nullable restore
#line 72 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                             foreach (var item in Model.presupuestos)
                                                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                                <tr>\r\n                                                                    <th scope=\"row\">1</th>\r\n                                                                </tr>\r\n");
#nullable restore
#line 77 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                                            <tr>
                                                                <th>Total $0 </th>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                    <div class=""modal-footer"">
                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                                                        <button class=""btn btn-primary""");
                    BeginWriteAttribute("value", " value=\"", 5665, "\"", 5682, 1);
#nullable restore
#line 85 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
WriteAttributeValue("", 5673, presu.id, 5673, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" id=""presuID"" name=""presuID"" > Registrar Proyección</button>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 95 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\AdminProyectos\ListaDePresupuestos.cshtml"
                     
                    count1++;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <th>Total $0 </th>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n\r\n");
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
