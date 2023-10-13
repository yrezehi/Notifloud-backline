using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Notifloud_dotnet.Extenstions
{
    public static class NotifloudExtensions
    {
        public static void UserNotifloud(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(Notifloud), typeof(Notifloud));
        }
    }
}
