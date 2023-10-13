using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Notifloud_dotnet.Tag
{
    public class NotifloudTag : TagHelper
    {
        private static readonly string CLASS_NAME = "toast";
        private Notifloud Notifloud { get; set; }

        public NotifloudTag(Notifloud notifloud) =>
            Notifloud = notifloud;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.Attributes.Add("class", CLASS_NAME);
            
            foreach(var toast in Notifloud.Toasts)
            {
                output.PreContent.AppendHtml(@"
                    <div class=""toast"">
                        <div class=""toast-inner"">
                            <div class=""icon {type}"">{icons[type]}</div>
                            <div class=""content"">
                                <h2>${title ?? DEFAULT_TITLE}</h2>
                                <p>${content ?? DEFAULT_CONTENT}</p>
                            </div>
                            <button class=""close"">${icons[""close""]}</button>
                        </div>
                    </div>
                ");
            }

            base.Process(context, output);
        }
    }
}
