using System.Globalization;

namespace Common.Analytics
{
    public class SubscriptionAnalyticsData
    {
        public string ProductName;
        public string IsoCurrencyCode;
        public string TransactionId;
        public string Signature;
        public string Receipt;
        public string PurchaseTimeDate;
        
        public float CurrencyValue;

        public string OrderId;
        public string PurchaseToken;
        
        public string GetCurrencyValueString()
        {
            return CurrencyValue.ToString("F", CultureInfo.InvariantCulture);
        }
        
        public SubscriptionAnalyticsData(string productName, string isoCurrencyCode, float currencyValue,
            string transactionId, string signature, string receipt, string purchaseTimeDate, string orderId, string purchaseToken)
        {
            ProductName = productName;
            IsoCurrencyCode = isoCurrencyCode;
            CurrencyValue = currencyValue;
            TransactionId = transactionId;
            Signature = signature;
            Receipt = receipt;
            PurchaseTimeDate = purchaseTimeDate;
            OrderId = orderId;
            PurchaseToken = purchaseToken;
        }
    }
}