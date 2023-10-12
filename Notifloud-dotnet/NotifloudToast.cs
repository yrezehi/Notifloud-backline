namespace Notifloud_dotnet
{
    public class NotifloudToast
    {
        public string Title { get; set; } = "";
        public string Message { get; set; }

        public static NotifloudToast Create(string title, string message) =>
            new() { Title = title, Message = message };

        public static NotifloudToast Create(string message) =>
            new() { Message = message };
    }
}
