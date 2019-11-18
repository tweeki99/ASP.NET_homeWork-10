using HomeWork10.DTOs;
using HomeWork10.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace HomeWork10.Services
{
    public class SmsSenderService : ISmsSenderService
    {
        public Task SendSMS(SmsMessageDTO smsMessageDTO)
        {
            const string accountSid = "AC093b30d628e2cd4cb5a22f75486ee3bf";
            const string authToken = "64037bd2e3fd7c7f81a8059c44604405";
            TwilioClient.Init(accountSid, authToken);
            return MessageResource.CreateAsync(
                    body: smsMessageDTO.Text,
                    from: new Twilio.Types.PhoneNumber("+13344544753"),
                    to: new Twilio.Types.PhoneNumber(smsMessageDTO.To)
                );
        }
    }
}
