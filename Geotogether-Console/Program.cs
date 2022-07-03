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


            var builder = new ConfigurationBuilder()
                                    .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            var username = configuration["GeoTogetherAccount:Username"];
            var password = configuration["GeoTogetherAccount:Password"];

            _service = new GeoTogetherService();

            await logIn(username, password).ConfigureAwait(false);

            while (true)
            {
                var deviceIds = await _service.GetDevices().ConfigureAwait(false);
                foreach (var deviceId in deviceIds)
                {
                    var (success, data, content) = await _service.GetDeviceData(deviceId).ConfigureAwait(false);
                    if (success.HasValue && !success.Value)
                    {
                        // Try logging in again
                        await logIn(username, password).ConfigureAwait(false);
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

        private static Task<bool> logIn(string username, string password)
        {
            Console.WriteLine("Logging in");
            return _service!.ConnectAsync(username, password);
        }
    }
}