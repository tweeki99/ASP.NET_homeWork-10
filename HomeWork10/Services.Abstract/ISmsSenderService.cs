using HomeWork10.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork10.Services.Abstract
{
    public interface ISmsSenderService
    {
        Task SendSMS(SmsMessageDTO smsMessageDTO);
    }
}
