using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialisationExample.MessageTypes {
    public class SendEmailMessage : MessageBase {
        public string FromEmail { get; set; }
        public string ToEmails{ get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
