# XAF 與 n8n 的 AI 聊天整合

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
    git clone
    ```
### 2. 設定 n8n

- 根據官方說明安裝並啟動 n8n：[n8n 安裝指南](https://docs.n8n.io/getting-started/installation/)
- 建立可接收應用程式端點或事件的工作流程，可以上傳儲存庫中的範例工作流程。

### 3. 更新 Blazor Server 應用程式

- 在 `Startup.cs` 中，確認已設定路由與 API 控制器所需的中介軟體。
- 實作或更新控制器（例如 `ChatActionController.cs`），以處理聊天動作並將請求轉發至對應的 n8n 端點。

例如，您的控制器可以包含一個動作，用來將聊天訊息發送至 n8n webhook：

### 4. 設定 API 端點

- **XAF 設定：** 確保 XAF AI 模組已設定在聊天事件觸發時呼叫 API。
- **n8n Webhook：** 在 n8n 中建立並設定 webhook 以接收並處理這些事件。

## 執行應用程式

1. **建置並執行 Blazor Server 專案**  
   在 Visual Studio 中使用 __建置方案__ 與 __開始偵錯__ 指令。

2. **監控通信狀況**  
   檢查輸出日誌，並使用 n8n 的工作流程執行記錄確認訊息已正確傳送與處理。

## 疑難排解

- **API 錯誤：** 確認 webhook URL 是否正確，且 n8n 已運行。
- **設定問題：** 確保 XAF 的 AI 聊天模組與 n8n 設定（例如 API 金鑰）正確無誤。
- **網路連線問題：** 測試 Blazor Server 與 n8n 實例之間的連線是否正常。

## 其他資源

- [XAF 官方文件](https://docs.devexpress.com/XAF)
- [n8n 官方文件](https://docs.n8n.io)
- [.NET 8 官方文件](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)

本 README 提供整合 XAF 的 AI 聊天功能與 n8n 的簡要指南。請依照您的實際環境需求進行相應的調整。
