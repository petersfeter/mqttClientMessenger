using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMqtt
{
    public class PrivMessageModel
    {
        public PrivMessage PrivMessage { get; set; }
        public List<string> ConversationBetween { get; set; }
        public string TopicName { get; set; }
    }
}
