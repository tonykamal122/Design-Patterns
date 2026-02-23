using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP_Soild
{
    //Violate SRP Resposnipity
    public class UserV
    {
        public string Username { get; set; }
        public string Email { get; set; }
        //if we put it here we violate -> put it in UserService
        // public void Register()
        // {
        //     //Register user Logic

        //     //send email
        //     EmailSender emailSender = new EmailSender();
        //     emailSender.SendEmail(Email,"Welcome to platform");
        // }
    }
}
/*
Why Violate Because we can add more properties for user
and the another reason that we can change the register Logic
*/