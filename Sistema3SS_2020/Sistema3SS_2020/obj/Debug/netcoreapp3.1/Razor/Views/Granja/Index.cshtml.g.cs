#pragma checksum "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Granja\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dca1c168a87a68641541f216e775067a941d354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Granja_Index), @"mvc.1.0.view", @"/Views/Granja/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dca1c168a87a68641541f216e775067a941d354", @"/Views/Granja/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045da2a7240690618b9a4d49852771807ef3a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Granja_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sistema3SS_2020.Models.Granja>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dca1c168a87a68641541f216e775067a941d3543700", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Bootstrap CRUD Data Table for Database with Modal Form</title>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto|Varela+Round"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    <script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
    <style>
        body {
            color: #566787;
            background: #f5f5f5;
            font-family: 'Varela Round', sans-serif;
 ");
                WriteLiteral(@"           font-size: 13px;
        }

        .table-responsive {
            margin: 30px 0;
        }

        .table-wrapper {
            background: #fff;
            padding: 20px 25px;
            border-radius: 3px;
            min-width: 1000px;
            box-shadow: 0 1px 1px rgba(0,0,0,.05);
        }

        .table-title {
            padding-bottom: 15px;
            background: #435d7d;
            color: #fff;
            padding: 16px 30px;
            min-width: 100%;
            margin: -20px -25px 10px;
            border-radius: 3px 3px 0 0;
        }

            .table-title h2 {
                margin: 5px 0 0;
                font-size: 24px;
            }

            .table-title .btn-group {
                float: right;
            }

            .table-title .btn {
                color: #fff;
                float: right;
                font-size: 13px;
                border: none;
                min-width: 50px;
                bord");
                WriteLiteral(@"er-radius: 2px;
                border: none;
                outline: none !important;
                margin-left: 10px;
            }

                .table-title .btn i {
                    float: left;
                    font-size: 21px;
                    margin-right: 5px;
                }

                .table-title .btn span {
                    float: left;
                    margin-top: 2px;
                }

        table.table tr th, table.table tr td {
            border-color: #e9e9e9;
            padding: 12px 15px;
            vertical-align: middle;
        }

            table.table tr th:first-child {
                width: 60px;
            }

            table.table tr th:last-child {
                width: 100px;
            }

        table.table-striped tbody tr:nth-of-type(odd) {
            background-color: #fcfcfc;
        }

        table.table-striped.table-hover tbody tr:hover {
            background: #f5f5f5;
        }

       ");
                WriteLiteral(@" table.table th i {
            font-size: 13px;
            margin: 0 5px;
            cursor: pointer;
        }

        table.table td:last-child i {
            opacity: 0.9;
            font-size: 22px;
            margin: 0 5px;
        }

        table.table td a {
            font-weight: bold;
            color: #566787;
            display: inline-block;
            text-decoration: none;
            outline: none !important;
        }

            table.table td a:hover {
                color: #2196F3;
            }

            table.table td a.edit {
                color: #FFC107;
            }

            table.table td a.delete {
                color: #F44336;
            }

        table.table td i {
            font-size: 19px;
        }

        table.table .avatar {
            border-radius: 50%;
            vertical-align: middle;
            margin-right: 10px;
        }

        .pagination {
            float: right;
            margin: ");
                WriteLiteral(@"0 0 5px;
        }

            .pagination li a {
                border: none;
                font-size: 13px;
                min-width: 30px;
                min-height: 30px;
                color: #999;
                margin: 0 2px;
                line-height: 30px;
                border-radius: 2px !important;
                text-align: center;
                padding: 0 6px;
            }

                .pagination li a:hover {
                    color: #666;
                }

            .pagination li.active a, .pagination li.active a.page-link {
                background: #03A9F4;
            }

                .pagination li.active a:hover {
                    background: #0397d6;
                }

            .pagination li.disabled i {
                color: #ccc;
            }

            .pagination li i {
                font-size: 16px;
                padding-top: 6px
            }

        .hint-text {
            float: left;
           ");
                WriteLiteral(@" margin-top: 10px;
            font-size: 13px;
        }
        /* Custom checkbox */
        .custom-checkbox {
            position: relative;
        }

            .custom-checkbox input[type=""checkbox""] {
                opacity: 0;
                position: absolute;
                margin: 5px 0 0 3px;
                z-index: 9;
            }

            .custom-checkbox label:before {
                width: 18px;
                height: 18px;
            }

            .custom-checkbox label:before {
                content: '';
                margin-right: 10px;
                display: inline-block;
                vertical-align: text-top;
                background: white;
                border: 1px solid #bbb;
                border-radius: 2px;
                box-sizing: border-box;
                z-index: 2;
            }

            .custom-checkbox input[type=""checkbox""]:checked + label:after {
                content: '';
                position: a");
                WriteLiteral(@"bsolute;
                left: 6px;
                top: 3px;
                width: 6px;
                height: 11px;
                border: solid #000;
                border-width: 0 3px 3px 0;
                transform: inherit;
                z-index: 3;
                transform: rotateZ(45deg);
            }

            .custom-checkbox input[type=""checkbox""]:checked + label:before {
                border-color: #03A9F4;
                background: #03A9F4;
            }

            .custom-checkbox input[type=""checkbox""]:checked + label:after {
                border-color: #fff;
            }

            .custom-checkbox input[type=""checkbox""]:disabled + label:before {
                color: #b8b8b8;
                cursor: auto;
                box-shadow: none;
                background: #ddd;
            }
        /* Modal styles */
        .modal .modal-dialog {
            max-width: 400px;
        }

        .modal .modal-header, .modal .modal-body, .moda");
                WriteLiteral(@"l .modal-footer {
            padding: 20px 30px;
        }

        .modal .modal-content {
            border-radius: 3px;
            font-size: 14px;
        }

        .modal .modal-footer {
            background: #ecf0f1;
            border-radius: 0 0 3px 3px;
        }

        .modal .modal-title {
            display: inline-block;
        }

        .modal .form-control {
            border-radius: 2px;
            box-shadow: none;
            border-color: #dddddd;
        }

        .modal textarea.form-control {
            resize: vertical;
        }

        .modal .btn {
            border-radius: 2px;
            min-width: 100px;
        }

        .modal form label {
            font-weight: normal;
        }
    </style>
    <script>
        $(document).ready(function () {
            // Activate tooltip
            $('[data-toggle=""tooltip""]').tooltip();

            // Select/Deselect checkboxes
            var checkbox = $('table tbody input");
                WriteLiteral(@"[type=""checkbox""]');
            $(""#selectAll"").click(function () {
                if (this.checked) {
                    checkbox.each(function () {
                        this.checked = true;
                    });
                } else {
                    checkbox.each(function () {
                        this.checked = false;
                    });
                }
            });
            checkbox.click(function () {
                if (!this.checked) {
                    $(""#selectAll"").prop(""checked"", false);
                }
            });
        });
    </script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dca1c168a87a68641541f216e775067a941d35413807", async() => {
                WriteLiteral(@"
    <div class=""container-xl"">
        <div class=""table-responsive"">
            <div class=""table-wrapper"">
                <div class=""table-title"">
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <h2>Administridar <b>Granjas</b></h2>
                        </div>
                        <div class=""col-sm-6"">
                            <a href=""#addEmployeeModal"" class=""btn btn-success"" data-toggle=""modal""><i class=""material-icons"">&#xE147;</i> <span>Agregar nueva granja</span></a>
                            <a href=""#deleteEmployeeModal"" class=""btn btn-danger"" data-toggle=""modal""><i class=""material-icons"">&#xE15C;</i> <span>Eliminar</span></a>
                        </div>
                    </div>
                </div>
                <table class=""table table-striped table-hover"">
                    <thead>
                        <tr>
                            <th>
                                <span class=");
                WriteLiteral(@"""custom-checkbox"">
                                    <input type=""checkbox"" id=""selectAll"">
                                    <label for=""selectAll""></label>
                                </span>
                            </th>
                            <th>Nombre</th>
                            <th>Ubicación</th>
                            <th>Nombre del responsable</th>
                            <th>Cantidad de estanques</th>
                            <th>Perimetro (en hectareas) <span class=""alert-info"">m²</span></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 343 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Granja\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <tr>
                            <td>
                                <span class=""custom-checkbox"">
                                    <input type=""checkbox"" id=""checkbox2"" name=""options[]"" value=""1"">
                                    <label for=""checkbox2""></label>
                                </span>
                            </td>
                            <td class=""text-center"">
                                ");
#nullable restore
#line 353 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Granja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
#nullable restore
#line 356 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Granja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ubicacion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
#nullable restore
#line 359 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Granja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.nombre_completo_responsable));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
#nullable restore
#line 362 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Granja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.numero_estanques));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
#nullable restore
#line 365 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Granja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.perimetro_hetareas));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                            <td>
                                <a href=""#editEmployeeModal"" class=""edit"" data-toggle=""modal""><i class=""material-icons"" data-toggle=""tooltip"" title=""Edit"">&#xE254;</i></a>
                                <a href=""#deleteEmployeeModal"" class=""delete"" data-toggle=""modal""><i class=""material-icons"" data-toggle=""tooltip"" title=""Delete"">&#xE872;</i></a>
                            </td>
                        </tr>
");
#nullable restore
#line 372 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Granja\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                </table>
                <div class=""clearfix"">
                    <div class=""hint-text"">Mostrando <b>1</b> de <b>1</b> en total</div>
                    <ul class=""pagination"">
                        <li class=""page-item disabled""><a href=""#"">Seguiente</a></li>
                        <li class=""page-item active""><a href=""#"" class=""page-link"">1</a></li>
                        <li class=""page-item""><a href=""#"" class=""page-link"">Anterior</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!-- Edit Modal HTML -->
    <div id=""addEmployeeModal"" class=""modal fade"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dca1c168a87a68641541f216e775067a941d35420367", async() => {
                    WriteLiteral(@"
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Agregar nueva granja</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <label>Name</label>
                            <input type=""text"" class=""form-control"" required>
                        </div>
                        <div class=""form-group"">
                            <label>Email</label>
                            <input type=""email"" class=""form-control"" required>
                        </div>
                        <div class=""form-group"">
                            <label>Address</label>
                            <textarea class=""form-control"" required></textarea>
                        </div>
                        <div class=""form-group"">
                    ");
                    WriteLiteral(@"        <label>Phone</label>
                            <input type=""text"" class=""form-control"" required>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                        <input type=""submit"" class=""btn btn-success"" value=""Add"">
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Edit Modal HTML -->\r\n    <div id=\"editEmployeeModal\" class=\"modal fade\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dca1c168a87a68641541f216e775067a941d35423473", async() => {
                    WriteLiteral(@"
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Edit Employee</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <label>Name</label>
                            <input type=""text"" class=""form-control"" required>
                        </div>
                        <div class=""form-group"">
                            <label>Email</label>
                            <input type=""email"" class=""form-control"" required>
                        </div>
                        <div class=""form-group"">
                            <label>Address</label>
                            <textarea class=""form-control"" required></textarea>
                        </div>
                        <div class=""form-group"">
                           ");
                    WriteLiteral(@" <label>Phone</label>
                            <input type=""text"" class=""form-control"" required>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                        <input type=""submit"" class=""btn btn-info"" value=""Save"">
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Delete Modal HTML -->\r\n    <div id=\"deleteEmployeeModal\" class=\"modal fade\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dca1c168a87a68641541f216e775067a941d35426574", async() => {
                    WriteLiteral(@"
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Delete Employee</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <p>Are you sure you want to delete these Records?</p>
                        <p class=""text-warning""><small>This action cannot be undone.</small></p>
                    </div>
                    <div class=""modal-footer"">
                        <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                        <input type=""submit"" class=""btn btn-danger"" value=""Delete"">
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sistema3SS_2020.Models.Granja>> Html { get; private set; }
    }
}
#pragma warning restore 1591
