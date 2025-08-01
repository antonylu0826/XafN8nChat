using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.Extensions.AI;

namespace XafN8nChat.Blazor.Server.Services
{
    public class n8nChatClient : IChatClient
    {
        readonly n8nChatClientOptions options;
        private HttpClient client;
        private string chatId;

        public n8nChatClient(ProtectedLocalStorage storage, n8nChatClientOptions options)
        {
            this.options = options ?? throw new ArgumentNullException(nameof(options));
        }

        public void Dispose()
        {
            client?.Dispose();
        }


        public async Task<ChatResponse> GetResponseAsync(
            IEnumerable<ChatMessage> messages,
            ChatOptions options = null,
            CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(messages);

            client = new HttpClient();

            if (string.IsNullOrEmpty(chatId))
                chatId = $"chat_{Guid.NewGuid().ToString("N")[..9]}";

            var userMessages = messages.Where(m => m.Role == ChatRole.User).Last().Text;

            using var httpResponse = await client.PostAsJsonAsync(
            this.options.ChatUrl,
            new
            {
                chatId,
                message = userMessages,
                route = "general",
            },
            cancellationToken).ConfigureAwait(false);

            if (!httpResponse.IsSuccessStatusCode)
            {
                await n8nUtilities.ThrowUnsuccessfulResponseAsync(httpResponse, cancellationToken).ConfigureAwait(false);
            }

            var response = (await httpResponse.Content.ReadFromJsonAsync<n8nChatResponse>(cancellationToken).ConfigureAwait(false))!;
            return new(new ChatMessage(ChatRole.Assistant, response?.output));
        }

        public object GetService(Type serviceType, object serviceKey = null)
        {
            return null;
        }

        public IAsyncEnumerable<ChatResponseUpdate> GetStreamingResponseAsync(IEnumerable<ChatMessage> messages, ChatOptions options = null, CancellationToken cancellationToken = default)
        {
            return null;
        }

    }
}
