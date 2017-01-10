using ToastNotifications;
using MaterialSkinExample.ShowDialog;
using MaterialSkinExample.DateSelect;

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

        public static string SelectDate()
        {
            string SelectDate = null;
            DateSelectForm dateSelectForm = new DateSelectForm();
            dateSelectForm.ShowDialog();
            SelectDate = dateSelectForm.SelectedDate;

            if (SelectDate == null)
                return null;
            else
                return SelectDate;
        }
    }
}
