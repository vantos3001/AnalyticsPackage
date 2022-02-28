using System.Collections.Generic;
using Common.Analytics;

namespace AnalyticsPackage.Scripts
{
    public interface IAnalyticProvider
    {
        void Send(string eventName, Dictionary<string, object> data, int importanceCode);
        void SendPurchase(PurchaseAnalyticsData purchaseAnalyticsData);
        void SendSubscription(SubscriptionAnalyticsData subscriptionAnalyticsData);

        void SetUserProperty(string name, object property);
        void OnApplicationPause(bool pauseStatus);
    }
}