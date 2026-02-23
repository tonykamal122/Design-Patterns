using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP_Soild
{
    //why we make it to put all the buissnes logic on it
    public class UserService
    {
        public void Register(UserV user)
        {
            //Register user Logic

            //send email
            EmailSenderV emailSender = new EmailSenderV();
            emailSender.SendEmail(user.Email, "Welcome to platform");
        }
    }
}