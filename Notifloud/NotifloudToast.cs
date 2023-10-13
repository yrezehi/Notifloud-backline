namespace Notifloud
{
    public class NotifloudToast
    {
        public string Title { get; set; } = "";
        public string Message { get; set; }
        public ToastType Type { get; set; }

        public static NotifloudToast Create(ToastType type, string title, string message) =>
            new() { Type = type, Title = title, Message = message };

        public static NotifloudToast Create(ToastType type, string message) =>
            new() { Type = type, Message = message };
    }
}
