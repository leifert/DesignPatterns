using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class SmtpClient : IEmailSender
    {
        public void Send(string emailAddress, string message)
        {
            // implementation of email using smtp
        }
    }
}
