using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication11.TagHelpers
{
    [HtmlTargetElement("input", Attributes = "asp-for")]
    public class MyInputTagHelper : InputTagHelper
    {
        public MyInputTagHelper(IHtmlGenerator generator) : base(generator)
        {
        }
    }
    [HtmlTargetElement("select", Attributes = "asp-for")]
    public class MySelectTagHelper : SelectTagHelper
    {
        public MySelectTagHelper(IHtmlGenerator generator) : base(generator)
        {
        }
    }
}