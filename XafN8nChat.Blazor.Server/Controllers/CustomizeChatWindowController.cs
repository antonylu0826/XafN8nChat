using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Templates;

namespace XafN8nChat.Blazor.Server.Controllers
{
    public class CustomizeChatWindowController : WindowController
    {
        protected override void OnActivated()
        {
            base.OnActivated();

            Window.TemplateChanged += Window_TemplateChanged;
        }
        private void Window_TemplateChanged(object sender, EventArgs e)
        {
            if (Window.View != null)
            {
                if (Window.View.Id == "AIChatDashboard")
                {
                    var t = Window.Template as PopupWindowTemplate;
                    var popup = t.Popup as DxPopupModel;
                    popup.ShowFooter = false;
                }
            }

        }
        protected override void OnDeactivated()
        {
            Window.TemplateChanged -= Window_TemplateChanged;
            base.OnDeactivated();
        }
    }
}
