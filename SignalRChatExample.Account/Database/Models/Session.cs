using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChatExample.Account.Database.Models
{
    public class Session
    {
        public long UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string IPaddress { get; set; }

        public DateTime LoggedInAt { get; set; }

        public DateTime? LoggedOffAt { get; set; }
    }
}
