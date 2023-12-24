// Итак, мы собираемся добавить поддержку работы с базой данных в наше приложение чата.
// Давайте разработаем для нее модель. Создадим новый проект - это будет серверное приложение.
// В проекте мы будем использовать CodeFirst подход. Начнем с двух таблиц - Messages и Users.
// В Messages должны храниться сообщения, тогда как в users список пользователей. Разработайте
// модель таким образом чтобы учесть что в сообщениях есть не только автор но и адресат и статус получениям им сообщения.


using Lesson05DB.Services;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    static async Task Main(string[] args)
    {
        if (args[0].Equals("Server"))
        {
            var netmsgsorce = new UdpMessageSouce();
            var server = new Server(netmsgsorce);
            await server.Start();
        }
        else
        {
            var client = new Client("Kat", "172.0.0.1", 12345);
            await client.Start();
        }
    }
}
