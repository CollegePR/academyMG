using ToastNotifications;
using MaterialSkinExample.ShowDialog;

namespace MaterialSkinExample
{
    public static class Util
    {
        public static void ShowInDialog(string Title, string Text)
        {
            ShowDialogForm showDialogForm = new ShowDialogForm(Title, Text);
            showDialogForm.ShowDialog();
        }

        public static void ShowInDialog(string Text)
        {
            ShowDialogForm showDialogForm = new ShowDialogForm(Text);
            showDialogForm.ShowDialog();
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
