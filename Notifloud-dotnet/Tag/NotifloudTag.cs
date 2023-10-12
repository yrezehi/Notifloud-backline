using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Notifloud_dotnet.Tag
{
    public class NotifloudTag : TagHelper
    {
        private static readonly string CLASS_NAME = "toast";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.Attributes.Add("class", CLASS_NAME);

            base.Process(context, output);
        }
    }
}
