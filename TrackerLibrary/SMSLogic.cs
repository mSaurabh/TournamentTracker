using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using static Twilio.Rest.Api.V2010.Account.MessageResource;

namespace TrackerLibrary
{
    public class SMSLogic
    {
        public static void SendSMSMessage(string to,string textMessage)
        {
            string accountSid = GlobalConfig.AppKeyLookUp("smsAccountSid");
            string authToken = GlobalConfig.AppKeyLookUp("smsAuthToken");
            string fromPhoneNumber = GlobalConfig.AppKeyLookUp("smsFromPhoneNumber");

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(to),
                from: new PhoneNumber(fromPhoneNumber),
                body: textMessage
                );

            GlobalConfig.Connection.InsertSMSLogMessage(Convert.ToDecimal(message.Price), message.PriceUnit, message.Status.ToString(), textMessage.Length, to, fromPhoneNumber);
        }
    }
}
