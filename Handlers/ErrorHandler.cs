﻿using MahApps.Metro.Controls.Dialogs;
using MBModManager.Events;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MBModManager.Handlers
{
    internal class ErrorHandler
    {

        public async static void BIX_INSTALL_FAILED(ProgressDialogController controller, string message)
        {
            controller.SetProgressBarForegroundBrush(new SolidColorBrush(Color.FromRgb(183, 35, 35)));
            controller.SetProgress(1f);
            controller.SetTitle("Opps.. We ran into an Error!");
            controller.SetMessage(message);
            await Task.Delay(5000);
            await controller.CloseAsync();
        }

        public static async void MOD_INSTALL_FAILED(ProgressDialogController controller, string message, bool shouldCleanUp)
        {
            controller.SetProgressBarForegroundBrush(new SolidColorBrush(Color.FromRgb(183, 35, 35)));
            controller.SetProgress(1f);
            controller.SetTitle("Opps. Mod Install Failed!");
            controller.SetMessage(message);
            if (shouldCleanUp) { GeneralEvents.CLEANUP_WORKDIR(); }
            await Task.Delay(5000);
            await controller.CloseAsync();
        }

    }
}
