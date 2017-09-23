using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lukaszsadlocha_onlineresume.Services
{
    public static class EmailService
    {
        public static bool IsValidEmailAddress(string emailAddress)
        {
            var regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", RegexOptions.Compiled);
            return regex.IsMatch(emailAddress);
        }
    }
}
