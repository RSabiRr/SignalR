using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models
{
    public class CustomUser:IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public byte Age { get; set; }

    }
}
