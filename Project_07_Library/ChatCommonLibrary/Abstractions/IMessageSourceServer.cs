using System.Net;
using ChatCommonLibrary.Models;

namespace ChatCommonLibrary.Abstractions
{
    public interface IMessageSourceServer<T>
    {
        Task SendAsync(NetMessage message, T ep);

        NetMessage Receive(ref T ep);

        T CreateEndpoint();

        T CopyEndpoint(IPEndPoint ep);
    }
}
