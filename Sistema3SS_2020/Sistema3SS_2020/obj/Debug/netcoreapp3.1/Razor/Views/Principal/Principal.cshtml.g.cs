#pragma checksum "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Principal\Principal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "931adfe9ff668d0f2a2d3e022adce3781b23f918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Principal_Principal), @"mvc.1.0.view", @"/Views/Principal/Principal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931adfe9ff668d0f2a2d3e022adce3781b23f918", @"/Views/Principal/Principal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045da2a7240690618b9a4d49852771807ef3a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Principal_Principal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<nav class=""navbar navbar-default navbar-static"">
    <div class=""navbar-header"">
		<button class=""navbar-toggle"" type=""button"" data-toggle=""collapse"" data-target="".js-navbar-collapse"">
			<span class=""sr-only"">Toggle navigation</span>
			<span class=""icon-bar""></span>
			<span class=""icon-bar""></span>
			<span class=""icon-bar""></span>
		</button>
		<a class=""navbar-brand"" href=""#"">Large Dropdown Menu</a>
	</div>
	
	
	<div class=""collapse navbar-collapse js-navbar-collapse"">
		<ul class=""nav navbar-nav"">
			<li class=""dropdown dropdown-large"">
				<a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">Dropdown <b class=""caret""></b></a>
				
				<ul class=""dropdown-menu ");
            WriteLiteral("dropdown-menu-large row\">\r\n\t\t\t\t\t<li class=\"col-sm-3\">\r\n\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t<li class=\"dropdown-header\">Usuarios</li>\r\n                            <li><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1175, "\"", 1232, 3);
            WriteAttributeValue("", 1185, "location.href=\'", 1185, 15, true);
#nullable restore
#line 27 "C:\Users\Edgaro\Desktop\proyectoSistema3SS\Repositorio\Sistema3SS\Sistema3SS_2020\Sistema3SS_2020\Views\Principal\Principal.cshtml"
WriteAttributeValue("", 1200, Url.Action("Index", "Usuario"), 1200, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1231, "\'", 1231, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ver lista</a></li>
						</ul>
					</li>
					<li class=""col-sm-3"">
						<ul>
							<li class=""dropdown-header"">Button groups</li>
							<li><a href=""#"">Basic example</a></li>
							<li><a href=""#"">Button toolbar</a></li>
							<li><a href=""#"">Sizing</a></li>
							<li><a href=""#"">Nesting</a></li>
							<li><a href=""#"">Vertical variation</a></li>
							<li class=""divider""></li>
							<li class=""dropdown-header"">Button dropdowns</li>
							<li><a href=""#"">Single button dropdowns</a></li>
						</ul>
					</li>
					<li class=""col-sm-3"">
						<ul>
							<li class=""dropdown-header"">Input groups</li>
							<li><a href=""#"">Basic example</a></li>
							<li><a href=""#"">Sizing</a></li>
							<li><a href=""#"">Checkboxes and radio addons</a></li>
							<li class=""divider""></li>
							<li class=""dropdown-header"">Navs</li>
							<li><a href=""#"">Tabs</a></li>
							<li><a href=""#"">Pills</a></li>
							<li><a href=""#"">Justified</a></li>
						</ul>
					</li>
					<li class");
            WriteLiteral(@"=""col-sm-3"">
						<ul>
							<li class=""dropdown-header"">Navbar</li>
							<li><a href=""#"">Default navbar</a></li>
							<li><a href=""#"">Buttons</a></li>
							<li><a href=""#"">Text</a></li>
							<li><a href=""#"">Non-nav links</a></li>
							<li><a href=""#"">Component alignment</a></li>
							<li><a href=""#"">Fixed to top</a></li>
							<li><a href=""#"">Fixed to bottom</a></li>
							<li><a href=""#"">Static top</a></li>
							<li><a href=""#"">Inverted navbar</a></li>
						</ul>
					</li>
				</ul>
				
			</li>
		</ul>
		
	</div><!-- /.nav-collapse -->
</nav>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591