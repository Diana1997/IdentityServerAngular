using System;
using IdentityServerAngular.Application.Common.Interfaces;

namespace IdentityServerAngular.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
