#pragma checksum "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d31ae7703c295c2d42fb65b002de70579ca9e89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultas_CadastroConsultaP1), @"mvc.1.0.view", @"/Views/Consultas/CadastroConsultaP1.cshtml")]
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
#line 1 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\_ViewImports.cshtml"
using Projeto_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\_ViewImports.cshtml"
using Projeto_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d31ae7703c295c2d42fb65b002de70579ca9e89", @"/Views/Consultas/CadastroConsultaP1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68314cadfeee5b5ae2c9a7d5cb0007bfc8bf03f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultas_CadastroConsultaP1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto_CRUD.Models.ViewBagModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<section>\r\n\r\n    <h1>Marcação de consulta</h1>\r\n\r\n    <br />\r\n    <br />\r\n\r\n");
#nullable restore
#line 20 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
     using (Html.BeginForm("CadastroConsultaP1", "Consultas", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <thead>\r\n                <tr>\r\n                    <td> ");
#nullable restore
#line 26 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
                    Write(Html.Label("", "Localize-se por nome ou CPF", new { @class = "form-label", @style = "font-weight: bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
                   Write(Html.EditorFor(model => model.msg, new { htmlAttributes = new { @style = "width:270px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 33 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
                   Write(Html.ValidationMessageFor(model => model.msg, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td> <br /> ");
#nullable restore
#line 37 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
                           Write(Html.Label("", "Selecione o tipo do exame", new { @class = "form-label", @style = "font-weight: bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 41 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
                          
                            List<SelectListItem>
                                listTipos = new List<SelectListItem>
                                    ();
                            foreach (var t in ViewBag.listaTipoExames)
                            {
                                listTipos.Add(new SelectListItem
                                {
                                    Text = t.tipo,
                                    Value = t.id.ToString()
                                });
                            }

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
                       Write(Html.DropDownListFor(model => model.msg2, listTipos));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td> <br /> <button type=\"submit\" class=\"btn btn-success btn-lg mb-1\">Enviar</button> </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 64 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Consultas\CadastroConsultaP1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto_CRUD.Models.ViewBagModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
