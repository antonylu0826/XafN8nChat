using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using XafN8nChat.Blazor.Server.Editors.ChatUI;

namespace XafN8nChat.Blazor.Server.Controllers
{
    public class ChatActionController : WindowController
    {
        public ChatActionController()
        {
            var chatAction = new PopupWindowShowAction()
            {
                Id = "n8nChatAction",
                Caption = "AI Chat",
                ImageName = "Glyph_Message",
                Category = "QuickAccess",
            };
            chatAction.CustomizePopupWindowParams += ChatAction_CustomizePopupWindowParams;
            Actions.Add(chatAction);
        }

        private void ChatAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = e.Application.CreateObjectSpace(typeof(N8nChatModel));
            var detailView = e.Application.CreateDashboardView(objectSpace, "AIChatDashboard", true);
            e.View = detailView;
            e.DialogController.AcceptAction.Active["Default"] = false;
            e.DialogController.CancelAction.Active["Default"] = false;
        }
    }
}
