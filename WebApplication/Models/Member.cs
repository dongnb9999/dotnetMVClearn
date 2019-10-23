using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Member
    {
        public long Id { get; set;}
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string avatar { get; set; }

        public string phone { get; set; }

        public string address { get; set; }

        public string introduction { get; set; }

        public int gender { get; set; }

        public string birthday { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}