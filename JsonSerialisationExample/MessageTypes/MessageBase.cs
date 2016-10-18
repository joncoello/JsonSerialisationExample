using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialisationExample.MessageTypes {

    public class MessageBase {

        public Guid MessageID { get; set; }
        public Type MyType { get; set; }

        public MessageBase() {
            MessageID = Guid.NewGuid();
            MyType = this.GetType();
        }

    }

}
