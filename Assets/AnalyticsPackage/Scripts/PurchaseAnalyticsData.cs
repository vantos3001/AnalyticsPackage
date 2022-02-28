using System.Globalization;
using UnityEngine;

namespace Common.Analytics
{
    public class PurchaseAnalyticsData
    {
        public string ProductName;
        public string IsoCurrencyCode;
        public string TransactionId;
        public string Signature;
        public string PurchaseData;

        public float LocalCurrencyValueForAnalytics;

        public string GetCurrencyValueString()
        {
            return LocalCurrencyValueForAnalytics.ToString("F", CultureInfo.InvariantCulture);
        }

        public decimal LocalizedPrice;
        
        public string GetFormatLocalizedPriceString()
        {
            return LocalizedPrice.ToString("F", CultureInfo.InvariantCulture);
        }

        public MonoBehaviour PurchaseControllerGameObject;

        public PurchaseAnalyticsData(string productName, string isoCurrencyCode, float localCurrencyValueForAnalytics, decimal localizedPrice,
            string transactionId, string signature, string purchaseData, MonoBehaviour purchaseControllerGameObject)
        {
            ProductName = productName;
            IsoCurrencyCode = isoCurrencyCode;
            LocalCurrencyValueForAnalytics = localCurrencyValueForAnalytics;
            LocalizedPrice = localizedPrice;
            TransactionId = transactionId;
            Signature = signature;
            PurchaseData = purchaseData;
            PurchaseControllerGameObject = purchaseControllerGameObject;
        }
    }
}