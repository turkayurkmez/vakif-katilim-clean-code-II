using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public interface ISender
    {
        void Send(string to);
    }

   
    public class Report
    {
        private readonly ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }

        public void Send(string to) 
        {
           
            sender.Send(to);
        }
    }

    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"{to} adresine mail gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"{to} adresine WhatsApp mesaji gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"{to} adresine Telegram mesaji gönderildi");
        }
    }



}
