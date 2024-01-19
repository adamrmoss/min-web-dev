using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MinWebDev.Web;

[HtmlTargetElement("resume-section")]
public class ResumeSectionTagHelper : TagHelper
{
    public required string Title { get; set; }
    
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var innerContent = output.GetChildContentAsync().Result.GetContent();

        var sectionTitleHeading = new TagBuilder("h2");
        sectionTitleHeading.AddCssClass("resume-section-title");
        sectionTitleHeading.InnerHtml.Append(this.Title);

        var sectionBody = new TagBuilder("div");
        sectionBody.AddCssClass("resume-section-body");
        sectionBody.InnerHtml.AppendHtml(innerContent);

        var section = new TagBuilder("section");
        section.AddCssClass("resume-section");
        section.InnerHtml.AppendHtml(sectionTitleHeading);
        section.InnerHtml.AppendHtml(sectionBody);

        output.TagMode = TagMode.StartTagAndEndTag;
        output.SuppressOutput();
        output.PreContent.SetHtmlContent(section);
    }
}
