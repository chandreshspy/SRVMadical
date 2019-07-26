using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRV.Models
{
    public class SendSms
    {
        public string Suject { get; set; }
        public string message { get; set; }
        public string numberenter { get; set; }
        public HttpPostedFileBase file { get; set; }
    }
    public class SendEmal
    {
        public string Suject { get; set; }
        public string message { get; set; }
        public string numberenter { get; set; }
        public HttpPostedFileBase file { get; set; }
    }
}