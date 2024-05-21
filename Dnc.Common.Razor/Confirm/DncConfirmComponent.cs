using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dnc.Common.Razor.Confirm
{
    public class DncConfirmComponent: ComponentBase
    {
        [Parameter] public RenderFragment HeaderTemplate { get; set; }
        [Parameter] public RenderFragment BodyTemplate { get; set; }
        [Parameter] public RenderFragment OkTemplate { get; set; }
        [Parameter] public RenderFragment CancelTemplate { get; set; }

        [Parameter] public bool Scrollable { get; set; }

        [Parameter] public EventCallback<bool> OnOk { get; set; }

        protected bool Visible { get; set; }

        public void Display()
        {
            Visible = true;
            StateHasChanged();
        }
        protected void Cancel()
        {
            Visible = false;
        }

        protected async Task Ok()
        {
            Visible = false;
            await OnOk.InvokeAsync(true);
        }
    }
}
