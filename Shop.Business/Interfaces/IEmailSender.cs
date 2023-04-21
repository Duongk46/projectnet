﻿using Shop.Business.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Interfaces
{
    public interface IEmailSender
    {
        Task<bool> SendMail(MailContent mailContent);
    }
}
