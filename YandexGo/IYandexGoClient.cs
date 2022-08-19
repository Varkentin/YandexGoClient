namespace YandexGo
{
    public interface IYandexGoClient
    {
        OrderInfo CreateOrder(string token, CreateOrderRequest request, int unicId, out ErrorInfo error);
        OrderInfo GetOrderInfo(string token, string claimId, out ErrorInfo error);
        OrderInfo EditOrder(string token, CreateOrderRequest request, string claimId, int version, out ErrorInfo error);
        ConfirmOrderResponse ConfirmOrder(string token, string claimId, int version, out ErrorInfo error);
        CancelOrderResponse CancelOrder(string token, string claimId, int version, out ErrorInfo error);
        EstimateOrderResponse CheckEstimateOrder(string token, EstimateOrderRequest request, out ErrorInfo error);
        IReadOnlyCollection<AvailableTariff> GetTariffs(string token, double latitude, double longitude, out ErrorInfo error);
    }
}
