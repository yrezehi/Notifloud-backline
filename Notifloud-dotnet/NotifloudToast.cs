namespace Notifloud_dotnet
{
    public class NotifloudToast
    {
        public string Title { get; set; } = "";
        public string Message { get; set; }

        public NotifloudToast(string title, string message) =>
            (Title, Message) = (title, message);
        
        public NotifloudToast(string message) =>
            Message = message;
    }
}
