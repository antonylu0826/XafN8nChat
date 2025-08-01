# AI Chat Integration between XAF and n8n

![XAF n8n Chat](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/xafchat.png)

This project demonstrates how to integrate XAF¡¦s AI chat functionality with n8n using a Blazor UI. The integration enables seamless communication between XAF's AI services and the n8n workflow automation platform.

## Overview

This solution provides:
- **XAF AI Chat**: An interactive dialogue system powered by AI.
- **n8n Integration**: Automates processes by responding to chat events via n8n workflows.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- A Blazor Server hosting environment
- A running instance of n8n (self-hosted or cloud)
- XAF configuration with AI chat functionality enabled

## Installation & Setup

### 1. Configure XAF AI Chat

- Clone the XAF project:
    ```bash
    git clone https://github.com/antonylu0826/XafN8nChat.git
    ```

### 2. Set Up n8n

- Install and start n8n following the official guide: [n8n Installation Guide](https://docs.n8n.io/getting-started/installation/)
- Create a workflow that can receive application endpoints or events. You can upload the sample workflow from the repository ([n8n sample](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/Simple%20Chat.json)).
![Sample Flow](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/simpleflow.png)
- Get the webhook URL from n8n. This will be used to communicate between Blazor Server and n8n.
![WebHook Url](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/webhookurl.png)

### 3. Update Blazor Server Application

- In `Startup.cs`, update the service configuration to include the XAF AI chat module:
    ```csharp
    services.Addn8nChat(configureOptions => {
        configureOptions.ChatUrl = "<your_n8n_webhook_url>";
    });
    ```

For example, your controller might include an action that sends a chat message to the n8n webhook:

## Run the Application

1. **Build and run the Blazor Server project**

## Troubleshooting

- **API Errors:** Ensure the webhook URL is correct and n8n is running.
- **Configuration Issues:** Verify that the XAF AI chat module and n8n setup (e.g., API key) are correctly configured.
- **Network Connectivity:** Test the connection between the Blazor Server and the n8n instance.

## Additional Resources

- [XAF Official Documentation](https://docs.devexpress.com/XAF)
- [n8n Official Documentation](https://docs.n8n.io)
- [.NET 8 Official Documentation](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)

This README provides a brief guide for integrating XAF's AI chat functionality with n8n. Please adjust it according to your specific environment and needs.
