using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Application.Messages.Request
{
    public class PersonPhoneInputRequest
    {
        public string PhoneNumber { get; set; }
        public int PhoneNumberType { get; set; }
    }
}
