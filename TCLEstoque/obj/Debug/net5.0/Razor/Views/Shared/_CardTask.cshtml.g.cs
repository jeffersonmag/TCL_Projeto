#pragma checksum "C:\Users\jefferson.magalhaes\Documents\arquivos importantes\Projetos .NET\TCLEstoque\TCLEstoque\Views\Shared\_CardTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41210493769ab4a31a0163480950bdd7f1549295"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CardTask), @"mvc.1.0.view", @"/Views/Shared/_CardTask.cshtml")]
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
#line 1 "C:\Users\jefferson.magalhaes\Documents\arquivos importantes\Projetos .NET\TCLEstoque\TCLEstoque\Views\_ViewImports.cshtml"
using TCLEstoque;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jefferson.magalhaes\Documents\arquivos importantes\Projetos .NET\TCLEstoque\TCLEstoque\Views\_ViewImports.cshtml"
using TCLEstoque.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jefferson.magalhaes\Documents\arquivos importantes\Projetos .NET\TCLEstoque\TCLEstoque\Views\_ViewImports.cshtml"
using TCLEstoque.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41210493769ab4a31a0163480950bdd7f1549295", @"/Views/Shared/_CardTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b1317512a2161087001b4eb8542828d28f2729", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CardTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<!-- Widgets -->
<div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
    <div class=""info-box bg-cyan hover-expand-effect"">
        <div class=""icon"">
            <i class=""material-icons"">devices_other</i>
        </div>
        <div class=""content"">
            <div class=""text"">");
#nullable restore
#line 14 "C:\Users\jefferson.magalhaes\Documents\arquivos importantes\Projetos .NET\TCLEstoque\TCLEstoque\Views\Shared\_CardTask.cshtml"
                         Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <!--<div class=\"number count-to\" data-from=\"0\" data-show=\"");
#nullable restore
#line 15 "C:\Users\jefferson.magalhaes\Documents\arquivos importantes\Projetos .NET\TCLEstoque\TCLEstoque\Views\Shared\_CardTask.cshtml"
                                                                 Write(Model.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-speed=\"1000\" data-fresh-interval=\"20\"></div>-->\r\n        <span class=\"Count\">R$ ");
#nullable restore
#line 16 "C:\Users\jefferson.magalhaes\Documents\arquivos importantes\Projetos .NET\TCLEstoque\TCLEstoque\Views\Shared\_CardTask.cshtml"
                          Write(Model.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- #END# Widgets -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591