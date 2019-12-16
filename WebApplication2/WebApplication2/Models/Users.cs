using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    [Table("user_register")]
    public class Users
    {
        public string user_name { get; set; }
        public string user_pwd { get; set; }
        public string user_gender { get; set; }
        public string user_city { get; set; }
        public string user_mobile { get; set; }
        public string user_email { get; set; }
    }
}