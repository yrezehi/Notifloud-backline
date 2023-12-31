﻿namespace Notifloud
{
    public class Notifloud
    {
        public IList<NotifloudToast> Toasts { get; set; }

        public Notifloud() =>
            Toasts = new List<NotifloudToast>();

        public void Success(string message) =>
            Toasts.Add(NotifloudToast.Create(ToastType.Success, message));

        public void Error(string message) =>
            Toasts.Add(NotifloudToast.Create(ToastType.Error, message));

        public void Information(string message) =>
            Toasts.Add(NotifloudToast.Create(ToastType.Error, message));

        public void Warning(string message) =>
            Toasts.Add(NotifloudToast.Create(ToastType.Error, message));
    }
}
