namespace FriendStorage.UI.Dialogs
{
    public interface IMessageDialogService
    {
        MessageDialogResult ShowYesNoDialaog(string title, string message);
    }

    public enum MessageDialogResult
    {
        Yes,
        No
    }
}
