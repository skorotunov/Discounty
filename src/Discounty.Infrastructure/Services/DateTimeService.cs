﻿using Discounty.Application.Common.Interfaces;
using System;

namespace Discounty.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
