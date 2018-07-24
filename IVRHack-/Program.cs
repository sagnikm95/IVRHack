using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace IVRHack_
{
    class Example
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            string accountSid = ConfigurationManager.AppSettings["accountSid"];
            string authToken = ConfigurationManager.AppSettings["authToken"];
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+919804172303");
            var from = new PhoneNumber(ConfigurationManager.AppSettings["twilioNumber"]);
            var call = CallResource.Create(to,
                                           from,
                                           url: new Uri("http://myapptwilio.azurewebsites.net/demo.ashx "));

            Console.WriteLine(call.Sid);
        }
    }
}
