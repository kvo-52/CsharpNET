using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientLesson3
{
    internal class Message
    {
        public string Text { get; set; }

        public DateTime DateTime { get; set; }

        public string NickNameFrom { get; set; }
        public string NickNameTo { get; set; }

        public string SerializeMessageToJson() => JsonSerializer.Serialize(this);

        public static Message? DeserializeFromJson(string message) => JsonSerializer.Deserialize<Message>(message);

        public string PrintGetMessageFrom()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{DateTime} \n Получено сообщение {Text} \n от {NickNameFrom}  ";
        }
    }
}
