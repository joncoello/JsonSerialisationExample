using JsonSerialisationExample.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialisationExample {
    class Program {
        static void Main(string[] args) {

            var msg = new SendEmailMessage {
                FromEmail = "jonsmith@gmail.com",
                ToEmails = "bobjones@gmail.com",
                Subject = "Covariance is hard",
                Body = "Lets hope this example works"
            };

            var q = new Queue();

            q.Enqueue(msg);

            var msgOut = q.Dequeue();

        }
    }
}
