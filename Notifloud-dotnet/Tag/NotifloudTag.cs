using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Notifloud.Tag
{
    public class NotifloudTag : TagHelper
    {
        private static readonly string CLASS_NAME = "toast";
        private Notifloud Notifloud { get; set; }

        public NotifloudTag(Notifloud notifloud) =>
            Notifloud = notifloud;

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.Attributes.Add("class", CLASS_NAME);

            foreach (var toast in Notifloud.Toasts)
            {
                output.PreContent.AppendHtml($@"
                    <div class=""toast"">
                        <div class=""toast-inner"">
                            <div class=""icon {toast.Type}""></div>
                            <div class=""content"">
                                <h2>${toast.Title ?? ""}</h2>
                                <p>${toast.Message ?? ""}</p>
                            </div>
                            <button class=""close"">close</button>
                        </div>
                    </div>
                ");
            }

            base.Process(context, output);
        }
    }
}
