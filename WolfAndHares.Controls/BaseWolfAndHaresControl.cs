namespace WolfAndHares.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class BaseWolfAndHaresControl : UserControl
    {
        protected void InvokeExternalDelegate(object key, object sender, EventArgs e)
        {
            var @event = Events[key];
            if (@event == null)
                return;

            var list = @event.GetInvocationList();
            foreach (var @delegate in list)
            {
                Invoke(@delegate, sender, e);
            }
        }

        public virtual void SetFont(Font font)
        {
        }
    }
}
