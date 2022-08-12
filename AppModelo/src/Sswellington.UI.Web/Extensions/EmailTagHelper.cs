using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sswellington.UI.Web.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        public string EmailDomain { get; set; } = "protonmail.com";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a"; //html referente a tag de âncora
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain;
              
            output.Attributes.SetAttribute("href", "mailto" + target); 
            output.Content.SetContent(target);
        }
    }
}
