#pragma checksum "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c4020e120b0272a83352bf26b07607f8edac0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
#line 1 "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#line 2 "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c4020e120b0272a83352bf26b07607f8edac0e", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c1dd89ee945937e85fe2e65d1d46d865d868a6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\Home\Post.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.Description = Model.Description;
    ViewBag.Keywords = $"{Model.Tags?.Replace(",", " ")} {Model.Category}";
    var basePath = Context.Request.PathBase;

#line default
#line hidden
            BeginContext(227, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(440, 61, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"post no-shadow\">\r\n");
            EndContext();
#line 23 "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\Home\Post.cshtml"
         if (!string.IsNullOrEmpty(Model.Image))
        {
            var imagePath = $"{basePath}/Image/{Model.Image}";

#line default
#line hidden
            BeginContext(626, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 642, "\"", 658, 1);
#line 26 "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 648, imagePath, 648, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(659, 49, true);
            WriteLiteral(" width=\"300\" />\r\n            <span class=\"title\">");
            EndContext();
            BeginContext(709, 11, false);
#line 27 "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\Home\Post.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(720, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 28 "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\Home\Post.cshtml"
        }

#line default
#line hidden
            BeginContext(740, 49, true);
            WriteLiteral("    </div>\r\n    <div class=\"post-body\">\r\n        ");
            EndContext();
            BeginContext(790, 20, false);
#line 31 "C:\Users\zvika\Desktop\C# Learning\C#Learning\Blog\Blog\Views\Home\Post.cshtml"
   Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(810, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
