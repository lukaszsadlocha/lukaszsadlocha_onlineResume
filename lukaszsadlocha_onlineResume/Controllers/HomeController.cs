using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lukaszsadlocha_onlineResume.Models;
using lukaszsadlocha_onlineresume.Services;
using lukaszsadlocha_onlineResume.Data;
using lukaszsadlocha_onlineresume.Models;

namespace lukaszsadlocha_onlineResume.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext _dbContext;

        public HomeController(ApplicationContext context)
        {
            _dbContext = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string emailAddress)
        {
            if (!string.IsNullOrEmpty(emailAddress) && EmailService.IsValidEmailAddress(emailAddress))
            {
                _dbContext.EmailContacts.Add(new EmailContact() { AddedByMe = "1", EmailAddress = emailAddress, CreatedAt = DateTime.Now });
                _dbContext.SaveChanges();

                var messageType = MessageType.Success;
                ViewBag.MessageType = messageType;
                ViewBag.Message = MessageService.GetMessageOnType(messageType);

            }
            else
            {
                var messageType = MessageType.Error;
                ViewBag.MessageType = messageType;
                ViewBag.Message = MessageService.GetMessageOnType(messageType);
            }
            return View();
        }
    }
}
