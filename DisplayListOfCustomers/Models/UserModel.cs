using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayListOfCustomers.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public UserModel(string name, string emailAddress, string phoneNumber)
        {
            Name = name;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }



    }
}