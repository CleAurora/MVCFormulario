#pragma checksum "C:\Users\34132336883\Documents\senai\Projetos\MVCFormulario\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e543d914e2f2ed578db51a26e80f3195d159e707"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e543d914e2f2ed578db51a26e80f3195d159e707", @"/Views/Usuario/Index.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\34132336883\Documents\senai\Projetos\MVCFormulario\Views\Usuario\Index.cshtml"
  
    Layout = "MasterPage";
    ViewBag.Title = "Cadastro de Usuários";



#line default
#line hidden
            BeginContext(84, 906, true);
            WriteLiteral(@"<div class = ""container"">
    <form action=""/Usuario/Cadastrar"" method = ""POST"">
        <h1>Cadastre-se</h1>
        <div class=""form-group"">
            <label for=""nome"">Nome:</label>
            <input type = ""text"" name = ""nome"" class=""form-control"">
            <label for = ""email"">Email</label>
            <input type=""text"" name = ""email"" class=""form-control"">
            <label for=""senha""> Senha: </label>
            <input type=""password"" name=""senha"" class=""form-control"">
            <label for = ""dataNascimento"">Data de Nascimento</label>
            <input type=""date"" name = ""dataNascimento"" class=""form-control"">
            <br>
            <input type=""submit"" value= ""Cadastrar"" class=""btn btn-secondary btn-lg btn-block"">
        </div>
    </form>
</div><!--fim do container aqui eu copiei as ""class"" do bootStrap e ele já encaminhou a ""maquiagem"" necessária-->
");
            EndContext();
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
