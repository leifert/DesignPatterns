using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    //Porusuje DIP
    public class EmailNotificationWithout
    {
        private SmtpClientWithout _smtpClient;

        public EmailNotificationWithout()
        {
            _smtpClient = new SmtpClientWithout();
        }

        public void Send(string emailAddress, string message)
        {

            _smtpClient.Send(emailAddress,message);
        }

    }
}
