using Geotogether;
using Microsoft.Extensions.Configuration;

namespace Geotogether_Console
{
    internal class Program
    {
        private static GeoTogetherService? _service;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Geo Together - Data capture");


            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            var username = configuration["GeoTogetherAccount:Username"];
            var password = configuration["GeoTogetherAccount:Password"];

            _service = new GeoTogetherService();
            string token;
            while (true)
            {
                (var _, token) = await logIn(username, password).ConfigureAwait(false);
                if (string.IsNullOrEmpty(token))
                    await Task.Delay(5000);
                else
                    break;
            }

            while (true)
            {
                var deviceIds = await _service.GetDevices(token).ConfigureAwait(false);
                foreach (var deviceId in deviceIds)
                {
                    await _service.GetAllData(token, deviceId);

                    var (success, data, content) = await _service.GetDeviceData(token, deviceId).ConfigureAwait(false);
                    if (success.HasValue && !success.Value)
                    {
                        // Try logging in again
                        (_, token) = await logIn(username, password).ConfigureAwait(false);
                        continue;
                    }

                    foreach (var d in data)
                    {
                        Console.WriteLine($"{d.Key} = {d.Value}");
                    }
                }
                await Task.Delay(20000).ConfigureAwait(false);
            }
        }

        private static Task<(bool, string)> logIn(string username, string password)
        {
            Console.WriteLine("Logging in");
            return _service.ConnectAsync(username, password);
        }
    }
}