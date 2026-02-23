using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP_Soild
{
    public class EmailSenderV
    {
        public void SendEmail(string email , string message)
        {
            Console.WriteLine($"Sending Email to {email} {message}");
        }
    }
}