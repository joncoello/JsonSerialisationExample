using JsonSerialisationExample.MessageTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialisationExample {
    class Queue {

        private readonly Queue<string> _q;

        public Queue() {
            _q = new Queue<string>();
        }

        public void Enqueue(MessageBase message) {
            var serialisedMessage = JsonConvert.SerializeObject(message);
            _q.Enqueue(serialisedMessage);
        }

        public MessageBase Dequeue() {
            var serialisedMessage = _q.Dequeue();
            var messageObject = (JObject)JsonConvert.DeserializeObject(serialisedMessage);
            var typeName = messageObject["MyType"].ToString();

            // get type from string - may need to test types outside assembly
            // http://stackoverflow.com/questions/12306/can-i-serialize-a-c-sharp-type-object
            var type = Type.GetType(typeName);

            var message = (MessageBase)messageObject.ToObject(type);
            return message;
        }

    }
}
