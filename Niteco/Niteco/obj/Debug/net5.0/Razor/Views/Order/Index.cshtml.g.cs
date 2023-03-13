#pragma checksum "F:\MiniProject\App\Niteco\Niteco\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a258a12f4f8af5f38d841261dcc711d0f11bac61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "F:\MiniProject\App\Niteco\Niteco\Views\_ViewImports.cshtml"
using Niteco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MiniProject\App\Niteco\Niteco\Views\_ViewImports.cshtml"
using Niteco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a258a12f4f8af5f38d841261dcc711d0f11bac61", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb02d6387beb52626d57fd4dded59babfba93c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("\r\n<div class=\"body-project\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a258a12f4f8af5f38d841261dcc711d0f11bac613181", async() => {
                WriteLiteral(@"
        <div class=""form-row align-items-center"">
            <div class=""col-auto"">
                <label class=""sr-only"" for=""inlineFormInput"">Order Name</label>
                <input type=""text"" class=""form-control mb-2"" name=""OrderName"" id=""OrderName"" placeholder=""name"">
            </div>
            <div class=""col-auto"">
                <label class=""sr-only"" for=""inlineFormInput"">Price</label>
                <input type=""text"" class=""form-control mb-2"" name=""Price"" id=""Price"" placeholder=""0"">
            </div>
            <div class=""col-auto"">
                <label class=""sr-only"" for=""inlineFormInput"">Amout</label>
                <input type=""text"" class=""form-control mb-2"" name=""Amount"" id=""Amount"" placeholder=""0"">
            </div>
            <div class=""col-auto"">
                <button type=""button"" onclick=""GetDataOrder('Order/GetData')"" class=""btn btn-primary mb-2"">Search</button>
            </div>
");
                WriteLiteral("        </div>\r\n    ");
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
            WriteLiteral(@"
    <div>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Order Name</th>
                    <th scope=""col"">Pro Name</th>
                    <th scope=""col"">Amount</th>
                    <th scope=""col"">Category</th>
                    <th scope=""col"">Price</th>
                    <th scope=""col"">Date</th>
                    <th scope=""col"">Desc</th>

                </tr>
            </thead>
            <tbody class=""data-table"">


                <tr>
                    <th scope=""row"">2</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td></td>
                </tr>
                <tr>
                    <th scope=""row"">3</th>
                    <td>Larry</td>
                    <td>the Bird</td>
                    <td></td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            GetDataOrder('/Order/GetData');
        })
        function RequestParam(name, price, amount) {
            var param = new Object();
            param.Name = (name != '' ? name : '');
            param.Price = (price != '' ? price : '');
            param.Amount = (amount != '' ? amount : '');
            return param;
        }
        function DataRow(data, i) {
            var tr = `
                    <tr>
                        <td>${i + 1}</td>
                        <td>${data.orderName}</td>
                        <td>${data.productName}</td>
                        <td>${data.orderAmount}</td>
                        <td>${data.cateTitle}</td>
                        <td>${data.price}</td>
                        <td>${data.createdDate}</td>
                        <td>${data.desc}</td>
                    </tr>
                        `;
            $('.data-table').append(tr);
        }
        functio");
                WriteLiteral(@"n SetRow(arr) {
            for (var i = 0; i < arr.length; i++) {
                DataRow(arr[i], i);
            }
        }
        function GetDataOrder(url) {
            var param = new Object();
            param.Name = $('#OrderName').val();
            param.Price = $('#Price').val();
            param.Amount = $('#Amount').val();
            $.ajax({
                url: url,
                type: ""POST"",
                data: JSON.stringify(param),
                dataType: ""json"",
                contentType: ""application/json"",
                beforeSend: function () {
                },
                success: function (res) {
                    console.log(res);
                    if (res != null) {
                        $('.data-table').html('');
                        SetRow(res);
                    }
                    else {

                        Swal.fire({
                            position: 'center',
                            icon: 'error',
   ");
                WriteLiteral(@"                         title: 'Không thành công',
                            showConfirmButton: false,
                            timer: 1500
                        });
                    }
                },
                error: function (e) {
                    console.log(e);
                },
                complete: function () {

                }
            })
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591