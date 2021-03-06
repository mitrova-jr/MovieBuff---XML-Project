#pragma checksum "C:\Users\PupanGlupan\Desktop\App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c129c6bf619d05582abfc60511a13f6c3749866"
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
#line 1 "C:\Users\PupanGlupan\Desktop\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PupanGlupan\Desktop\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c129c6bf619d05582abfc60511a13f6c3749866", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\PupanGlupan\Desktop\App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Movie Buff</h1>
    <h5>Find out details about your favorite movie!</h5>
    <div class=""container p-3"" id=""box1"">
        <div class=""text-left row border-bottom"">
            <div class=""col-2""><p class=""font-weight-bold"">Year of the movie: </p></div>
            <div class=""col-10""><label id=""year-text"">Year</label></div>
        </div>
        <div class=""text-left row border-bottom"">
            <div class=""col-2""><p class=""font-weight-bold"">Genre of the movie: </p></div>
            <div class=""col-10""><label id=""genre-text"">Genre</label></div>
        </div>
        <div class=""text-left row border-bottom"">
            <div class=""col-2""><p class=""font-weight-bold"">Director of the movie: </p></div>
            <div class=""col-10""><label id=""director-text"">Director</label></div>
        </div>
        <div class=""text-left row border-bottom"">
            <div class=""col-2""><p class=""font-weight-bold"">Language of the movie: </p></div>");
            WriteLiteral(@"
            <div class=""col-10""><label id=""language-text"">Language</label></div>
        </div>
        <div class=""text-left row border-bottom"">
            <div class=""col-2""><p class=""font-weight-bold"">IMDB Rating of the movie: </p></div>
            <div class=""col-10""><label id=""rating-text"">imdbRating</label></div>
        </div>
        <div class=""text-left row border-bottom"">
            <div class=""col-2""><p class=""font-weight-bold"">Plot of the movie: </p></div>
            <div class=""col-10""><label id=""plot-text"">Plot</label></div>
        </div>
        <div><input type=""text"" class=""form-control input"" id=""raw-text"" placeholder=""Movie Title""></div>
    </div>
    
    <div><input type=""button"" class=""mt-3 btn btn-outline-secondary"" id=""get-data"" value=""Give me details"" /></div>
</div>

<script>
    $(() => {
        $('#get-data').click(() => {
            const rawText = $('#raw-text').val();
            $.get('https://localhost:5001/Home/Check?query=' + rawText, null, 
 ");
            WriteLiteral(@"               (rawJson) =>{
                    const details = JSON.parse(rawJson);
                    $('#year-text').text(details.Year);
                    $('#genre-text').text(details.Genre);
                    $('#director-text').text(details.Director);
                    $('#language-text').text(details.Language);
                    $('#rating-text').text(details.imdbRating);
                    $('#plot-text').text(details.Plot);

                }
            );
        });
    });

</script>
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
