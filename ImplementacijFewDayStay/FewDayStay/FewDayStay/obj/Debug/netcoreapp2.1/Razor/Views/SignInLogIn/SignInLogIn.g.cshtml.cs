#pragma checksum "C:\Users\nadij\Source\Repos\Grupa1-FewDayStay2\ImplementacijFewDayStay\FewDayStay\FewDayStay\Views\SignInLogIn\SignInLogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f249cfebac2232451da61b778039cf4afb98a637"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SignInLogIn_SignInLogIn), @"mvc.1.0.view", @"/Views/SignInLogIn/SignInLogIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SignInLogIn/SignInLogIn.cshtml", typeof(AspNetCore.Views_SignInLogIn_SignInLogIn))]
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
#line 1 "C:\Users\nadij\Source\Repos\Grupa1-FewDayStay2\ImplementacijFewDayStay\FewDayStay\FewDayStay\Views\_ViewImports.cshtml"
using FewDayStay;

#line default
#line hidden
#line 2 "C:\Users\nadij\Source\Repos\Grupa1-FewDayStay2\ImplementacijFewDayStay\FewDayStay\FewDayStay\Views\_ViewImports.cshtml"
using FewDayStay.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f249cfebac2232451da61b778039cf4afb98a637", @"/Views/SignInLogIn/SignInLogIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343adf00c9232582c2d2b698f3ff74c8ed79bd15", @"/Views/_ViewImports.cshtml")]
    public class Views_SignInLogIn_SignInLogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 251, true);
            WriteLiteral("<!--ovo definise da jedan red biva obradjivan, a dole se slektuej koliko iz tog red aneki elemnt zauzima-->\r\n<div class=\"row\">\r\n    <!--form je kolekcija za vise unosa, editetxtova i tih tipova-->\r\n    <!--po defaultu idu prvo redovi, pa kolone-->\r\n\r\n");
            EndContext();
