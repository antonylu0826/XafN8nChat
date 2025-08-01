using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace XafN8nChat.Blazor.Server.Services
{
    internal static class n8nUtilities
    {
        [DoesNotReturn]
        public static async ValueTask ThrowUnsuccessfulResponseAsync(HttpResponseMessage response, CancellationToken cancellationToken)
        {
            Debug.Assert(!response.IsSuccessStatusCode, "must only be invoked for unsuccessful responses.");

            // Read the entire response content into a string.
            string errorContent =
#if NET
                await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
            await response.Content.ReadAsStringAsync().ConfigureAwait(false);
#endif

            // The response content *could* be JSON formatted, try to extract the error field.

#pragma warning disable CA1031 // Do not catch general exception types
            try
            {
                using JsonDocument document = JsonDocument.Parse(errorContent);
                if (document.RootElement.TryGetProperty("error", out JsonElement errorElement) &&
                    errorElement.ValueKind is JsonValueKind.String)
                {
                    errorContent = errorElement.GetString()!;
                }
            }
            catch
            {
                // Ignore JSON parsing errors.
            }
#pragma warning restore CA1031 // Do not catch general exception types

            throw new InvalidOperationException($"Ollama error: {errorContent}");
        }
    }
}
