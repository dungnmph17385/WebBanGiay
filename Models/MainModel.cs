using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class MainModel
    {
        public class objcheckbox {
            public string Code { get; set; }
            public string Name { get; set; }
        }
        public class objTop3Product {
            public string ProductId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string LastPrice { get; set; }
            public string Url { get; set; }
        }

        public class LoginAcc
        {
            public string UserName { get; set; }
            public string UserPassword { get; set; }
        }
        public class getUserLoginAcc
        {
            public string UserId { get; set; }
            public string UserName { get; set; }
            public string UserPassword { get; set; }
            public string UserRole { get; set; }
        }
    }
}