#pragma checksum "D:\POMS\PomsClicker\PC\Views\SinglePlayer\SinglePlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ad84c047c19c1d5805fff7f61511e30f83d351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SinglePlayer_SinglePlayer), @"mvc.1.0.razor-page", @"/Views/SinglePlayer/SinglePlayer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/SinglePlayer/SinglePlayer.cshtml", typeof(AspNetCore.Views_SinglePlayer_SinglePlayer), null)]
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
#line 1 "D:\POMS\PomsClicker\PC\Views\_ViewImports.cshtml"
using PC;

#line default
#line hidden
#line 2 "D:\POMS\PomsClicker\PC\Views\_ViewImports.cshtml"
using PC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ad84c047c19c1d5805fff7f61511e30f83d351", @"/Views/SinglePlayer/SinglePlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a7a157c7792c08be290accaafb5b17d24c4cbc4", @"/Views/_ViewImports.cshtml")]
    public class Views_SinglePlayer_SinglePlayer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\POMS\PomsClicker\PC\Views\SinglePlayer\SinglePlayer.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(80, 2640, true);
            WriteLiteral(@"
<div style=""overflow: hidden; display: flex; flex-direction: column; position: relative; height: 100%;"">
    <header class=""menu"">
        <button onclick=""openNav()"" style="" z-index:800; background-color: transparent;  border-color: transparent; margin-left:2%; top:50%; cursor: pointer;outline: none;"">
            <a class=""materialcolor"">
                <i class=""material-icons"" id=""btbt"">
                    menu
                </i>
            </a>
        </button>
        <div style=""position: absolute; top:50%; left: 50%; transform: translate(-50%,-50%);"">
            <h1 class=""headtext"">Single Player</h1>
        </div>
    </header>

    <div class=""scorecontainer"">
        <h1 class=""score"">00</h1>
    </div>

    <div class=""clickablezone"">
        <button style=""width: 100%; height: 100%; background: transparent; border: none; outline: none;"">
            <img id=""ApplePic"" src='Assets/Apple.png' />
        </button>
    </div>

    <footer style=""width: 100%; bottom: ");
            WriteLiteral(@"0;"">
        <table class=""mdl-data-table mdl-js-data-table  mdl-shadow--2dp"" style=""width: 100%;font-family: 'Montserrat', sans-serif;"">
            <thead style=""text-align: center;"">
                <tr>
                    <th class=""mdl-data-table__cell--non-numeric"" style=""width: 30%; text-align: center; color:#569981;"">Booster</th>
                    <th style=""width: 30%;  text-align: center; color: #569981;"">Quantity</th>
                    <th style=""width: 30%;  text-align: center; color: #569981;"">Price</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td class=""mdl-data-table__cell--non-numeric"" style=""width: 30%;  text-align: center;"">Eva</td>
                    <td style=""width: 30%;  text-align: center;"">00</td>
                    <td style=""width: 30%;  text-align: center;"">10</td>
                </tr>
                <tr>
                    <td class=""mdl-data-table__cell--non-numeric"" style=""width: 30%;  text-");
            WriteLiteral(@"align: center;"">Newton</td>
                    <td style=""width: 30%;  text-align: center;"">00</td>
                    <td style=""width: 30%;  text-align: center;"">50</td>
                </tr>
                <tr>
                    <td class=""mdl-data-table__cell--non-numeric"" style=""width: 30%;  text-align: center;"">Jobs</td>
                    <td style=""width: 30%;  text-align: center;"">00</td>
                    <td style=""width: 30%;  text-align: center;"">100</td>
                </tr>
            </tbody>
        </table>
    </footer>

</div style=""overflow:>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PC.Views.SingleiPlayer.SinglePlayer> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PC.Views.SingleiPlayer.SinglePlayer> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PC.Views.SingleiPlayer.SinglePlayer>)PageContext?.ViewData;
        public PC.Views.SingleiPlayer.SinglePlayer Model => ViewData.Model;
    }
}
#pragma warning restore 1591
