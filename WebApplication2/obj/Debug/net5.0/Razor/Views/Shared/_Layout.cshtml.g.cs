#pragma checksum "C:\Users\benja\Desktop\WebApplication2\WebApplication2\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20e717229d76ad772a62130ecdf87cdb6b9d8b23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\benja\Desktop\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\benja\Desktop\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e717229d76ad772a62130ecdf87cdb6b9d8b23", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e717229d76ad772a62130ecdf87cdb6b9d8b235241", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\benja\Desktop\WebApplication2\WebApplication2\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - WebApplication2</title>
    <link rel=""stylesheet"" href=""https://npmcdn.com/flickity@2/dist/flickity.css"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.1/css/all.css"" integrity=""sha384-vp86vTRFVJgpjF9jiIGPEEqYqlDwgyBgEF109VFjmqGmIY/Y4HV4d3Gp2irVfcrp"" crossorigin=""anonymous"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Exo:wght@700&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""css/site.css"" />
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e717229d76ad772a62130ecdf87cdb6b9d8b237121", async() => {
                WriteLiteral("\r\n\r\n    <header>\r\n        <!-- Main Top Menu -->\r\n        <nav>\r\n            <div id=\"navbar\">\r\n                <div id=\"logo\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e717229d76ad772a62130ecdf87cdb6b9d8b237542", async() => {
                    WriteLiteral("<div class=\"logo\">MovieMate</div>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
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
                <div id=""links"">
                    <a href=""/movies"">Movies</a>
                    <a href=""/User/Create"">Register</a>

                </div>
                <div id=""login"">
                    <a href=""#"" target=""_blank"">
                        <i class=""fas fa-search""></i>
                    </a>
                    <a href=""#"" target=""_blank"">
                        <img src=""/images/person.jpeg"" />
                    </a>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e717229d76ad772a62130ecdf87cdb6b9d8b239742", async() => {
                    WriteLiteral("Thomas Jackson");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </nav>\r\n    </header>\r\n\r\n    \r\n\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 45 "C:\Users\benja\Desktop\WebApplication2\WebApplication2\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer>\r\n    </footer>\r\n    <script src=\"https://npmcdn.com/flickity@2/dist/flickity.pkgd.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e717229d76ad772a62130ecdf87cdb6b9d8b2311640", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 52 "C:\Users\benja\Desktop\WebApplication2\WebApplication2\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 53 "C:\Users\benja\Desktop\WebApplication2\WebApplication2\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<style>

    ::-webkit-scrollbar-track {
        -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.3);
        border-radius: 10px;
        background-color: #182131;
    }

    ::-webkit-scrollbar {
        width: 12px;
        background-color: #14212C;
    }

    ::-webkit-scrollbar-thumb {
        border-radius: 10px;
        -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,.3);
        background-color: #1C2D3C;
    }

    body {
        width: 100%;
        height: 100%;
        margin: 0;
        background-color: #020916;
    }

    #navbar {
        position: sticky;
        top: 0;
        display: grid;
        min-height: 80px;
        grid-auto-flow: column;
        background-color: #182131;
        grid-gap: 1.5em;
        padding: 0 40px;
        margin-bottom: 20px;
    }

    #logo {
        display: grid;
        justify-content: start;
        align-content: center;
        font-family: 'Exo', sans-serif;
        font-size: 30px;
        font-weight");
                WriteLiteral(@": 500;
        color: white;
    }

    .pb-3 {
        position: relative;
        z-index: 98;
    }

    #links {
        display: grid;
        justify-content: left;
        align-content: center;
        grid-auto-flow: column;
        grid-gap: 4.5em;
        font-family: SF, sans-serif;
    }

    #login {
        display: grid;
        justify-content: right;
        align-content: center;
        grid-auto-flow: column;
        grid-gap: 1.5em;
        font-family: ""SF"", sans-serif;
    }

    .user {
        margin-top: 7px;
        align-content: center;
    }

        .user:after {
            font-family: ""Font Awesome 5 Free"";
            content: ""\f0dd"";
            display: inline-block;
            padding-left: 15px;
            padding-bottom: 5px;
            vertical-align: middle;
            font-weight: 900;
        }

    .fa-search {
        margin-top: 10px;
        font-size: 16px;
    }

    header a {
        text-decoration: none");
                WriteLiteral(@";
        color: rgb(238, 231, 231);
        transition: all 500ms ease;
        -webkit-font-smoothing: antialiased;
    }

    #login img {
        display: grid;
        width: 35px;
        align-content: center;
        height: auto;
        border-radius: 50%;
    }

    header a:hover {
        color: #b3c1d8;
        transform: perspective(1px) scale(1.060);
        -webkit-font-smoothing: antialiased;
    }

    .carousel {
        background: #020916;
    }

    .carousel-cell {
        width: 66%;
        height: 400px;
        margin-right: 10px;
        background: #8C8;
        border-radius: 5px;
        counter-increment: carousel-cell;
    }



    ._1 {
        background: linear-gradient(to left, rgba(98, 116, 148, 0.281) 150px, rgba(83, 96, 170, 0.54) 100%), url('//image.tmdb.org/t/p/w1920_and_h800_multi_faces/wzJRB4MKi3yK138bJyuL9nx47y6.jpg') no-repeat;
        background-size: cover;
        background-position: center;
    }


    ._2 {
       ");
                WriteLiteral(@" background: linear-gradient(to left, rgba(98, 116, 148, 0.281) 150px, rgba(83, 96, 170, 0.54) 100%), url('//image.tmdb.org/t/p/w1920_and_h800_multi_faces/9ijMGlJKqcslswWUzTEwScm82Gs.jpg') no-repeat;
        background-size: cover;
        background-position: center;
    }

    ._3 {
        background: linear-gradient(to left, rgba(98, 116, 148, 0.281) 150px, rgba(83, 96, 170, 0.54) 100%), url('//image.tmdb.org/t/p/w1920_and_h800_multi_faces/eCIvqa3QVCx6H09bdeOS8Al2Sqy.jpg') no-repeat;
        background-size: cover;
        background-position: center;
    }

    ._4 {
        background: linear-gradient(to left, rgba(98, 116, 148, 0.281) 150px, rgba(83, 96, 170, 0.54) 100%), url('//image.tmdb.org/t/p/w1920_and_h800_multi_faces/qAKvUu2FSaDlnqznY4VOp5PmjIF.jpg') no-repeat;
        background-size: cover;
        background-position: center;
    }


    ._5 {
        background: linear-gradient(to left, rgba(98, 116, 148, 0.281) 150px, rgba(83, 96, 170, 0.54) 100%), url('//image.tmdb.org/t");
                WriteLiteral(@"/p/w1920_and_h800_multi_faces/wu1uilmhM4TdluKi2ytfz8gidHf.jpg') no-repeat;
        background-size: cover;
        background-position: center;
    }


    .slider-txt {
        position: absolute;
        top: 125px;
        left: 15%;
    }

    .trending {
        color: white;
        font-size: 18px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        opacity: 70%;
    }

    .titel {
        margin: 1px 0;
        font-size: 38px;
        color: white;
        letter-spacing: 3px;
        font-family: 'SF', sans-serif;
        font-weight: 700;
    }

    .category {
        color: white;
        font-size: 18px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        opacity: 70%;
    }

    .trailer {
        color: white;
        font-size: 18px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        opacity: 70%;
        text-decoration: none;
    }

        .trailer:before {
            font-famil");
                WriteLiteral(@"y: ""Font Awesome 5 Free"";
            content: ""\f144"";
            display: inline-block;
            padding-right: 5px;
            padding-bottom: 5px;
            vertical-align: middle;
            font-weight: 900;
        }


    .section {
        display: grid;
        justify-content: start;
        align-content: left;
        font-family: 'Exo', sans-serif;
        font-size: 22px;
        font-weight: 400;
        color: white;
        padding: 0 80px;
        margin-top: 60px;
    }

    #container {
        display: flex;
        width: 100%;
        overflow-y: hidden;
        overflow-x: scroll;
        -webkit-overflow-scrolling: touch;
    }

    #moviecontainer {
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 7px 20px;
        text-decoration: none;
        white-space: nowrap;
    }


        #moviecontainer a {
            width: 220px;
            margin: 0 10px;
            transition: 40");
                WriteLiteral(@"0ms all;
            border-radius: 10px;
        }

            #moviecontainer a:hover {
                margin-left: 0 40px;
                transform: scale(1.025);
                cursor: pointer;
            }


    footer {
        display: grid;
        margin-top: 200px;
        height: 300px;
        background-color: #182131;
    }




    #largepage {
        top: -20px;
        height: 650px;
        width: 100%;
        position: relative;
        z-index: -1;
        background-position: right -200px top;
        background-size: cover;
        background-repeat: no-repeat;
        
    }

    #custombg {
        height: 650px;
        background-image: linear-gradient(to right, rgba(11.76%, 15.29%, 17.25%, 1.00) 150px, rgba(58, 64, 68, 0.596) 100%);
    }

    .moviegrid {
        padding: 50px 40px;
        display: grid;
        justify-content: center;
        grid-template-columns: [col1] 20% [col2] 40%;
        grid-template-rows: [row1] 10% [row");
                WriteLiteral(@"2] 10% [row3] 25% [row4] 10% [row5] 20%;
        text-align: center;
        color: #FFF;
    }

    .grid-cell-1 {
        grid-column: 2;
        grid-row: 1;
        padding-top: 30px;
        text-align: left;
        padding-left: 100px;
        border-radius: 6px;
        font-size: 38px;
        color: white;
        letter-spacing: 3px;
        font-family: 'SF', sans-serif;
        font-weight: 700;
    }

    .grid-cell-2 {
        grid-column: 2;
        grid-row: 2;
        padding-top: 50px;
        text-align: left;
        padding-left: 100px;
        border-radius: 6px;
        font-size: 15px;
        color: white;
        letter-spacing: 3px;
        font-family: 'SF', sans-serif;
        font-weight: 400;
    }

    .grid-cell-3 {
        grid-column: 2;
        grid-row: 3;
        padding-top: 50px;
        text-align: left;
        padding-left: 100px;
        border-radius: 6px;
        color: white;
        font-size: 18px;
        font-family:");
                WriteLiteral(@" 'SF', sans-serif;
        font-weight: 500;
        opacity: 80%;
    }

    .grid-cell-4 {
        position: relative;
        z-index: 99;
        grid-column: 2;
        grid-row: 4;
        text-align: left;
        padding-left: 100px;
        border-radius: 6px;
        color: white;
        font-size: 20px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        opacity: 90%;
    }

    .grid-cell-6 {
        grid-column: 2;
        grid-row: 5;
        text-align: left;
        padding-left: 100px;
    }

        .grid-cell-6 img {
            border-radius: 14px;
            min-width: 50px;
            width: 50px;
            height: 50px;
            margin-right: 20px;
        }

    .grid-cell-5 {
        grid-column: 1;
        grid-row: 1;
        border-radius: 6px;
    }




        .grid-cell-5 img {
            padding-top: 30px;
            border-radius: 5px;
            width: 350px;
            height: 500px;
        }");
                WriteLiteral(@"

    #castlist {
        display: flex;
        width: 100%;
        overflow-y: hidden;
        overflow-x: scroll;
        -webkit-overflow-scrolling: touch;
    }

    .castcontainer {
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 5px 20px;
    }

    .castinfo {
        background-color: #182131;
        border-radius: 6px;
        color: white;
        font-size: 14px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        opacity: 80%;
        text-align: center;
    }

        .castinfo img {
            border-radius: 5px 5px 0 0;
            max-width: 100%;
            height: auto;
          
        }

    iframe {
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 5px 20px;
    }

    .button {
        background-color: #182131;
        border: none;
        color: white;
        padding: 15px 28px;
        text-align: center;");
                WriteLiteral(@"
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        cursor: pointer;
    }


    a {
        text-decoration: none;
    }

    .commentcontainer {
        display: block;
        margin: 0 auto;
        width: 80%;
        border-radius: 5px;
        background-color: #182131;
        padding: 20px;
        margin-top: 20px;
        font-family: 'Exo', sans-serif;
        font-size: 18px;
        font-weight: 400;
        color: white;
    }

    .commentsection {
        display: grid;
        justify-content: start;
        align-content: left;
        font-family: 'Exo', sans-serif;
        font-size: 18px;
        font-weight: 400;
        color: white;
        padding: 0 80px;
        margin-top: 20px;
        margin-bottom: 20px;
        background-color: #182131;
    }

    .form-control {
     
        width: 80%;
        padding: 12px 20px;
        ");
                WriteLiteral(@"margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 5px;
        box-sizing: border-box;
    }

    .edit {
        background-color: #182131;
        border: none;
        color: white;
        padding: 5px 10px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 14px;
        font-family: 'SF', sans-serif;
        font-weight: 400;
        cursor: pointer;
    }

    .delete {
        background-color: #182131;
        border: none;
        color: white;
        padding: 5px 10px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 14px;
        font-family: 'SF', sans-serif;
        font-weight: 400;
        cursor: pointer;
    }

    .submit {
        background-color: #182131;
        border: none;
        color: white;
        padding: 10px 15px;
        text-align: center;
        text-decoration: no");
                WriteLiteral(@"ne;
        display: block;
        margin: 0 auto;
        font-size: 15px;
        font-family: 'SF', sans-serif;
        font-weight: 400;
        cursor: pointer;
    }



    .tabb {
        display: block!important;
        margin: 0 auto!important;
        
        width: 60%;
    }

    .control-label {
       
        color: white;
        font-size: 16px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        opacity: 90%;
        text-align: left;
        
    }


    .row {
        padding: 20px 150px;
      
    }

    .field-validation-valid {
        color: green;
        font-size: 16px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        opacity: 80%;
       
    }

    .text-danger {
        color: red;
        font-size: 16px;
        font-family: 'SF', sans-serif;
        font-weight: 500;
        opacity: 80%;
    }

</style>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
