using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifloud_dotnet
{
    public class NotifloudToast
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public NotifloudToast(string title, string message)
        {
            Title = title;
        }
        
        public NotifloudToast(string message)
        {
            Message = message;
        }

    }
}
