using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork10.DTOs;
using HomeWork10.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmailSenderService emailSenderService;
        private readonly ISmsSenderService smsSenderService;
        
        public ValuesController(IEmailSenderService emailSenderService, ISmsSenderService smsSenderService)
        {
            this.emailSenderService = emailSenderService;
            this.smsSenderService = smsSenderService;
        }

        public string Test()
        {
            return "123";
        }

        [Route("~/api/SendEmail")]
        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailMessageDTO emailMessage)
        {
            await emailSenderService.SendEmail(emailMessage);

            return Ok();
        }

        [Route("~/api/SendSms")]
        [HttpPost]
        public async Task<IActionResult> SendSms(SmsMessageDTO smsMessageDTO)
        {
            await smsSenderService.SendSMS(smsMessageDTO);

            return Ok();
        }
    }
}
