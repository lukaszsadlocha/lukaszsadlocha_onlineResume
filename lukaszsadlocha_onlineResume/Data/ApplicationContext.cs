﻿using lukaszsadlocha_onlineresume.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lukaszsadlocha_onlineResume.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        { }

        public DbSet<EmailContact> EmailContacts { get; set; }
    }
}
