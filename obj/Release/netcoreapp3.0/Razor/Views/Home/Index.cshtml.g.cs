#pragma checksum "C:\Users\igor2\igor\atividades do curso\projetohotsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f239e0f22702c5d0aca8cf318587737a92bc705"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\igor2\igor\atividades do curso\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\igor2\igor\atividades do curso\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\igor2\igor\atividades do curso\projetohotsite\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f239e0f22702c5d0aca8cf318587737a92bc705", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastrarInteresse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\igor2\igor\atividades do curso\projetohotsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-5"">
    <div class=""col-6"">
        <div class=""banner-title"">
            <h1>Projeto Iniciativa <strong>Vida saudavel</strong></h1>
            <div class=""banner-title-text"">
                <p>""SOMOS RESPONS??VEIS PELO QUE FAZEMOS, MAS TAMB??M SOMOS RESPONS??VEIS POR AQUILO QUE DEIXAMOS DE
                    FAZER.""

                    ?? verdade que a ci??ncia caminha a passos largos no desenvolvimento de solu????es para aumentar a sa??de
                    e
                    conseguir a cura para enfermidades que, pouco mais de algumas d??cadas atr??s, soavam como amea??as
                    quase
                    invenc??veis. Contudo, ainda n??o saiu das bancadas dos laborat??rios farmac??uticos ou das
                    universidades
                    uma p??lula capaz de prolongar a vida do ser humano com qualidade e prevenir a maior parte das
                    doen??as.
                    Uma das formas mais efetivas de fazer ao menos uma parcela desse aparente m");
            WriteLiteral(@"ilagre ?? mesmo a ado????o
                    de
                    h??bitos saud??veis ou, para quem est?? longe de andar na linha, a mudan??a do estilo de vida.</p>
            </div>
        </div>
    </div>
    <div class=""image-wapper col-6"">
        <img src=""../image/imageHome.png""");
            BeginWriteAttribute("alt", " alt=\"", 1396, "\"", 1402, 0);
            EndWriteAttribute();
            WriteLiteral(" style=width: 500px; height: 300px;>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-3\">\r\n    <div class=\"form-contato col-4\">\r\n        <title class=\"title\">Fique em contato</title>\r\n        <p>Bem vindo <strong>");
#nullable restore
#line 35 "C:\Users\igor2\igor\atividades do curso\projetohotsite\Views\Home\Index.cshtml"
                        Write(Context.Session.GetString("Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>, nos mande mensagem e fique por dentro</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f239e0f22702c5d0aca8cf318587737a92bc7056596", async() => {
                WriteLiteral(@"
            <input required placeholder=""Digite seu nome"" name=""nome"" />
            <input type=""email"" name=""email"" required placeholder=""Digite seu email"" />
            <input type=""text"" name=""mensagem"" placeholder=""Mensagem(opcional)"" />
            <button type=""submit"">
                Enviar
            </button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""social-media col-7"">
        <a href=""#"" class=""text-center p-4"" data-toggle=""modal"" data-target=""#idAgenda"">
            <i class=""ph-calendar-light""></i>
            <p>Agenda de eventos</p>
        </a>
        <a href=""#"" class=""text-center p-4"" data-toggle=""modal"" data-target=""#idVidaSaudavel"">
            <i class=""ph-magic-wand-light""></i>
            <p>Dicas de vida saudavel</p>
        </a>
        <a href=""#"" class=""text-center p-4"" data-toggle=""modal"" data-target=""#idApoidores"">
            <i class=""ph-smiley-wink-light""></i>
            <p>Apoiadores</p>
        </a>
    </div>
</div>
<div class=""modal fade"" id=""idAgenda"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content bg-dark text-white p-3"">
            <div class=""title-modal"">
                <h4 class=""text-center mt-3"">Agenda de eventos</h4>
            </div>
            <div class=""modal-body"">
                <div class=""empresa"">
 ");
            WriteLiteral("                   <img src=\"../image/evento-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3191, "\"", 3197, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""nome-description"">
                    <a href=""https://iess.org.br/evento/x-congresso-juridico-de-saude-suplementar"" target=""_blank"">X Congresso Jur??dico de Sa??de Suplementar</a>
                    <p>Pela primeira vez, o Congresso Jur??dico de Sa??de Suplementar poder?? ser acompanhado ao vivo. A
                        d??cima edi????o do evento, que acontece anualmente, ser?? transmitida para o p??blico externo de
                        forma gratuita pelo Youtube e site do IESS.</p>
                </div>
                <div class=""empresa"">
                    <img src=""../image/evento-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 3860, "\"", 3866, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""nome-description"">
                    <a href=""https://iess.org.br/evento/webinar-iess-esg-na-saude-governanca-corporativa"" target=""_blank"">Webinar IESS - ESG na Sa??de | Governan??a Corporativa</a>
                    <p>O movimento ESG vem ganhando cada vez mais espa??o no mundo. A sigla faz refer??ncia a compromissos
                        e boas pr??ticas Ambiental, Social e de Governan??a Corporativa nas empresas. Demandas importantes
                        que se aplicam a todos os setores, inclusive na Sa??de.
                    <p>
                </div>
                <div class=""empresa"">
                    <i class=""ph-calendar-light""></i>
                </div>
                <div class=""nome-description"">
                    <a href=""https://iess.org.br/evento/xi-premio-iess"" target=""_blank"">XI Pr??mio IESS</a>
                    <p>O movimento ESG vem ganhando cada vez mais espa??o no mundo. A sigla faz refer??ncia a compromissos
");
            WriteLiteral(@"                        e boas pr??ticas Ambiental, Social e de Governan??a Corporativa nas empresas. Demandas importantes
                        que se aplicam a todos os setores, inclusive na Sa??de.
                    <p>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""idApoidores"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content bg-dark text-white p-3 flex"">
            <div class=""title-modal"">
                <h4 class=""text-center mt-3"">Apoiadores</h4>
            </div>
            <div class=""modal-body"">
                <div class=""card-empresa"">
                    <div class=""empresa"">
                        <a href=""https://br.linkedin.com/""><i class=""ph-linkedin-logo-light""></i></a>
                    </div>
                    <div class=""nome-description"">
                        <h1>Linkedin</h1>
                        <p>LinkedIn ?? uma rede social de neg??cios fund");
            WriteLiteral(@"ada em dezembro de 2002 e lan??ada em 5 de maio de
                            2003.</p>
                    </div>
                </div>
                <div class=""card-empresa"">
                    <div class=""empresa"">
                        <a href=""https://www.instagram.com/""><i class=""ph-instagram-logo-light""></i></a>
                    </div>
                    <div class=""nome-description"">
                        <h1>Instagram</h1>
                        <p>
                            O Instagram ?? uma rede social online de compartilhamento de fotos e v??deos entre seus
                            usu??rios, que permite aplicar filtros digitais e compartilh??-los em uma variedade de
                            servi??os de redes sociais.</p>
                    </div>
                </div>
                <div class=""card-empresa"">
                    <div class=""empresa"">
                        <a href=""https://discord.com/""><i class=""ph-discord-logo-light""></i></a>
          ");
            WriteLiteral(@"          </div>
                    <div class=""nome-description"">
                        <h1>Discord</h1>
                        <p>
                            Discord ?? um aplicativo de voz sobre IP propriet??rio e gratuito, projetado inicialmente para
                            comunidades de jogos.</p>
                    </div>
                </div>
                <div class=""card-empresa"">
                    <div class=""empresa"">
                        <a href=""https://twitter.com/""><i class=""ph-twitter-logo-light""></i></a>
                    </div>
                    <div class=""nome-description"">
                        <h1>Twitter</h1>
                        <p>
                            Twitter ?? uma rede social e um servi??o de microblog, que permite aos usu??rios enviar e
                            receber atualiza????es pessoais de outros contatos.</p>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
<div clas");
            WriteLiteral(@"s=""modal fade"" id=""idVidaSaudavel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content bg-dark text-white p-3"">
            <div class=""title-modal"">
                <h4 class=""text-center mt-3"">Dicas de visa saudavel</h4>
            </div>
            <div class=""modal-body"">
                <div class=""milgrau"">
                    <p>1. Dormir bem
                        Assim como se alimentar e praticar exerc??cios s??o essenciais para uma vida saud??vel, dormir n??o
                        ?? diferente.
                    </p>
                    <p> 2. Beber ??gua
                        Aproximadamente dois ter??os do nosso corpo s??o compostos por ??gua. Ela transporta os nutrientes,
                        o oxig??nio e auxilia na produ????o de energia.
                    </p>
                    <p>
                        3. Praticar exerc??cios f??sicos
                        A atividade f??sica regular n??o ajuda somente a manter corpo saud??");
            WriteLiteral(@"vel e bonito esteticamente, mas
                        ?? fundamental na preven????o de v??rias patologias.
                    </p>
                    <p> 4. Dedicar tempo para fazer o que gosta
                        Fazer amigos, sair, rir, namorar, s??o coisas que fazem bem.</p>
                    <p>
                        5. Ter uma dieta equilibrada
                        Grande parte dos nossos problemas de sa??de est??o diretamente ligados ?? nossa m?? alimenta????o.</p>
                </div>
            </div>
        </div>
    </div>
</div>
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
