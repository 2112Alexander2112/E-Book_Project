using EBookLib01.BasicacModels;
using EBookLib01.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Web;

namespace EBookLib01.Services
{
    public class JSONSender
    {
        public string ClientMessageSerialize(ClientMessage cm)
        {
            return JsonSerializer.Serialize(cm);
        }

        public ClientMessage ClientMessageDeserialize(string jsonRows)
        {
            return JsonSerializer.Deserialize<ClientMessage>(jsonRows, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public string ServerMessageSerialize(ServerMessage cm)
        {
            return JsonSerializer.Serialize(cm);
        }

        public ServerMessage ServerMessageDeserialize(string jsonRows)
        {
            return JsonSerializer.Deserialize<ServerMessage>
                (jsonRows, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
