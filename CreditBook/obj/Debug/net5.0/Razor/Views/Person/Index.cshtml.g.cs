#pragma checksum "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa25119b0264f3a74b56e6463d6a7e83b730897b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#line 1 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\_ViewImports.cshtml"
using CreditBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
using CreditBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa25119b0264f3a74b56e6463d6a7e83b730897b", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a04afeef52d419509e2b1b8e810aea5a99dab06", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Person/IndexSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa25119b0264f3a74b56e6463d6a7e83b730897b5388", async() => {
                WriteLiteral("\r\n    <title>Долговая книга</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa25119b0264f3a74b56e6463d6a7e83b730897b5687", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa25119b0264f3a74b56e6463d6a7e83b730897b7656", async() => {
                WriteLiteral("\r\n    <div class=\"search-block\">\r\n        <div class=\"search-string-block\">\r\n            <div class=\"search-block-title\">\r\n                Поиск\r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa25119b0264f3a74b56e6463d6a7e83b730897b8106", async() => {
                    WriteLiteral("\r\n                <input class=\"search-string\" type=\"search\" name=\"name\"");
                    BeginWriteAttribute("value", " value=\"", 500, "\"", 508, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n");
                    WriteLiteral("            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <ul class=\"list\">\r\n");
#nullable restore
#line 20 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
             foreach (Person person in ViewBag.Persons)
            {
                

#line default
#line hidden
#nullable disable
                WriteLiteral("             <li class=\"list-search\"");
                BeginWriteAttribute("id", " id=\"", 902, "\"", 917, 1);
#nullable restore
#line 23 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
WriteAttributeValue("", 907, person.Id, 907, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                 <a");
                BeginWriteAttribute("href", " href=\"", 940, "\"", 971, 2);
                WriteAttributeValue("", 947, "/Person/Index/", 947, 14, true);
#nullable restore
#line 24 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
WriteAttributeValue("", 961, person.Id, 961, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"list-search-link\">\r\n");
#nullable restore
#line 25 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                      if (person.Id != @ViewBag.Person.Id)
                     {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                         <div class=""list-search-button"">
                             <div class=""person-icon"">
                             </div>
                             <div class=""person-txt"">
                                 <div class=""list-search-button-surname"">
                                     ");
#nullable restore
#line 32 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                Write(person.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                 </div>\r\n                                 <div class=\"list-search-button-name\">\r\n                                     ");
#nullable restore
#line 35 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                Write(person.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                             Write(person.Patronymic);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                 </div>\r\n                             </div>\r\n                         </div>\r\n");
#nullable restore
#line 39 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                     }
                     else
                     {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                         <div class=""list-search-button-active"">
                             <div class=""person-icon"">
                             </div>
                             <div class=""person-txt"">
                                 <div class=""list-search-button-surname"">
                                     ");
#nullable restore
#line 47 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                Write(person.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                 </div>\r\n                                 <div class=\"list-search-button-name\">\r\n                                     ");
#nullable restore
#line 50 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                Write(person.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                             Write(person.Patronymic);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                 </div>\r\n                             </div>\r\n                         </div>\r\n");
#nullable restore
#line 54 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                 </a>\r\n             </li>\r\n");
#nullable restore
#line 57 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\r\n        <a href=\"/Person/Add\" class=\"btn search-btn\">Добавить</a>\r\n    </div>\r\n    <div class=\"info-block\">\r\n        <div class=\"main-info\">\r\n");
#nullable restore
#line 63 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
             if (ViewBag.Person.Id != 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"main-info-title\">\r\n                    ");
#nullable restore
#line 66 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
               Write(ViewBag.FIO);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"last-modify-data\">\r\n                    Последнее изменение: ");
#nullable restore
#line 69 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                    Write(ViewBag.Person.LastModifyData);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""main-info-icon"">

                </div>
                <div class=""main-info-table"">
                    <table>
                        <tr>
                            <td style=""font-weight: bold;"">Id: </td>
                            <td>");
#nullable restore
#line 78 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                           Write(ViewBag.Person.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td style=\"font-weight: bold;\">Фамилия: </td>\r\n                            <td>");
#nullable restore
#line 82 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                           Write(ViewBag.Person.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td style=\"font-weight: bold;\">Имя: </td>\r\n                            <td>");
#nullable restore
#line 86 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                           Write(ViewBag.Person.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td style=\"font-weight: bold;\">Отчество: </td>\r\n                            <td>");
#nullable restore
#line 90 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                           Write(ViewBag.Person.Patronymic);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td style=\"font-weight: bold;\">Номер телефона: </td>\r\n                            <td>");
#nullable restore
#line 94 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                           Write(ViewBag.Person.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td style=\"font-weight: bold;\">Остаток долга: </td>\r\n                            <td>");
#nullable restore
#line 98 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                           Write(ViewBag.Person.Credit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td style=\"font-weight: bold;\">Последнее изменение: </td>\r\n                            <td>");
#nullable restore
#line 102 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                           Write(ViewBag.Person.LastModifyData);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                    </table>\r\n                </div>\r\n                <div class=\"main-btn-edit\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4649, "\"", 4689, 2);
                WriteAttributeValue("", 4656, "/Person/Reduce/", 4656, 15, true);
#nullable restore
#line 107 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
WriteAttributeValue("", 4671, ViewBag.Person.Id, 4671, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-edit\">Уменьшить долг</a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4754, "\"", 4796, 2);
                WriteAttributeValue("", 4761, "/Person/Increase/", 4761, 17, true);
#nullable restore
#line 108 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
WriteAttributeValue("", 4778, ViewBag.Person.Id, 4778, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-edit\">Увеличить долг</a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4861, "\"", 4899, 2);
                WriteAttributeValue("", 4868, "/Person/Edit/", 4868, 13, true);
#nullable restore
#line 109 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
WriteAttributeValue("", 4881, ViewBag.Person.Id, 4881, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-edit\">Редактировать</a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4963, "\"", 5003, 2);
                WriteAttributeValue("", 4970, "/Person/Delete/", 4970, 15, true);
#nullable restore
#line 110 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
WriteAttributeValue("", 4985, ViewBag.Person.Id, 4985, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-edit"">Удалить</a>
                </div>
                <table class=""table table-sm table-striped table-bordered"">
                    <caption>Аудит</caption>
                    <thead>
                        <tr>
                            <th class=""operation"">Имя операции</th>
                            <th class=""amount"">Сумма</th>
                            <th class=""data-operation"">Дата операции</th>
                        </tr>
                    </thead>
                </table>
                <div class=""audit"">
                    <table class=""table table-sm table-striped table-bordered"">
");
#nullable restore
#line 124 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                         foreach (var audit in ViewBag.Audits)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td class=\"operation\">");
#nullable restore
#line 127 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                                 Write(audit.Operation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td class=\"amount\">");
#nullable restore
#line 128 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                              Write(audit.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td class=\"data-operation\">");
#nullable restore
#line 129 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                                                      Write(audit.DataOperation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 131 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                </div>\r\n");
#nullable restore
#line 134 "C:\Users\Alexey\Desktop\CreditBook\CreditBook\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
