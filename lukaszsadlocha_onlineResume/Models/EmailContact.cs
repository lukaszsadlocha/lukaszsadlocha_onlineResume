using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lukaszsadlocha_onlineresume.Models
{
    public class EmailContact
    {
        public int ID { get; set; }
        public string EmailAddress { get; set; }
        public string AddedByMe { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
