using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Utils;
using Microsoft.AspNetCore.Components;

namespace XafN8nChat.Blazor.Server.Editors.ChatUI
{
    public class N8nChatAdapter : ComponentAdapterBase
    {
        private RenderFragment component;

        public N8nChatAdapter() { }

        public RenderFragment ComponentContent
        {
            get
            {
                if (component == null)
                {
                    component = builder =>
                    {
                        builder.OpenComponent<N8nChat>(0);
                        builder.CloseComponent();
                    };
                }
                return component;
            }
        }

        public override IComponentModel ComponentModel => throw new NotImplementedException();

        public override object GetValue()
        {
            return null;
        }

        public void Refresh()
        { }
        public override void SetAllowEdit(bool allowEdit) { }

        public override void SetAllowNull(bool allowNull) { }

        public override void SetDisplayFormat(string displayFormat) { }

        public override void SetEditMask(string editMask) { }

        public override void SetEditMaskType(EditMaskType editMaskType) { }

        public override void SetErrorIcon(ImageInfo errorIcon) { }

        public override void SetErrorMessage(string errorMessage) { }

        public override void SetIsPassword(bool isPassword) { }

        public override void SetMaxLength(int maxLength) { }

        public override void SetNullText(string nullText) { }
        public override void SetValue(object value) { }

        protected override RenderFragment CreateComponent()
        {
            return ComponentContent;
        }
    }
}
