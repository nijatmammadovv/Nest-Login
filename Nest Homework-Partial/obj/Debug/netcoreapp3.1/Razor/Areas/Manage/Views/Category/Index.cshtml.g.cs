#pragma checksum "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eedb7aa19e2f4c54e87142e69dee74c1f8de8e81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\_ViewImports.cshtml"
using Nest_Homework_Partial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\_ViewImports.cshtml"
using Nest_Homework_Partial.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\_ViewImports.cshtml"
using Nest_Homework_Partial.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\_ViewImports.cshtml"
using Nest_Homework_Partial.ViewModels.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eedb7aa19e2f4c54e87142e69dee74c1f8de8e81", @"/Areas/Manage/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28ed25220595540f9b0ceca8627d7ee83a4763c5", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "New orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Apple iphone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Ahmed Hassan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Category Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        table img {\r\n            width: 60px\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<header class=\"main-header navbar\">\r\n    <div class=\"col-search\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eedb7aa19e2f4c54e87142e69dee74c1f8de8e818284", async() => {
                WriteLiteral(@"
            <div class=""input-group"">
                <input list=""search_terms"" type=""text"" class=""form-control"" placeholder=""Axtarış termini"" />
                <button class=""btn btn-light bg"" type=""button""><i class=""material-icons md-search""></i></button>
            </div>
            <datalist id=""search_terms"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eedb7aa19e2f4c54e87142e69dee74c1f8de8e818900", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eedb7aa19e2f4c54e87142e69dee74c1f8de8e8110094", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eedb7aa19e2f4c54e87142e69dee74c1f8de8e8111289", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eedb7aa19e2f4c54e87142e69dee74c1f8de8e8112484", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </datalist>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-nav"">
        <button class=""btn btn-icon btn-mobile me-auto"" data-trigger=""#offcanvas_aside""><i class=""material-icons md-apps""></i></button>
        <ul class=""nav"">
            <li class=""nav-item"">
                <a class=""nav-link btn-icon"" href=""#"">
                    <i class=""material-icons md-notifications animation-shake""></i>
                    <span class=""badge rounded-pill"">3</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link btn-icon darkmode"" href=""#""> <i class=""material-icons md-nights_stay""></i> </a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""requestfullscreen nav-link btn-icon""><i class=""material-icons md-cast""></i></a>
            </li>
            <li class=""dropdown nav-item"">
                <a class=""dropdown-toggle"" data-bs-toggle=""dropdown"" href=""#"" id=""dropdownLanguage"" aria-expanded=""false""><i class=""material-icons md-public");
            WriteLiteral(@"""></i></a>
                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""dropdownLanguage"">
                    <a class=""dropdown-item text-brand"" href=""#""><img src=""assets/imgs/theme/flag-us.png"" alt=""English"" />English</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-fr.png"" alt=""Français"" />Français</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-jp.png"" alt=""Français"" />日本語</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-cn.png"" alt=""Français"" />中国人</a>
                </div>
            </li>
            <li class=""dropdown nav-item"">
                <a class=""dropdown-toggle"" data-bs-toggle=""dropdown"" href=""#"" id=""dropdownAccount"" aria-expanded=""false""> <img class=""img-xs rounded-circle"" src=""assets/imgs/people/avatar-2.png"" alt=""User"" /></a>
                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""dropdownAccount"">
             ");
            WriteLiteral(@"       <a class=""dropdown-item"" href=""#""><i class=""material-icons md-perm_identity""></i>Profili Düzənlə</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-settings""></i>Hesab Parametrləri</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-account_balance_wallet""></i>Pul kisəsi</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-receipt""></i>Fakturalandırma</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-help_outline""></i>Yardım mərkəzi</a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item text-danger"" href=""#""><i class=""material-icons md-exit_to_app""></i>Çıxış</a>
                </div>
            </li>
        </ul>
    </div>
</header>
<section class=""content-main"">
    <div class=""content-header"">
        <div>
            <h2 class=""content-title card-title"">Kateqoriya</h2>
            <p>Kateqoriya");
            WriteLiteral(@" əlavə edin, redaktə edin və ya silin</p>
        </div>
        <div>
            <input type=""text"" placeholder=""Kateqoriyaları axtarın"" class=""form-control bg-white"" />
        </div>
    </div>
    <div class=""card"">
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-3"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eedb7aa19e2f4c54e87142e69dee74c1f8de8e8118437", async() => {
                WriteLiteral(@"
                        <div class=""mb-4"">
                            <label for=""Name"" class=""form-label"">Ad</label>
                            <input name=""Name"" id=""Name"" type=""text"" placeholder=""Bura yazın"" class=""form-control"" />
                        </div>
                        <div class=""mb-4"">
                            <label for=""Logo"" class=""form-label"">Loqo</label>
                            <input type=""text"" name=""Logo"" placeholder=""Bura yazın"" class=""form-control"" id=""Logo"" />
                        </div>
                        <div class=""d-grid"">
                            <button class=""btn btn-primary"">Kateqoriya yaradın</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-md-9"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover"">
                            <thead>
                                <tr>
                                    <th class=""text-center"">
                                        <div class=""form-check"">
                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5533, "\"", 5541, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        </div>
                                    </th>
                                    <th>ID</th>
                                    <th>Loqo</th>
                                    <th>Kateqoriyanın adı</th>
                                    <th>Məhsul sayı</th>
                                    <th class=""text-end"">Fəaliyyət</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 113 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr ");
#nullable restore
#line 115 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
                                Write(item.IsDeleted == true ? "class=bg-danger" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    <td class=\"text-center\">\r\n                                        <div class=\"form-check\">\r\n                                            <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 6452, "\"", 6460, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </div>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 121 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eedb7aa19e2f4c54e87142e69dee74c1f8de8e8123475", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6662, "~/assets/imgs/shop/", 6662, 19, true);
#nullable restore
#line 122 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
AddHtmlAttributeValue("", 6681, item.Logo, 6681, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td><b>");
#nullable restore
#line 123 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                    <td>");
#nullable restore
#line 124 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
                                   Write(item.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td class=""text-end"">
                                        <div class=""dropdown"">
                                            <a href=""#"" data-bs-toggle=""dropdown"" class=""btn btn-light rounded btn-sm font-sm""> <i class=""material-icons md-more_horiz""></i> </a>
                                            <div class=""dropdown-menu"">
                                                <a class=""dropdown-item"" href=""#"">Detallara baxın</a>
                                                <a class=""dropdown-item"" href=""#"">Məlumatı redaktə edin</a>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eedb7aa19e2f4c54e87142e69dee74c1f8de8e8126406", async() => {
                WriteLiteral("Silin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
                                                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <!-- dropdown //end -->
                                    </td>
                                    </tr@(item.IsDeleted==true?""Silinib"":""Silinməyib"")>
");
#nullable restore
#line 137 "C:\Users\hp\OneDrive\İş masası\Nest-Homework\Nest Homework-Partial\Areas\Manage\Views\Category\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
            <!-- .col// -->
        </div>
        <!-- .row // -->
    </div>
    <!-- card body .// -->
</div>
<!-- card .// -->
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
