using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class SmtpClientWithout
    {
        public void Send(string emailAddress, string message) { }
    }
}
