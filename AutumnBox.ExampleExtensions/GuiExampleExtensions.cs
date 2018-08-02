﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/3/6 17:52:46 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.Basic.Device;
using AutumnBox.OpenFramework.Extension;

namespace AutumnBox.ExampleExtensions
{
    [ExtRequiredDeviceStates(DeviceState.None)]
    [ExtName("ClearLove")]
    public class GuiExampleExtensions : AutumnBoxExtension
    {
        public override int Main()
        {
            App.RunOnUIThread(() =>
            {
                App.CreateDebuggingWindow().Show();
            });
            return 0;
        }
    }
}
