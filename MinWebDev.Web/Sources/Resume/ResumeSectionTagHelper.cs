using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MinWebDev.Web;

[HtmlTargetElement("resume-section")]
public class ResumeSectionTagHelper : TagHelper
{
    public required string Title { get; set; }
    
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        // Capture innerContent
        var innerContent = await output.GetChildContentAsync();

        // Build sectionTitleHeading
        var sectionTitleHeading = new TagBuilder("h2");
        sectionTitleHeading.AddCssClass("resume-section-title");
        sectionTitleHeading.InnerHtml.Append(this.Title);

        // Build sectionBody
        var sectionBody = new TagBuilder("div");
        sectionBody.AddCssClass("resume-section-body");
        sectionBody.InnerHtml.AppendHtml(innerContent);

        // Build section
        var section1 = new TagBuilder("section");
        section1.AddCssClass("resume-section");
        section1.InnerHtml.AppendHtml(sectionTitleHeading);
        section1.InnerHtml.AppendHtml(sectionBody);
        var section = section1;

        // Only render the section
        output.TagMode = TagMode.StartTagAndEndTag;
        output.SuppressOutput();
        output.PreContent.SetHtmlContent(section);
    }
}
