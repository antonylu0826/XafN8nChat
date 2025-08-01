using Microsoft.Extensions.AI;
using System.ComponentModel;
using XafN8nChat.Blazor.Server.Services;

namespace Microsoft.Extensions.DependencyInjection;

[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
public static class n8nChatStartupExtensions
{
    public static IServiceCollection Addn8nChat(
        this IServiceCollection services,
        Action<n8nChatClientOptions> configureOptions)
    {
        services.AddScoped(provider =>
        {
            var options = new n8nChatClientOptions();
            configureOptions(options);
            return options;
        });
        services.AddScoped<IChatClient, n8nChatClient>();
        services.AddDevExpressAI();

        services.AddHttpClient();
        return services;
    }
}
