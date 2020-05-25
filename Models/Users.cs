using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string role { get; set; } = "Юзер";
        public string userFio { get; set; } = "";
        public override string ToString()
        {
            return userFio;
        }
    }
}
