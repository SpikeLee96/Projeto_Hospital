#pragma checksum "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08db093b5c4f7a050c5a94eee4c71266d9f756d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacientes_TabelaPacientes), @"mvc.1.0.razor-page", @"/Views/Pacientes/TabelaPacientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08db093b5c4f7a050c5a94eee4c71266d9f756d9", @"/Views/Pacientes/TabelaPacientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68314cadfeee5b5ae2c9a7d5cb0007bfc8bf03f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacientes_TabelaPacientes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
  
    var listaPacientes = ViewBag.listaPacientes;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div align=""left"">
</div>
<h3> Lista de Pacientes </h3>

<table class=""table table-striped"">
    <thead>
        <tr>
            <td class=""subtitulo"">&nbsp;&nbsp;ID&nbsp;&nbsp;</td>
            <td class=""subtitulo"">&nbsp;&nbsp;Nome&nbsp;&nbsp;</td>
            <td class=""subtitulo"">&nbsp;&nbsp;CPF&nbsp;&nbsp;</td>
            <td class=""subtitulo"">&nbsp;&nbsp;Data de nascimento&nbsp;&nbsp;</td>
            <td class=""subtitulo"">&nbsp;&nbsp;Sexo&nbsp;&nbsp;</td>
            <td class=""subtitulo"">&nbsp;&nbsp;Telefone&nbsp;&nbsp;</td>
            <td class=""subtitulo"">&nbsp;&nbsp;Email&nbsp;&nbsp;</td>
            <td>&nbsp;&nbsp;Editar&nbsp;&nbsp;</td>
            <td>&nbsp;&nbsp;Deletar&nbsp;&nbsp;</td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
         if(listaPacientes != null) { 
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
             foreach (var p in listaPacientes)
            {
            


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>&nbsp;&nbsp;");
#nullable restore
#line 33 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                       Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;</td>\r\n            <td>&nbsp;&nbsp;");
#nullable restore
#line 34 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                       Write(p.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;</td>\r\n            <td>&nbsp;&nbsp;");
#nullable restore
#line 35 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                       Write(p.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;</td>\r\n            <td>&nbsp;&nbsp;");
#nullable restore
#line 36 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                       Write(p.data);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;</td>\r\n            <td>&nbsp;&nbsp;");
#nullable restore
#line 37 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                       Write(p.sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;</td>\r\n            <td>&nbsp;&nbsp;");
#nullable restore
#line 38 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                       Write(p.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;</td>\r\n            <td>&nbsp;&nbsp;");
#nullable restore
#line 39 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                       Write(p.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;</td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
           Write(Html.ActionLink("Atualizar", "UpdatePaciente", "Pacientes", new { id = p.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td> \r\n            <td>\r\n");
#nullable restore
#line 44 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                 using (Html.BeginForm("DeletePaciente", "Pacientes", FormMethod.Post, new { id = p.id }))
                {
                    long id = p.id;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
               Write(Html.Hidden("id", id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Deletar\" onclick=\"return confirm(\'Você confirma a exclusão deste paciente?\');\"><i class=\"fa fa-trash fa-lg\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 49 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Sistema de Informação\Source\Projetos Inacabados\ASP .NET MVC, Projeto CRUD\Projeto CRUD\Views\Pacientes\TabelaPacientes.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto_CRUD.Models.Paciente> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projeto_CRUD.Models.Paciente> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projeto_CRUD.Models.Paciente>)PageContext?.ViewData;
        public Projeto_CRUD.Models.Paciente Model => ViewData.Model;
    }
}
#pragma warning restore 1591
