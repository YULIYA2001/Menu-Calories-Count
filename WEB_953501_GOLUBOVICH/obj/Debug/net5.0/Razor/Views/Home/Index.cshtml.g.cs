#pragma checksum "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b6e654543c2588d765c348257228afe3e65db65"
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
#line 1 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\_ViewImports.cshtml"
using WEB_953501_GOLUBOVICH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\_ViewImports.cshtml"
using WEB_953501_GOLUBOVICH.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\_ViewImports.cshtml"
using WEB_953501_GOLUBOVICH.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6e654543c2588d765c348257228afe3e65db65", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9defa1568506a9b4ad395336f441cba65fbb4047", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Главная страница";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--Содержимое страницы -->\n<main class=\"container\">\n\n    <h2>");
#nullable restore
#line 8 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\Home\Index.cshtml"
   Write(ViewData["Text"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n    <h3>Список</h3>\n    <ol type=\"A\">\n");
#nullable restore
#line 12 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\Home\Index.cshtml"
         for (int i = 1; i < 5; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>элемент ");
#nullable restore
#line 14 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\Home\Index.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" списка</li>\n");
#nullable restore
#line 15 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\n    <hr />\n\n    <h3>Форма</h3>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b6e654543c2588d765c348257228afe3e65db655077", async() => {
                WriteLiteral("\n        <!-- Чекбоксы -->\n\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b6e654543c2588d765c348257228afe3e65db655370", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 24 "E:\WEB_953501_GOLUBOVICH\WEB_953501_GOLUBOVICH\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Lst"] as SelectList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <div class=""form-group row"">
            <legend class=""col-form-label col-sm-2 pt-0""></legend>
            <div class=""col-sm-10"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" name=""gridCheck1"" id=""gridCheck1"">
                    <label class=""form-check-label"" for=""gridCheck1"">
                        Чек-бокс 1
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" name=""gridCheck2"" id=""gridCheck2"">
                    <label class=""form-check-label"" for=""gridCheck2"">
                        Чек-бокс 2
                    </label>
                </div>
            </div>
        </div>

        <!-- Радиокнопки -->
        <fieldset class=""form-group"">
            <div class=""row"">
                <legend class=""col-form-label col-sm-2 pt-0""></legend>
                <div class=""col-sm-10"">
                    <div class=""form-");
                WriteLiteral(@"check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios1"" value=""option1"" checked>
                        <label class=""form-check-label"" for=""gridRadios1"">
                            Радио-1
                        </label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios2"" value=""option2"">
                        <label class=""form-check-label"" for=""gridRadios2"">
                            Радио-2
                        </label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios3"" value=""option3"">
                        <label class=""form-check-label"" for=""gridRadios3"">
                            Радио-3
                        </label>
               ");
                WriteLiteral(@"     </div>
                </div>
            </div>
        </fieldset>

        <!-- Поля ввода -->
        <div class=""form-group row"">
            <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Логин</label>
            <div class=""col-sm-10"">
                <!--<input type=""email"" class=""form-control"" name=""login"" id=""inputEmail3"" placeholder=""Введите имя"">-->
                <input type=""text"" class=""form-control"" name=""login"" id=""inputText3"" placeholder=""Введите имя"">
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Пароль</label>
            <div class=""col-sm-10"">
                <input type=""password"" class=""form-control"" name=""password"" id=""inputPassword3"" placeholder=""Введите пароль"">
            </div>
        </div>

        <!-- Кнопка -->
        <div class=""form-group row"">
            <div class=""col-sm-10"">
                <button type=""submit"" class=""btn btn-primary"">Отправить</button>");
                WriteLiteral("\n            </div>\n        </div>\n    ");
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
            WriteLiteral("\n\n</main>");
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
