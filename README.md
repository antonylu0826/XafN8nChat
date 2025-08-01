# XAF 與 n8n 的 AI 聊天整合

![XAF n8n Chat](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/xafchat.png)

本專案展示如何使用 Blazor UI，將 XAF 的 AI 聊天功能與 n8n 整合。此整合可實現 XAF 的 AI 服務與 n8n 工作流程自動化平台之間的無縫通信。

## 概述

此解決方案可實現：
- **XAF AI 聊天**：由 AI 驅動的互動式對話系統。
- **n8n 整合**：透過 n8n 工作流程回應聊天事件並執行對應動作，自動化處理流程。

## 先決條件

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Blazor Server 主機環境
- 一個可運作的 n8n 實例（自架或雲端版本）
- 已啟用 AI 聊天功能的 XAF 設定

## 安裝與設定

### 1. 設定 XAF AI 聊天功能

- 複製 XAF 專案
    ```bash
    git clone https://github.com/antonylu0826/XafN8nChat.git
    ```
### 2. 設定 n8n

- 根據官方說明安裝並啟動 n8n：[n8n 安裝指南](https://docs.n8n.io/getting-started/installation/)
- 建立可接收應用程式端點或事件的工作流程，可以上傳儲存庫中的範例工作流程 ([n8n sample](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/Simple%20Chat.json))。
![Sample Flow](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/simpleflow.png)
- 取得 n8n 的 webhook URL，這將用於 Blazor Server 與 n8n 之間的通信。
![WebHook Url](https://github.com/antonylu0826/XafN8nChat/blob/master/n8n/webhookurl.png)
    

### 3. 更新 Blazor Server 應用程式

- 在 `Startup.cs` 中，更新服務設定以包含 XAF AI 聊天模組。
    ```csharp
    services.Addn8nChat(configureOptions => {
        configureOptions.ChatUrl = "<your_n8n_webhook_url>";
    });
    ```

例如，您的控制器可以包含一個動作，用來將聊天訊息發送至 n8n webhook：

## 執行應用程式

1. **建置並執行 Blazor Server 專案**  

## 疑難排解

- **API 錯誤：** 確認 webhook URL 是否正確，且 n8n 已運行。
- **設定問題：** 確保 XAF 的 AI 聊天模組與 n8n 設定（例如 API 金鑰）正確無誤。
- **網路連線問題：** 測試 Blazor Server 與 n8n 實例之間的連線是否正常。

## 其他資源

- [XAF 官方文件](https://docs.devexpress.com/XAF)
- [n8n 官方文件](https://docs.n8n.io)
- [.NET 8 官方文件](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)

本 README 提供整合 XAF 的 AI 聊天功能與 n8n 的簡要指南。請依照您的實際環境需求進行相應的調整。