#line 6 "C:\Users\nadij\Source\Repos\Grupa1-FewDayStay2\ImplementacijFewDayStay\FewDayStay\FewDayStay\Views\SignInLogIn\SignInLogIn.cshtml"
     using (Html.BeginForm("ValidateSignIn", "SignInLogIn", FormMethod.Post, new { @class = "col-xs-4 panel panel-default col-lg-offset-1 prozirnaPozadina dodajMarginuGore" }))
    {

#line default
#line hidden
            BeginContext(436, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(444, 5276, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5518d1e0f65749958bcf867de13c34f8", async() => {
                BeginContext(450, 5263, true);
                WriteLiteral(@"

            <header class=""naslov dodajMarginuGoreIDole"">
                Ovo je forma za SIGN IN
            </header>

            <!--u ""class"" tag se mogu staviti vise klasa-->
            <div class=""row well-sm"">
                <div class=""col-xs-3"">
                    <label for=""unosImena"">Ime </label>
                </div>
                <div class=""col-xs-9"">
                    <input id=""unosImena"" name=""unosImena"" type=""text"" placeholder=""Ime"" required>
                </div>
            </div>

            <div class=""row well-sm"">
                <div class=""col-xs-3"">
                    <label for=""unosPrezimena"">Prezime </label>
                </div>
                <div class=""col-xs-9"">
                    <input id=""unosPrezimena"" name=""unosPrezimena"" type=""text"" placeholder=""Prezime"" required />
                </div>
            </div>

            <div class=""row well-sm"">
                <div class=""col-xs-3"">
                    <label for=""unosEmail");
                WriteLiteral(@"a"">Email </label>
                </div>

                <div class=""col-xs-9"">
                    <input id=""unosEmaila"" name=""unosEmaila"" type=""email"" placeholder=""Email"" required />
                </div>
            </div>

            <div class=""row well-sm"">
                <div class=""col-xs-3"">
                    <label for=""unosSifre"">Sifra </label>
                </div>

                <div class=""col-xs-9"">
                    <!-- ""for"" iz labele dole zanci da kad kliknes na labelu tu, pocinjes pisati u input, preko ""id"" -->
                    <input id=""unosSifre"" name=""unosSifre"" type=""password"" placeholder=""Sifra"" required />
                </div>
            </div>

            <div class=""row well-sm"">
                <div class=""col-xs-3"">
                    <label for=""unosDatumaRodjenja"">Datum rodjenja </label>
                </div>

                <div class=""col-xs-9"">
                    <input id=""unosDatumaRodjenja"" name=""unosDatumaRodjenja"" type=""d");
                WriteLiteral(@"ate"" placeholder=""Datum rodjenja"" required />
                </div>
            </div>

            <!--AKO PRODJE SVU VALIDACIJU IZBACI OVAJ MODAL DA POTVRDI DA JE DOBRO PODATKE UNIO-->
            <div class=""row well-sm"">
                <div class=""col-xs-12"">
                    <!-- ""onclick=IME_FUNKCIJE_KOJA_SE_POZIVA"" koja je implementirana u ""script"" tagu -->
                    <button type=""button"" class=""btn btn-info"" data-toggle=""modal"" data-target=""#myModal"" onclick=""prikaziUnesenePodatke()"">Zavrsi sa SignIn-om</button>
                </div>
            </div>

            <script>
                function prikaziUnesenePodatke() {
                    $(""#pregledImena"").html($(""#unosImena"").val());
                    $(""#pregledPrezimena"").html($(""#unosPrezimena"").val());
                    $(""#pregledEmaila"").html($(""#unosEmaila"").val());
                    $(""#pregledDatumaRodjenja"").html($(""#unosDatumaRodjenja"").val());
                }
            </script>

      ");
                WriteLiteral(@"      <!-- Modal -->
            <div class=""modal fade"" id=""myModal"" role=""dialog"">
                <div class=""modal-dialog"">

                    <!-- Modal content-->
                    <div class=""modal-content"">

                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                            <h4 class=""modal-title"">Podaci koje ste unijeli su</h4>
                        </div>

                        <div class=""modal-body"">

                            <div class=""row well-sm"">
                                <div class=""col-xs-2"">
                                    <label>Ime </label>
                                </div>
                                <div id=""pregledImena"" class=""col-xs-10""></div>
                            </div>

                            <div class=""row well-sm"">
                                <div class=""col-xs-2"">
                                 ");
                WriteLiteral(@"   <label>Prezime </label>
                                </div>
                                <div id=""pregledPrezimena"" class=""col-xs-10""></div>
                            </div>

                            <div class=""row well-sm"">
                                <div class=""col-xs-2"">
                                    <label>Email </label>
                                </div>

                                <div id=""pregledEmaila"" class=""col-xs-10""></div>
                            </div>

                            <div class=""row well-sm"">
                                <div class=""col-xs-2"">
                                    <label>Datum rodjenja </label>
                                </div>

                                <div id=""pregledDatumaRodjenja"" class=""col-xs-10""></div>
                            </div>

                        </div>

                        <div class=""modal-footer"">
                            <button type=""submit"" class=""btn btn-i");
                WriteLiteral("nfo\">Zatvori</button>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(5720, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 138 "C:\Users\nadij\Source\Repos\Grupa1-FewDayStay2\ImplementacijFewDayStay\FewDayStay\FewDayStay\Views\SignInLogIn\SignInLogIn.cshtml"
    }

#line default
#line hidden
            BeginContext(5729, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 140 "C:\Users\nadij\Source\Repos\Grupa1-FewDayStay2\ImplementacijFewDayStay\FewDayStay\FewDayStay\Views\SignInLogIn\SignInLogIn.cshtml"
     using (Html.BeginForm("ValidateLogIn", "SignInLogIn", FormMethod.Post, new { @class = "col-xs-4 panel panel-default col-xs-offset-2 prozirnaPozadina dodajMarginuGore" }))
    {

#line default
#line hidden
            BeginContext(5915, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(5923, 1054, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0880ccefa2545f697cd2e1585f2d18a", async() => {
                BeginContext(5929, 1041, true);
                WriteLiteral(@"

            <header class=""naslov dodajMarginuGoreIDole"">
                Ovo je forma za LOG IN
            </header>

            <div class=""row well-sm"">
                <div class=""col-xs-3"">
                    <label for=""loginIme"">Ime </label>
                </div>
                <div class=""col-xs-9"">
                    <input name=""loginIme"" type=""text"" placeholder=""Ime"" required>
                </div>
            </div>

            <div class=""row well-sm"">
                <div class=""col-xs-3"">
                    <label for=""loginSifra"">Sifra </label>
                </div>
                <div class=""col-xs-9"">
                    <input id=""loginSifra"" name=""loginSifra"" type=""password"" placeholder=""Sifra"" required />
                </div>
            </div>

            <div class=""row well-sm"">
                <div class=""col-xs-12"">
                    <button class=""btn btn-primary pull-left"" type=""submit"">Log in</button>
                </div>
           ");
                WriteLiteral(" </div>\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(6977, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 172 "C:\Users\nadij\Source\Repos\Grupa1-FewDayStay2\ImplementacijFewDayStay\FewDayStay\FewDayStay\Views\SignInLogIn\SignInLogIn.cshtml"
    }

#line default
#line hidden
            BeginContext(6986, 6, true);
            WriteLiteral("</div>");
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
