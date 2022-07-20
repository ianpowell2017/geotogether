using Geotogether.DTOs.Device;
using Geotogether.DTOs.DeviceList;
using Geotogether.DTOs.Login;
using RestSharp;

namespace Geotogether
{
    public class GeoTogetherService
    {
        private readonly RestClient _client;

        public GeoTogetherService()
        {
            _client = new RestClient("https://api.geotogether.com");
        }

        public async Task<(bool Success, string Token)> ConnectAsync(string username, string password)
        {
            var restRequest = new RestRequest("usersservice/v2/login", Method.Post);
            restRequest.AddJsonBody(new Login { Username = username, Password = password });
            var response = await _client.ExecuteAsync<LoginResponse>(restRequest);
            var token = response.Data?.AccessToken;
            return (!string.IsNullOrEmpty(token), token);
        }

        public async Task<List<string>> GetDevices(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new Exception("You need to login first");

            var restRequest = new RestRequest("api/userapi/v2/user/detail-systems?systemDetails=true", Method.Get);
            restRequest.AddHeader("Authorization", $"Bearer {token}");
            var response = await _client.ExecuteAsync<DeviceListResponse>(restRequest);
            if (response.Data == null || response.Data.SystemRoles == null)
                return new List<string?>();

            return response.Data.SystemRoles.Select(x => x.SystemId).ToList();
        }

        public async Task<(bool? connected, Dictionary<string, int> data, string responseContent)> GetDeviceData(string token, string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId))
                throw new ArgumentNullException(nameof(deviceId));

            if (string.IsNullOrEmpty(token))
                throw new Exception("You need to login first");

            if (string.IsNullOrEmpty(deviceId))
                throw new Exception("You need to specify the device");

            var restRequest = new RestRequest("api/userapi/system/smets2-live-data/{deviceId}", Method.Get);
            restRequest.AddUrlSegment("deviceId", deviceId);
            restRequest.AddHeader("Authorization", $"Bearer {token}");
            var response = await _client.ExecuteAsync<Data>(restRequest);

            var retValue = new Dictionary<string, int>();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
                return (false, retValue, response.Content);
            }

            if (response.Data == null)
                return (null, retValue, response.Content);

            foreach (var powerType in response.Data.Power ?? Enumerable.Empty<Power>())
            {
                if (!powerType.ValueAvailable)
                    continue;

                retValue.Add(powerType.Type, powerType.Watts);
            }

            return (true, retValue, response.Content);
        }
    }
}