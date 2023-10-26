using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmailNotification
    {
        private IEmailSender _sender;

        public EmailNotification(IEmailSender sender)
        {
            _sender = sender;
        }
        public void Send(string emailAddress, string message)
        {
            _sender.Send(emailAddress, message);
        }
    }
}
