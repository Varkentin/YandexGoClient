namespace YandexGo
{
    public class YandexGoClient : IYandexGoClient
    {
        private const string _endpoint = "https://b2b.taxi.yandex.net/b2b/cargo/integration/";
        private readonly HttpClient _client;
        public YandexGoClient()
        {
            _client = new HttpClient();
        }

        public OrderInfo CreateOrder(string token, CreateOrderRequest request, int uniqId, out ErrorInfo error)
            => GetResponse<OrderInfo>(token, new HttpRequestMessage
            {
                RequestUri = new Uri($"{_endpoint}v2/claims/create?request_id={uniqId}"),
                Method = HttpMethod.Post,
                Content = request.ToStringContent()
            }, out error);

        public OrderInfo GetOrderInfo(string claimId, string token, out ErrorInfo error)
            => GetResponse<OrderInfo>(token, new HttpRequestMessage
            {
                RequestUri = new Uri($"{_endpoint}v2/claims/info?claim_id={claimId}"),
                Method = HttpMethod.Post
            }, out error);

        public YandexGoOrdersInfo GetOrdersInfo(string token, List<string> claimIds, out ErrorInfo error)
            => GetResponse<YandexGoOrdersInfo>(token, new HttpRequestMessage
            {
                RequestUri = new Uri(_endpoint + "v2/claims/bulk_info"),
                Method = HttpMethod.Post,
                Content = claimIds.ToStringContent()
            }, out error);


        public OrderInfo EditOrder(string token, CreateOrderRequest request, string claimId, int version, out ErrorInfo error)
            => GetResponse<OrderInfo>(token, new HttpRequestMessage
            {
                RequestUri = new Uri($"{_endpoint}v2/claims/edit?claim_id={claimId}&version={version}"),
                Method = HttpMethod.Post,
                Content = request.ToStringContent()
            }, out error);

        public ConfirmOrderResponse ConfirmOrder(string token, string claimId, int version, out ErrorInfo error)
            => GetResponse<ConfirmOrderResponse>(token, new HttpRequestMessage
            {
                RequestUri = new Uri($"{_endpoint}v1/claims/accept?claim_id={claimId}"),
                Method = HttpMethod.Post,
                Content = new { version }.ToStringContent()
            }, out error);

        public CancelOrderResponse CancelOrder(string token, string claimId, int version, out ErrorInfo error)
            => GetResponse<CancelOrderResponse>(token, new HttpRequestMessage
            {
                RequestUri = new Uri($"{_endpoint}v1/claims/accept?claim_id={claimId}"),
                Method = HttpMethod.Post,
                Content = new { cancel_state = "free", version }.ToStringContent()
            }, out error);

        public EstimateOrderResponse CheckEstimateOrder(string token, EstimateOrderRequest request, out ErrorInfo error)
            => GetResponse<EstimateOrderResponse>(token, new HttpRequestMessage
            {
                RequestUri = new Uri(_endpoint + "v1/check-price"),
                Method = HttpMethod.Post,
                Content = request.ToStringContent()
            }, out error);

        public IReadOnlyCollection<AvailableTariff> GetTariffs(string token, double latitude, double longitude, out ErrorInfo error)
            => GetResponse<IReadOnlyCollection<AvailableTariff>>(token, new HttpRequestMessage
            {
                RequestUri = new Uri(_endpoint + "v1/check-price"),
                Method = HttpMethod.Post,
                Content = $"{{\"start_point\": [{latitude},{longitude}]}}".ToStringContent()
            }, out error);


        private TResponse GetResponse<TResponse>(string token, HttpRequestMessage request, out ErrorInfo error)
        {
            error = null;

            try
            {
                request.Headers.Add("Authorization", $"Bearer {token}");

                var response = _client.Send(request);
                var content = response.Content.ReadAsStringAsync().Result;

                if (response?.IsSuccessStatusCode != true)
                {
                    error = content.Deserialize<ErrorInfo>();
                    Logger.Debug($"Ошибка, при попытке запроса, ответ сервера yandexGo: {error.Message}");
                    return default;
                }

                return content.Deserialize<TResponse>();
            }
            catch (Exception ex)
            {
                Logger.Debug(ex.Message);
                return default;
            }
        }
    }
}
