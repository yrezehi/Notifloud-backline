using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifloud_dotnet
{
    public class Notifloud
    {
        public IList<NotifloudToast> Toasts { get; set; }

        public Notifloud() =>
            Toasts = new List<NotifloudToast>();

        public void Success(string message)
        {
            Toasts.Add();
        }

        public void Error()
        {

        }

        public void Information()
        {

        }

        public void Warning() { 
            
        }
    }
}
