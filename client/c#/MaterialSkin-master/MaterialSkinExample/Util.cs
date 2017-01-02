using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ToastNotifications;

namespace MaterialSkinExample
{
    public static class Util
    {
        public static void ShowInDialog(string Name, string Text)
        {
            ShowDialogForm Dialog = new ShowDialogForm(Name,Text);
            Dialog.ShowDialog();
        }

        public static void Notification(string Name, string Text)
        {
            Notification NotifyForm = new Notification(Name, Text, 5, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
            NotifyForm.Show();
        }

        public static void Notification(string Text)
        {
            Notification NotifyForm = new Notification("", Text, 5, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
            NotifyForm.Show();
        }
    }
}
