using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class MailSender
    {
        public void SendMail(string to, string body)
        {
            MessageBox.Show(body);
        }
    }
}
