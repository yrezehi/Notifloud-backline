using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Notifloud.Extensions
{
    public static class NotifloudExtensions
    {
        public static void UseNotifloud(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(Notifloud), typeof(Notifloud));
        }
    }
}
