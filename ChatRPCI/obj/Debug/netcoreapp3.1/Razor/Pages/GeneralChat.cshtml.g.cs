#pragma checksum "C:\Users\Артем\source\repos\ChatRPCI\ChatRPCI\Pages\GeneralChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8330ea3a2763ab0ac657ed973e730fcc1e6e9458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChatRPCI.Pages.Pages_GeneralChat), @"mvc.1.0.razor-page", @"/Pages/GeneralChat.cshtml")]
namespace ChatRPCI.Pages
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
#line 1 "C:\Users\Артем\source\repos\ChatRPCI\ChatRPCI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Артем\source\repos\ChatRPCI\ChatRPCI\Pages\_ViewImports.cshtml"
using ChatRPCI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Артем\source\repos\ChatRPCI\ChatRPCI\Pages\_ViewImports.cshtml"
using ChatRPCI.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8330ea3a2763ab0ac657ed973e730fcc1e6e9458", @"/Pages/GeneralChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c987638de00aaccf84d38a47fa1ed389f0c385f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GeneralChat : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Dialogs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Артем\source\repos\ChatRPCI\ChatRPCI\Pages\GeneralChat.cshtml"
  
    ViewData["Title"] = "GeneralChat";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""container-fluid h1"" id=""gc_header"">
            General chat
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12  col-sm-8 col-md-6"">
            <div> <span id=""validation"" class="" text-danger""></span></div> 
            <Label id=""OutputLabel"">");
#nullable restore
#line 17 "C:\Users\Артем\source\repos\ChatRPCI\ChatRPCI\Pages\GeneralChat.cshtml"
                               Write(Model.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</Label>
            <textarea id=""msg"" type=""text"" class=""form-control"" placeholder=""Message""></textarea><br>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12  col-sm-8 col-md-6"" display=""inline-flex"">
            <button id=""send_btn"" type=""submit"" class=""btn btn-info"">Send</button>
            <button id=""clear_btn"" type=""button"" class=""btn btn-success"">
                Clear chat
            </button>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8330ea3a2763ab0ac657ed973e730fcc1e6e94586006", async() => {
                WriteLiteral("Dialogs");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
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
    </div>
</div>
<br>
<div class=""container"">
    <div class=""row"">
        <div id=""ms"" class=""col"">
            <h1 id=""nomsg"">No Message Yet</h1>
            <div class=""msg-wrapper"" style="" overflow-y: auto"">
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8330ea3a2763ab0ac657ed973e730fcc1e6e94587850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n    const hubConnection = new signalR.HubConnectionBuilder()\r\n        .withUrl(\"/chat\")\r\n            .build();\r\n\r\n    let us = \"");
#nullable restore
#line 49 "C:\Users\Артем\source\repos\ChatRPCI\ChatRPCI\Pages\GeneralChat.cshtml"
         Write(Model.userName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";


    function clear_val() {
    $('#validation').text('');
        }

    $('#clear_btn').on(""click"", function () {
        $(""p.msg_p"").remove();
    });
// #region hub
        hubConnection.on(""MessageToClient"", function (msg) {
        $('#msg').val('');
        $('#nomsg').remove();
        $('div.msg-wrapper').append('<p class=""msg_p""><b>' + us + ':' + '</b> ' + msg + '</p>');
    });
    $('#send_btn').on(""click"", function () {
        let message = $('#msg').val();
        if (message == '') {
            $('#validation').text('Enter message!');
            setTimeout(clear_val, 5000); 
        } else {
            hubConnection.invoke(""Send"", message);
        }
    });
 //#endregion
    hubConnection.start();
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatRPCI.GeneralChatModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChatRPCI.GeneralChatModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChatRPCI.GeneralChatModel>)PageContext?.ViewData;
        public ChatRPCI.GeneralChatModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591