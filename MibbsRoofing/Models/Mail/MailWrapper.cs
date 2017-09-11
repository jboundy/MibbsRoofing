using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MibbsRoofing.Models.Mail
{
    public class MailWrapper
    {
        public string TemplateId { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
    }
}
